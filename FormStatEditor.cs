using System.Windows.Forms;

namespace KevInvTest
{
	public partial class FormStatEditor: Form
	{
		bool _bNotSaved = false;

		//----------------------------------------------------------------------
		public FormStatEditor()
		{
			InitializeComponent();
		}


		//----------------------------------------------------------------------
		public void SaveChanges()
		{
			//TODO: Call this when done editing
		}


		//----------------------------------------------------------------------
		private void FormStatEditor_FormClosing( object sender, FormClosingEventArgs e )
		{
			DialogResult dlgResult = DialogResult.No;
			if ( _bNotSaved )
			{
				dlgResult = MessageBox.Show(
					"Save changes?",
					"Save",
					MessageBoxButtons.YesNo,
					MessageBoxIcon.Question );
			}

			if ( dlgResult == DialogResult.Yes )
			{
				SaveChanges();
			}
		}

	}
}
