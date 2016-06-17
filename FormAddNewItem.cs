using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KevInvTest
{
	public partial class FormAddNewItem: Form
	{
		public FormAddNewItem()
		{
			InitializeComponent();
		}

		private void buttDone_Click( object sender, EventArgs e )
		{
			//TODO: Add to DB
			Close();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			Close();
		}
	}
}
