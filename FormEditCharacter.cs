using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XRpg;

namespace XenoRPGEditor
{
	public partial class FormEditCharacter: Form
	{
		public CharacterManager charManager;
		public InventoryManager invManager;

		public CharacterPlayer player;

		public FormEditCharacter()
		{
			InitializeComponent();

			FormMain.CharManager.LoadAllStats();
			//FormMain.RpgMan.LoadMasterSkills();

			// Init UI for item type selection...
			/*
			comboItemTypes.DataSource = new BindingSource( RpgMan.dictTypeNames, null );
			comboItemTypes.DisplayMember = "Value";
			comboItemTypes.ValueMember   = "Key";
			*/
			//TODO: Load player data from DB
			player = new CharacterPlayer
			{
				Name = "Bob"
			};

			//TODO: Initialize/load player attributes and skills
			//player.Load( "fileOrDB" );
			//player.LoadAttribs( RpgMan.m_dictAttribsAll );
			//player.LoadSkills( RpgMan.m_dictSkillsAll );

			/*
			for ( int i = 0; i < player.m_listAttributes.Count; ++i )
			{
				textBox1.AppendText(
					string.Format(
						"{0}({1})={2}\n",
						player.m_listAttributes[ i ].m_statInfo.m_strName,
						player.m_listAttributes[ i ].m_statInfo.m_strAbbr,
						player.m_listAttributes[ i ].m_statInfo.m_fLevelBase ) );
			}
			*/
			DataGridView dgv;

			dgv = gridAttributes;
			dgv.DataSource = player._listAttributes;
			try
			{
				dgv.Columns[ 0 ].HeaderText = "Name";
				dgv.Columns[ 1 ].HeaderText = "Abbr";
				dgv.Columns[ 2 ].HeaderText = "Desc";
				dgv.Columns[ 3 ].HeaderText = "Lvl Base";
				dgv.Columns[ 4 ].HeaderText = "Lvl Total";
				dgv.Columns[ 5 ].HeaderText = "Score";
				dgv.Columns[ 6 ].HeaderText = "XP";

				dgv.Columns[ 0 ].Width = 90;
				dgv.Columns[ 1 ].Width = 50;
				dgv.Columns[ 2 ].Width = 40;
				dgv.Columns[ 3 ].Width = 40;
				dgv.Columns[ 4 ].Width = 40;
				dgv.Columns[ 5 ].Width = 40;
				dgv.Columns[ 6 ].Width = 80;

				dgv = gridSkills;
				dgv.DataSource = player._listSkills;
				dgv.Columns[ 0 ].HeaderText = "Name";
				dgv.Columns[ 1 ].HeaderText = "Abbr";
				dgv.Columns[ 2 ].HeaderText = "Desc";
				dgv.Columns[ 3 ].HeaderText = "Lvl Base";
				dgv.Columns[ 4 ].HeaderText = "Lvl Total";
				dgv.Columns[ 5 ].HeaderText = "Score";
				dgv.Columns[ 6 ].HeaderText = "XP";

				dgv.Columns[ 0 ].Width = 90;
				dgv.Columns[ 1 ].Width = 50;
				dgv.Columns[ 2 ].Width = 50;
				dgv.Columns[ 3 ].Width = 40;
				dgv.Columns[ 4 ].Width = 40;
				dgv.Columns[ 5 ].Width = 40;
				dgv.Columns[ 6 ].Width = 80;
			}
			catch
			{
				; //IGNORE
			}
		}


		//----------------------------------------------------------------------
		private void Form1_Shown( object sender, EventArgs e )
		{
			RefreshTreeView();
		}


