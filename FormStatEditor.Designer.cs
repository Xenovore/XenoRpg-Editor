namespace KevInvTest
{
	partial class FormStatEditor
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
			this.menuPopup = new System.Windows.Forms.ContextMenuStrip( this.components );
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tooltip = new System.Windows.Forms.ToolTip( this.components );
			this.label1 = new System.Windows.Forms.Label();
			this.menuPopup.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuPopup
			// 
			this.menuPopup.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
			this.deleteRowToolStripMenuItem,
			this.newRowToolStripMenuItem} );
			this.menuPopup.Name = "menuPopup";
			this.menuPopup.Size = new System.Drawing.Size( 134, 48 );
			// 
			// deleteRowToolStripMenuItem
			// 
			this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
			this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size( 133, 22 );
			this.deleteRowToolStripMenuItem.Text = "Delete Row";
			// 
			// newRowToolStripMenuItem
			// 
			this.newRowToolStripMenuItem.Name = "newRowToolStripMenuItem";
			this.newRowToolStripMenuItem.Size = new System.Drawing.Size( 133, 22 );
			this.newRowToolStripMenuItem.Text = "New Row";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font( "Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
			this.label1.Location = new System.Drawing.Point( 34, 51 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 394, 23 );
			this.label1.TabIndex = 1;
			this.label1.Text = "TODO: Build out; this is for editing individual stats.";
			// 
			// FormStatEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb( ( ( int )( ( ( byte )( 227 ) ) ) ), ( ( int )( ( ( byte )( 227 ) ) ) ), ( ( int )( ( ( byte )( 208 ) ) ) ) );
			this.ClientSize = new System.Drawing.Size( 653, 524 );
			this.Controls.Add( this.label1 );
			this.Font = new System.Drawing.Font( "Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 0 ) ) );
			this.Name = "FormStatEditor";
			this.Text = "Stat Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.FormStatEditor_FormClosing );
			this.menuPopup.ResumeLayout( false );
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolTip tooltip;
		private System.Windows.Forms.ContextMenuStrip menuPopup;
		private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newRowToolStripMenuItem;
		private System.Windows.Forms.Label label1;
	}
}