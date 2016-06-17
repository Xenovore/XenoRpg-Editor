namespace XenoRPGEditor
{
	partial class UserCtrlItemsEditor
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.buttSaveList = new System.Windows.Forms.Button();
			this.gridview = new System.Windows.Forms.DataGridView();
			this.lblMasterItemList = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
			this.SuspendLayout();
			// 
			// buttSaveList
			// 
			this.buttSaveList.Enabled = false;
			this.buttSaveList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttSaveList.Location = new System.Drawing.Point(114, 4);
			this.buttSaveList.Name = "buttSaveList";
			this.buttSaveList.Size = new System.Drawing.Size(100, 23);
			this.buttSaveList.TabIndex = 9;
			this.buttSaveList.Text = "Save Changes";
			this.buttSaveList.UseVisualStyleBackColor = true;
			this.buttSaveList.Click += new System.EventHandler(this.buttSaveChanges_Click);
			// 
			// gridview
			// 
			this.gridview.AllowUserToOrderColumns = true;
			this.gridview.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
			this.gridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.gridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridview.BackgroundColor = System.Drawing.SystemColors.Control;
			this.gridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.gridview.EnableHeadersVisualStyles = false;
			this.gridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.gridview.Location = new System.Drawing.Point(0, 34);
			this.gridview.Margin = new System.Windows.Forms.Padding(4);
			this.gridview.MultiSelect = false;
			this.gridview.Name = "gridview";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridview.RowHeadersWidth = 24;
			this.gridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.gridview.Size = new System.Drawing.Size(574, 623);
			this.gridview.TabIndex = 5;
			this.gridview.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridItemMasterList_CellEndEdit);
			this.gridview.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridItems_RowHeaderMouseDoubleClick);
			this.gridview.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gridItemsMasterList_UserDeletedRow);
			this.gridview.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.gridItemsMasterList_UserDeletingRow);
			// 
			// lblMasterItemList
			// 
			this.lblMasterItemList.AutoSize = true;
			this.lblMasterItemList.BackColor = System.Drawing.Color.Transparent;
			this.lblMasterItemList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMasterItemList.Location = new System.Drawing.Point(2, 11);
			this.lblMasterItemList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMasterItemList.Name = "lblMasterItemList";
			this.lblMasterItemList.Size = new System.Drawing.Size(95, 15);
			this.lblMasterItemList.TabIndex = 15;
			this.lblMasterItemList.Text = "Master Item List";
			// 
			// UserCtrlItemsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.lblMasterItemList);
			this.Controls.Add(this.buttSaveList);
			this.Controls.Add(this.gridview);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "UserCtrlItemsEditor";
			this.Size = new System.Drawing.Size(574, 659);
			this.Load += new System.EventHandler(this.Editor_Load);
			this.Leave += new System.EventHandler(this.UserCtrlItemEditor_Leave);
			((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttSaveList;
		private System.Windows.Forms.DataGridView gridview;
		private System.Windows.Forms.Label lblMasterItemList;
	}
}
