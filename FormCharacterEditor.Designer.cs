namespace XenoRPGEditor
{
	partial class FormCharacterEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCharacterEditor));
			this.imglistTree = new System.Windows.Forms.ImageList(this.components);
			this.buttSave = new System.Windows.Forms.Button();
			this.buttClose = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.SuspendLayout();
			// 
			// imglistTree
			// 
			this.imglistTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglistTree.ImageStream")));
			this.imglistTree.TransparentColor = System.Drawing.Color.Magenta;
			this.imglistTree.Images.SetKeyName(0, "InvSlot.png");
			this.imglistTree.Images.SetKeyName(1, "InvBag.png");
			this.imglistTree.Images.SetKeyName(2, "InvEmpty.png");
			this.imglistTree.Images.SetKeyName(3, "InvAny.png");
			this.imglistTree.Images.SetKeyName(4, "InvApparel.png");
			this.imglistTree.Images.SetKeyName(5, "InvCoin.png");
			this.imglistTree.Images.SetKeyName(6, "InvGem.png");
			this.imglistTree.Images.SetKeyName(7, "InvHerb.png");
			this.imglistTree.Images.SetKeyName(8, "InvNecklace.png");
			this.imglistTree.Images.SetKeyName(9, "InvRing.png");
			this.imglistTree.Images.SetKeyName(10, "InvWeapon.png");
			// 
			// buttSave
			// 
			this.buttSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttSave.Enabled = false;
			this.buttSave.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttSave.Location = new System.Drawing.Point(7, 790);
			this.buttSave.Name = "buttSave";
			this.buttSave.Size = new System.Drawing.Size(120, 32);
			this.buttSave.TabIndex = 21;
			this.buttSave.Text = "Save Changes";
			this.buttSave.UseVisualStyleBackColor = true;
			this.buttSave.Click += new System.EventHandler(this.buttSave_Click);
			// 
			// buttClose
			// 
			this.buttClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttClose.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttClose.Location = new System.Drawing.Point(133, 790);
			this.buttClose.Name = "buttClose";
			this.buttClose.Size = new System.Drawing.Size(120, 32);
			this.buttClose.TabIndex = 22;
			this.buttClose.Text = "Close";
			this.buttClose.UseVisualStyleBackColor = true;
			this.buttClose.Click += new System.EventHandler(this.buttClose_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("DejaVu Sans Mono", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(287, 736);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(489, 19);
			this.label10.TabIndex = 23;
			this.label10.Text = "TODO: PUT DETAILS AND INVENTORY ON SEPARATE TABS";
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1209, 789);
			this.tabControl.TabIndex = 24;
			// 
			// FormCharacterEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1209, 828);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.buttClose);
			this.Controls.Add(this.buttSave);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "FormCharacterEditor";
			this.Text = "Character Editor";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ImageList imglistTree;
		private System.Windows.Forms.Button buttSave;
		private System.Windows.Forms.Button buttClose;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TabControl tabControl;
	}
}