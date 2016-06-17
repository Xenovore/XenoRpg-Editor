namespace KevInvTest
{
	partial class FormCharEditor
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
			this.label1 = new System.Windows.Forms.Label();
			this.menuPopup = new System.Windows.Forms.ContextMenuStrip( this.components );
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tooltip = new System.Windows.Forms.ToolTip( this.components );
			this.menuPopup.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 16, 8 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 83, 13 );
			this.label1.TabIndex = 0;
			this.label1.Text = "Character Editor";
			// 
			// menuPopup
			// 
			this.menuPopup.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.newRowToolStripMenuItem} );
			this.menuPopup.Name = "menuPopup";
			this.menuPopup.Size = new System.Drawing.Size( 153, 70 );
			// 
			// deleteRowToolStripMenuItem
			// 
			this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
			this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.deleteRowToolStripMenuItem.Text = "Delete Row";
			// 
			// newRowToolStripMenuItem
			// 
			this.newRowToolStripMenuItem.Name = "newRowToolStripMenuItem";
			this.newRowToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.newRowToolStripMenuItem.Text = "New Row";
			// 
			// FormCharEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 290, 271 );
			this.Controls.Add( this.label1 );
			this.Name = "FormCharEditor";
			this.Text = "FormCharEditor";
			this.menuPopup.ResumeLayout( false );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenuStrip menuPopup;
		private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newRowToolStripMenuItem;
		private System.Windows.Forms.ToolTip tooltip;
	}
}