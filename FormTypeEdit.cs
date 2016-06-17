using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XenoRpgLib;

namespace XenoRPGEditor
{
	public partial class FormTypeEdit: Form
	{
		public UInt32 TypeValue { get; set; }

		public Dictionary<RpgItemType, byte> dictItemIconIndexes = new Dictionary<RpgItemType, byte>()
		{
			// Type                      Icon Idx
			{ RpgItemType.None         ,  0 },
			{ RpgItemType.ContSlot     , 14 },
			{ RpgItemType.ContEndo     ,  4 },
			{ RpgItemType.ContExo      ,  4 },
			{ RpgItemType.Container    ,  4 },
			{ RpgItemType.ContLiquid   ,  6 },
			{ RpgItemType.BodyHead     ,  5 },
			{ RpgItemType.BodyEar      ,  5 },
			{ RpgItemType.BodyFace     ,  5 },
			{ RpgItemType.BodyNeck     ,  5 },
			{ RpgItemType.BodyShldr    ,  5 },
			{ RpgItemType.BodyTorso    ,  5 },
			{ RpgItemType.BodyArm      ,  5 },
			{ RpgItemType.BodyWrist    ,  5 },
			{ RpgItemType.BodyHand     ,  5 },
			{ RpgItemType.BodyWaist    ,  5 },
			{ RpgItemType.BodyLeg      ,  5 },
			{ RpgItemType.BodyFoot     ,  5 },
			{ RpgItemType.Body         ,  5 },
			{ RpgItemType.Apparel      , 12 },
			{ RpgItemType.Ring         , 13 },
			{ RpgItemType.Bracelet     , 13 },
			{ RpgItemType.Necklace     , 12 },
			{ RpgItemType.Earring      , 12 },
			{ RpgItemType.ArmorHead    ,  3 },
			{ RpgItemType.ArmorFace    ,  3 },
			{ RpgItemType.ArmorNeck    ,  3 },
			{ RpgItemType.ArmorShldr   ,  3 },
			{ RpgItemType.ArmorTorso   ,  3 },
			{ RpgItemType.ArmorArm     ,  3 },
			{ RpgItemType.ArmorHand    ,  3 },
			{ RpgItemType.ArmorWaist   ,  3 },
			{ RpgItemType.ArmorLeg     ,  3 },
			{ RpgItemType.ArmorFoot    ,  3 },
			{ RpgItemType.WeaponBlade  , 15 },
			{ RpgItemType.WeaponBlunt  , 15 },
			{ RpgItemType.WeaponThrown , 15 },
			{ RpgItemType.WeaponMissile, 15 },
			{ RpgItemType.Weapon       , 15 },
			{ RpgItemType.AmmoArrow    ,  1 },
			{ RpgItemType.AmmoBolt     ,  1 },
			{ RpgItemType.AmmoOther    ,  1 },
			{ RpgItemType.Unused1      ,  0 },
			{ RpgItemType.Unused2      ,  0 },
			{ RpgItemType.Unused3      ,  0 },
			{ RpgItemType.Ammo         ,  1 },
			{ RpgItemType.Coin         ,  7 },
			{ RpgItemType.Gem          ,  9 },
			{ RpgItemType.Herb         , 10 },
			{ RpgItemType.Liquid       , 11 },
			{ RpgItemType.Any          ,  2 },
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
		<<<<<*/
		};

		public FormTypeEdit()
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
		private void PopulateListView()
		{
			listviewTypes.Items.Clear();

			//TODO: Get TypeValue from DB row
			//TODO: Set selected items from TypeValue

			// Create and add items...
			bool bAltRow = false;
			foreach ( KeyValuePair<RpgItemType, byte> kvp in dictItemIconIndexes )
			{
				var item = new ListViewItem( kvp.Key.ToString() );
				item.SubItems.Add( ( ( uint )kvp.Key ).ToString( "X8" ) );
				item.Tag = ( uint )kvp.Key;
				item.ImageIndex = kvp.Value;
				if ( bAltRow )
				{
					item.BackColor = Color.FromArgb( 0x00F4F6FF );
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
