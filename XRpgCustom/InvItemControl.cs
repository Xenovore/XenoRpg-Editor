using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XRpgUtils;


namespace XenoRPGEditor
{
	public partial class InvItemControl: Control
	{
		// Position for text overlay (used for quantity if item is stacked)
		public enum TextPosition
		{
			TopLeft,
			TopCenter,
			TopRight,
			BottomLeft,
			BottomCenter,
			BottomRight,
		}

		Point _clickLoc; // Used with mouse dragging

		//protected string _text;
		protected bool   _useImageSize;
		protected bool   _useBgImageSize;
		protected bool   _isMovable;
		protected float  _fUiScale;
		protected string _strItemImageFilename;
		protected string _strBackgroundFilename;
		protected Bitmap _bmpItemImage;
		protected Bitmap _bmpBackground;

		protected TextPosition _textPos;

		public XRpg.Item XRpgItem { get; set; }

		/* Just use Control.Text for now
		[Category("Appearance"), Description( "Text" )]
		public TextPosition Text
		{
			get
			{
				return _text;
			}
			set
			{
				_text = value;
				if ( DesignMode ) this.Invalidate();
			}
		}
		*/

		//----------------------------------------------------------------------
		[Category("Appearance"), Description( "Use Image Size" ), DefaultValue( false )]
		public bool UseImageSize
		{
			get { return _useImageSize; }
			set { _useImageSize = value; }
		}


		//----------------------------------------------------------------------
		[Category("Appearance"), Description( "Use BG Image Size" ), DefaultValue( true )]
		public bool UseBgImageSize
		{
			get { return _useBgImageSize; }
			set { _useBgImageSize = value; }
		}


		//----------------------------------------------------------------------
		[Category("Appearance"), Description( "Movable" ), DefaultValue( false )]
		public bool Movable
		{
			get { return _isMovable; }
			set { _isMovable = value; }
		}


		//----------------------------------------------------------------------
		[Category("Appearance"), Description( "Text Position" )]
		public TextPosition TextPos
		{
			get
			{
				return _textPos;
			}
			set
			{
				_textPos = value;
				if ( DesignMode ) this.Invalidate();
			}
		}


		//----------------------------------------------------------------------
		[Category("Appearance"), Description( "UI Scale" ), DefaultValue( 1.0f )]
		public float UIScale
		{
			get
			{
				return _fUiScale;
			}
			set
			{
				_fUiScale = value;
				if ( DesignMode ) this.Invalidate();
			}
		}


		//----------------------------------------------------------------------
		[Category("Appearance"), Description( "Filename for item image" )]
		public string ItemImageFilename
		{
			get
			{
				return _strItemImageFilename;
			}
			set
			{
				_strItemImageFilename = value;
				if ( !String.IsNullOrWhiteSpace( _strItemImageFilename ) )
				{
					_bmpItemImage = new Bitmap( _strItemImageFilename );
					Color chromakey = _bmpItemImage.GetPixel( 0, 0 );

					//TODO: Remove magenta assumption if we want another color
					if ( chromakey.ToArgb() == Color.Magenta.ToArgb() )
					{
						_bmpItemImage.MakeTransparent( chromakey );
					}

					if ( _useImageSize )
					{
						this.Width = _bmpItemImage.Width;
						this.Height = _bmpItemImage.Height;
					}

					if ( DesignMode ) this.Invalidate();
				}
			}
		}


		//----------------------------------------------------------------------
		[Browsable(true)]
		[Category("Appearance"), Description( "Filename for background image" )]
		public string BackgroundFilename
		{
			get
			{
				return _strBackgroundFilename;
			}
			set
			{
				_strBackgroundFilename = value;
				if ( !String.IsNullOrWhiteSpace( _strBackgroundFilename ) )
				{
					_bmpItemImage = new Bitmap( _strBackgroundFilename );
					if ( _useBgImageSize )
					{
						this.Width = _bmpItemImage.Width;
						this.Height = _bmpItemImage.Height;
					}

					if ( DesignMode ) this.Invalidate();
				}
			}
		}


