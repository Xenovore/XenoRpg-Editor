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
	public partial class FormCharDetails: Form
	{
		public RpgManager RpgMan;
		public RpgCharacterPlayer player;
		
		public FormCharDetails()
		{
			InitializeComponent();

			// Init RPG manager...
			RpgMan = new RpgManager();
			RpgMan.InitItemTypeNames();
			RpgMan.LoadMasterAttribList();
			RpgMan.LoadMasterSkillList();


			// Init UI for item type selection...
			/*
			comboItemTypes.DataSource = new BindingSource( RpgMan.dictTypeNames, null );
			comboItemTypes.DisplayMember = "Value";
			comboItemTypes.ValueMember   = "Key";
			*/
			//TODO: Load player data from XML
			player = new RpgCharacterPlayer
			{
				m_strName = "Bob"
			};

			player.m_strName = RpgMan.dictTypeNames[ RpgItemType.AmmoArrow ];
			//TODO: Initialize/load player attributes and skills
			//player.Load( "fileOrDB" );
			player.LoadAttribs( RpgMan.m_dictAttribsAll );
			player.LoadSkills( RpgMan.m_dictSkillsAll );

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
			dgv.DataSource = player.m_listAttributes;
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
			dgv.DataSource = player.m_listSkills;
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


		//----------------------------------------------------------------------
		private void Form1_Shown( object sender, EventArgs e )
		{
			RefreshTreeView();
		}


		//----------------------------------------------------------------------
		public void LoadInventoryTest( RpgItemContainer contParent )
		{
			// ----- Create and add all body location containers...

			// Temporary containers in case we need to immediately add stuff to it...
			RpgItemContainer contTmp;
			RpgItemContainer contTmp2; // TEST

			//TODO: Add all items based on ID? 
			//(ID would already reference a complete item definition)

			//TODO: All body containers/slots should be locked by default
			// ----- HEAD...
			contTmp = contParent.AddNewContainer(
				"Head",
				RpgItemType.Container,
				RpgItemType.ContExo,
				4 );

			//TODO: Instead of creating additional slots just to limit slot type,
			// have a list of allowed types that matches the container slot list...
			// Here, instead of AddNewContainer()...
			// contTmp.m_listTypeAllowed[0] = RpgItemType.ArmorHead;
			// contTmp.m_listTypeAllowed[1] = RpgItemType.ClothingHead;
			// contTmp.m_listTypeAllowed[2] = RpgItemType.BodyEar | RpgItemType.ContExo;
			// contTmp.m_listTypeAllowed[3] = RpgItemType.BodyEar | RpgItemType.ContExo;

			contTmp.AddNewContainer( "HeadArmor", RpgItemType.ArmorHead );
			contTmp.AddNewContainer( "Hood", RpgItemType.Hat );

			contTmp2 = contTmp.AddNewContainer(
				"EarLeft",
				RpgItemType.Earring,
				RpgItemType.ContExo,
				2 );

			//TODO: TEST REMOVE
			contTmp2.AddNewItem( "Gold Earring", RpgItemType.Earring );

			contTmp2 = contTmp.AddNewContainer(
				"EarRight",
				RpgItemType.Earring,
				RpgItemType.ContExo,
				2 );
			contTmp2.AddNewItem( "Earring", RpgItemType.Earring );

			// ----- NECK...
			contTmp = contParent.AddNewContainer(
				"Neck",
				RpgItemType.Container,
				RpgItemType.ContExo,
				2 );
			contTmp.AddNewContainer( "NeckArmor", RpgItemType.BodyNeck );
			contTmp2 = contTmp.AddNewContainer( "Necklace", RpgItemType.Necklace );

			//TODO: TEST REMOVE
			contTmp2.AddNewItem( "Amulet Of Power", RpgItemType.Necklace );
			contTmp2.AddNewItem( "Necklace2", RpgItemType.Necklace );
			contTmp2.AddNewItem( "StockingCap", RpgItemType.Hat );

			// ----- SHOULDERS...
			contTmp = contParent.AddNewContainer(
				"Shoulders",
				RpgItemType.Container,
				RpgItemType.ContExo,
				2 );
			contTmp.AddNewContainer( "ShldrArmor", RpgItemType.ArmorShldr );
			contTmp.AddNewContainer( "Cloak", RpgItemType.Cape );

			// ----- TORSO...
			contTmp = contParent.AddNewContainer(
				"Torso",
				RpgItemType.Container,
				RpgItemType.ContExo,
				4 );
			contTmp2 = contTmp.AddNewContainer( "TorsoArmor", RpgItemType.BodyTorso );
			contTmp2 = contTmp.AddNewContainer( "Shirt", RpgItemType.BodyTorso );

			//TODO: TEST REMOVE
			contTmp2.AddNewItem( "Fancy Black Shirt", RpgItemType.Shirt );

			//TODO: TEST REMOVE
			contTmp2 = contTmp.AddNewContainer(
				"Backpack",
				RpgItemType.Any,
				RpgItemType.ContEndo,
				20,
				100.0f,
				100 );

			//TODO: TEST REMOVE
			contTmp2 = contTmp.AddNewContainer(
				"Baldric",
				RpgItemType.Container,
				RpgItemType.ContExo,
				3 );
			contTmp  = contTmp2.AddNewContainer( "SwSheath1", RpgItemType.Weapon );

			// ----- ARM, LEFT...
			contTmp = contParent.AddNewContainer(
				"ArmL",
				RpgItemType.Container,
				RpgItemType.ContExo,
				1 );
			contTmp.AddNewContainer( "BracerL", RpgItemType.BodyArm );

			contTmp = contParent.AddNewContainer(
				"HandL",
				RpgItemType.Container,
				RpgItemType.ContExo,
				4 );
			contTmp.AddNewContainer( "GloveL", RpgItemType.BodyHand );

			contTmp.AddNewContainer(
				"WristL",
				RpgItemType.Bracelet,
				RpgItemType.ContExo,
				1 );

			contTmp.AddNewContainer(
				"FingersL",
				RpgItemType.Ring,
				RpgItemType.ContExo,
				3 );

			contTmp.AddNewContainer( "HeldLeft", RpgItemType.Any );

			// ----- ARM, RIGHT...
			contTmp = contParent.AddNewContainer(
				"ArmR",
				RpgItemType.Container,
				RpgItemType.ContExo,
				1 );

			contTmp.AddNewContainer(
				"BracerR",
				RpgItemType.BodyArm );

			contTmp = contParent.AddNewContainer(
				"HandR",
				RpgItemType.Container,
				RpgItemType.ContExo,
				4 );
			contTmp.AddNewContainer(
				"GloveR",
				RpgItemType.BodyHand );

			contTmp.AddNewContainer(
				"WristR",
				RpgItemType.Bracelet,
				RpgItemType.ContExo,
				1 );

			contTmp.AddNewContainer(
				"FingersR",
				RpgItemType.Ring,
				RpgItemType.ContExo,
				3 );

			contTmp.AddNewContainer( "HeldRight", RpgItemType.Any );

			// ----- WAIST...
			contTmp = contParent.AddNewContainer(
				"Waist",
				RpgItemType.BodyWaist );

			// Waist can only take belt
			contTmp2 = contTmp.AddNewContainer(
				"Belt",
				RpgItemType.Container,
				RpgItemType.ContExo | RpgItemType.BodyWaist,
				5,
				10.0f,
				10 );

			contTmp = contTmp2.AddNewContainer(
				"Pouch1",
				RpgItemType.Any,
				RpgItemType.ContEndo,
				6,
				5.0f,
				10 );

			contTmp = contTmp2.AddNewContainer( "Pouch2",
				RpgItemType.Any,
				RpgItemType.ContEndo,
				6,
				5.0f,
				10 );

			contTmp = contTmp2.AddNewContainer( "Sheath1", RpgItemType.Weapon );

			contTmp = contTmp2.AddNewContainer( "Sheath2", RpgItemType.Weapon );

			// ----- LEGS...
			contTmp = contParent.AddNewContainer(
				"Legs",
				RpgItemType.Container,
				RpgItemType.ContExo,
				2 );
			contTmp.AddNewContainer( "LegArmor", RpgItemType.BodyLeg );
			contTmp.AddNewContainer( "Pants", RpgItemType.BodyLeg );

			// ----- FEET...
			contTmp = contParent.AddNewContainer(
				"Feet",
				RpgItemType.Container,
				RpgItemType.ContExo,
				2 );
			contTmp2 = contTmp.AddNewContainer( "Feet", RpgItemType.BodyFoot );

			//TODO: TEST REMOVE
			contTmp2.AddNewItem( "Suave Boot of Stalking", RpgItemType.ArmorFoot );

			contTmp.AddNewContainer(
				"Anklets",
				RpgItemType.Bracelet,
				RpgItemType.ContExo,
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
				//player.m_contBody.SaveToDB();
				//<<<<<
				player.m_contBody.SaveToXML( "TestInventory.xml" );
			}
			else
				MessageBox.Show( "Can't save empty inventory." );
		}


		public int GetItemImgIdx( RpgItem itemInv )
		{
			if ( ( itemInv.m_itemType & RpgItemType.ContSlot  ) == RpgItemType.ContSlot ) return 0;
			if ( ( itemInv.m_itemType & RpgItemType.Container )  > 0                    ) return 1;
			if ( ( itemInv.m_itemType & RpgItemType.Coin      ) == RpgItemType.Coin     ) return 5;
			if ( ( itemInv.m_itemType & RpgItemType.Gem       ) == RpgItemType.Gem      ) return 6;
			if ( ( itemInv.m_itemType & RpgItemType.Herb      ) == RpgItemType.Herb     ) return 7;
			if ( ( itemInv.m_itemType & RpgItemType.Necklace  ) == RpgItemType.Necklace ) return 8;
			if ( ( itemInv.m_itemType & RpgItemType.Ring      ) == RpgItemType.Ring     ) return 9;
			if ( ( itemInv.m_itemType & RpgItemType.Earring   ) == RpgItemType.Earring  ) return 9;
			if ( ( itemInv.m_itemType & RpgItemType.Bracelet  ) == RpgItemType.Bracelet ) return 9;
			if ( ( itemInv.m_itemType & RpgItemType.Weapon    ) == RpgItemType.Weapon   ) return 10;
			if ( ( itemInv.m_itemType & RpgItemType.Body      )  > 0                    ) return 4;

			// Image index 2 is currently "empty"
			return 3;
		}


		//----------------------------------------------------------------------
		static int m_iDepthCurr = 0;

		public void UpdateInvTree_r( RpgItem itemInv, TreeNode node )
		{

			TreeNode nodeNew = new TreeNode();
			m_iDepthCurr++;

			if ( itemInv != null )
			{
				nodeNew.Text = itemInv.m_strName;
				nodeNew.ImageIndex = GetItemImgIdx( itemInv );
			}
			else
			{
				nodeNew.Text = "(empty)";
				nodeNew.ForeColor = Color.LightGray;
				nodeNew.ImageIndex = 2;
			}

			node.Nodes.Insert( 0, nodeNew );

			if ( itemInv is RpgItemContainer )
			{
				int iChildIdx = ( itemInv as RpgItemContainer ).m_listItems.Capacity - 1;
				while ( iChildIdx >= 0 )
				{
					if ( iChildIdx < ( itemInv as RpgItemContainer ).m_listItems.Count )
					{
						UpdateInvTree_r( ( itemInv as RpgItemContainer ).m_listItems[ iChildIdx ], nodeNew );
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
