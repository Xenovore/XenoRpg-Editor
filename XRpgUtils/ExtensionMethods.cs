using System.Windows.Forms;

namespace ExtensionMethods
{
	static class ExtensionMethods
	{
		//----------------------------------------------------------------------
		// AddUserControlTab( <user control>, <tab name> )
		// • Adds <user control> as tab named <tab name> to tab control
		//----------------------------------------------------------------------
		public static void AddUserControlTab( this TabControl tabCtrl, UserControl uc, string strTabName )
		{
			var tabNew = new TabPage( strTabName );

			uc.Dock     = DockStyle.Fill;
			uc.AutoSize = true;

			tabNew.Controls.Add( uc );
			tabCtrl.TabPages.Add( tabNew );
		}
	}
}
