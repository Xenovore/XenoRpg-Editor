using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XenoRPGEditor
{
	public partial class InvContainerControl: Control
	{
		public InvContainerControl()
		{
			InitializeComponent();
		}

		protected override void OnPaint( PaintEventArgs pe )
		{
			base.OnPaint( pe );

			Color c1 = Color.FromArgb( 255, 250, 250, 255 );
			Color c2 = Color.FromArgb( 255, 200, 200, 220 );
			Brush b = new LinearGradientBrush( ClientRectangle, c1, c2, 10 );
			pe.Graphics.FillRectangle( b, ClientRectangle );
			b.Dispose();
		}
	}
}
