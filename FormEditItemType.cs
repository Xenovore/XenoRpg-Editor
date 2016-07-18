using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using XRpg;

namespace XenoRPGEditor
{
	public partial class FormEditItemType: Form
	{
		public UInt32 TypeValue { get; set; }

		List<ItemTypeDef> _listItemTypes;

		// NOTE: These are special case; icons are for item TYPES not items
		public Dictionary<ItemType, byte> dictItemTypeNames = new Dictionary<ItemType, byte>
		{
			// Type                      Icon Idx
			{ ItemType.None         ,  0 },
			{ ItemType.Container    ,  4 },
			{ ItemType.ContSlot     , 14 },
			{ ItemType.ContExo      ,  4 },
			{ ItemType.ContLiquid   ,  6 },
			{ ItemType.BodyHead     ,  5 },
			{ ItemType.BodyEar      ,  5 },
			{ ItemType.BodyFace     ,  5 },
			{ ItemType.BodyNeck     ,  5 },
			{ ItemType.BodyShldr    ,  5 },
			{ ItemType.BodyTorso    ,  5 },
			{ ItemType.BodyArm      ,  5 },
			{ ItemType.BodyWrist    ,  5 },
			{ ItemType.BodyHand     ,  5 },
			{ ItemType.BodyWaist    ,  5 },
			{ ItemType.BodyLeg      ,  5 },
			{ ItemType.BodyFoot     ,  5 },
			//{ ItemType.Body         ,  5 },
			{ ItemType.Jewelry      , 12 },
			{ ItemType.Ring         , 13 },
			{ ItemType.Bracelet     , 13 },
			{ ItemType.Necklace     , 12 },
			{ ItemType.Earring      , 12 },
			{ ItemType.ArmorHead    ,  3 },
			{ ItemType.ArmorFace    ,  3 },
			{ ItemType.ArmorNeck    ,  3 },
			{ ItemType.ArmorShldr   ,  3 },
			{ ItemType.ArmorTorso   ,  3 },
			{ ItemType.ArmorArm     ,  3 },
			{ ItemType.ArmorHand    ,  3 },
			{ ItemType.ArmorWaist   ,  3 },
			{ ItemType.ArmorLeg     ,  3 },
			{ ItemType.ArmorFoot    ,  3 },
			{ ItemType.Clothing     ,  3 },
			{ ItemType.ClothingHead ,  3 },
			{ ItemType.ClothingFace ,  3 },
			{ ItemType.ClothingNeck ,  3 },
			{ ItemType.ClothingShldr,  3 },
			{ ItemType.ClothingTorso,  3 },
			{ ItemType.ClothingArm  ,  3 },
			{ ItemType.ClothingHand ,  3 },
			{ ItemType.ClothingWaist,  3 },
			{ ItemType.ClothingLeg  ,  3 },
			{ ItemType.ClothingFoot ,  3 },
			//{ ItemType.Unused2      ,  0 },
			{ ItemType.WeaponBlade  , 15 },
			{ ItemType.WeaponBlunt  , 15 },
			{ ItemType.WeaponThrown , 15 },
			{ ItemType.WeaponMissile, 15 },
			{ ItemType.Weapon       , 15 },
			{ ItemType.AmmoArrow    ,  1 },
			{ ItemType.AmmoBolt     ,  1 },
			{ ItemType.AmmoUnused   ,  1 },
			//{ ItemType.Unused3      ,  0 },
			{ ItemType.Ammo         ,  1 },
			{ ItemType.Coin         ,  7 },
			{ ItemType.Gem          ,  9 },
			{ ItemType.Herb         , 10 },
			{ ItemType.Liquid       , 11 },
			{ ItemType.Any          ,  2 },
		/* NO MORE ROOM IN UINT FOR THESE>>>>>
		// Food (consumable)... TODO: Any reason for food-only containers?
		Meat         = 0x10000000, // TODO: Prolly not needed
		Bread        = 0x20000000, // TODO: Prolly not needed
		Powder       = 0x40000000, // TODO: Prolly not needed
		Fruit        = 0x00100000, // TEMP CHANGE
		Food         = Meat | Bread,
		Unused6      = 0x00200000,
		Unused7      = 0x00400000,
		Unused8      = 0x00800000,
		// Paper, books...
		Paper        = 0x01000000, // Can be written on or used as craft item: note, etc.
		Scroll       = 0x02000000, // Magic: spell can be inscribed, power included
		Book         = 0x04000000, // Normal book: history, story, etc.
		SpellBook    = 0x08000000, // Magic: spells can be inscribed, no power included
		// Craft items...
		Wood         = 0x10000000, // Craft item
		Metal        = 0x20000000, // Craft item
		Leather      = 0x40000000, // Craft item
		Stone        = 0x80000000, // Craft item
		 */
		};

		public FormEditItemType()
		{
			InitializeComponent();
			PopulateListView();
			ResizeColumnHeaders();
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
		private void LoadItemTypesTable()
		{
			_listItemTypes = FormMain.InvManager.LoadItemTypes();
		}


		//----------------------------------------------------------------------
		private void PopulateListView()
		{
			listviewTypes.Items.Clear();

			LoadItemTypesTable();

			//TODO: Set selected items from TypeValue

			// Create and add items...
			bool bAltRow = false;

			foreach ( ItemTypeDef itemTypeDef in _listItemTypes )
			{
				var item = new ListViewItem( itemTypeDef.Name );
				item.SubItems.Add( itemTypeDef.HexValue );
				item.Tag = itemTypeDef.Value;
				item.ImageIndex = itemTypeDef.IconIdx;

				if ( bAltRow )
				{
					item.BackColor = Color.FromArgb( 0x00F4F6FF );
				}
				bAltRow = !bAltRow;

				listviewTypes.Items.Add( item );
			}
			//<<<<<*/
		}


		//----------------------------------------------------------------------
		private void SelectRows()
		{
			foreach ( ListViewItem item in listviewTypes.Items )
			{
				// Don't ever select "None"; makes no sense...
				if ( ( uint )item.Tag == 0x0000000 ) item.Selected = false;
				else
					item.Selected = ( ( TypeValue & ( uint )item.Tag ) == ( uint )item.Tag );

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
				TypeValue |= ( uint )item.Tag; // Get all set types
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

	} // class FormTypeEdit
}
