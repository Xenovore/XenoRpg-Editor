namespace XenoRPGEditor
{
    partial class UserCtrlCharactersEditor
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvCharacters = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.comboSearchBy = new System.Windows.Forms.ComboBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCharacters
			// 
			this.dgvCharacters.AllowUserToResizeRows = false;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
			this.dgvCharacters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCharacters.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvCharacters.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCharacters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvCharacters.EnableHeadersVisualStyles = false;
			this.dgvCharacters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvCharacters.Location = new System.Drawing.Point(8, 32);
			this.dgvCharacters.Margin = new System.Windows.Forms.Padding(4);
			this.dgvCharacters.MultiSelect = false;
			this.dgvCharacters.Name = "dgvCharacters";
			this.dgvCharacters.ReadOnly = true;
			this.dgvCharacters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCharacters.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvCharacters.RowHeadersWidth = 24;
			this.dgvCharacters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvCharacters.Size = new System.Drawing.Size(620, 400);
			this.dgvCharacters.TabIndex = 6;
			this.dgvCharacters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCharacters_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Characters";
			// 
			// comboSearchBy
			// 
			this.comboSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboSearchBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboSearchBy.FormattingEnabled = true;
			this.comboSearchBy.Location = new System.Drawing.Point(67, 443);
			this.comboSearchBy.MaxDropDownItems = 5;
			this.comboSearchBy.Name = "comboSearchBy";
			this.comboSearchBy.Size = new System.Drawing.Size(241, 26);
			this.comboSearchBy.TabIndex = 22;
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.BackColor = System.Drawing.Color.Transparent;
			this.lblSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(8, 446);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(53, 18);
			this.lblSearch.TabIndex = 21;
			this.lblSearch.Text = "Search:";
			this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(119, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 13);
			this.label2.TabIndex = 23;
			this.label2.Text = "Double-click row to edit.";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("DejaVu Sans Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(328, 445);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(259, 19);
			this.label3.TabIndex = 24;
			this.label3.Text = "TODO: SEARCH BY DROP_DOWN";
			// 
			// UserCtrlCharactersEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboSearchBy);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCharacters);
			this.Name = "UserCtrlCharactersEditor";
			this.Size = new System.Drawing.Size(640, 480);
			this.Load += new System.EventHandler(this.Editor_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCharacters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSearchBy;
        private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}
