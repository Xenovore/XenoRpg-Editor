namespace XenoRPGEditor
{
	partial class FormEditItemType
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditItemType));
			this.listviewTypes = new System.Windows.Forms.ListView();
			this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imagelist = new System.Windows.Forms.ImageList(this.components);
			this.buttOk = new System.Windows.Forms.Button();
			this.buttCancel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listviewTypes
			// 
			this.listviewTypes.Activation = System.Windows.Forms.ItemActivation.OneClick;
			this.listviewTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listviewTypes.CausesValidation = false;
			this.listviewTypes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderValue,
            this.columnHeaderDescription});
			this.listviewTypes.FullRowSelect = true;
			this.listviewTypes.GridLines = true;
			this.listviewTypes.HideSelection = false;
			this.listviewTypes.Location = new System.Drawing.Point(8, 32);
			this.listviewTypes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.listviewTypes.Name = "listviewTypes";
			this.listviewTypes.Size = new System.Drawing.Size(769, 488);
			this.listviewTypes.SmallImageList = this.imagelist;
			this.listviewTypes.TabIndex = 0;
			this.listviewTypes.UseCompatibleStateImageBehavior = false;
			this.listviewTypes.View = System.Windows.Forms.View.Details;
			this.listviewTypes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listviewTypes_MouseClick);
			// 
			// columnHeaderName
			// 
			this.columnHeaderName.Text = "Name";
			this.columnHeaderName.Width = 150;
			// 
			// columnHeaderValue
			// 
			this.columnHeaderValue.Text = "Value";
			this.columnHeaderValue.Width = 150;
			// 
			// columnHeaderDescription
			// 
			this.columnHeaderDescription.Text = "Description";
			this.columnHeaderDescription.Width = 300;
			// 
			// imagelist
			// 
			this.imagelist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imagelist.ImageStream")));
			this.imagelist.TransparentColor = System.Drawing.Color.Magenta;
			this.imagelist.Images.SetKeyName(0, "Inv_No.png");
			this.imagelist.Images.SetKeyName(1, "InvAmmo.png");
			this.imagelist.Images.SetKeyName(2, "InvAny.png");
			this.imagelist.Images.SetKeyName(3, "InvApparel.png");
			this.imagelist.Images.SetKeyName(4, "InvBag.png");
			this.imagelist.Images.SetKeyName(5, "InvBody.png");
			this.imagelist.Images.SetKeyName(6, "InvBottle.png");
			this.imagelist.Images.SetKeyName(7, "InvCoin.png");
			this.imagelist.Images.SetKeyName(8, "InvEmpty.png");
			this.imagelist.Images.SetKeyName(9, "InvGem.png");
			this.imagelist.Images.SetKeyName(10, "InvHerb.png");
			this.imagelist.Images.SetKeyName(11, "InvLiquid.png");
			this.imagelist.Images.SetKeyName(12, "InvNecklace.png");
			this.imagelist.Images.SetKeyName(13, "InvRing.png");
			this.imagelist.Images.SetKeyName(14, "InvSlot.png");
			this.imagelist.Images.SetKeyName(15, "InvWeapon.png");
			// 
			// buttOk
			// 
			this.buttOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttOk.Location = new System.Drawing.Point(8, 527);
			this.buttOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttOk.Name = "buttOk";
			this.buttOk.Size = new System.Drawing.Size(80, 26);
			this.buttOk.TabIndex = 1;
			this.buttOk.Text = "Ok";
			this.buttOk.UseVisualStyleBackColor = true;
			this.buttOk.Click += new System.EventHandler(this.buttOk_Click);
			// 
			// buttCancel
			// 
			this.buttCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttCancel.Location = new System.Drawing.Point(94, 527);
			this.buttCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttCancel.Name = "buttCancel";
			this.buttCancel.Size = new System.Drawing.Size(80, 26);
			this.buttCancel.TabIndex = 2;
			this.buttCancel.Text = "Cancel";
			this.buttCancel.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "Item Types";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.label2.Location = new System.Drawing.Point(130, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(193, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "(Hold \'Ctrl\' to select multiple types.)";
			// 
			// FormEditItemType
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttCancel);
			this.Controls.Add(this.buttOk);
			this.Controls.Add(this.listviewTypes);
			this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(250, 200);
			this.Name = "FormEditItemType";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Choose Item Type(s)...";
			this.TopMost = true;
			this.Activated += new System.EventHandler(this.FormTypeEdit_Activated);
			this.ResizeEnd += new System.EventHandler(this.FormTypeEdit_ResizeEnd);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listviewTypes;
		private System.Windows.Forms.Button buttOk;
		private System.Windows.Forms.Button buttCancel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imagelist;
		private System.Windows.Forms.ColumnHeader columnHeaderName;
		private System.Windows.Forms.ColumnHeader columnHeaderValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader columnHeaderDescription;
	}
}