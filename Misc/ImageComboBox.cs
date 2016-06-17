using System.Drawing;


namespace System.Windows.Forms
{
	class ImageComboBox: ComboBox
	{
		private ImageList m_listImages = new ImageList();

		public ImageComboBox()
		{
			this.DrawMode = DrawMode.OwnerDrawFixed;
		}

		public ImageList Images
		{
			get { return m_listImages; }
			set { m_listImages = value; }
		}


		public void LoadImageList( string strFilename )
		{
			m_listImages.Images.Clear();
			m_listImages.Images.Add( Image.FromFile( strFilename ) );
		}


		protected override void OnDrawItem( DrawItemEventArgs e )
		{
			e.DrawBackground(); //Draw Background Of Item
			e.DrawFocusRectangle(); //Draw Its rectangle

			if ( e.Index >= 0 ) //Do We Have A Valid List?
			{
				// Just need index into image list...
				//Draw Image
				this.m_listImages.Draw( e.Graphics, e.Bounds.Left, e.Bounds.Top, e.Index );
			}

			base.OnDrawItem( e );
		}
	}
}
