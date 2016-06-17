namespace XenoRPGEditor
{
	partial class FormEditCharacter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditCharacter));
			this.menuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loadFromTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.miCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.miExpand = new System.Windows.Forms.ToolStripMenuItem();
			this.miExpandAll = new System.Windows.Forms.ToolStripMenuItem();
			this.imglistTree = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.gridAttributes = new System.Windows.Forms.DataGridView();
			this.lblCharAttribs = new System.Windows.Forms.Label();
			this.gridSkills = new System.Windows.Forms.DataGridView();
			this.lblCharSkills = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.invContainerControl1 = new XenoRPGEditor.InvContainerControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lblInvTree = new System.Windows.Forms.Label();
			this.treeviewInv = new System.Windows.Forms.TreeView();
			this.menuTree.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSkills)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
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
			this.menuTree.Size = new System.Drawing.Size(170, 142);
			// 
			// loadFromTestToolStripMenuItem
			// 
			this.loadFromTestToolStripMenuItem.Name = "loadFromTestToolStripMenuItem";
			this.loadFromTestToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.loadFromTestToolStripMenuItem.Text = "Load From Test";
			this.loadFromTestToolStripMenuItem.Click += new System.EventHandler(this.loadFromTestToolStripMenuItem_Click);
			// 
			// loadFromXMLToolStripMenuItem
			// 
			this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
			this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.loadFromXMLToolStripMenuItem.Text = "Load From XML";
			this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.loadFromXMLToolStripMenuItem_Click);
			// 
			// saveToXMLToolStripMenuItem
			// 
			this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
			this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
			this.saveToXMLToolStripMenuItem.Text = "Save to XML";
			this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(166, 6);
			// 
			// miCollapse
			// 
			this.miCollapse.Name = "miCollapse";
			this.miCollapse.Size = new System.Drawing.Size(169, 22);
			this.miCollapse.Text = "Collapse";
			this.miCollapse.Click += new System.EventHandler(this.miCollapse_Click);
			// 
			// miExpand
			// 
			this.miExpand.Name = "miExpand";
			this.miExpand.Size = new System.Drawing.Size(169, 22);
			this.miExpand.Text = "Expand";
			this.miExpand.Click += new System.EventHandler(this.miExpand_Click);
			// 
			// miExpandAll
			// 
			this.miExpandAll.Name = "miExpandAll";
			this.miExpandAll.Size = new System.Drawing.Size(169, 22);
			this.miExpandAll.Text = "Expand All";
			this.miExpandAll.Click += new System.EventHandler(this.miExpandAll_Click);
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
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.textBox4);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.textBox3);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(640, 57);
			this.panel1.TabIndex = 21;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(244, 6);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(102, 20);
			this.textBox2.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(179, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Profession:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(175, 32);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(34, 20);
			this.textBox4.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(118, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "XP Total:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(53, 32);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(34, 20);
			this.textBox3.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 35);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Age:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(53, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(102, 20);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer2.Location = new System.Drawing.Point(0, 63);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer2.Size = new System.Drawing.Size(640, 401);
			this.splitContainer2.SplitterDistance = 340;
			this.splitContainer2.TabIndex = 20;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(8, 8);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gridAttributes);
			this.splitContainer1.Panel1.Controls.Add(this.lblCharAttribs);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gridSkills);
			this.splitContainer1.Panel2.Controls.Add(this.lblCharSkills);
			this.splitContainer1.Size = new System.Drawing.Size(328, 387);
			this.splitContainer1.SplitterDistance = 220;
			this.splitContainer1.TabIndex = 18;
			// 
			// gridAttributes
			// 
			this.gridAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridAttributes.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridAttributes.Location = new System.Drawing.Point(0, 16);
			this.gridAttributes.Name = "gridAttributes";
			this.gridAttributes.RowHeadersVisible = false;
			this.gridAttributes.Size = new System.Drawing.Size(328, 202);
			this.gridAttributes.TabIndex = 15;
			// 
			// lblCharAttribs
			// 
			this.lblCharAttribs.AutoSize = true;
			this.lblCharAttribs.Location = new System.Drawing.Point(0, 0);
			this.lblCharAttribs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCharAttribs.Name = "lblCharAttribs";
			this.lblCharAttribs.Size = new System.Drawing.Size(51, 13);
			this.lblCharAttribs.TabIndex = 16;
			this.lblCharAttribs.Text = "Attributes";
			// 
			// gridSkills
			// 
			this.gridSkills.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridSkills.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridSkills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridSkills.Location = new System.Drawing.Point(0, 16);
			this.gridSkills.Name = "gridSkills";
			this.gridSkills.RowHeadersVisible = false;
			this.gridSkills.Size = new System.Drawing.Size(328, 145);
			this.gridSkills.TabIndex = 15;
			// 
			// lblCharSkills
			// 
			this.lblCharSkills.AutoSize = true;
			this.lblCharSkills.Location = new System.Drawing.Point(0, 0);
			this.lblCharSkills.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCharSkills.Name = "lblCharSkills";
			this.lblCharSkills.Size = new System.Drawing.Size(31, 13);
			this.lblCharSkills.TabIndex = 16;
			this.lblCharSkills.Text = "Skills";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(3, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(258, 250);
			this.tabControl1.TabIndex = 23;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.invContainerControl1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(250, 224);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// invContainerControl1
			// 
			this.invContainerControl1.Location = new System.Drawing.Point(21, 43);
			this.invContainerControl1.Name = "invContainerControl1";
			this.invContainerControl1.Size = new System.Drawing.Size(204, 15);
			this.invContainerControl1.TabIndex = 23;
			this.invContainerControl1.Text = "invContainerControl1";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lblInvTree);
			this.tabPage2.Controls.Add(this.treeviewInv);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(250, 224);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lblInvTree
			// 
			this.lblInvTree.AutoSize = true;
			this.lblInvTree.Location = new System.Drawing.Point(18, 40);
			this.lblInvTree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInvTree.Name = "lblInvTree";
			this.lblInvTree.Size = new System.Drawing.Size(76, 13);
			this.lblInvTree.TabIndex = 23;
			this.lblInvTree.Text = "Inventory Tree";
			// 
			// treeviewInv
			// 
			this.treeviewInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeviewInv.BackColor = System.Drawing.SystemColors.Window;
			this.treeviewInv.ContextMenuStrip = this.menuTree;
			this.treeviewInv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeviewInv.LineColor = System.Drawing.Color.DarkGray;
			this.treeviewInv.Location = new System.Drawing.Point(18, 56);
			this.treeviewInv.Name = "treeviewInv";
			this.treeviewInv.Size = new System.Drawing.Size(280, 70);
			this.treeviewInv.TabIndex = 22;
			// 
			// FormEditCharacter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(640, 464);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitContainer2);
			this.Name = "FormEditCharacter";
			this.Text = "Character Details";
			this.menuTree.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridAttributes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridSkills)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView gridAttributes;
		private System.Windows.Forms.Label lblCharAttribs;
		private System.Windows.Forms.DataGridView gridSkills;
		private System.Windows.Forms.Label lblCharSkills;
		private System.Windows.Forms.ImageList imglistTree;
		private System.Windows.Forms.ContextMenuStrip menuTree;
		private System.Windows.Forms.ToolStripMenuItem miCollapse;
		private System.Windows.Forms.ToolStripMenuItem miExpand;
		private System.Windows.Forms.ToolStripMenuItem miExpandAll;
		private System.Windows.Forms.ToolStripMenuItem loadFromTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private InvContainerControl invContainerControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label lblInvTree;
		private System.Windows.Forms.TreeView treeviewInv;

	}
}