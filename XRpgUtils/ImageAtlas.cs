using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace XRpgUtils
{
	public class ImageAtlas
	{
		private Bitmap _bitmap;
		private List<Rectangle> _listRects;

		public List<Rectangle> ListRects { get { return _listRects; } }

		//TODO: UV coords list
		public int IconCount { get { return _listRects.Count; } }

		public Bitmap  MainImage
		{
			get { return _bitmap; }
		}

		//----------------------------------------------------------------------
		public ImageAtlas( string strFilename )
		{
			try
			{
				_bitmap = new Bitmap( strFilename );
			}
			catch
			{
				return;
			}

			_listRects = new List<Rectangle>();

			//TODO: Look for XML file with same name as image and load rects/uvs from there

			int iCount = ConstructRects();

			//TODO: Construct UVs

			if ( iCount == 0 ) MessageBox.Show( "Crap." );

		}

		//----------------------------------------------------------------------------
		Int32 ConstructRects()
		{
			// Already populated? Return count...
			if ( _listRects.Count > 0 ) return _listRects.Count;

			// Paranoia...
			if ( _bitmap == null ) MessageBox.Show( "No bitmap loaded." );

			//get the separator color
			Color colorSep = _bitmap.GetPixel( 0, 0 );
			if ( colorSep != Color.FromArgb( 0, Color.Magenta ) )
				MessageBox.Show( "Warning: Separator color was not magenta." );

			//now loop through all the scroll pieces, and find the bounding rectangle for each piece in each state
			int iPosY = 0;

			// ascertain the height of this row...
			_listRects.Clear();
			while ( iPosY < _bitmap.Height )
			{
				// Skip any seperator colors
				Color color = _bitmap.GetPixel( 0, iPosY );
				if ( color == colorSep )
				{
					iPosY++;
					continue;
				}

				// Process left to right, grabbing rects...
				int iPosX = 0;
				while ( iPosX < _bitmap.Width )
				{
					color = _bitmap.GetPixel( iPosX, iPosY );
					if ( color == colorSep )
					{
						iPosX++;
						continue;
					}

					int iPosXStart = iPosX;
					while ( iPosX < _bitmap.Width )
					{
						color = _bitmap.GetPixel( iPosX, iPosY );
						if ( color == colorSep ) break;
						iPosX++;
					}

					int iPosYStep = iPosY;
					while ( iPosYStep < _bitmap.Height )
					{
						color = _bitmap.GetPixel( iPosXStart, iPosYStep );
						if ( color == colorSep ) break;
						iPosYStep++;
					}

					_listRects.Add( new Rectangle( iPosXStart, iPosY, iPosX - iPosXStart, iPosYStep - iPosY ) );
				}

				// Skip to the next separation color on column 0
				while ( iPosY < _bitmap.Height )
				{
					color = _bitmap.GetPixel( 0, iPosY );
					if(color == colorSep) break;
					iPosY++;
				}
			}

			//TODO: Save rect list to XML file with same name as parent image

			return _listRects.Count;
		}


		//----------------------------------------------------------------------------
		public Rectangle GetSubImageRectAt( ushort i )
		{
			return ( i < _listRects.Count ) ? _listRects[ i ] : new Rectangle( 0, 0, 0, 0 );
		}


		//----------------------------------------------------------------------------
		public Bitmap GetSubImageAt( ushort i )
		{
			return _bitmap.Clone( GetSubImageRectAt( i ), _bitmap.PixelFormat );
		}

	}
}
