#pragma warning disable RECS0113 // Redundant comma in array initializer


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
	public partial class UserCtrlCharactersEditor: UserControl
	{
		int[] _iColWidths =
		{
			50,
			100,
			50,
			55,
			60,
			50,
			50,
			50,
			40,
			45,
			45,
			45,
			45,
			45,
			45,
		};

		bool _bModified = false;


		//----------------------------------------------------------------------
		public UserCtrlCharactersEditor()
		{
			InitializeComponent();

			//TODO: Populate gridview with characters from DB
		}


		//----------------------------------------------------------------------
		private void SetColWidths( DataGridView gv )
		{
			if ( gv.Columns.Count == 0 ) return;

			// Use shortest size so we don't run into problems if the number of grid columns
			// doesn't match the number of elements...
			int iColMax = Math.Min( gv.Columns.Count, _iColWidths.Length );

			for ( int i = 0; i < iColMax; ++i )
			{
				gv.Columns[ i ].Width = _iColWidths[ i ];
			}

			// Set last column to fill...
			gv.Columns[ gv.Columns.Count - 1 ].AutoSizeMode =
					DataGridViewAutoSizeColumnMode.Fill;
		}


		//----------------------------------------------------------------------
		private void InitGrid()
		{
			if ( gridview.Columns.Count == 0 ) return;

			/*var column = new DataGridViewComboBoxColumn();
			column.HeaderText = "Type";
			column.ToolTipText = "";
			column.DataSource = dictItemTypeNames;
			column.ValueMember = "Key";
			column.DisplayMember = "Value";
			column.DataPropertyName = "type";

			gridview.Columns[ 3 ].Visible = false;
			gridview.Columns.Insert( 3, column );
			 */
		}


		//----------------------------------------------------------------------
		private void LoadCharactersTable()
		{
			List<CharacterBase> listCharacters = FormMain.CharManager.LoadCharacters();

			gridview.DataSource = listCharacters;

		}


		//----------------------------------------------------------------------
		private void Editor_Load( object sender, EventArgs e )
		{
			LoadCharactersTable();
			InitGrid();
			SetColWidths( gridview );

			//dataGridView1.Columns[ 2 ].HeaderText = "Type";
			//dataGridView1.Columns[ 3 ].HeaderText = "Wt";
			//dataGridView1.Columns[ 6 ].HeaderText = "Qty";
			//dataGridView1.Columns[ 7 ].HeaderText = "Qty Cap";
		}


		//----------------------------------------------------------------------
		private void SetModified( bool b )
		{
			_bModified = b;
			//TODO: Need to add controls
			//lblMasterItemList.ForeColor = b ? Color.Red : Color.Black;
			//buttSaveList.Enabled = b;

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
					//m_sqlAdapter.Update( (DataTable)gridview.DataSource );

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
			if ( _bModified )
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

			LoadCharactersTable();
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
			var form = new FormEditItem();
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
	}
}