		//----------------------------------------------------------------------
		public void LoadInventoryTest( ItemContainer contParent )
		{
			// ----- Create and add all body location containers...

			ItemContainer contBodySlot;
			ItemContainer contLvl2;

			//TODO: Add all items based on ID?
			//(ID would already reference a complete item definition)

			//TODO: All body containers/slots should be locked by default
			// ----- HEAD...
			contBodySlot = contParent.AddNewContainer(
				"Head",
				ItemType.ContExo,
				ItemType.ContSlot,
				4 );

			//TODO: Instead of creating additional slots just to limit slot type,
			// have a list of allowed types that matches the container slot list...
			// Here, instead of AddNewContainer()...
			// contTmp.m_listTypeAllowed[0] = RpgItemType.ArmorHead;
			// contTmp.m_listTypeAllowed[1] = RpgItemType.ClothingHead;
			// contTmp.m_listTypeAllowed[2] = RpgItemType.BodyEar | RpgItemType.ContExo;
			// contTmp.m_listTypeAllowed[3] = RpgItemType.BodyEar | RpgItemType.ContExo;

			// Head - Armor
			contLvl2 = contBodySlot.AddNewContainer( "HeadArmor", ItemType.ContSlot, ItemType.ArmorHead, 1 );
			contLvl2.AddNewItem( "Helm", ItemType.ArmorHead );

			// Head - Clothing
			contLvl2 = contBodySlot.AddNewContainer( "HeadCloth", ItemType.ContSlot, ItemType.ClothingHead, 1 );
			contLvl2.AddNewItem( "Hood", ItemType.ClothingHead );

			// Head - Left Ear
			contLvl2 = contBodySlot.AddNewContainer( "EarLeft", ItemType.ContExo, ItemType.Earring, 2 );
			contLvl2.AddNewItem( "Gold Stud", ItemType.Earring );
			contLvl2.AddNewItem( "Silver Earring", ItemType.Earring );

			// Head - Right Ear
			contLvl2 = contBodySlot.AddNewContainer( "EarRight", ItemType.ContExo, ItemType.Earring, 2 );
			contLvl2.AddNewItem( "Ruby Earring", ItemType.Earring );
			contLvl2.AddNewItem( "Silver Earring", ItemType.Earring );

			// ----- NECK...
			contBodySlot = contParent.AddNewContainer(
				"Neck",
				ItemType.ContExo,
				ItemType.Container,
				2 );

			// Neck - Armor
			contBodySlot.AddNewContainer( "NeckArmor", ItemType.ContSlot, ItemType.BodyNeck );
			contLvl2.AddNewItem( "Gorget", ItemType.BodyNeck );

			// Neck - Jewelry
			contLvl2 = contBodySlot.AddNewContainer( "Necklace", ItemType.ContSlot, ItemType.Necklace );
			contLvl2.AddNewItem( "Amulet Of Power", ItemType.Necklace );

			// TEST: ADDL. ITEM THAT DOESN't FIT IN SLOT>>>>>
			contLvl2.AddNewItem( "Necklace2", ItemType.Necklace );
			// TEST: WRONG ITEM TYPE FOR THIS CONTAINER>>>>>
			contLvl2.AddNewItem( "StockingCap", ItemType.ClothingHead );

			// ----- SHOULDERS...
			contBodySlot = contParent.AddNewContainer(
				"Shoulders",
				ItemType.ContExo,
				ItemType.Container,
				2 );

			// Shoulder - Armor
			contLvl2 = contBodySlot.AddNewContainer( "ShldrArmor", ItemType.ContSlot, ItemType.ArmorShldr );
			contLvl2.AddNewItem( "Pauldron", ItemType.ArmorShldr );

			// Shoulder - Clothing
			contLvl2 = contBodySlot.AddNewContainer( "Cloak", ItemType.ContSlot, ItemType.ClothingShldr );
			contLvl2.AddNewItem( "Cloak", ItemType.ClothingShldr );


			// ----- TORSO...
			contBodySlot = contParent.AddNewContainer(
				"Torso",
				ItemType.ContExo,
				ItemType.Container,
				4 );

			// Torso - Armor
			contLvl2 = contBodySlot.AddNewContainer( "TorsoArmor", ItemType.ContSlot, ItemType.ArmorTorso );
			contLvl2.AddNewItem( "Chain Hauberk", ItemType.ArmorTorso );

			// Torso - Clothing
			contLvl2 = contBodySlot.AddNewContainer( "Shirt", ItemType.ContSlot, ItemType.ClothingTorso );
			contLvl2.AddNewItem( "Fancy Black Shirt", ItemType.ClothingTorso );

			// TORSO - BACKPACK...
			contLvl2 = contBodySlot.AddNewContainer(
				"Backpack",
				ItemType.ContEndo,
				ItemType.Any,
				20,
				100.0f,
				100 );

			//TODO: Chuck some junk in the pack

			// Torso - Baldric
			contLvl2 = contBodySlot.AddNewContainer(
				"Baldric",
				ItemType.ContExo,
				ItemType.Container,
				3 );
			contBodySlot  = contLvl2.AddNewContainer( "SwSheath1", ItemType.ContEndo, ItemType.Weapon );

			// ----- ARM, LEFT...
			contBodySlot = contParent.AddNewContainer(
				"ArmL",
				ItemType.ContExo,
				ItemType.Container,
				1 );

			contBodySlot.AddNewContainer( "BracerL", ItemType.ContSlot, ItemType.BodyArm );

			contBodySlot = contParent.AddNewContainer(
				"HandL",
				ItemType.ContExo,
				ItemType.Container,
				4 );
			contBodySlot.AddNewContainer( "GloveL", ItemType.ContSlot, ItemType.BodyHand );

			contBodySlot.AddNewContainer(
				"WristL",
				ItemType.ContExo,
				ItemType.Bracelet,
				1 );

			contBodySlot.AddNewContainer(
				"FingersL",
				ItemType.ContExo,
				ItemType.Ring,
				3 );

			contBodySlot.AddNewContainer( "HeldLeft", ItemType.Any );

			// ----- ARM, RIGHT...
			contBodySlot = contParent.AddNewContainer(
				"ArmR",
				ItemType.ContExo,
				ItemType.Container,
				1 );

			contBodySlot.AddNewContainer(
				"BracerR",
				ItemType.ContSlot,
				ItemType.BodyArm );

			contBodySlot = contParent.AddNewContainer(
				"HandR",
				ItemType.ContExo,
				ItemType.Container,
				4 );
			contBodySlot.AddNewContainer(
				"GloveR",
				ItemType.ContSlot,
				ItemType.BodyHand );

			contBodySlot.AddNewContainer(
				"WristR",
				ItemType.ContExo,
				ItemType.Bracelet,
				1 );

			contBodySlot.AddNewContainer(
				"FingersR",
				ItemType.ContExo,
				ItemType.Ring,
				3 );

			contBodySlot.AddNewContainer( "HeldRight", ItemType.Any );

			// ----- WAIST...
			contBodySlot = contParent.AddNewContainer(
				"Waist",
				ItemType.ContSlot,
				ItemType.BodyWaist );

			// Waist can only take belt
			contLvl2 = contBodySlot.AddNewContainer(
				"Belt",
				ItemType.ContExo | ItemType.BodyWaist,
				ItemType.Container,
				5,
				10.0f,
				10 );

			// Pouch goes on belt...
			contBodySlot = contLvl2.AddNewContainer(
				"Pouch1",
				ItemType.ContEndo,
				ItemType.Any,
				6,
				5.0f,
				10 );

			// Pouch goes on belt...
			contBodySlot = contLvl2.AddNewContainer( "Pouch2",
				ItemType.ContEndo,
				ItemType.Any,
				6,
				5.0f,
				10 );

			// Sheath goes on belt...
			contBodySlot = contLvl2.AddNewContainer( "Sheath1", ItemType.ContSlot, ItemType.Weapon );

			// Sheath goes on belt...
			contBodySlot = contLvl2.AddNewContainer( "Sheath2", ItemType.ContSlot, ItemType.Weapon );

			// ----- LEGS...
			contBodySlot = contParent.AddNewContainer(
				"Legs",
				ItemType.ContExo,
				ItemType.ContSlot,
				2 );
			contBodySlot.AddNewContainer( "LegArmor", ItemType.ContSlot, ItemType.BodyLeg );
			contBodySlot.AddNewContainer( "Pants",    ItemType.ContSlot, ItemType.BodyLeg );

			// ----- FEET...
			contBodySlot = contParent.AddNewContainer(
				"Feet",
				ItemType.ContExo,
				ItemType.ContSlot,
				2 );
			contLvl2 = contBodySlot.AddNewContainer( "Feet",  ItemType.ContSlot, ItemType.BodyFoot );

			contLvl2.AddNewItem( "Suave Boot of Stalking", ItemType.ArmorFoot );

			contBodySlot.AddNewContainer(
				"Anklets",
				ItemType.ContExo,
				ItemType.Bracelet,
				2 );

		}


