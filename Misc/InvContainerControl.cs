using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XRpgUtils;

namespace XenoRPGEditor
{
	public partial class InvContainerControl: Control
	{
		protected enum FramePiece: byte
		{
			TopLeft,
			Top,
			TopRight,
			Left,
			//middle?
			Right,
			BottomLeft,
			Bottom,
			BottomRight,
		}

		protected List<Rectangle> _listFrameRects;
		protected ImageAtlas _atlasFrame;
		protected Bitmap _bmpBackground;
		protected bool   _bMovable;
		protected float  _fUiScale;
		protected Color  _colorGradient1;
		protected Color  _colorGradient2;
		protected int    _iGradientAngle;

		protected string _strBackgroundImageFilename;
		protected string _strFrameImageFilename;

		protected List<InvItemControl> _listItemCtrls;

		[Category("Appearance"), Description( "Movable" ), DefaultValue( false )]
		public bool Movable { get; set; }
		//{
		//	get { return _bMovable; }
		//	set { _bMovable = value; }
		//}


		[Category("Appearance"), Description( "UI Scale" ), DefaultValue( 1.0f ) ]
		public float UIScale
		{
			get
			{
				return _fUiScale;
			}
			set
			{
				_fUiScale = value;
				if (DesignMode ) Invalidate();
			}
		}


		[Category("Appearance"), Description( "Top color for gradient background" )]
		public Color GradientColor1
		{
			get
			{
				return _colorGradient1;
			}
			set
			{
				_colorGradient1 = value;
				if (DesignMode ) Invalidate();
			}
		}


		[Category("Appearance"), Description( "Top color for gradient background" )]
		public Color GradientColor2
		{
			get
			{
				return _colorGradient2;
			}
			set
			{
				_colorGradient2 = value;
				if (DesignMode ) this.Invalidate();
			}
		}


		[Category("Appearance"), Description( "Angle for gradient background" )]
		public int GradientAngle
		{
			get
			{
				return _iGradientAngle;
			}
			set
			{
				_iGradientAngle = value;
				if (DesignMode ) this.Invalidate();
			}
		}


		[Category("Appearance"), Description( "Filename for background image" )]
		public string BackgroundImageFilename
		{
			get
			{
				return _strBackgroundImageFilename;
			}
			set
			{
				_strBackgroundImageFilename = value;
				if ( !String.IsNullOrWhiteSpace( _strBackgroundImageFilename ) )
				{
					_bmpBackground = new Bitmap( _strBackgroundImageFilename );
					if ( DesignMode ) this.Invalidate();
				}
			}
		}


		[Category("Appearance"), Description( "Filename for frame image atlas" )]
		public string FrameImageFilename
		{
			get
			{
				return _strFrameImageFilename;
			}
			set
			{
				_strFrameImageFilename = value;
				if ( !String.IsNullOrWhiteSpace( _strFrameImageFilename ) )
				{
					_atlasFrame = new ImageAtlas( _strFrameImageFilename );
					if ( DesignMode ) this.Invalidate();
				}
			}
		}


		//----------------------------------------------------------------------
		public InvContainerControl()
		{
			InitializeComponent();

			if ( !String.IsNullOrWhiteSpace( _strFrameImageFilename ) )
			{
				_atlasFrame = new ImageAtlas( _strFrameImageFilename );
				if ( _atlasFrame != null && _atlasFrame.MainImage != null )
				{
					ConstructFrameRects( _atlasFrame.ListRects );
				}
			}
		}

