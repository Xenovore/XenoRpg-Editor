using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Transactions;
using System.Data.SQLite;

namespace XenoRPGEditor
{
	public partial class UserCtrlStatEditor: UserControl
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

		SQLiteDataAdapter m_sqlAdapterAttribs = new SQLiteDataAdapter();
		SQLiteDataAdapter m_sqlAdapterSkills  = new SQLiteDataAdapter();

		bool m_bAttribsModified = false;
		bool m_bSkillsModified = false;

		//----------------------------------------------------------------------
		public UserCtrlStatEditor()
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
		void LoadAttribsTable()
		{
			// ----- Get attrib. master list from DB...
			string strSQL = "SELECT * FROM statinfo_attribs";
			SQLiteCommand sqlCmd = new SQLiteCommand( strSQL, FormMain.SQLConn );
			m_sqlAdapterAttribs.SelectCommand = sqlCmd;
			try
			{
				var datatable = new DataTable();
				m_sqlAdapterAttribs.Fill( datatable );
				gridAttribMasterList.DataSource = datatable;

				var sqlCmdBuild = new SQLiteCommandBuilder( m_sqlAdapterAttribs );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Error: " + ex.Message );
			}

		}


		//----------------------------------------------------------------------
		void LoadSkillsTable()
		{
			// ----- Get skill master list from DB...
			m_sqlAdapterSkills = new SQLiteDataAdapter();
			string strSQL = "SELECT * FROM statinfo_skills";
			SQLiteCommand sqlCmd = new SQLiteCommand( strSQL, FormMain.SQLConn );
			m_sqlAdapterSkills.SelectCommand = sqlCmd;
			try
			{
				var datatable = new DataTable();
				m_sqlAdapterSkills.Fill( datatable );
				gridSkillMasterList.DataSource = datatable;

				var sqlCmdBuild = new SQLiteCommandBuilder( m_sqlAdapterSkills );
			}
			catch ( Exception ex )
			{
				MessageBox.Show( "Error: " + ex.Message );
			}
		}

		
		//----------------------------------------------------------------------
		private void UserCtrlStatEditor_Load( object sender, EventArgs e )
		{
			tooltip.SetToolTip( 
				lblMasterAttribList, 
				"Right-click table for options." );

			tooltip.SetToolTip( 
				lblMasterSkillList, 
				"Right-click table for options." );

			LoadAttribsTable();
			SetColWidths( gridAttribMasterList, m_iColWidths );

			LoadSkillsTable();
			SetColWidths( gridSkillMasterList, m_iColWidths );
		}//FormStatEditor_Load()

		//----------------------------------------------------------------------
		private void SetAttribsModified( bool b )
		{
			m_bAttribsModified = b;
			lblMasterAttribList.ForeColor = b ? Color.Red : Color.Black;
			buttUpdateAttribList.Enabled = b;

		}


		//----------------------------------------------------------------------
		private void SetSkillsModified( bool b )
		{
			m_bSkillsModified = b;
			lblMasterSkillList.ForeColor = b ? Color.Red : Color.Black;
			buttUpdateSkillList.Enabled = b;

		}

	
		//----------------------------------------------------------------------
		private void gridAttribMasterList_CellEndEdit( object sender, DataGridViewCellEventArgs e )
		{
			SetAttribsModified( true );

		}


		//----------------------------------------------------------------------
		private void gridSkillMasterList_CellEndEdit( object sender, DataGridViewCellEventArgs e )
		{
			SetSkillsModified( true );

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

			return true;
		}
		

		//----------------------------------------------------------------------
		private void buttUpdateAttribList_Click( object sender, EventArgs e )
		{
			SaveChanges();
			SetAttribsModified( false );
		}


		//----------------------------------------------------------------------
		private void buttUpdateSkillList_Click( object sender, EventArgs e )
		{
			SaveChanges();
			SetSkillsModified( false );
		}


		//----------------------------------------------------------------------
		private void UserCtrlStatEditor_Leave( object sender, EventArgs e )
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

			LoadAttribsTable();
			LoadSkillsTable();
			SetAttribsModified( false );
			SetSkillsModified( false );
		}

	
		//----------------------------------------------------------------------
		private void gridAttribsMasterList_UserDeletingRow( object sender, DataGridViewRowCancelEventArgs e )
		{
			var result = MessageBox.Show(
				"Delete attribute?", "Delete", MessageBoxButtons.OKCancel );

			if ( result == DialogResult.Cancel )
				e.Cancel = true;
		}


		//----------------------------------------------------------------------
		private void gridAttribsMasterList_UserDeletedRow( object sender, DataGridViewRowEventArgs e )
		{
			SetAttribsModified( true );
		}


		//----------------------------------------------------------------------
		private void gridSkillsMasterList_UserDeletingRow( object sender, DataGridViewRowCancelEventArgs e )
		{
			var result = MessageBox.Show(
				"Delete skill?", "Delete", MessageBoxButtons.OKCancel );

			if ( result == DialogResult.Cancel )
				e.Cancel = true;
		}


		//----------------------------------------------------------------------
		private void gridSkillsMasterList_UserDeletedRow( object sender, DataGridViewRowEventArgs e )
		{
			SetSkillsModified( true );
		}


	}
}
