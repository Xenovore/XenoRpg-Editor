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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuTree = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.loadFromTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.miCollapse = new System.Windows.Forms.ToolStripMenuItem();
			this.miExpand = new System.Windows.Forms.ToolStripMenuItem();
			this.miExpandAll = new System.Windows.Forms.ToolStripMenuItem();
			this.imglistTree = new System.Windows.Forms.ImageList(this.components);
			this.splitContMain = new System.Windows.Forms.SplitContainer();
			this.label9 = new System.Windows.Forms.Label();
			this.splitContInfoStats = new System.Windows.Forms.SplitContainer();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.comboProfession = new System.Windows.Forms.ComboBox();
			this.comboRace = new System.Windows.Forms.ComboBox();
			this.textNameLast = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textXpPool = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textAge = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textNameFirst = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboStatTypeFilter = new System.Windows.Forms.ComboBox();
			this.gridCharacterStats = new System.Windows.Forms.DataGridView();
			this.lblCharAttribs = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitContInventory = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageEquipped = new System.Windows.Forms.TabPage();
			this.invContainerSlots = new XenoRPGEditor.InvContainerControl();
			this.tabPageTreeView = new System.Windows.Forms.TabPage();
			this.treeviewInv = new System.Windows.Forms.TreeView();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.invContainerSelected = new XenoRPGEditor.InvContainerControl();
			this.menuTree.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContMain)).BeginInit();
			this.splitContMain.Panel1.SuspendLayout();
			this.splitContMain.Panel2.SuspendLayout();
			this.splitContMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContInfoStats)).BeginInit();
			this.splitContInfoStats.Panel1.SuspendLayout();
			this.splitContInfoStats.Panel2.SuspendLayout();
			this.splitContInfoStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCharacterStats)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContInventory)).BeginInit();
			this.splitContInventory.Panel1.SuspendLayout();
			this.splitContInventory.Panel2.SuspendLayout();
			this.splitContInventory.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPageEquipped.SuspendLayout();
			this.tabPageTreeView.SuspendLayout();
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
			this.menuTree.Size = new System.Drawing.Size(159, 142);
			// 
			// loadFromTestToolStripMenuItem
			// 
			this.loadFromTestToolStripMenuItem.Name = "loadFromTestToolStripMenuItem";
			this.loadFromTestToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.loadFromTestToolStripMenuItem.Text = "Load From Test";
			this.loadFromTestToolStripMenuItem.Click += new System.EventHandler(this.loadFromTestToolStripMenuItem_Click);
			// 
			// loadFromXMLToolStripMenuItem
			// 
			this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
			this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.loadFromXMLToolStripMenuItem.Text = "Load From XML";
			this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.loadFromXMLToolStripMenuItem_Click);
			// 
			// saveToXMLToolStripMenuItem
			// 
			this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
			this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
			this.saveToXMLToolStripMenuItem.Text = "Save to XML";
			this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
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
			this.miCollapse.Click += new System.EventHandler(this.miCollapse_Click);
			// 
			// miExpand
			// 
			this.miExpand.Name = "miExpand";
			this.miExpand.Size = new System.Drawing.Size(158, 22);
			this.miExpand.Text = "Expand";
			this.miExpand.Click += new System.EventHandler(this.miExpand_Click);
			// 
			// miExpandAll
			// 
			this.miExpandAll.Name = "miExpandAll";
			this.miExpandAll.Size = new System.Drawing.Size(158, 22);
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
			// splitContMain
			// 
			this.splitContMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContMain.BackColor = System.Drawing.Color.Transparent;
			this.splitContMain.Location = new System.Drawing.Point(0, 0);
			this.splitContMain.Name = "splitContMain";
			// 
			// splitContMain.Panel1
			// 
			this.splitContMain.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.splitContMain.Panel1.Controls.Add(this.label9);
			this.splitContMain.Panel1.Controls.Add(this.splitContInfoStats);
			// 
			// splitContMain.Panel2
			// 
			this.splitContMain.Panel2.Controls.Add(this.label6);
			this.splitContMain.Panel2.Controls.Add(this.panel2);
			this.splitContMain.Size = new System.Drawing.Size(1216, 645);
			this.splitContMain.SplitterDistance = 436;
			this.splitContMain.TabIndex = 20;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label9.Location = new System.Drawing.Point(4, 6);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 18);
			this.label9.TabIndex = 20;
			this.label9.Text = "Character Details";
			// 
			// splitContInfoStats
			// 
			this.splitContInfoStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContInfoStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContInfoStats.Location = new System.Drawing.Point(7, 25);
			this.splitContInfoStats.Name = "splitContInfoStats";
			this.splitContInfoStats.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContInfoStats.Panel1
			// 
			this.splitContInfoStats.Panel1.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.splitContInfoStats.Panel1.Controls.Add(this.textTitle);
			this.splitContInfoStats.Panel1.Controls.Add(this.comboProfession);
			this.splitContInfoStats.Panel1.Controls.Add(this.comboRace);
			this.splitContInfoStats.Panel1.Controls.Add(this.textNameLast);
			this.splitContInfoStats.Panel1.Controls.Add(this.label5);
			this.splitContInfoStats.Panel1.Controls.Add(this.label2);
			this.splitContInfoStats.Panel1.Controls.Add(this.textXpPool);
			this.splitContInfoStats.Panel1.Controls.Add(this.label4);
			this.splitContInfoStats.Panel1.Controls.Add(this.textAge);
			this.splitContInfoStats.Panel1.Controls.Add(this.label3);
			this.splitContInfoStats.Panel1.Controls.Add(this.textNameFirst);
			this.splitContInfoStats.Panel1.Controls.Add(this.label1);
			// 
			// splitContInfoStats.Panel2
			// 
			this.splitContInfoStats.Panel2.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.splitContInfoStats.Panel2.Controls.Add(this.comboStatTypeFilter);
			this.splitContInfoStats.Panel2.Controls.Add(this.gridCharacterStats);
			this.splitContInfoStats.Panel2.Controls.Add(this.lblCharAttribs);
			this.splitContInfoStats.Size = new System.Drawing.Size(429, 615);
			this.splitContInfoStats.SplitterDistance = 176;
			this.splitContInfoStats.TabIndex = 19;
			// 
			// textTitle
			// 
			this.textTitle.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textTitle.Location = new System.Drawing.Point(318, 7);
			this.textTitle.Name = "textTitle";
			this.textTitle.Size = new System.Drawing.Size(100, 23);
			this.textTitle.TabIndex = 17;
			// 
			// comboProfession
			// 
			this.comboProfession.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboProfession.FormattingEnabled = true;
			this.comboProfession.Location = new System.Drawing.Point(298, 35);
			this.comboProfession.Name = "comboProfession";
			this.comboProfession.Size = new System.Drawing.Size(120, 24);
			this.comboProfession.TabIndex = 16;
			// 
			// comboRace
			// 
			this.comboRace.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboRace.FormattingEnabled = true;
			this.comboRace.Location = new System.Drawing.Point(66, 35);
			this.comboRace.Name = "comboRace";
			this.comboRace.Size = new System.Drawing.Size(120, 24);
			this.comboRace.TabIndex = 15;
			// 
			// textNameLast
			// 
			this.textNameLast.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNameLast.Location = new System.Drawing.Point(192, 7);
			this.textNameLast.Name = "textNameLast";
			this.textNameLast.Size = new System.Drawing.Size(120, 23);
			this.textNameLast.TabIndex = 14;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(211, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 16);
			this.label5.TabIndex = 12;
			this.label5.Text = "Profession:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Race:";
			// 
			// textXpPool
			// 
			this.textXpPool.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textXpPool.Location = new System.Drawing.Point(66, 111);
			this.textXpPool.Name = "textXpPool";
			this.textXpPool.Size = new System.Drawing.Size(106, 23);
			this.textXpPool.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(6, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 16);
			this.label4.TabIndex = 5;
			this.label4.Text = "XP Pool:";
			// 
			// textAge
			// 
			this.textAge.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textAge.Location = new System.Drawing.Point(66, 64);
			this.textAge.Name = "textAge";
			this.textAge.Size = new System.Drawing.Size(34, 23);
			this.textAge.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 66);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 16);
			this.label3.TabIndex = 6;
			this.label3.Text = "Age:";
			// 
			// textNameFirst
			// 
			this.textNameFirst.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNameFirst.Location = new System.Drawing.Point(66, 7);
			this.textNameFirst.Name = "textNameFirst";
			this.textNameFirst.Size = new System.Drawing.Size(120, 23);
			this.textNameFirst.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 16);
			this.label1.TabIndex = 7;
			this.label1.Text = "Name:";
			// 
			// comboStatTypeFilter
			// 
			this.comboStatTypeFilter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboStatTypeFilter.FormattingEnabled = true;
			this.comboStatTypeFilter.Location = new System.Drawing.Point(54, 3);
			this.comboStatTypeFilter.Name = "comboStatTypeFilter";
			this.comboStatTypeFilter.Size = new System.Drawing.Size(140, 22);
			this.comboStatTypeFilter.TabIndex = 21;
			this.comboStatTypeFilter.SelectedIndexChanged += new System.EventHandler(this.comboStatTypeFilter_SelectedIndexChanged);
			// 
			// gridCharacterStats
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
			this.gridCharacterStats.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridCharacterStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridCharacterStats.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCharacterStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridCharacterStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCharacterStats.Location = new System.Drawing.Point(6, 31);
			this.gridCharacterStats.Name = "gridCharacterStats";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCharacterStats.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridCharacterStats.RowHeadersVisible = false;
			this.gridCharacterStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.gridCharacterStats.Size = new System.Drawing.Size(415, 398);
			this.gridCharacterStats.TabIndex = 19;
			// 
			// lblCharAttribs
			// 
			this.lblCharAttribs.AutoSize = true;
			this.lblCharAttribs.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCharAttribs.Location = new System.Drawing.Point(3, 6);
			this.lblCharAttribs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCharAttribs.Name = "lblCharAttribs";
			this.lblCharAttribs.Size = new System.Drawing.Size(46, 16);
			this.lblCharAttribs.TabIndex = 20;
			this.lblCharAttribs.Text = "Stats";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label6.Location = new System.Drawing.Point(4, 6);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(90, 18);
			this.label6.TabIndex = 19;
			this.label6.Text = "Inventory";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.splitContInventory);
			this.panel2.Location = new System.Drawing.Point(0, 25);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(770, 615);
			this.panel2.TabIndex = 0;
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
			this.splitContInventory.Panel1.Controls.Add(this.tabControl1);
			this.splitContInventory.Panel1.Controls.Add(this.label7);
			// 
			// splitContInventory.Panel2
			// 
			this.splitContInventory.Panel2.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.splitContInventory.Panel2.Controls.Add(this.label8);
			this.splitContInventory.Panel2.Controls.Add(this.invContainerSelected);
			this.splitContInventory.Size = new System.Drawing.Size(770, 615);
			this.splitContInventory.SplitterDistance = 383;
			this.splitContInventory.TabIndex = 0;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPageEquipped);
			this.tabControl1.Controls.Add(this.tabPageTreeView);
			this.tabControl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(3, 22);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(375, 589);
			this.tabControl1.TabIndex = 28;
			// 
			// tabPageEquipped
			// 
			this.tabPageEquipped.Controls.Add(this.invContainerSlots);
			this.tabPageEquipped.Location = new System.Drawing.Point(4, 25);
			this.tabPageEquipped.Name = "tabPageEquipped";
			this.tabPageEquipped.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageEquipped.Size = new System.Drawing.Size(367, 560);
			this.tabPageEquipped.TabIndex = 0;
			this.tabPageEquipped.Text = "Slots";
			this.tabPageEquipped.UseVisualStyleBackColor = true;
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
			this.invContainerSlots.Location = new System.Drawing.Point(0, 0);
			this.invContainerSlots.Name = "invContainerSlots";
			this.invContainerSlots.Size = new System.Drawing.Size(367, 558);
			this.invContainerSlots.TabIndex = 25;
			this.invContainerSlots.Text = "invContainerControl2";
			this.invContainerSlots.UIScale = 0F;
			// 
			// tabPageTreeView
			// 
			this.tabPageTreeView.Controls.Add(this.treeviewInv);
			this.tabPageTreeView.Location = new System.Drawing.Point(4, 25);
			this.tabPageTreeView.Name = "tabPageTreeView";
			this.tabPageTreeView.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTreeView.Size = new System.Drawing.Size(367, 560);
			this.tabPageTreeView.TabIndex = 1;
			this.tabPageTreeView.Text = "Tree View";
			this.tabPageTreeView.UseVisualStyleBackColor = true;
			// 
			// treeviewInv
			// 
			this.treeviewInv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeviewInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(255)))));
			this.treeviewInv.ContextMenuStrip = this.menuTree;
			this.treeviewInv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeviewInv.LineColor = System.Drawing.Color.DarkGray;
			this.treeviewInv.Location = new System.Drawing.Point(8, 6);
			this.treeviewInv.Name = "treeviewInv";
			this.treeviewInv.Size = new System.Drawing.Size(355, 554);
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
			this.invContainerSelected.Location = new System.Drawing.Point(6, 20);
			this.invContainerSelected.Name = "invContainerSelected";
			this.invContainerSelected.Size = new System.Drawing.Size(367, 585);
			this.invContainerSelected.TabIndex = 24;
			this.invContainerSelected.Text = "invContainerControl1";
			this.invContainerSelected.UIScale = 0F;
			// 
			// FormEditCharacter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(1216, 646);
			this.Controls.Add(this.splitContMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "FormEditCharacter";
			this.Text = "Character Details";
			this.menuTree.ResumeLayout(false);
			this.splitContMain.Panel1.ResumeLayout(false);
			this.splitContMain.Panel1.PerformLayout();
			this.splitContMain.Panel2.ResumeLayout(false);
			this.splitContMain.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContMain)).EndInit();
			this.splitContMain.ResumeLayout(false);
			this.splitContInfoStats.Panel1.ResumeLayout(false);
			this.splitContInfoStats.Panel1.PerformLayout();
			this.splitContInfoStats.Panel2.ResumeLayout(false);
			this.splitContInfoStats.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContInfoStats)).EndInit();
			this.splitContInfoStats.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCharacterStats)).EndInit();
			this.panel2.ResumeLayout(false);
			this.splitContInventory.Panel1.ResumeLayout(false);
			this.splitContInventory.Panel1.PerformLayout();
			this.splitContInventory.Panel2.ResumeLayout(false);
			this.splitContInventory.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContInventory)).EndInit();
			this.splitContInventory.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPageEquipped.ResumeLayout(false);
			this.tabPageTreeView.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContMain;
		private System.Windows.Forms.ImageList imglistTree;
		private System.Windows.Forms.ContextMenuStrip menuTree;
		private System.Windows.Forms.ToolStripMenuItem miCollapse;
		private System.Windows.Forms.ToolStripMenuItem miExpand;
		private System.Windows.Forms.ToolStripMenuItem miExpandAll;
		private System.Windows.Forms.ToolStripMenuItem loadFromTestToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContInventory;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageEquipped;
		private System.Windows.Forms.TabPage tabPageTreeView;
		private System.Windows.Forms.TreeView treeviewInv;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private InvContainerControl invContainerSelected;
		private InvContainerControl invContainerSlots;
		private System.Windows.Forms.SplitContainer splitContInfoStats;
		private System.Windows.Forms.TextBox textNameLast;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textXpPool;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textAge;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textNameFirst;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView gridCharacterStats;
		private System.Windows.Forms.Label lblCharAttribs;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.ComboBox comboProfession;
		private System.Windows.Forms.ComboBox comboRace;
		private System.Windows.Forms.ComboBox comboStatTypeFilter;
	}
}