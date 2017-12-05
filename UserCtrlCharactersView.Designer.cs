namespace XenoRPGEditor
{
    partial class UserCtrlCharactersView
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvCharacters = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.comboSearchBy = new System.Windows.Forms.ComboBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textSearchFor = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttResetSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCharacters)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCharacters
			// 
			this.dgvCharacters.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
			this.dgvCharacters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCharacters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCharacters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.dgvCharacters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCharacters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCharacters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvCharacters.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvCharacters.EnableHeadersVisualStyles = false;
			this.dgvCharacters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dgvCharacters.Location = new System.Drawing.Point(11, 39);
			this.dgvCharacters.Margin = new System.Windows.Forms.Padding(5);
			this.dgvCharacters.MultiSelect = false;
			this.dgvCharacters.Name = "dgvCharacters";
			this.dgvCharacters.ReadOnly = true;
			this.dgvCharacters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCharacters.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvCharacters.RowHeadersVisible = false;
			this.dgvCharacters.RowHeadersWidth = 24;
			this.dgvCharacters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvCharacters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCharacters.Size = new System.Drawing.Size(825, 490);
			this.dgvCharacters.TabIndex = 6;
			this.dgvCharacters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCharacters_CellDoubleClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(11, 10);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 17);
			this.label1.TabIndex = 7;
			this.label1.Text = "Characters";
			// 
			// comboSearchBy
			// 
			this.comboSearchBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboSearchBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.comboSearchBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboSearchBy.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboSearchBy.ForeColor = System.Drawing.Color.White;
			this.comboSearchBy.FormattingEnabled = true;
			this.comboSearchBy.Items.AddRange(new object[] {
            "Name",
            "Profession",
            "Race",
            "Level"});
			this.comboSearchBy.Location = new System.Drawing.Point(397, 539);
			this.comboSearchBy.Margin = new System.Windows.Forms.Padding(4);
			this.comboSearchBy.MaxDropDownItems = 5;
			this.comboSearchBy.Name = "comboSearchBy";
			this.comboSearchBy.Size = new System.Drawing.Size(265, 26);
			this.comboSearchBy.TabIndex = 22;
			// 
			// lblSearch
			// 
			this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblSearch.AutoSize = true;
			this.lblSearch.BackColor = System.Drawing.Color.Transparent;
			this.lblSearch.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.ForeColor = System.Drawing.Color.White;
			this.lblSearch.Location = new System.Drawing.Point(11, 542);
			this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
			this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(128, 10);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(154, 18);
			this.label2.TabIndex = 23;
			this.label2.Text = "Double-click row to edit.";
			// 
			// textSearchFor
			// 
			this.textSearchFor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.textSearchFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
			this.textSearchFor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSearchFor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textSearchFor.ForeColor = System.Drawing.Color.White;
			this.textSearchFor.Location = new System.Drawing.Point(72, 539);
			this.textSearchFor.Margin = new System.Windows.Forms.Padding(4);
			this.textSearchFor.Name = "textSearchFor";
			this.textSearchFor.Size = new System.Drawing.Size(241, 26);
			this.textSearchFor.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(362, 542);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(27, 18);
			this.label3.TabIndex = 25;
			this.label3.Text = "By:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttResetSearch
			// 
			this.buttResetSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.buttResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttResetSearch.Font = new System.Drawing.Font("Wingdings 2", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.buttResetSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.buttResetSearch.Location = new System.Drawing.Point(314, 539);
			this.buttResetSearch.Margin = new System.Windows.Forms.Padding(4);
			this.buttResetSearch.Name = "buttResetSearch";
			this.buttResetSearch.Size = new System.Drawing.Size(24, 26);
			this.buttResetSearch.TabIndex = 26;
			this.buttResetSearch.Text = "Ï";
			this.buttResetSearch.UseVisualStyleBackColor = false;
			this.buttResetSearch.Click += new System.EventHandler(this.buttResetSearch_Click);
			// 
			// UserCtrlCharactersView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.buttResetSearch);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textSearchFor);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboSearchBy);
			this.Controls.Add(this.lblSearch);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvCharacters);
			this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "UserCtrlCharactersView";
			this.Size = new System.Drawing.Size(851, 589);
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
		private System.Windows.Forms.TextBox textSearchFor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttResetSearch;
	}
}
