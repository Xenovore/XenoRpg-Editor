namespace XenoRPGEditor
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuitmExit = new System.Windows.Forms.ToolStripMenuItem();
			this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuitemStatEditor = new System.Windows.Forms.ToolStripMenuItem();
			this.charDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabCtrlMain = new System.Windows.Forms.TabControl();
			this.menuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuMain
			// 
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dBToolStripMenuItem,
            this.charDetailsToolStripMenuItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Size = new System.Drawing.Size(1201, 24);
			this.menuMain.TabIndex = 0;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDatabaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuitmExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadDatabaseToolStripMenuItem
			// 
			this.loadDatabaseToolStripMenuItem.Name = "loadDatabaseToolStripMenuItem";
			this.loadDatabaseToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.loadDatabaseToolStripMenuItem.Text = "Open...";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 6);
			// 
			// mnuitmExit
			// 
			this.mnuitmExit.Name = "mnuitmExit";
			this.mnuitmExit.Size = new System.Drawing.Size(112, 22);
			this.mnuitmExit.Text = "Exit";
			this.mnuitmExit.Click += new System.EventHandler(this.mnuitmExit_Click);
			// 
			// dBToolStripMenuItem
			// 
			this.dBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemStatEditor});
			this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
			this.dBToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.dBToolStripMenuItem.Text = "Edit";
			// 
			// menuitemStatEditor
			// 
			this.menuitemStatEditor.Name = "menuitemStatEditor";
			this.menuitemStatEditor.Size = new System.Drawing.Size(192, 22);
			this.menuitemStatEditor.Text = "Item Type Editor (Test)";
			this.menuitemStatEditor.Click += new System.EventHandler(this.menuitemStatEditor_Click);
			// 
			// charDetailsToolStripMenuItem
			// 
			this.charDetailsToolStripMenuItem.Name = "charDetailsToolStripMenuItem";
			this.charDetailsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.charDetailsToolStripMenuItem.Text = "CharDetails";
			this.charDetailsToolStripMenuItem.Click += new System.EventHandler(this.charDetailsToolStripMenuItem_Click);
			// 
			// tabCtrlMain
			// 
			this.tabCtrlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabCtrlMain.Location = new System.Drawing.Point(0, 27);
			this.tabCtrlMain.Name = "tabCtrlMain";
			this.tabCtrlMain.SelectedIndex = 0;
			this.tabCtrlMain.Size = new System.Drawing.Size(1199, 931);
			this.tabCtrlMain.TabIndex = 20;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(208)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(1201, 960);
			this.Controls.Add(this.tabCtrlMain);
			this.Controls.Add(this.menuMain);
			this.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuMain;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 520);
			this.Name = "FormMain";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "XenoRPG Editor";
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuitmExit;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuitemStatEditor;
		private System.Windows.Forms.ToolStripMenuItem loadDatabaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem charDetailsToolStripMenuItem;
		private System.Windows.Forms.TabControl tabCtrlMain;
	}
}

