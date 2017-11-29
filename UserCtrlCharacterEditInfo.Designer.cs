namespace XenoRPGEditor
{
	partial class UserCtrlCharacterEditInfo
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label9 = new System.Windows.Forms.Label();
			this.splitContInfoStats = new System.Windows.Forms.SplitContainer();
			this.textTitle = new System.Windows.Forms.TextBox();
			this.comboProfession = new System.Windows.Forms.ComboBox();
			this.comboRace = new System.Windows.Forms.ComboBox();
			this.textNameLast = new System.Windows.Forms.TextBox();
			this.labelProfession = new System.Windows.Forms.Label();
			this.labelRace = new System.Windows.Forms.Label();
			this.textXpPool = new System.Windows.Forms.TextBox();
			this.labelXpPool = new System.Windows.Forms.Label();
			this.textAge = new System.Windows.Forms.TextBox();
			this.labelAge = new System.Windows.Forms.Label();
			this.textNameFirst = new System.Windows.Forms.TextBox();
			this.labelName = new System.Windows.Forms.Label();
			this.comboStatTypeFilter = new System.Windows.Forms.ComboBox();
			this.gridCharacterStats = new System.Windows.Forms.DataGridView();
			this.lblCharAttribs = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContInfoStats)).BeginInit();
			this.splitContInfoStats.Panel1.SuspendLayout();
			this.splitContInfoStats.Panel2.SuspendLayout();
			this.splitContInfoStats.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridCharacterStats)).BeginInit();
			this.SuspendLayout();
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.label9.Location = new System.Drawing.Point(2, 0);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 18);
			this.label9.TabIndex = 22;
			this.label9.Text = "Character Details";
			// 
			// splitContInfoStats
			// 
			this.splitContInfoStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContInfoStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContInfoStats.Location = new System.Drawing.Point(5, 19);
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
			this.splitContInfoStats.Panel1.Controls.Add(this.labelProfession);
			this.splitContInfoStats.Panel1.Controls.Add(this.labelRace);
			this.splitContInfoStats.Panel1.Controls.Add(this.textXpPool);
			this.splitContInfoStats.Panel1.Controls.Add(this.labelXpPool);
			this.splitContInfoStats.Panel1.Controls.Add(this.textAge);
			this.splitContInfoStats.Panel1.Controls.Add(this.labelAge);
			this.splitContInfoStats.Panel1.Controls.Add(this.textNameFirst);
			this.splitContInfoStats.Panel1.Controls.Add(this.labelName);
			// 
			// splitContInfoStats.Panel2
			// 
			this.splitContInfoStats.Panel2.BackgroundImage = global::XenoRPGEditor.Properties.Resources.formBG;
			this.splitContInfoStats.Panel2.Controls.Add(this.comboStatTypeFilter);
			this.splitContInfoStats.Panel2.Controls.Add(this.gridCharacterStats);
			this.splitContInfoStats.Panel2.Controls.Add(this.lblCharAttribs);
			this.splitContInfoStats.Size = new System.Drawing.Size(623, 695);
			this.splitContInfoStats.SplitterDistance = 170;
			this.splitContInfoStats.TabIndex = 21;
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
			// labelProfession
			// 
			this.labelProfession.AutoSize = true;
			this.labelProfession.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProfession.Location = new System.Drawing.Point(211, 38);
			this.labelProfession.Name = "labelProfession";
			this.labelProfession.Size = new System.Drawing.Size(81, 16);
			this.labelProfession.TabIndex = 12;
			this.labelProfession.Text = "Profession:";
			// 
			// labelRace
			// 
			this.labelRace.AutoSize = true;
			this.labelRace.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelRace.Location = new System.Drawing.Point(6, 38);
			this.labelRace.Name = "labelRace";
			this.labelRace.Size = new System.Drawing.Size(46, 16);
			this.labelRace.TabIndex = 4;
			this.labelRace.Text = "Race:";
			// 
			// textXpPool
			// 
			this.textXpPool.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textXpPool.Location = new System.Drawing.Point(66, 111);
			this.textXpPool.Name = "textXpPool";
			this.textXpPool.Size = new System.Drawing.Size(106, 23);
			this.textXpPool.TabIndex = 9;
			// 
			// labelXpPool
			// 
			this.labelXpPool.AutoSize = true;
			this.labelXpPool.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelXpPool.Location = new System.Drawing.Point(6, 114);
			this.labelXpPool.Name = "labelXpPool";
			this.labelXpPool.Size = new System.Drawing.Size(63, 16);
			this.labelXpPool.TabIndex = 5;
			this.labelXpPool.Text = "XP Pool:";
			// 
			// textAge
			// 
			this.textAge.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textAge.Location = new System.Drawing.Point(66, 64);
			this.textAge.Name = "textAge";
			this.textAge.Size = new System.Drawing.Size(34, 23);
			this.textAge.TabIndex = 10;
			// 
			// labelAge
			// 
			this.labelAge.AutoSize = true;
			this.labelAge.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAge.Location = new System.Drawing.Point(6, 66);
			this.labelAge.Name = "labelAge";
			this.labelAge.Size = new System.Drawing.Size(39, 16);
			this.labelAge.TabIndex = 6;
			this.labelAge.Text = "Age:";
			// 
			// textNameFirst
			// 
			this.textNameFirst.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textNameFirst.Location = new System.Drawing.Point(66, 7);
			this.textNameFirst.Name = "textNameFirst";
			this.textNameFirst.Size = new System.Drawing.Size(120, 23);
			this.textNameFirst.TabIndex = 11;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelName.Location = new System.Drawing.Point(6, 10);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(50, 16);
			this.labelName.TabIndex = 7;
			this.labelName.Text = "Name:";
			// 
			// comboStatTypeFilter
			// 
			this.comboStatTypeFilter.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboStatTypeFilter.FormattingEnabled = true;
			this.comboStatTypeFilter.Location = new System.Drawing.Point(54, 7);
			this.comboStatTypeFilter.Name = "comboStatTypeFilter";
			this.comboStatTypeFilter.Size = new System.Drawing.Size(140, 22);
			this.comboStatTypeFilter.TabIndex = 21;
			// 
			// gridCharacterStats
			// 
			this.gridCharacterStats.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridCharacterStats.BackgroundColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCharacterStats.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.gridCharacterStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridCharacterStats.Location = new System.Drawing.Point(6, 35);
			this.gridCharacterStats.Name = "gridCharacterStats";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.gridCharacterStats.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.gridCharacterStats.RowHeadersVisible = false;
			this.gridCharacterStats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.gridCharacterStats.Size = new System.Drawing.Size(609, 480);
			this.gridCharacterStats.TabIndex = 19;
			// 
			// lblCharAttribs
			// 
			this.lblCharAttribs.AutoSize = true;
			this.lblCharAttribs.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCharAttribs.Location = new System.Drawing.Point(3, 10);
			this.lblCharAttribs.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblCharAttribs.Name = "lblCharAttribs";
			this.lblCharAttribs.Size = new System.Drawing.Size(46, 16);
			this.lblCharAttribs.TabIndex = 20;
			this.lblCharAttribs.Text = "Stats";
			// 
			// UserCtrlCharacterEditInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label9);
			this.Controls.Add(this.splitContInfoStats);
			this.Name = "UserCtrlCharacterEditInfo";
			this.Size = new System.Drawing.Size(1120, 857);
			this.splitContInfoStats.Panel1.ResumeLayout(false);
			this.splitContInfoStats.Panel1.PerformLayout();
			this.splitContInfoStats.Panel2.ResumeLayout(false);
			this.splitContInfoStats.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContInfoStats)).EndInit();
			this.splitContInfoStats.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridCharacterStats)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.SplitContainer splitContInfoStats;
		private System.Windows.Forms.TextBox textTitle;
		private System.Windows.Forms.ComboBox comboProfession;
		private System.Windows.Forms.ComboBox comboRace;
		private System.Windows.Forms.TextBox textNameLast;
		private System.Windows.Forms.Label labelProfession;
		private System.Windows.Forms.Label labelRace;
		private System.Windows.Forms.TextBox textXpPool;
		private System.Windows.Forms.Label labelXpPool;
		private System.Windows.Forms.TextBox textAge;
		private System.Windows.Forms.Label labelAge;
		private System.Windows.Forms.TextBox textNameFirst;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.ComboBox comboStatTypeFilter;
		private System.Windows.Forms.DataGridView gridCharacterStats;
		private System.Windows.Forms.Label lblCharAttribs;
	}
}
