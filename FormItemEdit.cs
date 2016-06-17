using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using XenoRpgLib;

namespace XenoRPGEditor
{
	public partial class formItemEdit: Form
	{
		private InvIcons m_invicons = new InvIcons( @"..\RpgInvIcons.png" );
		private FormTypeEdit formTypeEdit;

		public DataRow dataRowItem { get; set; }

		//----------------------------------------------------------------------
		public formItemEdit()
		{
			InitializeComponent();
			formTypeEdit = new FormTypeEdit();
			spinIconIdx.Maximum = m_invicons.IconCount - 1;
		}



		//----------------------------------------------------------------------------
		private void formItemEdit_Load( object sender, EventArgs e )
		{
			// Load info from DB table (data grid view) row...
			txtID.Text                   = dataRowItem[ "id" ].ToString();
			txtName.Text                 = dataRowItem[ "name" ].ToString();
			//TODO: Wrap Converts in try...catch
            txtType.Text                 = "0x" + Convert.ToUInt32( dataRowItem[ "type" ].ToString() ).ToString( "X8" );

			spinIconIdx.Value            = Convert.ToDecimal( dataRowItem[ "icon_idx" ] );
			UpdateIconPreview();

			spinWeight.Value             = Convert.ToDecimal( dataRowItem[ "weight" ] );
			//TODO: Should find the selected index from these values, not use them as indexes...
			comboWidth.SelectedIndex     = Convert.ToInt32( dataRowItem[ "size_w" ] ) - 1;
			comboHeight.SelectedIndex    = Convert.ToInt32( dataRowItem[ "size_h" ] ) - 1;
			
			spinQuantity.Value           = Convert.ToDecimal( dataRowItem[ "quantity" ] );
			spinQuantityCap.Value        = Convert.ToDecimal( dataRowItem[ "quantity_cap" ] );
			comboDisabled.SelectedIndex  = Convert.ToInt32( dataRowItem[ "disabled" ] );
			comboContainer.Text          = "0x" + Convert.ToUInt32( dataRowItem[ "id_container" ].ToString() ).ToString( "X8" );
			rtfDescription.Text          = dataRowItem[ "desc" ].ToString();

			//TODO: Load container info...
		}

		//----------------------------------------------------------------------
		public void UpdateIconPreview()
		{
			pictItemIcon.Image = m_invicons.GetIconBitmap( (int)spinIconIdx.Value );
		}


		//----------------------------------------------------------------------
		private void EnableContInfo()
		{
			//TODO: Wrap in try...catch
            uint iTypeVal = Convert.ToUInt32( txtType.Text, 16 );
			
            pnlContInfo.Enabled = ( ( iTypeVal & (uint)RpgItemType.Container ) > 0 );
		}


		//----------------------------------------------------------------------
		private void txtType_TextChanged( object sender, EventArgs e )
		{
			EnableContInfo();
		}


		//----------------------------------------------------------------------
		private void buttType_Click( object sender, EventArgs e )
		{
			this.Enabled = false;
			try
			{
				formTypeEdit.TypeValue = Convert.ToUInt32( txtType.Text, 16 );
			}
			catch
			{
				// Conversion exception... bogus text
				formTypeEdit.TypeValue = 0x00000000;
			}

			DialogResult result = formTypeEdit.ShowDialog();
			if ( result == DialogResult.OK )
			{
                //TODO: CORRECTLY OR ALL BIT VALUES...
                txtType.Text = "0x" + formTypeEdit.TypeValue.ToString( "X8" );
				EnableContInfo();
			}

			this.Enabled = true;
		}


		//----------------------------------------------------------------------
		private void buttTypeAllowed_Click( object sender, EventArgs e )
		{
			this.Enabled = false;

			DialogResult result = formTypeEdit.ShowDialog();
			if ( result == DialogResult.OK )
			{
				//TODO: CORRECTLY OR ALL BIT VALUES...
                txtTypeAllowed.Text = "0x" + formTypeEdit.TypeValue.ToString( "X8" );
			}

			this.Enabled = true;
		}


		//----------------------------------------------------------------------------
		private void formItemEdit_Deactivate( object sender, EventArgs e )
		{
		}


		//----------------------------------------------------------------------------
		private void spinIconIdx_ValueChanged( object sender, EventArgs e )
		{

			// Attempting to shift origin... doesn't work...
			float fX = pictItemIcon.Width;
			float fY = pictItemIcon.Height / 2;
			Graphics g = pictItemIcon.CreateGraphics();
			g.TranslateTransform( fX, fY );

			UpdateIconPreview();
		}


		//----------------------------------------------------------------------------
		private void cbZoom_CheckedChanged( object sender, EventArgs e )
		{
			pictItemIcon.SizeMode = ( cbZoom.Checked ? PictureBoxSizeMode.Zoom : PictureBoxSizeMode.Normal );
		}


		//----------------------------------------------------------------------------
		private void formItemEdit_FormClosing( object sender, FormClosingEventArgs e )
		{
			var result = MessageBox.Show( "Save changes?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question );
			if ( result == DialogResult.Yes )
			{  
				//TODO: IF THIS A BRAND-NEW ITEM, THE DATA ROW WON'T EXIST YET; NEED TO CREATE A NEW DATA ROW FIRST.
                dataRowItem[ "name"   ] = txtName.Text;
				dataRowItem[ "type"   ] = Convert.ToInt64( txtType.Text, 16 );
				dataRowItem[ "weight" ] = Convert.ToDouble( spinWeight.Value );
				dataRowItem[ "size_w" ] = comboWidth.Text;
				dataRowItem[ "size_h" ] = comboHeight.Text;

				this.DialogResult = result;
			}
		}


	}
}
