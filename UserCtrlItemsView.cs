using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XRpg;

namespace XenoRPGEditor
{
	public partial class UserCtrlItemsView: UserControl
	{
		bool m_bModified = false;

		//----------------------------------------------------------------------
		public UserCtrlItemsView()
		{
			InitializeComponent();
		}


		//----------------------------------------------------------------------
		private void Editor_Load( object sender, EventArgs e )
		{
			LoadItemsTable();

			SetGridColumnOrder( gridview );
			SetGridColumnWidths( gridview );
			SetGridHeaderText( gridview );

			gridview.Update();
		}


		//----------------------------------------------------------------------
		private void LoadItemsTable()
		{
			List<Item> listItems = InventoryManager.LoadAllItems();

			gridview.DataSource = listItems;

		}


		//----------------------------------------------------------------------
		private void SetGridColumnOrder( DataGridView gv )
		{
			if ( gv.Columns.Count == 0 ) return;

			// Throws exception if column name is wrong...
			try
			{
				gv.Columns["NestLevel"   ].Visible = false;
				gv.Columns["ParentContId"].Visible = false;

				gv.Columns["IsEnabled"  ].DisplayIndex = 0;
				gv.Columns["Id"         ].DisplayIndex = 1;
				gv.Columns["Name"       ].DisplayIndex = 2;
				gv.Columns["Type"       ].DisplayIndex = 3;
				gv.Columns["Weight"     ].DisplayIndex = 4;
				gv.Columns["Quantity"   ].DisplayIndex = 5;
				gv.Columns["QuantityCap"].DisplayIndex = 6;
				gv.Columns["IconIndex"  ].DisplayIndex = 7;
				gv.Columns["SizeW"      ].DisplayIndex = 8;
				gv.Columns["SizeH"      ].DisplayIndex = 9;
				gv.Columns["Location"   ].DisplayIndex = 10;
				gv.Columns["PosX"       ].DisplayIndex = 11;
				gv.Columns["PosY"       ].DisplayIndex = 12;
				gv.Columns["PosZ"       ].DisplayIndex = 13;
				//gv.Columns["Description"].DisplayIndex = 15;
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
				gv.Columns["Description"].Width = 250;
				gv.Columns["Weight"     ].Width = 40;
				gv.Columns["Quantity"   ].Width = 40;
				gv.Columns["QuantityCap"].Width = 45;
				gv.Columns["IsEnabled"  ].Width = 55;
				gv.Columns["IconIndex"  ].Width = 40;
				gv.Columns["SizeW"      ].Width = 42;
				gv.Columns["SizeH"      ].Width = 40;
				gv.Columns["Location"   ].Width = 60;
				gv.Columns["PosX"       ].Width = 50;
				gv.Columns["PosY"       ].Width = 50;
				gv.Columns["PosZ"       ].Width = 50;
			}
			catch { } // Don't care

			// Set last column to fill...
			gv.Columns[ gv.Columns.Count - 1 ].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}


		//----------------------------------------------------------------------
		private void SetGridHeaderText( DataGridView gv )
		{
			if ( gv.Columns.Count == 0 ) return;

			// Throws exception if column name is wrong...
			try
			{
				gv.Columns["Weight"     ].HeaderText = "Wt";
				gv.Columns["Quantity"   ].HeaderText = "Qty";
				gv.Columns["QuantityCap"].HeaderText = "QtyCap";
				gv.Columns["IsEnabled"  ].HeaderText = "Enabled";
				gv.Columns["IconIndex"  ].HeaderText = "Icon";
				gv.Columns["Location"   ].HeaderText = "Loc";
			}
			catch { } // Don't care
		}


		//----------------------------------------------------------------------
		private void SetModified( bool b )
		{
			m_bModified = b;
			lblMasterItemList.ForeColor = b ? Color.Red : Color.Black;
			buttSaveList.Enabled = b;

		}


		//----------------------------------------------------------------------
		private void gridItemMasterList_CellEndEdit( object sender, DataGridViewCellEventArgs e )
		{
			SetModified( true );
		}


		//----------------------------------------------------------------------
		private bool SaveChanges()
		{
			//TODO: Call RpgManager save items method
			try
			{
				//using ( TransactionScope tScope = new TransactionScope() )
				{
					//m_sqlAdapter.Update( (DataTable)gridItems.DataSource );

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
		private void buttSaveChanges_Click( object sender, EventArgs e )
		{
			SaveChanges();
			SetModified( false );
		}


		//----------------------------------------------------------------------
		private void UserCtrlItemEditor_Leave( object sender, EventArgs e )
		{
			DialogResult dlgResult = DialogResult.No;
			if ( m_bModified )
			{
				dlgResult = MessageBox.Show(
					"Table has been modified. Save changes?",
					"Save",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question );
			}

			if ( dlgResult == DialogResult.Yes )
			{
				SaveChanges();
			}

			LoadItemsTable();
			SetModified( false );
		}


		//----------------------------------------------------------------------
		private void gridItemsMasterList_UserDeletingRow( object sender, DataGridViewRowCancelEventArgs e )
		{
			var result = MessageBox.Show(
				"Delete item?", "Delete", MessageBoxButtons.OKCancel );

			if ( result == DialogResult.Cancel ) e.Cancel = true;
		}


		//----------------------------------------------------------------------
		private void gridItemsMasterList_UserDeletedRow( object sender, DataGridViewRowEventArgs e )
		{
			SetModified( true );
		}


		//----------------------------------------------------------------------
		private void gridItems_RowHeaderMouseDoubleClick( object sender, DataGridViewCellMouseEventArgs e )
		{
			//TODO: Create the form once above...
			var form = new FormItemEditor();
			var table = ( DataTable )gridview.DataSource;

			// If clicking on bottom row, add new item...
			if ( e.RowIndex >= table.Rows.Count )
			{
				//var rowNew = table.NewRow();
				//table.Rows.Add( rowNew );
				//form.dataRowItem = rowNew;
			}
			else
			{
				form.dataRowItem = table.Rows[ e.RowIndex ];
			}

			var result = form.ShowDialog();
			SetModified( ( result == DialogResult.Yes ) );
		}


		private void lblMasterItemList_Click( object sender, EventArgs e )
		{

		}


		private void comboSearchBy_SelectedIndexChanged( object sender, EventArgs e )
		{

			//TODO: filter displayed items by search criteria

			// 1) Change data filter

			// 2) Iterate grid rows and hide the ones that don't match
		}
	}
}
