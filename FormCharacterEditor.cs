using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ExtensionMethods;

using XRpg;

namespace XenoRPGEditor
{
	public partial class FormCharacterEditor: Form
	{
		//----------------------------------------------------------------------
		public FormCharacterEditor()
		{
			InitializeComponent();

			//TODO: Kind of need the character ID; but if none was supplied, do something, e.g. ask for ID
		}


		//----------------------------------------------------------------------
		public FormCharacterEditor( uint iCharacterId )
		{
			Debug.Assert( iCharacterId > 0 );

			InitializeComponent();

			var ucCharEditInfo = new UserCtrlCharacterEditInfo( iCharacterId );
			tabControl.AddUserControlTab( ucCharEditInfo, "Stats & Info" );

			var ucCharEditInventory = new UserCtrlCharacterEditInventory( iCharacterId );
			tabControl.AddUserControlTab( ucCharEditInventory, "Inventory" );

		}


		//----------------------------------------------------------------------
		private void buttSave_Click( object sender, EventArgs e )
		{
			//TODO: Save changes to character DB tables
		}


		//----------------------------------------------------------------------
		private void buttClose_Click( object sender, EventArgs e )
		{
			//TODO: Check for unsaved changes; show confirmation dialog
			this.Close();
		}
	}
}
