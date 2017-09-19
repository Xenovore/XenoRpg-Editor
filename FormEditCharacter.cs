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

		private CharacterBase _character;

		public FormEditCharacter()
		{
			InitializeComponent();

			charManager = FormMain.CharManager;
			invManager  = FormMain.InvManager;

			//TODO: DO WE NEED THIS HERE?
			//FormMain.CharManager.LoadAllStats(); // Attributes, resistances, skills


			// Init UI for item type selection...
			/*
			comboItemTypes.DataSource = new BindingSource( RpgMan.dictTypeNames, null );
			comboItemTypes.DisplayMember = "Value";
			comboItemTypes.ValueMember   = "Key";
			*/

			// Load default character
			_character = charManager.LoadCharacterById( 1 );
			PopulateCharInfo( _character );

			// Load stats...
			var listCharStats = charManager.LoadCharacterStats( _character.Id );

			// Must have DataTable in order to filter...
			DataTable dt = ToDataTable( listCharStats );

			gridCharacterStats.DataSource = dt;
			AdjustGrid( gridCharacterStats );

			// Load character inventory...
			_character._contBody = invManager.LoadContainer( _character.ContBodyId );

			RefreshSlotView();
			RefreshTreeView();
		}


		//----------------------------------------------------------------------
		private void PopulateCharInfo( CharacterBase character )
		{
			textNameFirst.Text = character.Name;
			textNameLast.Text  = character.NameLast;
			textAge.Text       = character.Age.ToString();
			textXpPool.Text    = character.XPPool.ToString();

			// Populate species and profession combo boxes
			var listSpecies = charManager.GetSpeciesList();
			comboRace.DataSource    = listSpecies;
			comboRace.ValueMember   = "Id";
			comboRace.DisplayMember = "Name";

			var listProfs = charManager.GetProfessionList();
			comboProfession.DataSource    = listProfs;
			comboProfession.ValueMember   = "Id";
			comboProfession.DisplayMember = "Name";

			// Populate stat type filter combo box...
			var listStatTypes = charManager.GetStatTypeList();
			listStatTypes.Insert( 0, new XRpg.StatType() { Id = 0, Name = "All" } );
			comboStatTypeFilter.DataSource    = listStatTypes;
			comboStatTypeFilter.ValueMember   = "Id";
			comboStatTypeFilter.DisplayMember = "Name";
		}


		//----------------------------------------------------------------------
		public static DataTable ToDataTable<T>( IList<T> data )
		{
			PropertyDescriptorCollection properties =
				TypeDescriptor.GetProperties(typeof(T));
			DataTable table = new DataTable();
			foreach (PropertyDescriptor prop in properties)
				table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			foreach ( T item in data )
			{
				DataRow row = table.NewRow();
				foreach (PropertyDescriptor prop in properties)
				{
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				}
				table.Rows.Add(row);
			}
			return table;
		}

		//----------------------------------------------------------------------
		private void AdjustGrid( DataGridView dgv )
		{
			try
			{
				//Hide columns...
				dgv.Columns[ 0 ].Visible = false; // ID
				dgv.Columns[ 3 ].Visible = false; // Desc

				// Set columns to read-only
				dgv.Columns[ 1 ].ReadOnly = true;
				dgv.Columns[ 2 ].ReadOnly = true;
				dgv.Columns[ 3 ].ReadOnly = true;

				// Set read-only column colors
				Color colorPhysAttr = Color.FromArgb( 0xFF, 0xD0, 0xD0 );
				Color colorMentAttr = Color.FromArgb( 0xFF, 0xD0, 0xFF );
				Color colorSpecAttr = Color.FromArgb( 0xD0, 0xD0, 0xFF );
				Color colorResists  = Color.FromArgb( 0xD0, 0xFF, 0xD0 );
				Color colorSkills   = Color.FromArgb( 0xFF, 0xF0, 0xD0 );
				Color colorInvalid  = Color.FromArgb( 0xA0, 0xA0, 0xA0 );

				// Set tooltips...
				for ( int i = 0; i < dgv.Rows.Count; ++i )
				{
					var row = dgv.Rows[i];
					const int iTypeColIdx = 4;
					var strType = row.Cells[iTypeColIdx].Value.ToString();
					switch ( strType )
					{
						case "AttribPhysical": row.Cells[3].Style.BackColor = colorPhysAttr; break;
						case "AttribMental " : row.Cells[3].Style.BackColor = colorMentAttr; break;
						case "AttribSpecial" : row.Cells[3].Style.BackColor = colorSpecAttr; break;
						case "Resistance"    : row.Cells[3].Style.BackColor = colorResists;  break;
						case "Skill"         : row.Cells[3].Style.BackColor = colorSkills;   break;
						case "Special"       : row.Cells[3].Style.BackColor = colorInvalid;  break;
						default              : row.Cells[3].Style.BackColor = colorInvalid;  break;
					}
				}

				//dgv.Columns[ 1 ].DefaultCellStyle.BackColor = colorPhysAttr;
				//dgv.Columns[ 2 ].DefaultCellStyle.BackColor = colorPhysAttr;
				//dgv.Columns[ 3 ].DefaultCellStyle.BackColor = colorPhysAttr;

				dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb( 0xD0, 0xD0, 0xFF );

				//dgv.Columns[ 0 ].HeaderText = "Name";
				//dgv.Columns[ 1 ].HeaderText = "Abbr";
				//dgv.Columns[ 2 ].HeaderText = "Desc";
				//dgv.Columns[ 3 ].HeaderText = "Lvl Base";
				//dgv.Columns[ 4 ].HeaderText = "Lvl Total";
				//dgv.Columns[ 5 ].HeaderText = "Score";
				//dgv.Columns[ 6 ].HeaderText = "XP";

				// Set column widths....
				dgv.Columns[ 0 ].Width =  0;
				dgv.Columns[ 1 ].Width = 90;
				dgv.Columns[ 2 ].Width = 50;
				dgv.Columns[ 3 ].Width = 40;
				dgv.Columns[ 4 ].Width = 40;
				dgv.Columns[ 5 ].Width = 40;
				dgv.Columns[ 6 ].Width = 40;
			}
			catch
			{
				; //IGNORE
			}

			// Set tooltips...
			//for ( int i = 0; i < dgv.Rows.Count; ++i )
			//{
			//	dgv.Rows[i].Cells[1].ToolTipText = dgv.Rows[i].Cells[3].Value.ToString();
			//}
		}


		//----------------------------------------------------------------------
		private void Form1_Shown( object sender, EventArgs e )
		{
			//TODO: Remove... doesn't look like this event is hooked up
			RefreshSlotView();
			RefreshTreeView();
		}


		//=====================================================================
		// FORM UI STUFF
		//=====================================================================

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
			if ( _character._contBody != null )
			{
				//TEST>>>>>
				//TODO: MOVE TO MANAGER>>>>> player.m_contBody.SaveToDB();
				//<<<<<
				//player._contBody.SaveToXML( "TestInventory.xml" );
			}
			else
				MessageBox.Show( "Can't save empty inventory." );
		}


		public int GetItemImgIdx( Item itemInv )
		{
			if ( ( itemInv.Type & ItemTypeEnum.ContSlot  ) == ItemTypeEnum.ContSlot ) return 0;
			if ( ( itemInv.Type & ItemTypeEnum.Container )  > 0                 ) return 1;
			if ( ( itemInv.Type & ItemTypeEnum.Coin      ) == ItemTypeEnum.Coin     ) return 5;
			if ( ( itemInv.Type & ItemTypeEnum.Gem       ) == ItemTypeEnum.Gem      ) return 6;
			if ( ( itemInv.Type & ItemTypeEnum.Herb      ) == ItemTypeEnum.Herb     ) return 7;
			if ( ( itemInv.Type & ItemTypeEnum.Necklace  ) == ItemTypeEnum.Necklace ) return 8;
			if ( ( itemInv.Type & ItemTypeEnum.Ring      ) == ItemTypeEnum.Ring     ) return 9;
			if ( ( itemInv.Type & ItemTypeEnum.Earring   ) == ItemTypeEnum.Earring  ) return 9;
			if ( ( itemInv.Type & ItemTypeEnum.Bracelet  ) == ItemTypeEnum.Bracelet ) return 9;
			if ( ( itemInv.Type & ItemTypeEnum.Weapon    ) == ItemTypeEnum.Weapon   ) return 10;
			if ( ( itemInv.Type & ItemTypeEnum.Body      )  > 0                 ) return 4;

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
			var listSlots = _character._contBody.Container._listItems;
			int count = 0;
			int offsetX = 0;
			int offsetY = 0;
			foreach( Item item in listSlots )
			{
				//TODO: REMOVE; temporary
				offsetX = count % 5 * ( c_slotExtent + 4 );
				if ( count % 5 == 0 ) offsetY += c_slotExtent + 4;

				var ctrlSlot = new InvItemControl
				{
					Text      = item.Name,
					Location  = new Point( (int)item.PosX + offsetX, (int)item.PosY + offsetY ),
					Width     = (int)item.SizeW * c_slotExtent,
					Height    = (int)item.SizeH * c_slotExtent,
					Movable   = true,
					Font      = new Font( "Calibri", 8 ),
					BackgroundFilename = "images/InvSlot.png",
					ItemImageFilename = "images/InvGem.png",
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
			UpdateInvTree_r( _character._contBody, nodeRoot );

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


		//----------------------------------------------------------------------
		private void comboStatTypeFilter_SelectedIndexChanged( object sender, EventArgs e )
		{
			if ( gridCharacterStats.DataSource == null ) return;

			// Filter stat list based on selected filter
			var dt = (gridCharacterStats.DataSource as DataTable);
			// If "All" is selected, clear the filter...
			if ( comboStatTypeFilter.SelectedIndex == 0 )
			{
				dt.DefaultView.RowFilter = "";
			}
			else
			{
				dt.DefaultView.RowFilter = $"Type='{comboStatTypeFilter.SelectedIndex}'";
			}
		}
	}
}
