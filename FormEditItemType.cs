using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

using XRpg;
using XRpg.Utility;
using XRpgUtils;

namespace XenoRPGEditor
{
	public partial class FormEditItemType: Form
	{
		ImageAtlas _atlasInventoryIcons;

		// Used to load values for listview
		KeyedCollectionEx<string, ItemTypeClass> _collectionItemTypes;

		public ulong TypeValue { get; set; }


		public FormEditItemType()
		{
			InitializeComponent();
			LoadItemTypes();
			LoadItemTypeIcons();
			PopulateListView();
			ResizeColumnHeaders();
		}


		//----------------------------------------------------------------------
		private void LoadItemTypes()
		{
			// Used to load values for listview
			_collectionItemTypes = InventoryManager.LoadItemTypes();
		}


		//----------------------------------------------------------------------
		private void LoadItemTypeIcons()
		{
			_atlasInventoryIcons = new ImageAtlas( @"Images\ItemTypeIcons.png" );

			var imageList = new ImageList();
			for ( ushort i = 0; i < _atlasInventoryIcons.ImageCount; ++i )
			{
				Bitmap image = _atlasInventoryIcons.GetSubImageAt( i );
				imageList.Images.Add( image );
			}

			listviewTypes.SmallImageList = imageList;
		}


		//----------------------------------------------------------------------
		private void ResizeColumnHeaders()
		{
			// UNCOMMENT TO AUTO-RESIZE COLUMNS...
			/*
			for ( int iColIdx = 0; iColIdx < listviewTypes.Columns.Count; ++iColIdx )
			{
				listviewTypes.AutoResizeColumn( iColIdx, ColumnHeaderAutoResizeStyle.ColumnContent );
			}
			*/

			// -2 = magically resize last column to fill remaining space...
			listviewTypes.Columns[ listviewTypes.Columns.Count - 1 ].Width = -2;
		}


		//----------------------------------------------------------------------
		private void PopulateListView()
		{
			listviewTypes.Items.Clear();

			//TODO: Set selected items from TypeValue

			// Create and add items...
			bool bAltRow = false;
			foreach ( ItemTypeClass itemType in _collectionItemTypes )
			{
				var item = new ListViewItem( itemType.Name );
				item.SubItems.Add( itemType.ValueAsHex );
				item.SubItems.Add( itemType.Description );

				item.Tag = itemType.Value;
				item.ImageIndex = itemType.IconIndex;

				if ( bAltRow )
				{
					item.BackColor = Color.FromArgb( 235, 235, 255 );
				}
				bAltRow = !bAltRow;

				listviewTypes.Items.Add( item );
			}
		}


		//----------------------------------------------------------------------
		private void SelectRows()
		{
			foreach ( ListViewItem item in listviewTypes.Items )
			{
				// Don't ever select "None"; makes no sense...
				if ( (ulong)item.Tag == 0 ) item.Selected = false;
				else
					item.Selected = ( ( TypeValue & ( ulong )item.Tag ) == ( ulong )item.Tag );

				// Scroll to last selected item...
				if ( item.Selected ) item.EnsureVisible();
				item.Checked = item.Selected;
			}
		}


		//----------------------------------------------------------------------
		private void FormTypeEdit_ResizeEnd( object sender, EventArgs e )
		{
			ResizeColumnHeaders();
		}


		//----------------------------------------------------------------------
		private void buttOk_Click( object sender, EventArgs e )
		{
			TypeValue = 0x00000000; // blank slate
			foreach ( ListViewItem item in listviewTypes.SelectedItems )
			{
				TypeValue |= ( ulong )item.Tag; // Get all set types
			}
		}


		//----------------------------------------------------------------------
		private void FormTypeEdit_Activated( object sender, EventArgs e )
		{
			listviewTypes.HideSelection = false;
			SelectRows();

			listviewTypes.Focus();
		}


		private void listviewTypes_MouseClick( object sender, MouseEventArgs e )
		{
			ListViewItem itemCurr = listviewTypes.GetItemAt( e.X, e.Y );
			if ( itemCurr != null )
			{
				foreach ( ListViewItem item in listviewTypes.Items )
				{
					if ( item.Text == itemCurr.Text ) item.Checked = !item.Checked;
				}
			}
		}

		private void listviewTypes_ColumnClick( object sender, ColumnClickEventArgs e )
		{
			//TODO: SORT BY COLUMN CLICKED: Ascending or Descending or None
		}
	} // class FormTypeEdit
}
