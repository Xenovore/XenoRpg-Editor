namespace XenoRPGEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( FormItemEditor ) );
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.groupContainer = new System.Windows.Forms.GroupBox();
            this.pnlContInfo = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttTypeAllowed = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTypeAllowed = new System.Windows.Forms.TextBox();
            this.groupItem = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbZoom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictItemIcon = new System.Windows.Forms.PictureBox();
            this.spinIconIdx = new System.Windows.Forms.NumericUpDown();
            this.rtfDescription = new System.Windows.Forms.RichTextBox();
            this.spinQuantityCap = new System.Windows.Forms.NumericUpDown();
            this.spinWeight = new System.Windows.Forms.NumericUpDown();
            this.spinQuantity = new System.Windows.Forms.NumericUpDown();
            this.comboHeight = new System.Windows.Forms.ComboBox();
            this.comboWidth = new System.Windows.Forms.ComboBox();
            this.comboContainer = new System.Windows.Forms.ComboBox();
            this.comboDisabled = new System.Windows.Forms.ComboBox();
            this.buttType = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip( this.components );
            this.panel1.SuspendLayout();
            this.groupContainer.SuspendLayout();
            this.pnlContInfo.SuspendLayout();
            this.groupItem.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.pictItemIcon ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinIconIdx ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinQuantityCap ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinWeight ) ).BeginInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinQuantity ) ).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImage = ( (System.Drawing.Image)( resources.GetObject( "panel1.BackgroundImage" ) ) );
            this.panel1.Controls.Add( this.label19 );
            this.panel1.Controls.Add( this.groupContainer );
            this.panel1.Controls.Add( this.groupItem );
            this.panel1.Location = new System.Drawing.Point( 0, 0 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 330, 697 );
            this.panel1.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point( 80, 0 );
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size( 231, 18 );
            this.label19.TabIndex = 8;
            this.label19.Text = "TODO: Put save & cancel buttons here";
            // 
            // groupContainer
            // 
            this.groupContainer.BackColor = System.Drawing.Color.Transparent;
            this.groupContainer.Controls.Add( this.pnlContInfo );
            this.groupContainer.Location = new System.Drawing.Point( 8, 505 );
            this.groupContainer.Name = "groupContainer";
            this.groupContainer.Size = new System.Drawing.Size( 314, 184 );
            this.groupContainer.TabIndex = 1;
            this.groupContainer.TabStop = false;
            this.groupContainer.Text = "Container Info";
            this.toolTip1.SetToolTip( this.groupContainer, "Choose a Container type to enable." );
            // 
            // pnlContInfo
            // 
            this.pnlContInfo.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom )
                        | System.Windows.Forms.AnchorStyles.Left )
                        | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.pnlContInfo.Controls.Add( this.textBox10 );
            this.pnlContInfo.Controls.Add( this.label18 );
            this.pnlContInfo.Controls.Add( this.label17 );
            this.pnlContInfo.Controls.Add( this.label16 );
            this.pnlContInfo.Controls.Add( this.label15 );
            this.pnlContInfo.Controls.Add( this.label14 );
            this.pnlContInfo.Controls.Add( this.label13 );
            this.pnlContInfo.Controls.Add( this.label8 );
            this.pnlContInfo.Controls.Add( this.buttTypeAllowed );
            this.pnlContInfo.Controls.Add( this.textBox9 );
            this.pnlContInfo.Controls.Add( this.textBox8 );
            this.pnlContInfo.Controls.Add( this.textBox4 );
            this.pnlContInfo.Controls.Add( this.textBox6 );
            this.pnlContInfo.Controls.Add( this.textBox7 );
            this.pnlContInfo.Controls.Add( this.textBox5 );
            this.pnlContInfo.Controls.Add( this.txtTypeAllowed );
            this.pnlContInfo.Enabled = false;
            this.pnlContInfo.Location = new System.Drawing.Point( 0, 11 );
            this.pnlContInfo.Name = "pnlContInfo";
            this.pnlContInfo.Size = new System.Drawing.Size( 314, 173 );
            this.pnlContInfo.TabIndex = 0;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 240 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ), ( (int)( ( (byte)( 251 ) ) ) ) );
            this.textBox10.Location = new System.Drawing.Point( 98, 10 );
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size( 96, 26 );
            this.textBox10.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point( 6, 13 );
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size( 86, 18 );
            this.label18.TabIndex = 22;
            this.label18.Text = "ID_ContInfo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point( 166, 141 );
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size( 56, 18 );
            this.label17.TabIndex = 18;
            this.label17.Text = "Wt Cap:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point( 6, 141 );
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size( 63, 18 );
            this.label16.TabIndex = 17;
            this.label16.Text = "Wt Total:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point( 166, 108 );
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size( 62, 18 );
            this.label15.TabIndex = 16;
            this.label15.Text = "Vol. Cap:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point( 6, 109 );
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size( 69, 18 );
            this.label14.TabIndex = 21;
            this.label14.Text = "Vol. Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point( 166, 77 );
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size( 67, 18 );
            this.label13.TabIndex = 20;
            this.label13.Text = "Item Cap:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point( 6, 77 );
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size( 74, 18 );
            this.label8.TabIndex = 19;
            this.label8.Text = "Item Total:";
            // 
            // buttTypeAllowed
            // 
            this.buttTypeAllowed.Location = new System.Drawing.Point( 9, 42 );
            this.buttTypeAllowed.Name = "buttTypeAllowed";
            this.buttTypeAllowed.Size = new System.Drawing.Size( 112, 26 );
            this.buttTypeAllowed.TabIndex = 15;
            this.buttTypeAllowed.Text = "Type Allowed...";
            this.buttTypeAllowed.UseVisualStyleBackColor = true;
            this.buttTypeAllowed.Click += new System.EventHandler( this.buttTypeAllowed_Click );
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point( 246, 138 );
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size( 57, 26 );
            this.textBox9.TabIndex = 18;
            this.textBox9.Text = "0";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point( 246, 105 );
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size( 57, 26 );
            this.textBox8.TabIndex = 16;
            this.textBox8.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point( 246, 74 );
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size( 57, 26 );
            this.textBox4.TabIndex = 14;
            this.textBox4.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Window;
            this.textBox6.Location = new System.Drawing.Point( 86, 138 );
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size( 57, 26 );
            this.textBox6.TabIndex = 17;
            this.textBox6.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Window;
            this.textBox7.Location = new System.Drawing.Point( 86, 106 );
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size( 57, 26 );
            this.textBox7.TabIndex = 15;
            this.textBox7.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Location = new System.Drawing.Point( 86, 74 );
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size( 57, 26 );
            this.textBox5.TabIndex = 13;
            this.textBox5.Text = "0";
            // 
            // txtTypeAllowed
            // 
            this.txtTypeAllowed.Location = new System.Drawing.Point( 127, 42 );
            this.txtTypeAllowed.Name = "txtTypeAllowed";
            this.txtTypeAllowed.Size = new System.Drawing.Size( 176, 26 );
            this.txtTypeAllowed.TabIndex = 12;
            this.txtTypeAllowed.Text = "Type (0x00000000)";
            // 
            // groupItem
            // 
            this.groupItem.BackColor = System.Drawing.Color.Transparent;
            this.groupItem.Controls.Add( this.groupBox1 );
            this.groupItem.Controls.Add( this.rtfDescription );
            this.groupItem.Controls.Add( this.spinQuantityCap );
            this.groupItem.Controls.Add( this.spinWeight );
            this.groupItem.Controls.Add( this.spinQuantity );
            this.groupItem.Controls.Add( this.comboHeight );
            this.groupItem.Controls.Add( this.comboWidth );
            this.groupItem.Controls.Add( this.comboContainer );
            this.groupItem.Controls.Add( this.comboDisabled );
            this.groupItem.Controls.Add( this.buttType );
            this.groupItem.Controls.Add( this.txtType );
            this.groupItem.Controls.Add( this.txtName );
            this.groupItem.Controls.Add( this.txtID );
            this.groupItem.Controls.Add( this.label4 );
            this.groupItem.Controls.Add( this.label12 );
            this.groupItem.Controls.Add( this.label11 );
            this.groupItem.Controls.Add( this.label10 );
            this.groupItem.Controls.Add( this.label9 );
            this.groupItem.Controls.Add( this.label7 );
            this.groupItem.Controls.Add( this.label6 );
            this.groupItem.Controls.Add( this.label5 );
            this.groupItem.Controls.Add( this.label3 );
            this.groupItem.Controls.Add( this.label1 );
            this.groupItem.Location = new System.Drawing.Point( 8, 8 );
            this.groupItem.Name = "groupItem";
            this.groupItem.Size = new System.Drawing.Size( 314, 491 );
            this.groupItem.TabIndex = 0;
            this.groupItem.TabStop = false;
            this.groupItem.Text = "Item Info";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add( this.cbZoom );
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Controls.Add( this.pictItemIcon );
            this.groupBox1.Controls.Add( this.spinIconIdx );
            this.groupBox1.Location = new System.Drawing.Point( 160, 116 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 145, 212 );
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Icon";
            // 
            // cbZoom
            // 
            this.cbZoom.AutoSize = true;
            this.cbZoom.Location = new System.Drawing.Point( 9, 187 );
            this.cbZoom.Name = "cbZoom";
            this.cbZoom.Size = new System.Drawing.Size( 78, 22 );
            this.cbZoom.TabIndex = 11;
            this.cbZoom.Text = "Zoomed";
            this.cbZoom.UseVisualStyleBackColor = true;
            this.cbZoom.CheckedChanged += new System.EventHandler( this.cbZoom_CheckedChanged );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 6, 157 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 47, 18 );
            this.label2.TabIndex = 10;
            this.label2.Text = "Index:";
            // 
            // pictItemIcon
            // 
            this.pictItemIcon.BackColor = System.Drawing.Color.Gray;
            this.pictItemIcon.BackgroundImage = ( (System.Drawing.Image)( resources.GetObject( "pictItemIcon.BackgroundImage" ) ) );
            this.pictItemIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictItemIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictItemIcon.Location = new System.Drawing.Point( 9, 20 );
            this.pictItemIcon.Margin = new System.Windows.Forms.Padding( 0 );
            this.pictItemIcon.Name = "pictItemIcon";
            this.pictItemIcon.Size = new System.Drawing.Size( 128, 128 );
            this.pictItemIcon.TabIndex = 9;
            this.pictItemIcon.TabStop = false;
            // 
            // spinIconIdx
            // 
            this.spinIconIdx.Location = new System.Drawing.Point( 59, 155 );
            this.spinIconIdx.Maximum = new decimal( new int[] {
            9999,
            0,
            0,
            0} );
            this.spinIconIdx.Name = "spinIconIdx";
            this.spinIconIdx.Size = new System.Drawing.Size( 78, 26 );
            this.spinIconIdx.TabIndex = 5;
            this.spinIconIdx.ValueChanged += new System.EventHandler( this.spinIconIdx_ValueChanged );
            // 
            // rtfDescription
            // 
            this.rtfDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtfDescription.Location = new System.Drawing.Point( 9, 390 );
            this.rtfDescription.Name = "rtfDescription";
            this.rtfDescription.Size = new System.Drawing.Size( 296, 93 );
            this.rtfDescription.TabIndex = 6;
            this.rtfDescription.Text = "";
            // 
            // spinQuantityCap
            // 
            this.spinQuantityCap.Location = new System.Drawing.Point( 77, 269 );
            this.spinQuantityCap.Maximum = new decimal( new int[] {
            32767,
            0,
            0,
            0} );
            this.spinQuantityCap.Name = "spinQuantityCap";
            this.spinQuantityCap.Size = new System.Drawing.Size( 74, 26 );
            this.spinQuantityCap.TabIndex = 5;
            // 
            // spinWeight
            // 
            this.spinWeight.DecimalPlaces = 2;
            this.spinWeight.Increment = new decimal( new int[] {
            1,
            0,
            0,
            131072} );
            this.spinWeight.Location = new System.Drawing.Point( 77, 141 );
            this.spinWeight.Maximum = new decimal( new int[] {
            9999,
            0,
            0,
            0} );
            this.spinWeight.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            131072} );
            this.spinWeight.Name = "spinWeight";
            this.spinWeight.Size = new System.Drawing.Size( 74, 26 );
            this.spinWeight.TabIndex = 5;
            this.spinWeight.Value = new decimal( new int[] {
            1,
            0,
            0,
            131072} );
            // 
            // spinQuantity
            // 
            this.spinQuantity.Location = new System.Drawing.Point( 77, 237 );
            this.spinQuantity.Maximum = new decimal( new int[] {
            9999,
            0,
            0,
            0} );
            this.spinQuantity.Minimum = new decimal( new int[] {
            1,
            0,
            0,
            0} );
            this.spinQuantity.Name = "spinQuantity";
            this.spinQuantity.Size = new System.Drawing.Size( 74, 26 );
            this.spinQuantity.TabIndex = 5;
            this.spinQuantity.Value = new decimal( new int[] {
            1,
            0,
            0,
            0} );
            // 
            // comboHeight
            // 
            this.comboHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboHeight.FormattingEnabled = true;
            this.comboHeight.Items.AddRange( new object[] {
            "1",
            "2",
            "3",
            "4"} );
            this.comboHeight.Location = new System.Drawing.Point( 77, 205 );
            this.comboHeight.MaxDropDownItems = 4;
            this.comboHeight.Name = "comboHeight";
            this.comboHeight.Size = new System.Drawing.Size( 74, 26 );
            this.comboHeight.TabIndex = 4;
            // 
            // comboWidth
            // 
            this.comboWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWidth.FormattingEnabled = true;
            this.comboWidth.Items.AddRange( new object[] {
            "1",
            "2",
            "3",
            "4"} );
            this.comboWidth.Location = new System.Drawing.Point( 77, 173 );
            this.comboWidth.MaxDropDownItems = 4;
            this.comboWidth.Name = "comboWidth";
            this.comboWidth.Size = new System.Drawing.Size( 74, 26 );
            this.comboWidth.TabIndex = 4;
            // 
            // comboContainer
            // 
            this.comboContainer.FormattingEnabled = true;
            this.comboContainer.Items.AddRange( new object[] {
            "false",
            "true"} );
            this.comboContainer.Location = new System.Drawing.Point( 108, 334 );
            this.comboContainer.Name = "comboContainer";
            this.comboContainer.Size = new System.Drawing.Size( 197, 26 );
            this.comboContainer.TabIndex = 4;
            this.comboContainer.Text = "id - name";
            // 
            // comboDisabled
            // 
            this.comboDisabled.Font = new System.Drawing.Font( "Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.comboDisabled.FormattingEnabled = true;
            this.comboDisabled.Items.AddRange( new object[] {
            "false",
            "true"} );
            this.comboDisabled.Location = new System.Drawing.Point( 77, 301 );
            this.comboDisabled.Name = "comboDisabled";
            this.comboDisabled.Size = new System.Drawing.Size( 74, 26 );
            this.comboDisabled.TabIndex = 4;
            this.comboDisabled.Text = "false";
            // 
            // buttType
            // 
            this.buttType.Location = new System.Drawing.Point( 8, 83 );
            this.buttType.Name = "buttType";
            this.buttType.Size = new System.Drawing.Size( 57, 26 );
            this.buttType.TabIndex = 2;
            this.buttType.Text = "Type...";
            this.buttType.UseVisualStyleBackColor = true;
            this.buttType.Click += new System.EventHandler( this.buttType_Click );
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font( "Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.txtType.Location = new System.Drawing.Point( 77, 84 );
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size( 227, 26 );
            this.txtType.TabIndex = 1;
            this.txtType.Text = "0x00000000";
            this.txtType.TextChanged += new System.EventHandler( this.txtType_TextChanged );
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point( 77, 52 );
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size( 227, 26 );
            this.txtName.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.FromArgb( ( (int)( ( (byte)( 240 ) ) ) ), ( (int)( ( (byte)( 241 ) ) ) ), ( (int)( ( (byte)( 251 ) ) ) ) );
            this.txtID.Location = new System.Drawing.Point( 77, 20 );
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size( 96, 26 );
            this.txtID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point( 8, 337 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 91, 18 );
            this.label4.TabIndex = 0;
            this.label4.Text = "Contained In:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point( 9, 369 );
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size( 82, 18 );
            this.label12.TabIndex = 0;
            this.label12.Text = "Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point( 8, 271 );
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size( 60, 18 );
            this.label11.TabIndex = 0;
            this.label11.Text = "Qty Cap:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point( 8, 239 );
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size( 65, 18 );
            this.label10.TabIndex = 0;
            this.label10.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font( "Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.label9.Location = new System.Drawing.Point( 8, 304 );
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size( 66, 18 );
            this.label9.TabIndex = 0;
            this.label9.Text = "Disabled:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point( 8, 208 );
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size( 53, 18 );
            this.label7.TabIndex = 0;
            this.label7.Text = "Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point( 8, 176 );
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size( 50, 18 );
            this.label6.TabIndex = 0;
            this.label6.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point( 8, 143 );
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size( 56, 18 );
            this.label5.TabIndex = 0;
            this.label5.Text = "Weight:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point( 8, 55 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 49, 18 );
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point( 8, 23 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 25, 18 );
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // toolTip1
            // 
            this.toolTip1.ForeColor = System.Drawing.Color.Firebrick;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // formItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 8F, 18F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size( 330, 697 );
            this.Controls.Add( this.panel1 );
            this.Font = new System.Drawing.Font( "Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte)( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding( 4 );
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size( 362, 740 );
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size( 346, 400 );
            this.Name = "formItemEdit";
            this.Text = "Edit Item";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.formItemEdit_FormClosing );
            this.Load += new System.EventHandler( this.formItemEdit_Load );
            this.panel1.ResumeLayout( false );
            this.panel1.PerformLayout();
            this.groupContainer.ResumeLayout( false );
            this.pnlContInfo.ResumeLayout( false );
            this.pnlContInfo.PerformLayout();
            this.groupItem.ResumeLayout( false );
            this.groupItem.PerformLayout();
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            ( (System.ComponentModel.ISupportInitialize)( this.pictItemIcon ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinIconIdx ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinQuantityCap ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinWeight ) ).EndInit();
            ( (System.ComponentModel.ISupportInitialize)( this.spinQuantity ) ).EndInit();
            this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupContainer;
		private System.Windows.Forms.GroupBox groupItem;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RichTextBox rtfDescription;
		private System.Windows.Forms.NumericUpDown spinQuantityCap;
		private System.Windows.Forms.NumericUpDown spinWeight;
		private System.Windows.Forms.NumericUpDown spinQuantity;
		private System.Windows.Forms.ComboBox comboHeight;
		private System.Windows.Forms.ComboBox comboWidth;
		private System.Windows.Forms.ComboBox comboDisabled;
		private System.Windows.Forms.Button buttType;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictItemIcon;
		private System.Windows.Forms.NumericUpDown spinIconIdx;
		private System.Windows.Forms.ComboBox comboContainer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel pnlContInfo;
		private System.Windows.Forms.TextBox textBox10;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button buttTypeAllowed;
		private System.Windows.Forms.TextBox textBox9;
		private System.Windows.Forms.TextBox textBox8;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox txtTypeAllowed;
		private System.Windows.Forms.CheckBox cbZoom;
        private System.Windows.Forms.Label label19;
	}
}