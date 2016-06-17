namespace XenoRPGEditor
{
	partial class UserCtrlStatEditor
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.buttUpdateAttribList = new System.Windows.Forms.Button();
			this.gridAttribMasterList = new System.Windows.Forms.DataGridView();
			this.lblMasterAttribList = new System.Windows.Forms.Label();
			this.buttUpdateSkillList = new System.Windows.Forms.Button();
			this.gridSkillMasterList = new System.Windows.Forms.DataGridView();
			this.lblMasterSkillList = new System.Windows.Forms.Label();
			this.popupMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tooltip = new System.Windows.Forms.ToolTip( this.components );
			( (System.ComponentModel.ISupportInitialize)( this.splitContainer1 ) ).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			( (System.ComponentModel.ISupportInitialize)( this.gridAttribMasterList ) ).BeginInit();
			( (System.ComponentModel.ISupportInitialize)( this.gridSkillMasterList ) ).BeginInit();
			this.popupMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Location = new System.Drawing.Point( 0, 0 );
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add( this.buttUpdateAttribList );
			this.splitContainer1.Panel1.Controls.Add( this.gridAttribMasterList );
			this.splitContainer1.Panel1.Controls.Add( this.lblMasterAttribList );
			this.splitContainer1.Panel1.Font = new System.Drawing.Font( "Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.splitContainer1.Panel1MinSize = 100;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add( this.buttUpdateSkillList );
			this.splitContainer1.Panel2.Controls.Add( this.gridSkillMasterList );
			this.splitContainer1.Panel2.Controls.Add( this.lblMasterSkillList );
			this.splitContainer1.Panel2.Font = new System.Drawing.Font( "Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.splitContainer1.Panel2MinSize = 100;
			this.splitContainer1.Size = new System.Drawing.Size( 658, 658 );
			this.splitContainer1.SplitterDistance = 265;
			this.splitContainer1.TabIndex = 18;
			// 
			// buttUpdateAttribList
			// 
			this.buttUpdateAttribList.Enabled = false;
			this.buttUpdateAttribList.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.buttUpdateAttribList.Location = new System.Drawing.Point( 120, 2 );
			this.buttUpdateAttribList.Name = "buttUpdateAttribList";
			this.buttUpdateAttribList.Size = new System.Drawing.Size( 88, 23 );
			this.buttUpdateAttribList.TabIndex = 15;
			this.buttUpdateAttribList.Text = "Save Changes";
			this.buttUpdateAttribList.UseVisualStyleBackColor = true;
			this.buttUpdateAttribList.Click += new System.EventHandler( this.buttUpdateAttribList_Click );
			// 
			// gridAttribMasterList
			// 
			this.gridAttribMasterList.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 235 ) ) ) ), ( (int)( ( (byte)( 235 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ) );
			this.gridAttribMasterList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridAttribMasterList.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.gridAttribMasterList.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridAttribMasterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ) );
			dataGridViewCellStyle2.Font = new System.Drawing.Font( "Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridAttribMasterList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridAttribMasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridAttribMasterList.EnableHeadersVisualStyles = false;
			this.gridAttribMasterList.GridColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ) );
			this.gridAttribMasterList.Location = new System.Drawing.Point( 0, 32 );
			this.gridAttribMasterList.MultiSelect = false;
			this.gridAttribMasterList.Name = "gridAttribMasterList";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ) );
			dataGridViewCellStyle3.Font = new System.Drawing.Font( "Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridAttribMasterList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridAttribMasterList.RowHeadersWidth = 24;
			this.gridAttribMasterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridAttribMasterList.Size = new System.Drawing.Size( 654, 229 );
			this.gridAttribMasterList.TabIndex = 13;
			this.gridAttribMasterList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler( this.gridAttribMasterList_CellEndEdit );
			this.gridAttribMasterList.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler( this.gridAttribsMasterList_UserDeletedRow );
			this.gridAttribMasterList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler( this.gridAttribsMasterList_UserDeletingRow );
			// 
			// lblMasterAttribList
			// 
			this.lblMasterAttribList.AutoSize = true;
			this.lblMasterAttribList.BackColor = System.Drawing.Color.Transparent;
			this.lblMasterAttribList.Font = new System.Drawing.Font( "Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.lblMasterAttribList.Location = new System.Drawing.Point( 0, 8 );
			this.lblMasterAttribList.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.lblMasterAttribList.Name = "lblMasterAttribList";
			this.lblMasterAttribList.Size = new System.Drawing.Size( 119, 15 );
			this.lblMasterAttribList.TabIndex = 14;
			this.lblMasterAttribList.Text = "Master Attribute List";
			// 
			// buttUpdateSkillList
			// 
			this.buttUpdateSkillList.Enabled = false;
			this.buttUpdateSkillList.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.buttUpdateSkillList.Location = new System.Drawing.Point( 120, 2 );
			this.buttUpdateSkillList.Name = "buttUpdateSkillList";
			this.buttUpdateSkillList.Size = new System.Drawing.Size( 88, 23 );
			this.buttUpdateSkillList.TabIndex = 19;
			this.buttUpdateSkillList.Text = "Save Changes";
			this.buttUpdateSkillList.UseVisualStyleBackColor = true;
			this.buttUpdateSkillList.Click += new System.EventHandler( this.buttUpdateSkillList_Click );
			// 
			// gridSkillMasterList
			// 
			this.gridSkillMasterList.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 235 ) ) ) ), ( (int)( ( (byte)( 235 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ) );
			this.gridSkillMasterList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.gridSkillMasterList.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.gridSkillMasterList.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridSkillMasterList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ) );
			dataGridViewCellStyle5.Font = new System.Drawing.Font( "Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridSkillMasterList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridSkillMasterList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridSkillMasterList.EnableHeadersVisualStyles = false;
			this.gridSkillMasterList.GridColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ), ( (int)( ( (byte)( 224 ) ) ) ) );
			this.gridSkillMasterList.Location = new System.Drawing.Point( 0, 32 );
			this.gridSkillMasterList.Name = "gridSkillMasterList";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 192 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ) );
			dataGridViewCellStyle6.Font = new System.Drawing.Font( "Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridSkillMasterList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.gridSkillMasterList.RowHeadersWidth = 24;
			this.gridSkillMasterList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridSkillMasterList.Size = new System.Drawing.Size( 654, 353 );
			this.gridSkillMasterList.TabIndex = 17;
			this.gridSkillMasterList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler( this.gridSkillMasterList_CellEndEdit );
			this.gridSkillMasterList.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler( this.gridSkillsMasterList_UserDeletedRow );
			this.gridSkillMasterList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler( this.gridSkillsMasterList_UserDeletingRow );
			// 
			// lblMasterSkillList
			// 
			this.lblMasterSkillList.AutoSize = true;
			this.lblMasterSkillList.BackColor = System.Drawing.Color.Transparent;
			this.lblMasterSkillList.Font = new System.Drawing.Font( "Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.lblMasterSkillList.Location = new System.Drawing.Point( 0, 8 );
			this.lblMasterSkillList.Margin = new System.Windows.Forms.Padding( 2, 0, 2, 0 );
			this.lblMasterSkillList.Name = "lblMasterSkillList";
			this.lblMasterSkillList.Size = new System.Drawing.Size( 95, 15 );
			this.lblMasterSkillList.TabIndex = 18;
			this.lblMasterSkillList.Text = "Master Skill List";
			// 
			// popupMenu
			// 
			this.popupMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.deleteRowToolStripMenuItem,
            this.addRowToolStripMenuItem} );
			this.popupMenu.Name = "contextMenuStrip1";
			this.popupMenu.Size = new System.Drawing.Size( 142, 48 );
			// 
			// deleteRowToolStripMenuItem
			// 
			this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
			this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.deleteRowToolStripMenuItem.Text = "Delete Row";
			// 
			// addRowToolStripMenuItem
			// 
			this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
			this.addRowToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.addRowToolStripMenuItem.Text = "Add Row";
			// 
			// UserCtrlStatEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.Controls.Add( this.splitContainer1 );
			this.Name = "UserCtrlStatEditor";
			this.Size = new System.Drawing.Size( 658, 658 );
			this.Load += new System.EventHandler( this.UserCtrlStatEditor_Load );
			this.Leave += new System.EventHandler( this.UserCtrlStatEditor_Leave );
			this.splitContainer1.Panel1.ResumeLayout( false );
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout( false );
			this.splitContainer1.Panel2.PerformLayout();
			( (System.ComponentModel.ISupportInitialize)( this.splitContainer1 ) ).EndInit();
			this.splitContainer1.ResumeLayout( false );
			( (System.ComponentModel.ISupportInitialize)( this.gridAttribMasterList ) ).EndInit();
			( (System.ComponentModel.ISupportInitialize)( this.gridSkillMasterList ) ).EndInit();
			this.popupMenu.ResumeLayout( false );
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.SplitContainer    splitContainer1;
		private System.Windows.Forms.Button            buttUpdateAttribList;
		private System.Windows.Forms.DataGridView      gridAttribMasterList;
		private System.Windows.Forms.Label             lblMasterAttribList;
		private System.Windows.Forms.Button            buttUpdateSkillList;
		private System.Windows.Forms.DataGridView      gridSkillMasterList;
		private System.Windows.Forms.Label             lblMasterSkillList;
		private System.Windows.Forms.ContextMenuStrip  popupMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
		private System.Windows.Forms.ToolTip tooltip;

	}
}
