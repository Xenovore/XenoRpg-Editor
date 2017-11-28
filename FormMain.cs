using System;
using System.Windows.Forms;
using XRpg;
using ExtensionMethods;

namespace XenoRPGEditor
{
	public partial class FormMain: Form
	{
		public static CharacterManager CharManager { get; set; }
		public static InventoryManager InvManager { get; set; }

		//----------------------------------------------------------------------
		// AddFormTab( <form> )
		// • Adds <form> as tab to tabCtrlMain
		// • FormMain must have property IsMdiContainer = true
		//----------------------------------------------------------------------
		/* UNUSED>>>>>
		private void AddFormTab( Form frm )
		{
			var tabNew = new TabPage( frm.Text );

			frm.TopLevel        = false;
			frm.Parent          = tabNew;
			frm.Visible         = true;
			frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			frm.Anchor          = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
			frm.Size            = frm.Parent.Size;

			tabCtrlMain.TabPages.Add( tabNew );
		}
		//<<<<<*/


		//----------------------------------------------------------------------
		// AddCtrlTab( <user control> )
		// • Adds <user control> as tab to tabCtrlMain
		//----------------------------------------------------------------------
		private void AddCtrlTab( UserControl uc, string strTabName )
		{
			var tabNew = new TabPage( strTabName );

			uc.Dock     = DockStyle.Fill;
			uc.AutoSize = true;

			tabNew.Controls.Add( uc );
			tabCtrlMain.TabPages.Add( tabNew );
		}


		//----------------------------------------------------------------------
		public FormMain()
		{
			InitializeComponent();

			CharManager = new CharacterManager();
			InvManager = new InventoryManager();

			var ucCharacters = new UserCtrlCharactersView();
			tabCtrlMain.AddUserControlTab( ucCharacters, "Characters" );

			var ucStats = new UserCtrlStatsView();
			tabCtrlMain.AddUserControlTab( ucStats, "Stats" );

			var ucItems = new UserCtrlItemsView();
			tabCtrlMain.AddUserControlTab( ucItems, "Items" );

			//TODO: Effects
			//TODO: Spells

		}


		//----------------------------------------------------------------------
		// DESTRUCTOR
		//TODO: RpgManager.Uninit


		private void button1_Click_2( object sender, EventArgs e )
		{
			var form = new FormCharacterEditor();
			form.ShowDialog();
		}


		private void mnuitmExit_Click( object sender, EventArgs e )
		{
			this.Close();
		}


		private void charDetailsToolStripMenuItem_Click( object sender, EventArgs e )
		{
			var form = new FormCharacterEditor();
			form.ShowDialog();
		}


		private void menuitemStatEditor_Click( object sender, EventArgs e )
		{
			var form = new FormEditItemType();
			form.ShowDialog();
		}
	}
}
