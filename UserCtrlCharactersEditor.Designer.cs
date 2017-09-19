namespace XenoRPGEditor
{
	partial class UserCtrlCharactersEditor
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.gridview = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.comboSearchBy = new System.Windows.Forms.ComboBox();
			this.lblSearch = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
			this.SuspendLayout();
			// 
			// gridview
			// 
			this.gridview.AllowUserToOrderColumns = true;
			this.gridview.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
			this.gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridview.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridview.EnableHeadersVisualStyles = false;
			this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gridview.Location = new System.Drawing.Point(8, 32);
			this.gridview.Margin = new System.Windows.Forms.Padding(4);
			this.gridview.MultiSelect = false;
			this.gridview.Name = "gridview";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridview.RowHeadersWidth = 24;
			this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridview.Size = new System.Drawing.Size(620, 400);
			this.gridview.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Characters";
			// 
			// comboSearchBy
			// 
			this.comboSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboSearchBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboSearchBy.FormattingEnabled = true;
			this.comboSearchBy.Location = new System.Drawing.Point(67, 443);
			this.comboSearchBy.MaxDropDownItems = 5;
			this.comboSearchBy.Name = "comboSearchBy";
			this.comboSearchBy.Size = new System.Drawing.Size(241, 26);
			this.comboSearchBy.TabIndex = 22;
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.BackColor = System.Drawing.Color.Transparent;
			this.lblSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(8, 446);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(53, 18);
			this.lblSearch.TabIndex = 21;
			this.lblSearch.Text = "Search:";
			this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UserCtrlCharactersEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.Controls.Add(this.comboSearchBy);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.gridview);
			this.Name = "UserCtrlCharactersEditor";
			this.Size = new System.Drawing.Size(640, 480);
			this.Load += new System.EventHandler(this.Editor_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView gridview;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboSearchBy;
		private System.Windows.Forms.Label lblSearch;
	}
}
