namespace XenoRPGEditor
{
	partial class UserCtrlStatsEditor
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tooltip = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.buttSaveList = new System.Windows.Forms.Button();
			this.gridview = new System.Windows.Forms.DataGridView();
			this.lblFilterBy = new System.Windows.Forms.Label();
			this.lbStatFilterTypes = new System.Windows.Forms.ListBox();
			this.popupMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
			this.SuspendLayout();
			// 
			// popupMenu
			// 
			this.popupMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem});
			this.popupMenu.Name = "contextMenuStrip1";
			this.popupMenu.Size = new System.Drawing.Size(134, 48);
			// 
			// addRowToolStripMenuItem
			// 
			this.addRowToolStripMenuItem.Name = "addRowToolStripMenuItem";
			this.addRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.addRowToolStripMenuItem.Text = "Insert Row";
			// 
			// deleteRowToolStripMenuItem
			// 
			this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
			this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.deleteRowToolStripMenuItem.Text = "Delete Row";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.CausesValidation = false;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 17);
			this.label1.TabIndex = 14;
			this.label1.Text = "Stat Editor";
			// 
			// buttSaveList
			// 
			this.buttSaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttSaveList.Enabled = false;
			this.buttSaveList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttSaveList.Location = new System.Drawing.Point(114, 4);
			this.buttSaveList.Name = "buttSaveList";
			this.buttSaveList.Size = new System.Drawing.Size(100, 23);
			this.buttSaveList.TabIndex = 9;
			this.buttSaveList.Text = "Save Changes";
			this.buttSaveList.UseVisualStyleBackColor = true;
			this.buttSaveList.Click += new System.EventHandler(this.buttUpdateAttribList_Click);
			// 
			// gridview
			// 
			this.gridview.AllowUserToOrderColumns = true;
			this.gridview.AllowUserToResizeColumns = false;
			this.gridview.AllowUserToResizeRows = false;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
			this.gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridview.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.gridview.EnableHeadersVisualStyles = false;
			this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gridview.Location = new System.Drawing.Point(0, 34);
			this.gridview.Margin = new System.Windows.Forms.Padding(4);
			this.gridview.MultiSelect = false;
			this.gridview.Name = "gridview";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.gridview.RowHeadersWidth = 24;
			this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridview.Size = new System.Drawing.Size(640, 570);
			this.gridview.TabIndex = 16;
			// 
			// lblFilterBy
			// 
			this.lblFilterBy.AutoSize = true;
			this.lblFilterBy.Location = new System.Drawing.Point(8, 614);
			this.lblFilterBy.Name = "lblFilterBy";
			this.lblFilterBy.Size = new System.Drawing.Size(54, 14);
			this.lblFilterBy.TabIndex = 17;
			this.lblFilterBy.Text = "Filter By:";
			// 
			// lbStatFilterTypes
			// 
			this.lbStatFilterTypes.FormattingEnabled = true;
			this.lbStatFilterTypes.ItemHeight = 14;
			this.lbStatFilterTypes.Location = new System.Drawing.Point(54, 614);
			this.lbStatFilterTypes.Name = "lbStatFilterTypes";
			this.lbStatFilterTypes.Size = new System.Drawing.Size(123, 4);
			this.lbStatFilterTypes.TabIndex = 18;
			// 
			// UserCtrlStatsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.lbStatFilterTypes);
			this.Controls.Add(this.lblFilterBy);
			this.Controls.Add(this.gridview);
			this.Controls.Add(this.buttSaveList);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UserCtrlStatsEditor";
			this.Size = new System.Drawing.Size(658, 658);
			this.Load += new System.EventHandler(this.Editor_Load);
			this.Leave += new System.EventHandler(this.UserCtrlStatEditor_Leave);
			this.popupMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip  popupMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteRowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addRowToolStripMenuItem;
		private System.Windows.Forms.ToolTip tooltip;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttSaveList;
		private System.Windows.Forms.DataGridView gridview;
		private System.Windows.Forms.Label lblFilterBy;
		private System.Windows.Forms.ListBox lbStatFilterTypes;

	}
}
