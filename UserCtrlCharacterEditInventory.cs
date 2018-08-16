using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XRpg;
using XRpgUtils;

namespace XenoRPGEditor
{
	public partial class UserCtrlCharacterEditInventory: UserControl
	{
		Item _contBody;
		ImageAtlas _atlasItemIcons;

		public UserCtrlCharacterEditInventory()
		{
			InitializeComponent();

		}

		public UserCtrlCharacterEditInventory( uint characterId )
		{
			InitializeComponent();

			// Load character inventory...
			var character = CharacterManager.GetCharacterById( characterId );
			_contBody = XRpg.InventoryManager.LoadContainer( character.ContBodyId );

			_atlasItemIcons = new XRpgUtils.ImageAtlas( "Images/RpgInvIcons.png" );

			RefreshSlotView();
			RefreshTreeView();
		}

		private void loadFromTestToolStripMenuItem_Click( object sender, EventArgs e )
		{
			//player._contBody.Clear();

			//TODO: Load from DB

			RefreshTreeView();
		}


		private void loadFromXMLToolStripMenuItem_Click( object sender, EventArgs e )
		{
			//TODO C++: Destroy old m_contBody if it exists

			//player._contBody.LoadFromXML( "TestInventory.xml" );
			RefreshTreeView();
		}


		private void saveToXMLToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if ( _contBody != null )
			{
				//TEST>>>>>
				//TODO: MOVE TO MANAGER>>>>> player.m_contBody.SaveToDB();
				//<<<<<
				//player._contBody.SaveToXML( "TestInventory.xml" );
			}
			else
				MessageBox.Show( "Can't save empty inventory." );
		}


		//TODO: USE ITEMTYPES IconIndex
		public int GetItemImgIdx( Item itemInv )
		{
			if ( ( itemInv.Type & ItemTypeEnum.ContSlot  ) == ItemTypeEnum.ContSlot ) return 0;
			if ( ( itemInv.Type & ItemTypeEnum.Container )  > 0                     ) return 1;
			if ( ( itemInv.Type & ItemTypeEnum.Coin      ) == ItemTypeEnum.Coin     ) return 5;
			if ( ( itemInv.Type & ItemTypeEnum.Gem       ) == ItemTypeEnum.Gem      ) return 6;
			if ( ( itemInv.Type & ItemTypeEnum.Herb      ) == ItemTypeEnum.Herb     ) return 7;
			if ( ( itemInv.Type & ItemTypeEnum.Necklace  ) == ItemTypeEnum.Necklace ) return 8;
			if ( ( itemInv.Type & ItemTypeEnum.Ring      ) == ItemTypeEnum.Ring     ) return 9;
			if ( ( itemInv.Type & ItemTypeEnum.Earring   ) == ItemTypeEnum.Earring  ) return 9;
			if ( ( itemInv.Type & ItemTypeEnum.Bracelet  ) == ItemTypeEnum.Bracelet ) return 9;
			if ( ( itemInv.Type & ItemTypeEnum.Weapon    ) == ItemTypeEnum.Weapon   ) return 10;
			if ( ( itemInv.Type & ItemTypeEnum.Body      )  > 0                     ) return 4;

			// Image index 2 is currently "empty"
			return 3;
		}


		//----------------------------------------------------------------------
		static int m_iDepthCurr = 0;

		public void UpdateInvTree_r( Item itemInv, TreeNode node )
		{

			TreeNode nodeNew = new TreeNode();
			m_iDepthCurr++;

			if ( itemInv != null )
			{
				nodeNew.Text = itemInv.Name;
				nodeNew.ImageIndex = GetItemImgIdx( itemInv );
			}
			else
			{
				nodeNew.Text = "(empty)";
				nodeNew.ForeColor = Color.LightSteelBlue;
				nodeNew.ImageIndex = 2;
			}

			node.Nodes.Insert( 0, nodeNew );

			if ( itemInv != null && ( itemInv.Type & ItemTypeEnum.Container ) > 0 )
			{
				var itemCont = itemInv.Container;
				if ( itemCont != null )
				{
					int iChildIdx = itemCont._listItems?.Count - 1 ?? 0;
					while ( iChildIdx >= 0 )
					{
						if ( iChildIdx < itemCont._listItems?.Count )
						{
							UpdateInvTree_r( itemCont._listItems[ iChildIdx ], nodeNew );
						}
						else
							UpdateInvTree_r( null, nodeNew );

						iChildIdx--;
					}
				}
			}

			m_iDepthCurr--;
		}


