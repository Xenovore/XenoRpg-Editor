namespace XenoRPGEditor
{
	partial class UserCtrlCharacterEditInventory
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
			this.components = new System.ComponentModel.Container();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitContInventory = new System.Windows.Forms.SplitContainer();
			this.invContainerSlots = new XenoRPGEditor.InvContainerControl();
			this.treeviewInv = new System.Windows.Forms.TreeView();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.invContainerSelected = new XenoRPGEditor.InvContainerControl();
			this.menuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loadFromTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.miCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.miExpand = new System.Windows.Forms.ToolStripMenuItem();
			this.miExpandAll = new System.Windows.Forms.ToolStripMenuItem();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContInventory)).BeginInit();
			this.splitContInventory.Panel1.SuspendLayout();
			this.splitContInventory.Panel2.SuspendLayout();
			this.splitContInventory.SuspendLayout();
			this.menuTree.SuspendLayout();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label6.Location = new System.Drawing.Point(13, 12);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 18);
			this.label6.TabIndex = 21;
			this.label6.Text = "Inventory";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.splitContInventory);
			this.panel2.Location = new System.Drawing.Point(3, 31);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1083, 847);
			this.panel2.TabIndex = 20;
			// 
			// splitContInventory
			// 
			this.splitContInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContInventory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContInventory.Location = new System.Drawing.Point(0, 0);
			this.splitContInventory.Name = "splitContInventory";
			// 
			// splitContInventory.Panel1
			// 
			this.splitContInventory.Panel1.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.splitContInventory.Panel1.Controls.Add(this.invContainerSlots);
			this.splitContInventory.Panel1.Controls.Add(this.label7);
			this.splitContInventory.Panel1.Controls.Add(this.invContainerSelected);
			// 
			// splitContInventory.Panel2
			// 
			this.splitContInventory.Panel2.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.splitContInventory.Panel2.Controls.Add(this.treeviewInv);
			this.splitContInventory.Panel2.Controls.Add(this.label8);
			this.splitContInventory.Size = new System.Drawing.Size(1083, 847);
			this.splitContInventory.SplitterDistance = 538;
			this.splitContInventory.TabIndex = 0;
			// 
			// invContainerSlots
			// 
			this.invContainerSlots.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.invContainerSlots.BackgroundImageFilename = null;
			this.invContainerSlots.FrameImageFilename = "images/rpginvframe.png";
			this.invContainerSlots.GradientAngle = 55;
			this.invContainerSlots.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
			this.invContainerSlots.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(155)))));
			this.invContainerSlots.Location = new System.Drawing.Point(5, 21);
			this.invContainerSlots.Name = "invContainerSlots";
			this.invContainerSlots.Size = new System.Drawing.Size(522, 390);
			this.invContainerSlots.TabIndex = 25;
			this.invContainerSlots.Text = "invContainerControl2";
			this.invContainerSlots.UIScale = 0F;
			// 
			// treeviewInv
			// 
			this.treeviewInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeviewInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
			this.treeviewInv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeviewInv.LineColor = System.Drawing.Color.DarkGray;
			this.treeviewInv.Location = new System.Drawing.Point(5, 21);
			this.treeviewInv.Name = "treeviewInv";
			this.treeviewInv.Size = new System.Drawing.Size(513, 805);
			this.treeviewInv.TabIndex = 22;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(2, 2);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 16);
			this.label7.TabIndex = 27;
			this.label7.Text = "Equipped";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(2, 2);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(146, 16);
			this.label8.TabIndex = 25;
			this.label8.Text = "Selected Container";
			// 
			// invContainerSelected
			// 
			this.invContainerSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.invContainerSelected.BackgroundImageFilename = null;
			this.invContainerSelected.FrameImageFilename = "images/rpginvframe.png";
			this.invContainerSelected.GradientAngle = 55;
			this.invContainerSelected.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
			this.invContainerSelected.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(174)))), ((int)(((byte)(155)))));
			this.invContainerSelected.Location = new System.Drawing.Point(6, 547);
			this.invContainerSelected.Name = "invContainerSelected";
			this.invContainerSelected.Size = new System.Drawing.Size(522, 279);
			this.invContainerSelected.TabIndex = 24;
			this.invContainerSelected.Text = "invContainerControl1";
			this.invContainerSelected.UIScale = 0F;
			// 
			// menuTree
			// 
			this.menuTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromTestToolStripMenuItem,
            this.loadFromXMLToolStripMenuItem,
            this.saveToXMLToolStripMenuItem,
            this.toolStripMenuItem2,
            this.miCollapse,
            this.miExpand,
            this.miExpandAll});
			this.menuTree.Name = "menuTree";
			this.menuTree.Size = new System.Drawing.Size(159, 142);
			// 
			// loadFromTestToolStripMenuItem
			// 
			this.loadFromTestToolStripMenuItem.Name = "loadFromTestToolStripMenuItem";
			this.loadFromTestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.loadFromTestToolStripMenuItem.Text = "Load From Test";
			// 
			// loadFromXMLToolStripMenuItem
			// 
			this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
			this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.loadFromXMLToolStripMenuItem.Text = "Load From XML";
			// 
			// saveToXMLToolStripMenuItem
			// 
			this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
			this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.saveToXMLToolStripMenuItem.Text = "Save to XML";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(155, 6);
			// 
			// miCollapse
			// 
			this.miCollapse.Name = "miCollapse";
			this.miCollapse.Size = new System.Drawing.Size(158, 22);
			this.miCollapse.Text = "Collapse";
			// 
			// miExpand
			// 
			this.miExpand.Name = "miExpand";
			this.miExpand.Size = new System.Drawing.Size(158, 22);
			this.miExpand.Text = "Expand";
			// 
			// miExpandAll
			// 
			this.miExpandAll.Name = "miExpandAll";
			this.miExpandAll.Size = new System.Drawing.Size(158, 22);
			this.miExpandAll.Text = "Expand All";
			// 
			// UserCtrlCharacterEditInventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label6);
			this.Controls.Add(this.panel2);
			this.Name = "UserCtrlCharacterEditInventory";
			this.Size = new System.Drawing.Size(1089, 881);
			this.panel2.ResumeLayout(false);
			this.splitContInventory.Panel1.ResumeLayout(false);
			this.splitContInventory.Panel1.PerformLayout();
			this.splitContInventory.Panel2.ResumeLayout(false);
			this.splitContInventory.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContInventory)).EndInit();
			this.splitContInventory.ResumeLayout(false);
			this.menuTree.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContInventory;
		private InvContainerControl invContainerSlots;
		private System.Windows.Forms.TreeView treeviewInv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private InvContainerControl invContainerSelected;
		private System.Windows.Forms.ContextMenuStrip menuTree;
		private System.Windows.Forms.ToolStripMenuItem loadFromTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem miCollapse;
		private System.Windows.Forms.ToolStripMenuItem miExpand;
		private System.Windows.Forms.ToolStripMenuItem miExpandAll;
	}
}
