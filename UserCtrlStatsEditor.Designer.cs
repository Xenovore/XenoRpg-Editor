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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.popupMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tooltip = new System.Windows.Forms.ToolTip(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.buttSaveList = new System.Windows.Forms.Button();
			this.gvStatsAll = new System.Windows.Forms.DataGridView();
			this.comboFilterBy = new System.Windows.Forms.ComboBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.popupMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvStatsAll)).BeginInit();
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
			this.buttSaveList.Location = new System.Drawing.Point(117, 4);
			this.buttSaveList.Name = "buttSaveList";
			this.buttSaveList.Size = new System.Drawing.Size(100, 23);
			this.buttSaveList.TabIndex = 9;
			this.buttSaveList.Text = "Save Changes";
			this.buttSaveList.UseVisualStyleBackColor = true;
			this.buttSaveList.Click += new System.EventHandler(this.buttUpdateAttribList_Click);
			// 
			// gvStatsAll
			// 
			this.gvStatsAll.AllowUserToOrderColumns = true;
			this.gvStatsAll.AllowUserToResizeColumns = false;
			this.gvStatsAll.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
			this.gvStatsAll.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gvStatsAll.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gvStatsAll.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gvStatsAll.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvStatsAll.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gvStatsAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gvStatsAll.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.gvStatsAll.EnableHeadersVisualStyles = false;
			this.gvStatsAll.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gvStatsAll.Location = new System.Drawing.Point(8, 32);
			this.gvStatsAll.Margin = new System.Windows.Forms.Padding(4);
			this.gvStatsAll.MultiSelect = false;
			this.gvStatsAll.Name = "gvStatsAll";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gvStatsAll.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gvStatsAll.RowHeadersWidth = 24;
			this.gvStatsAll.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gvStatsAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gvStatsAll.Size = new System.Drawing.Size(620, 400);
			this.gvStatsAll.TabIndex = 16;
			// 
			// comboFilterBy
			// 
			this.comboFilterBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFilterBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboFilterBy.FormattingEnabled = true;
			this.comboFilterBy.Items.AddRange(new object[] {
            "All",
            "Attributes - Physical",
            "Attributes - Mental",
            "Attributes - Special",
            "Resistances",
            "Skills",
            "Special Abilities"});
			this.comboFilterBy.Location = new System.Drawing.Point(60, 443);
			this.comboFilterBy.MaxDropDownItems = 5;
			this.comboFilterBy.Name = "comboFilterBy";
			this.comboFilterBy.Size = new System.Drawing.Size(157, 26);
			this.comboFilterBy.TabIndex = 22;
			this.comboFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboFilterBy_SelectedIndexChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(8, 446);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(46, 18);
			this.lblSearch.TabIndex = 21;
			this.lblSearch.Text = "Show:";
			this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// UserCtrlStatsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.comboFilterBy);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.gvStatsAll);
			this.Controls.Add(this.buttSaveList);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UserCtrlStatsEditor";
			this.Size = new System.Drawing.Size(640, 480);
			this.Load += new System.EventHandler(this.Editor_Load);
			this.Leave += new System.EventHandler(this.UserCtrlStatEditor_Leave);
			this.popupMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gvStatsAll)).EndInit();
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
		private System.Windows.Forms.DataGridView gvStatsAll;
		private System.Windows.Forms.ComboBox comboFilterBy;
		private System.Windows.Forms.Label lblSearch;
	}
}