		//----------------------------------------------------------------------
		private void ExpandTreeNode_r( TreeNode nodeRoot, int iDepth )
		{
			nodeRoot.Expand();

			m_iDepthCurr++;

			foreach ( TreeNode node in nodeRoot.Nodes )
			{
				if ( m_iDepthCurr < iDepth && node.Nodes.Count > 0 )
				{
					ExpandTreeNode_r( node, iDepth );
				}
			}

			m_iDepthCurr--;
		}


		//----------------------------------------------------------------------
		private void RefreshSlotView()
		{
			const int c_slotExtent = 32;

			if ( invContainerSlots.Controls.Count > 0 ) return;

			//TODO: Instead of this; need something to recurse through all containers
			var listSlots = _contBody.Container._listItems;
			int count = 0;
			int offsetX = 0;
			int offsetY = 0;
			foreach( Item item in listSlots )
			{
				//TODO: REMOVE; temporary
				offsetX = count % 5 * ( c_slotExtent + 4 );
				if ( count % 5 == 0 ) offsetY += c_slotExtent + 4;

				//var ctrlSlot = new InvItemControl( _itemIconsAtlas.GetSubImageAt( item.IconIndex ) )
				var ctrlSlot = new InvItemControl()
				{
					Text      = item.Name,
					Location  = new Point( (int)item.PosX + offsetX, (int)item.PosY + offsetY ),
					Width     = (int)item.SizeW * c_slotExtent,
					Height    = (int)item.SizeH * c_slotExtent,
					Movable   = true,
					Font      = new Font( "Calibri", 8 ),
					BackgroundFilename = "images/InvSlot.png",
					//ItemImageFilename = "images/InvGem.png",
				};

				invContainerSlots.Controls.Add( ctrlSlot );

				count++;
			}
		}


		//----------------------------------------------------------------------
		private void RefreshTreeView()
		{
			treeviewInv.Nodes.Clear();

			// Create and insert root node...
			TreeNode nodeRoot = new TreeNode();
			nodeRoot.Text = "(TmpRoot)";
			nodeRoot.ForeColor = Color.LightGray;
			treeviewInv.Nodes.Add( nodeRoot );

			// Build tree view from player inventory container....
			UpdateInvTree_r( _contBody, nodeRoot );

			// Recursively expand first few levels...
			ExpandTreeNode_r( nodeRoot, 3 );

			// Scroll to top...
			treeviewInv.Nodes[ 0 ].EnsureVisible();
		}


		//----------------------------------------------------------------------
		private void button1_Click( object sender, EventArgs e )
		{
			RefreshTreeView();
		}


		private void treeviewInv_MouseUp( object sender, MouseEventArgs e )
		{
			if ( e.Button == MouseButtons.Right )
			{
				// Select the clicked node
				treeviewInv.SelectedNode = treeviewInv.GetNodeAt( e.X, e.Y );

				if ( treeviewInv.SelectedNode != null )
				{
					menuTree.Show( treeviewInv, e.Location );
				}
			}
		}


		//----------------------------------------------------------------------
		private void miCollapse_Click( object sender, EventArgs e )
		{
			if ( treeviewInv.SelectedNode != null )
				treeviewInv.SelectedNode.Collapse();
			else
				treeviewInv.Nodes[ 0 ].Collapse();

		}


		//----------------------------------------------------------------------
		private void miExpand_Click( object sender, EventArgs e )
		{
			if ( treeviewInv.SelectedNode != null )
				treeviewInv.SelectedNode.Expand();
			else
			{
				treeviewInv.Nodes[ 0 ].Expand();
			}
		}


		//----------------------------------------------------------------------
		private void miExpandAll_Click( object sender, EventArgs e )
		{
			if ( treeviewInv.SelectedNode != null )
				treeviewInv.SelectedNode.ExpandAll();
			else
				treeviewInv.Nodes[ 0 ].ExpandAll();
		}


	}
}