		public bool LoadItems( )
		{
			//TODO: Load items for this container
			return false;
		}
		//----------------------------------------------------------------------
		protected bool ConstructFrameRects( List<Rectangle> listSrcRects )
		{
			if ( _listFrameRects == null )
			{
				_listFrameRects = new List<Rectangle>();
			}
			else
			{
				_listFrameRects.Clear();
			}

			Rectangle rectSrc;
			Rectangle rectTopLeft;
			Rectangle rectTopRight;
			Rectangle rectTop;
			Rectangle rectBottomLeft;
			Rectangle rectBottomRight;
			Rectangle rectBottom;
			Rectangle rectLeft;
			Rectangle rectRight;

			Rectangle rectClient = this.ClientRectangle;

			//NOTE: Because middle sections can stretch, have to calculate corners first

			//----- Top
			rectSrc = listSrcRects[ (ushort)FramePiece.TopLeft ];
			rectTopLeft = new Rectangle
			{
				X = rectClient.X,
				Y = rectClient.Y,
				Width = (int)( rectSrc.Width ),
				Height = (int)( rectSrc.Height ),
			};

			rectSrc = listSrcRects[(ushort)FramePiece.TopRight];
			rectTopRight = new Rectangle
			{
				X = rectClient.Width - rectSrc.Width,
				Y = rectClient.Y,
				Width = (int)( rectSrc.Width ),
				Height = (int)( rectSrc.Height ),
			};

			rectSrc = listSrcRects[(ushort)FramePiece.Top];
			rectTop = new Rectangle
			{
				X = rectClient.X + rectTopLeft.Width,
				Y = rectClient.Y
			};
			rectTop.Width = (int)( rectTopRight.X - rectTop.X );
			rectTop.Height = (int)( rectSrc.Height );

			//----- Bottom
			rectSrc = listSrcRects[(ushort)FramePiece.BottomLeft];
			rectBottomLeft = new Rectangle
			{
				X = rectClient.X,
				Y = rectClient.Height - rectSrc.Height,
				Width = (int)( rectSrc.Width ),
				Height = (int)( rectSrc.Height ),
			};

			rectSrc = listSrcRects[(ushort)FramePiece.BottomRight];
			rectBottomRight = new Rectangle
			{
				X = rectClient.Width - rectSrc.Width,
				Y = rectClient.Height - rectSrc.Height,
				Width = (int)( rectSrc.Width ),
				Height = (int)( rectSrc.Height ),
			};

			rectSrc = listSrcRects[(ushort)FramePiece.Bottom];
			rectBottom = new Rectangle
			{
				X = rectClient.X + rectBottomLeft.Width,
				Y = rectClient.Height - rectSrc.Height,
			};
			rectBottom.Width = (int)( rectBottomRight.X - rectBottom.X );
			rectBottom.Height = (int)( rectSrc.Height );

			//----- Left
			rectSrc = listSrcRects[(ushort)FramePiece.Left];
			rectLeft = new Rectangle
			{
				X = rectClient.X,
				Y = rectClient.Y + rectTopLeft.Height,
				Width = (int)( rectSrc.Width ),
			};
			rectLeft.Height = (int)( rectBottomLeft.Y - rectLeft.Y );

			//----- Right
			rectSrc = listSrcRects[(ushort)FramePiece.Right];
			rectRight = new Rectangle()
			{
				X = rectTopRight.X,
				Y = rectTopRight.Height,
				Width = (int)( rectSrc.Width ),
			};
			rectRight.Height = (int)( rectBottomRight.Y - rectRight.Y );

			//----- Add rects to list
			_listFrameRects.Add( rectTopLeft );
			_listFrameRects.Add( rectTop );
			_listFrameRects.Add( rectTopRight );
			_listFrameRects.Add( rectLeft );
			_listFrameRects.Add( rectRight );
			_listFrameRects.Add( rectBottomLeft );
			_listFrameRects.Add( rectBottom );
			_listFrameRects.Add( rectBottomRight );

			return true;
		}


		//----------------------------------------------------------------------
		protected void DrawFramePiece( Graphics grfx, FramePiece piece )
		{
			if ( _atlasFrame == null || _atlasFrame.MainImage == null || !_listFrameRects.Any() )
			{
				return;
			}

			Bitmap mainImage = _atlasFrame.MainImage;
			Rectangle rectSrc = _atlasFrame.GetSubImageRectAt( (ushort)piece );
			Rectangle rectDst = _listFrameRects[ (ushort)piece ];
			grfx.DrawImage( mainImage, rectDst, rectSrc, GraphicsUnit.Pixel );

			//Test frame
			Pen pen = new Pen( Color.DarkGray );
			grfx.DrawRectangle( pen, rectDst );
		}


		//----------------------------------------------------------------------
		protected override void OnPaint( PaintEventArgs pe )
		{
			Graphics grfx = pe.Graphics;

			// Call base paint first; everything here should paint over any default rendering...
			base.OnPaint( pe );

			Rectangle rectClient = this.ClientRectangle;

			//----- Render default background
			Brush brushGradient = new LinearGradientBrush( rectClient, GradientColor1, GradientColor2, GradientAngle );
			grfx.FillRectangle( brushGradient, rectClient );
			brushGradient.Dispose();

			//----- Render default border
			if ( true )
			{
				Pen pen = new Pen( Color.Magenta );
				grfx.DrawRectangle( pen, rectClient );
			}

			//----- Render frame
			DrawFramePiece( grfx, FramePiece.TopLeft     );
			DrawFramePiece( grfx, FramePiece.Top         );
			DrawFramePiece( grfx, FramePiece.TopRight    );
			DrawFramePiece( grfx, FramePiece.Left        );
			DrawFramePiece( grfx, FramePiece.Right       );
			DrawFramePiece( grfx, FramePiece.BottomLeft  );
			DrawFramePiece( grfx, FramePiece.Bottom      );
			DrawFramePiece( grfx, FramePiece.BottomRight );
		}


		//----------------------------------------------------------------------
		protected override void OnResize( EventArgs e )
		{
			base.OnResize( e );

			if ( _atlasFrame != null && _atlasFrame.MainImage != null )
			{
				ConstructFrameRects( _atlasFrame.ListRects );
			}
		}

		Point _clickLoc;

		protected override void OnMouseDown( MouseEventArgs e )
		{
			//TODO: Check if click is on title bar, and isMovable is set, and moveOnlyWithTitleBar flag is set

			//TODO: Check if click is on other border rectangles, and isResizable flag is set

			// Only capture if movable...
			Capture = Movable;
			_clickLoc = e.Location;

			base.OnMouseDown( e );
		}


		//----------------------------------------------------------------------
		protected override void OnMouseMove( MouseEventArgs e )
		{
			// e.X, e.Y is current mouse position
			// New control position is at current control position + current mouse position - original click position
			if ( Capture )
			{
				Location = new Point( Location.X + e.X - _clickLoc.X, Location.Y + e.Y - _clickLoc.Y);
			}

			base.OnMouseMove( e );
		}


		//----------------------------------------------------------------------
		protected override void OnMouseUp( MouseEventArgs e )
		{
			Capture = false;

			base.OnMouseUp( e );
		}
	}
}
