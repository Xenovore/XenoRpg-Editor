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
	public partial class UserCtrlCharactersView: UserControl
	{
		bool _bModified = false;


		//----------------------------------------------------------------------
		public UserCtrlCharactersView()
		{
			InitializeComponent();

			//TODO: Populate gridview with characters from DB
		}


		//----------------------------------------------------------------------
		private void SetColWidths( DataGridView gv )
		{
			if ( gv.Columns.Count == 0 ) return;

			//TODO: JUST USE COLUMN NAMES INSTEAD

			int[] iColWidths =
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

			// Use shortest size so we don't run into problems if the number of grid columns
			// doesn't match the number of elements...
			int iColMax = Math.Min( gv.Columns.Count, iColWidths.Length );

			for ( int i = 0; i < iColMax; ++i )
			{
				gv.Columns[ i ].Width = iColWidths[ i ];
			}

			// Set last column to fill...
			gv.Columns[ gv.Columns.Count - 1 ].AutoSizeMode =
					DataGridViewAutoSizeColumnMode.Fill;
		}


		//----------------------------------------------------------------------
		private void InitGrid()
		{
			if ( dgvCharacters.Columns.Count == 0 ) return;

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
			List<CharacterBase> listCharacters = FormMain.CharManager.LoadAllCharacters();

			dgvCharacters.DataSource = listCharacters;

		}


		//----------------------------------------------------------------------
		private void Editor_Load( object sender, EventArgs e )
		{
			LoadCharactersTable();
			InitGrid();
			SetColWidths( dgvCharacters );

			comboSearchBy.SelectedIndex = 0;
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
			var table = ( DataTable )dgvCharacters.DataSource;

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


		//----------------------------------------------------------------------
		private void dgvCharacters_CellDoubleClick( object sender, DataGridViewCellEventArgs e )
		{
			uint id = (uint)dgvCharacters.Rows[e.RowIndex].Cells["Id"].Value;
			var form = new FormCharacterEditor( id );
			form.ShowDialog();
		}


		//----------------------------------------------------------------------
		private void buttResetSearch_Click( object sender, EventArgs e )
		{
			textSearchFor.Text = "";
			//TODO: Reset gridview
		}
	}
}