		//=====================================================================
		// FORM UI STUFF
		//=====================================================================

		private void loadFromTestToolStripMenuItem_Click( object sender, EventArgs e )
		{
			player.m_contBody.Clear();
			LoadInventoryTest( player.m_contBody );
			RefreshTreeView();
		}


		private void loadFromXMLToolStripMenuItem_Click( object sender, EventArgs e )
		{
			//TODO C++: Destroy old m_contBody if it exists

			player.m_contBody.LoadFromXML( "TestInventory.xml" );
			RefreshTreeView();
		}


		private void saveToXMLToolStripMenuItem_Click( object sender, EventArgs e )
		{
			if ( player.m_contBody != null )
			{
				//TEST>>>>>
				//TODO: MOVE TO MANAGER>>>>> player.m_contBody.SaveToDB();
				//<<<<<
				player.m_contBody.SaveToXML( "TestInventory.xml" );
			}
			else
				MessageBox.Show( "Can't save empty inventory." );
		}


		public int GetItemImgIdx( Item itemInv )
		{
			if ( ( itemInv.Type & ItemType.ContSlot  ) == ItemType.ContSlot ) return 0;
			if ( ( itemInv.Type & ItemType.Container )  > 0                    ) return 1;
			if ( ( itemInv.Type & ItemType.Coin      ) == ItemType.Coin     ) return 5;
			if ( ( itemInv.Type & ItemType.Gem       ) == ItemType.Gem      ) return 6;
			if ( ( itemInv.Type & ItemType.Herb      ) == ItemType.Herb     ) return 7;
			if ( ( itemInv.Type & ItemType.Necklace  ) == ItemType.Necklace ) return 8;
			if ( ( itemInv.Type & ItemType.Ring      ) == ItemType.Ring     ) return 9;
			if ( ( itemInv.Type & ItemType.Earring   ) == ItemType.Earring  ) return 9;
			if ( ( itemInv.Type & ItemType.Bracelet  ) == ItemType.Bracelet ) return 9;
			if ( ( itemInv.Type & ItemType.Weapon    ) == ItemType.Weapon   ) return 10;
			if ( ( itemInv.Type & ItemType.Body      )  > 0                 ) return 4;

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
				nodeNew.ForeColor = Color.LightGray;
				nodeNew.ImageIndex = 2;
			}

			node.Nodes.Insert( 0, nodeNew );

			if ( itemInv is ItemContainer )
			{
				int iChildIdx = ( itemInv as ItemContainer ).m_listItems.Capacity - 1;
				while ( iChildIdx >= 0 )
				{
					if ( iChildIdx < ( itemInv as ItemContainer ).m_listItems.Count )
					{
						UpdateInvTree_r( ( itemInv as ItemContainer ).m_listItems[ iChildIdx ], nodeNew );
					}
					else
						UpdateInvTree_r( null, nodeNew );

					iChildIdx--;
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
				if ( m_iDepthCurr < iDepth &&
					 node.Nodes.Count > 0 )
				{
					ExpandTreeNode_r( node, iDepth );
				}
			}

			m_iDepthCurr--;
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
			UpdateInvTree_r( player.m_contBody, nodeRoot );

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
