using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XRpgUtils
{
	class ImageAtlas
	{
		private Bitmap m_bitmap;
		private List<Rectangle> m_listRects;
		//TODO: UV coords list
		public int IconCount { get { return m_listRects.Count; } }

		//----------------------------------------------------------------------------
		public ImageAtlas( string strFilename )
		{
			try
			{
				m_bitmap = new Bitmap( strFilename );
			}
			catch
			{
				MessageBox.Show(
					"Error: Unable to load image file " + strFilename,
					"Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error );
				return;
			}
			m_listRects = new List<Rectangle>();

			//TODO: Look for XML file with same name as image and load rects/uvs from there

			int iCount = ConstructRects();

			//TODO: Construct UVs

			if ( iCount == 0 ) MessageBox.Show( "Crap." );

		}

		//----------------------------------------------------------------------------
		Int32 ConstructRects()
		{
			// Already populated? Return count...
			if ( m_listRects.Count > 0 ) return m_listRects.Count;

			// Paranoia...
			if ( m_bitmap == null ) MessageBox.Show( "No bitmap loaded." );

			//get the separator color
			Color colorSep = m_bitmap.GetPixel( 0, 0 );
			if ( colorSep != Color.FromArgb( 0, Color.Magenta ) )
				MessageBox.Show( "Warning: Separator color was not magenta." );

			//now loop through all the scroll pieces, and find the bounding rectangle for each piece in each state
			int iPosY = 0;

			// ascertain the height of this row...
			m_listRects.Clear();
			while ( iPosY < m_bitmap.Height )
			{
				// Skip any seperator colors
				Color color = m_bitmap.GetPixel( 0, iPosY );
				if ( color == colorSep )
				{
					iPosY++;
					continue;
				}

				// Process left to right, grabbing rects...
				int iPosX = 0;
				while ( iPosX < m_bitmap.Width )
				{
					color = m_bitmap.GetPixel( iPosX, iPosY );
					if ( color == colorSep )
					{
						iPosX++;
						continue;
					}

					int iPosXStart = iPosX;
					while ( iPosX < m_bitmap.Width )
					{
						color = m_bitmap.GetPixel( iPosX, iPosY );
						if ( color == colorSep ) break;
						iPosX++;
					}

					int iPosYStep = iPosY;
					while ( iPosYStep < m_bitmap.Height )
					{
						color = m_bitmap.GetPixel( iPosXStart, iPosYStep );
						if ( color == colorSep ) break;
						iPosYStep++;
					}

					m_listRects.Add( new Rectangle( iPosXStart, iPosY, iPosX - iPosXStart, iPosYStep - iPosY ) );
				}

				// Skip to the next separation color on column 0
				while ( iPosY < m_bitmap.Height )
				{
					color = m_bitmap.GetPixel( 0, iPosY );
					if(color == colorSep) break;
					iPosY++;
				}
			}

			//TODO: Save rect list to XML file with same name as parent image

			return m_listRects.Count;
		}


		//----------------------------------------------------------------------------
		public Rectangle GetImageRectAt( int i )
		{
			if ( i >= 0 && i < m_listRects.Count )
				return m_listRects[ i ];
			else
				return new Rectangle( 0, 0, 0, 0 );
		}


		//----------------------------------------------------------------------------
		public Bitmap GetImageAt( int i )
		{
			return m_bitmap.Clone( GetImageRectAt( i ), m_bitmap.PixelFormat );
		}

	}
}
