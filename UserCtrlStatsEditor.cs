using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XRpg;

namespace XenoRPGEditor
{
	public partial class UserCtrlStatsEditor: UserControl
	{
		readonly int[] m_iColWidths =
		{
			 30, // Id
			140, // Name
			 60, // Abbr
			 90, // Type
			 60,  // Lvl Min
			 60, // Lvl Base Low
			 60, // Lvl Base High
			 60, // Lvl Max
			 60, // ScoreBase
			 80, // XPCost
			 40, // ApplyType
			 40, // ApplyHow
			 40, // ApplyPercent
			// Desc is set to fill
		};

		bool m_bAttribsModified = false;

		public BindingSource bsStats { get; set; }

		//----------------------------------------------------------------------
		public UserCtrlStatsEditor()
		{
			InitializeComponent();
		}


		//----------------------------------------------------------------------
		private void SetColWidths( DataGridView gv, int[] iColWidths )
		{
			// Use shortest size so we don't run into problems if they don't match...
			int iColMax = Math.Min( gv.Columns.Count, iColWidths.Length );

			for ( int i = 0; i < iColMax; ++i )
			{
				gv.Columns[ i ].Width = iColWidths[ i ];
			}

			// Set last column to fill...
			gv.Columns[ gv.Columns.Count - 1 ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}


		//----------------------------------------------------------------------
		void LoadAllStats()
		{
			Dictionary<int, StatBase> stats = FormMain.CharManager.LoadAllStats();

			//NOTE: Without the BindingSource, gridview is not editable.
			var blist = new FilterList<StatBase>( stats.Values.ToList() );

			bsStats = new BindingSource { DataSource = blist };
			gridview.DataSource = bsStats;

//			if ( bsStats.SupportsFiltering ) bsStats.Filter = "Type='Skill'";
		}


		void LoadStatTypes()
		{
			Dictionary<int, StatType> listStatTypes = FormMain.CharManager.LoadStatTypes();
		}


		//----------------------------------------------------------------------
		private void Editor_Load( object sender, EventArgs e )
		{
			tooltip.SetToolTip(
				label1,
				"Right-click table for options." );

			LoadAllStats();

			SetColWidths( gridview, m_iColWidths );
		}

		//----------------------------------------------------------------------
		private void SetStatsModified( bool b )
		{
			m_bAttribsModified = b;
			label1.ForeColor = b ? Color.Red : Color.Black;

			buttSaveList.Enabled = b;

		}


		//----------------------------------------------------------------------
		private void gvStatsAll_CellEndEdit( object sender, DataGridViewCellEventArgs e )
		{
			SetStatsModified( true );

		}


		//----------------------------------------------------------------------
		private bool SaveChanges()
		{
			var list = ( (BindingSource)gridview.DataSource ).List;

			int result = FormMain.CharManager.SaveMasterAttribs( (List<Stat>)list );

			return ( result != 0 );
		}


		//----------------------------------------------------------------------
		private void buttUpdateAttribList_Click( object sender, EventArgs e )
		{
			SaveChanges();
			SetStatsModified( false );
		}


		//----------------------------------------------------------------------
		private void UserCtrlStatEditor_Leave( object sender, EventArgs e )
		{
			DialogResult dlgResult = DialogResult.No;
			if ( m_bAttribsModified )
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

			LoadAllStats();

			SetStatsModified( false );
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
			SetStatsModified( true );
		}


		//----------------------------------------------------------------------
		private void gridSkillsMasterList_UserDeletingRow( object sender, DataGridViewRowCancelEventArgs e )
		{
			var result = MessageBox.Show(
				"Delete skill?", "Delete", MessageBoxButtons.OKCancel );

			if ( result == DialogResult.Cancel )
				e.Cancel = true;
		}
	}
}