		//----------------------------------------------------------------------
		public InvItemControl( string itemImageName )
		{
			InitializeComponent();

			//TODO: Get item image based on itemImageName
		}


		//----------------------------------------------------------------------
		public InvItemControl()
		{
			InitializeComponent();

			if ( !String.IsNullOrWhiteSpace( _strItemImageFilename ) )
			{
				_bmpItemImage = new Bitmap( _strItemImageFilename );
			}

			if ( !String.IsNullOrWhiteSpace( _strBackgroundFilename ) )
			{
				_bmpItemImage = new Bitmap( _strBackgroundFilename );
			}

			TextPos = TextPosition.BottomRight;
		}


		//----------------------------------------------------------------------
		protected override void OnPaint( PaintEventArgs pe )
		{
			Graphics grfx = pe.Graphics;
			grfx.InterpolationMode = InterpolationMode.Bicubic;

			// Call base paint first; everything here should paint over any default rendering...
			//! Forget base paint; do not want any default rendering!
			//base.OnPaint( pe );

			Rectangle rectClient = this.ClientRectangle;

			//----- Draw item image background to client rect so image scales with control...
			if ( _bmpBackground != null ) grfx.DrawImage( _bmpBackground, rectClient  );

			//----- Draw item image to client rect so image scales with control...
			if ( _bmpItemImage != null ) grfx.DrawImage( _bmpItemImage, rectClient  );

			//----- Render text overlay
			//var font = new Font(
			//	this.Font.FontFamily,
			//	this.Font.Size,
			//	this.Font.Style,
			//	GraphicsUnit.Pixel );

			SizeF sizeText = grfx.MeasureString( this.Text, this.Font, rectClient.Width - this.Padding.Horizontal );

			Point ptTextPos = new Point( this.Padding.Left, this.Padding.Top );

			// Calc offset from text position...
			switch ( _textPos )
			{
				case TextPosition.TopRight:
					ptTextPos.X = rectClient.Width  - ptTextPos.X - (int)sizeText.Width;
					break;

				case TextPosition.BottomLeft:
					ptTextPos.Y = rectClient.Height - ptTextPos.Y - (int)sizeText.Height;
					break;

				case TextPosition.BottomRight:
					ptTextPos.X = rectClient.Width  - ptTextPos.X - (int)sizeText.Width;
					ptTextPos.Y = rectClient.Height - ptTextPos.Y - (int)sizeText.Height;
					break;

				case TextPosition.TopLeft:
				default:
					break;
			}

			var solidBrush = new SolidBrush( this.ForeColor );
			grfx.TextRenderingHint = TextRenderingHint.AntiAlias;
			grfx.DrawString( this.Text, this.Font, solidBrush, ptTextPos );

			var pen = new Pen( Color.Magenta );
			grfx.DrawRectangle( pen, rectClient );
		}


		protected override void OnMouseDown( MouseEventArgs e )
		{
			//TODO: Check Movable here
			//TODO: Check if click is on other border rectangles, and isResizable flag is set

			this.Capture = true;
			_clickLoc = e.Location;

			base.OnMouseDown( e );
		}


		//----------------------------------------------------------------------
		protected override void OnMouseMove( MouseEventArgs e )
		{
			if ( _isMovable )
			{
				// e.X, e.Y is current mouse position
				// New control position is at current control position + current mouse position - original click position
				if ( this.Capture )
				{
					this.Location = new Point( this.Location.X + e.X - _clickLoc.X, this.Location.Y + e.Y - _clickLoc.Y);
				}
			}

			base.OnMouseMove( e );
		}


		//----------------------------------------------------------------------
		protected override void OnMouseUp( MouseEventArgs e )
		{
			this.Capture = false;

			base.OnMouseUp( e );
		}
	}
}
