namespace KevInvTest
{
	partial class FormItemEditor
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.buttAddNewItem = new System.Windows.Forms.Button();
			this.comboTables = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttLoadTable = new System.Windows.Forms.Button();
			( (System.ComponentModel.ISupportInitialize)( this.dataGridView1 ) ).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 226 ) ) ) ), ( (int)( ( (byte)( 228 ) ) ) ), ( (int)( ( (byte)( 243 ) ) ) ) );
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom ) 
            | System.Windows.Forms.AnchorStyles.Left ) 
            | System.Windows.Forms.AnchorStyles.Right ) ) );
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeight = 25;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView1.Location = new System.Drawing.Point( 10, 42 );
			this.dataGridView1.Margin = new System.Windows.Forms.Padding( 4 );
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 25;
			this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size( 553, 490 );
			this.dataGridView1.TabIndex = 0;
			// 
			// buttAddNewItem
			// 
			this.buttAddNewItem.Location = new System.Drawing.Point( 10, 542 );
			this.buttAddNewItem.Margin = new System.Windows.Forms.Padding( 4 );
			this.buttAddNewItem.Name = "buttAddNewItem";
			this.buttAddNewItem.Size = new System.Drawing.Size( 102, 28 );
			this.buttAddNewItem.TabIndex = 1;
			this.buttAddNewItem.Text = "Add New Item";
			this.buttAddNewItem.UseVisualStyleBackColor = true;
			this.buttAddNewItem.Click += new System.EventHandler( this.buttAddNewItem_Click );
			// 
			// comboTables
			// 
			this.comboTables.FormattingEnabled = true;
			this.comboTables.Items.AddRange( new object[] {
            "item_templates"} );
			this.comboTables.Location = new System.Drawing.Point( 62, 11 );
			this.comboTables.Name = "comboTables";
			this.comboTables.Size = new System.Drawing.Size( 148, 24 );
			this.comboTables.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point( 16, 15 );
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size( 45, 16 );
			this.label1.TabIndex = 3;
			this.label1.Text = "Table:";
			// 
			// buttLoadTable
			// 
			this.buttLoadTable.Location = new System.Drawing.Point( 216, 10 );
			this.buttLoadTable.Name = "buttLoadTable";
			this.buttLoadTable.Size = new System.Drawing.Size( 48, 26 );
			this.buttLoadTable.TabIndex = 4;
			this.buttLoadTable.Text = "Load";
			this.buttLoadTable.UseVisualStyleBackColor = true;
			this.buttLoadTable.Click += new System.EventHandler( this.buttLoadTable_Click );
			// 
			// FormItemEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 7F, 16F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 227 ) ) ) ), ( (int)( ( (byte)( 227 ) ) ) ), ( (int)( ( (byte)( 208 ) ) ) ) );
			this.ClientSize = new System.Drawing.Size( 571, 580 );
			this.Controls.Add( this.buttLoadTable );
			this.Controls.Add( this.label1 );
			this.Controls.Add( this.comboTables );
			this.Controls.Add( this.buttAddNewItem );
			this.Controls.Add( this.dataGridView1 );
			this.Font = new System.Drawing.Font( "Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
			this.Margin = new System.Windows.Forms.Padding( 4 );
			this.Name = "FormItemEditor";
			this.Text = "Item Editor";
			( (System.ComponentModel.ISupportInitialize)( this.dataGridView1 ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button buttAddNewItem;
		private System.Windows.Forms.ComboBox comboTables;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttLoadTable;
	}
}