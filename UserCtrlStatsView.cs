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
	public partial class UserCtrlStatsView: UserControl
	{
		bool m_bAttribsModified = false;
		Dictionary<int, StatType> _listStatTypes;
		public BindingSource bsStats { get; set; }

		//----------------------------------------------------------------------
		public UserCtrlStatsView()
		{
			InitializeComponent();
		}


		//----------------------------------------------------------------------
		void LoadAllStats()
		{
			List<StatBaseInfo> stats = CharacterManager.ListStatsInfoAll;

			//NOTE: Without the BindingSource, gridview is not editable.
			var blist = new FilterList<StatBaseInfo>( stats );

			bsStats = new BindingSource { DataSource = blist };
			gridview.DataSource = bsStats;

			//if ( bsStats.SupportsFiltering ) bsStats.Filter = "Type='Skill'";
		}


		void LoadStatTypes()
		{
			_listStatTypes = CharacterManager.LoadStatTypes();
		}


		//----------------------------------------------------------------------
		private void Editor_Load( object sender, EventArgs e )
		{
			tooltip.SetToolTip(
				label1,
				"Right-click table for options." );

			LoadAllStats();
			LoadStatTypes();

			SetGridColumnOrder( gridview );
			SetGridColumnWidths( gridview );

			gridview.Update();
		}

		//----------------------------------------------------------------------
		private void SetGridColumnOrder( DataGridView gv )
		{
			if ( gv.Columns.Count == 0 ) return;

			// Throws exception if column name is wrong...
			try
			{
				gv.Columns["Id"         ].DisplayIndex = 0;
				gv.Columns["Name"       ].DisplayIndex = 1;
				gv.Columns["Abbr"       ].DisplayIndex = 2;
				gv.Columns["TypeId"     ].DisplayIndex = 3;
			}
			catch { } // Don't care
		}


		//----------------------------------------------------------------------
		private void SetGridColumnWidths( DataGridView gv )
		{
			if ( gv.Columns.Count == 0 ) return;

			// Throws exception if column name is wrong...
			try
			{
				gv.Columns["Id"         ].Width = 40;
				gv.Columns["Name"       ].Width = 130;
				gv.Columns["Abbr"       ].Width = 50;
				gv.Columns["TypeId"     ].Width = 100;
			}
			catch { } // Don't care

			// Set last column to fill...
			gv.Columns[ gv.Columns.Count - 1 ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

			int result = CharacterManager.SaveMasterAttribs( (List<StatBaseInfo>)list );

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


		//----------------------------------------------------------------------
		private void comboFilterBy_SelectedIndexChanged( object sender, EventArgs e )
		{
			// Filter grid by
			string strFilter = comboFilterBy.SelectedText;

			/* FILTER EXAMPLE >>>>>
			string rowFilter = string.Format("[{0}] = '{1}'", columnName, filterValue);
			(myDataGridView.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
			//The square brackets allow for spaces in the column name.

			//Additionally, if you want to include multiple values in your filter, you can add the following line for each additional value:

			rowFilter += string.Format(" OR [{0}] = '{1}'", columnName, additionalFilterValue);
			<<<<< */
		}
	}
}
