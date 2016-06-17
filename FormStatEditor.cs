using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using System.Data.SQLite;

namespace KevInvTest
{
	public partial class FormStatEditor: Form
	{
		int[] m_iColWidths = 
		{ 
			30, // ID 
			90, // Name
			40, // Abbr
			40, // Type
			40, // ApplyType
			50,	// LvlBase
			50, // LvlCap
			50,	// ScorePerLvl
			70	// XPCostPerLvl
			// Desc is set to fill
		};

		SQLiteConnection  m_sqlConn           = new SQLiteConnection();
		SQLiteDataAdapter m_sqlAdapterAttribs = new SQLiteDataAdapter();
		SQLiteDataAdapter m_sqlAdapterSkills  = new SQLiteDataAdapter();

		bool m_bAttribsModified = false;
		bool m_bSkillsModified = false;

		//----------------------------------------------------------------------
		public FormStatEditor()
		{
			InitializeComponent();
		}


		//----------------------------------------------------------------------
		private void SetColWidths( DataGridView gridview, int[] iColWidths )
		{
			// Use shortest size so we don't run into problems if they don't match...
			int iColMax = Math.Min( gridview.Columns.Count, iColWidths.Length );

			for ( int i = 0; i < iColMax; ++i )
			{
				gridview.Columns[ i ].Width = iColWidths[ i ];
			}

			// Set last column to fill...
			gridview.Columns[ gridview.Columns.Count - 1 ].AutoSizeMode = 
					DataGridViewAutoSizeColumnMode.Fill;
		}


		//----------------------------------------------------------------------
		private void FormStatEditor_Load( object sender, EventArgs e )
		{
			tooltip.SetToolTip( 
				lblMasterAttribList, 
				"Right-click table for options." );

			tooltip.SetToolTip( 
				lblMasterSkillList, 
				"Right-click table for options." );

			//KEVTODO: If connection pooling required, add 
			// "Pooling=True;Max Pool Size=100;" to this...
			m_sqlConn.ConnectionString = @"Data Source=InvTest.sqlite";
			m_sqlConn.Open();

			// ----- Get attrib. master list from DB...
			string strSQL = "SELECT * FROM master_list_attribs";
			SQLiteCommand sqlCmd = new SQLiteCommand( strSQL, m_sqlConn );
			m_sqlAdapterAttribs.SelectCommand = sqlCmd;
			//DataSet dataset = new DataSet();
			try
			{
				var datatable = new DataTable();
				m_sqlAdapterAttribs.Fill( datatable );
				//sqlAdapter.Fill( dataset );
				//DataTable datatable = dataset.Tables[ 0 ];
				gridAttribMasterList.DataSource = datatable;

				var sqlCmdBuild = new SQLiteCommandBuilder( m_sqlAdapterAttribs );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Error: " + ex.Message );
			}

			SetColWidths( gridAttribMasterList, m_iColWidths );

			// ----- Get skill master list from DB...
			m_sqlAdapterSkills = new SQLiteDataAdapter();
			strSQL = "SELECT * FROM master_list_skills";
			sqlCmd = new SQLiteCommand( strSQL, m_sqlConn );
			m_sqlAdapterSkills.SelectCommand = sqlCmd;
			//dataset = new DataSet();
			try
			{
				var datatable = new DataTable();
				//sqlAdapter.Fill( dataset );
				//DataTable datatable = dataset.Tables[ 0 ];
				m_sqlAdapterSkills.Fill( datatable );
				gridSkillMasterList.DataSource = datatable;
					
				var sqlCmdBuild = new SQLiteCommandBuilder( m_sqlAdapterSkills );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Error: " + ex.Message );
			}

			SetColWidths( gridSkillMasterList, m_iColWidths );

			//sqlConn.Close();
		}//FormStatEditor_Load()


		//----------------------------------------------------------------------
		private void AttribsModified( object sender, DataGridViewRowEventArgs e )
		{
			m_bAttribsModified = true;
			lblMasterAttribList.ForeColor = Color.Red;
		}


		//----------------------------------------------------------------------
		private void gridAttribMasterList_CellEndEdit( object sender, DataGridViewCellEventArgs e )
		{
			m_bAttribsModified = true;
			lblMasterAttribList.ForeColor = Color.Red;
		}


		//----------------------------------------------------------------------
		private void SkillsModified( object sender, DataGridViewRowEventArgs e )
		{
			m_bSkillsModified = true;
			lblMasterSkillList.ForeColor = Color.Red;
		}


		//----------------------------------------------------------------------
		private void gridSkillMasterList_CellEndEdit( object sender, DataGridViewCellEventArgs e )
		{
			m_bSkillsModified = true;
			lblMasterSkillList.ForeColor = Color.Red;
		}


		//----------------------------------------------------------------------
		private bool SaveChanges()
		{
			try
			{
				//using ( TransactionScope tScope = new TransactionScope() )
				{
					m_sqlAdapterAttribs.Update( (DataTable)gridAttribMasterList.DataSource );
					m_sqlAdapterSkills.Update( (DataTable)gridSkillMasterList.DataSource );

				//	tScope.Complete();
				}
			}
			catch ( Exception ex )
			{
				MessageBox.Show( ex.Message );
				return false;
			}

			m_bAttribsModified = false;
			m_bSkillsModified = false;

			lblMasterAttribList.ForeColor = Color.Black;
			lblMasterSkillList.ForeColor = Color.Black;
			
			return true;
		}
		

		//----------------------------------------------------------------------
		private void buttUpdateAttribList_Click( object sender, EventArgs e )
		{
			SaveChanges();
		}


		//----------------------------------------------------------------------
		private void buttUpdateSkillList_Click( object sender, EventArgs e )
		{
			SaveChanges();
		}


		//----------------------------------------------------------------------
		private void FormStatEditor_FormClosing( object sender, FormClosingEventArgs e )
		{
			DialogResult dlgResult = DialogResult.No;
			if ( m_bAttribsModified || m_bSkillsModified )
			{
				dlgResult = MessageBox.Show(
					"A table has been modified. Save changes?",
					"Save",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question );
			}

			if ( dlgResult == DialogResult.Yes )
			{
				SaveChanges();
			}
		}

	}
}
