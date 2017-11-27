using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;

namespace XRpgUtils
{
	//TODO: REPLACE ALL MESSAGEBOXES WITH SOMETHING ELSE; LOG FILE?
	public class ImageAtlas
	{
		Bitmap _bitmap;

		public List<Rectangle> ListRects { get; set; }
		//TODO: UV coords list

		public int ImageCount => ListRects.Count;
		public Bitmap MainImage => _bitmap;

		//----------------------------------------------------------------------
		public ImageAtlas()
		{
		}


		//----------------------------------------------------------------------
		public ImageAtlas( string strFilename )
		{
			int result = Load( strFilename );
			//TODO: Check result; log message
		}


		//----------------------------------------------------------------------
		public int Load( string strFilename )
		{
			try
			{
				_bitmap = new Bitmap( strFilename );
			}
			catch
			{
				//TODO: Provide an alternative here; the exception makes the control look unstable at design time
				//throw new ApplicationException( $"ERROR: Failed to load atlas bitmap \"{strFilename}\"!" );
			}

			if ( _bitmap == null ) return -1;

			ListRects = new List<Rectangle>();

			//TODO: Look for XML file with same name as image and load rects/uvs from there
			// if xmlfile exists then load rects/uvs
			// else
			// {
			int iRectCount = ConstructRects();
			int iUVCount = ConstructUVs();

			Debug.Assert( iRectCount > 0 );
			Debug.Assert( iUVCount > 0 );
			// }

			return 0;
		}


		//----------------------------------------------------------------------------
		Int32 ConstructRects()
		{
			// Already populated? Return count...
			if ( ListRects.Count > 0 ) return ListRects.Count;

			// Paranoia...
			if ( _bitmap == null ) MessageBox.Show( "No bitmap loaded." );

			// Get the separator color; magenta is preferred
			Color colorSep = _bitmap.GetPixel( 0, 0 );
			if ( colorSep != Color.FromArgb( 0, Color.Magenta ) )
				MessageBox.Show( "Warning: Separator color was not magenta." );

			// Now loop through pieces, and find the bounding rectangle for each piece...
			int iPosY = 0;

			ListRects.Clear();
			while ( iPosY < _bitmap.Height )
			{
				// Determine the height of this row
				Color color = _bitmap.GetPixel( 0, iPosY );
				// Skip any seperator colors
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

					ListRects.Add( new Rectangle( iPosXStart, iPosY, iPosX - iPosXStart, iPosYStep - iPosY ) );
				}

				// Skip to the next separation color on column 0
				while ( iPosY < _bitmap.Height )
				{
					color = _bitmap.GetPixel( 0, iPosY );
					if(color == colorSep) break;
					iPosY++;
				}
			}

			//TODO: Save rect list to XML file with same name as parent image;
			// then we can just load that instead of doing all this work every time.

			return ListRects.Count;
		}


		//----------------------------------------------------------------------------
		Int32 ConstructUVs()
		{
			//TODO: Construct UV list

			return 1;
		}

		
		//----------------------------------------------------------------------------
		public Rectangle GetSubImageRectAt( ushort i ) =>
			( i < ListRects.Count ) ? ListRects[ i ] : new Rectangle( 0, 0, 0, 0 );


		//----------------------------------------------------------------------------
		public Bitmap GetSubImageAt( ushort i ) =>
			_bitmap.Clone( GetSubImageRectAt( i ), _bitmap.PixelFormat );

	}
}
