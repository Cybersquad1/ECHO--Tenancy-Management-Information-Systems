namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    partial class AvailableUnitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvailableUnitForm));
            this.unitPnl = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewUnits = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.txtBoxNatureOfOccupancy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTransferOwnership = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtBoxFloor = new System.Windows.Forms.TextBox();
            this.txtBoxAvailability = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxUnitOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUnitNumber = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewUnitSearch = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label49 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBoxFloor = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.comboBoxAvailability = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txtBoxUnitNoSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxTenant = new System.Windows.Forms.TextBox();
            this.btnSelectTenant = new System.Windows.Forms.Button();
            this.unitPnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // unitPnl
            // 
            this.unitPnl.Controls.Add(this.groupBox1);
            this.unitPnl.Controls.Add(this.groupBox2);
            this.unitPnl.Controls.Add(this.btnExport);
            this.unitPnl.Controls.Add(this.button2);
            this.unitPnl.Location = new System.Drawing.Point(10, 10);
            this.unitPnl.Name = "unitPnl";
            this.unitPnl.Size = new System.Drawing.Size(967, 548);
            this.unitPnl.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(216, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 498);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Units";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(12, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 28);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "     Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 437);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewUnits);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewUnits
            // 
            this.listViewUnits.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewUnits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewUnits.FullRowSelect = true;
            this.listViewUnits.GridLines = true;
            this.listViewUnits.Location = new System.Drawing.Point(3, 2);
            this.listViewUnits.MultiSelect = false;
            this.listViewUnits.Name = "listViewUnits";
            this.listViewUnits.Size = new System.Drawing.Size(710, 357);
            this.listViewUnits.TabIndex = 1;
            this.listViewUnits.UseCompatibleStateImageBehavior = false;
            this.listViewUnits.View = System.Windows.Forms.View.Details;
            this.listViewUnits.DoubleClick += new System.EventHandler(this.listViewUnits_DoubleClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Unit Number";
            this.columnHeader1.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Availability";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit Floor";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Type";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 137;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Unit Owner";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 172;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tenant";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 90;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSelectTenant);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.btnTransferOwnership);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unit Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxTenant);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.datePickerEnd);
            this.groupBox4.Controls.Add(this.datePickerStart);
            this.groupBox4.Controls.Add(this.txtBoxNatureOfOccupancy);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(187, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(423, 141);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tenant:";
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.CustomFormat = "mm/dd/yyyy";
            this.datePickerEnd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerEnd.Location = new System.Drawing.Point(143, 53);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(123, 20);
            this.datePickerEnd.TabIndex = 124;
            // 
            // datePickerStart
            // 
            this.datePickerStart.CustomFormat = "mm/dd/yyyy";
            this.datePickerStart.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerStart.Location = new System.Drawing.Point(143, 28);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(123, 20);
            this.datePickerStart.TabIndex = 123;
            // 
            // txtBoxNatureOfOccupancy
            // 
            this.txtBoxNatureOfOccupancy.Enabled = false;
            this.txtBoxNatureOfOccupancy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNatureOfOccupancy.Location = new System.Drawing.Point(143, 79);
            this.txtBoxNatureOfOccupancy.Name = "txtBoxNatureOfOccupancy";
            this.txtBoxNatureOfOccupancy.Size = new System.Drawing.Size(253, 20);
            this.txtBoxNatureOfOccupancy.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nature Of Occupancy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "End Of Occupancy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Of Occupancy:";
            // 
            // btnTransferOwnership
            // 
            this.btnTransferOwnership.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferOwnership.Location = new System.Drawing.Point(454, 350);
            this.btnTransferOwnership.Name = "btnTransferOwnership";
            this.btnTransferOwnership.Size = new System.Drawing.Size(156, 24);
            this.btnTransferOwnership.TabIndex = 18;
            this.btnTransferOwnership.Text = "Transfer Ownership";
            this.btnTransferOwnership.UseVisualStyleBackColor = true;
            this.btnTransferOwnership.Click += new System.EventHandler(this.btnTransferOwnership_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtBoxType);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label29);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label32);
            this.groupBox6.Controls.Add(this.txtBoxFloor);
            this.groupBox6.Controls.Add(this.txtBoxAvailability);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(187, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(423, 112);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            // 
            // txtBoxType
            // 
            this.txtBoxType.Enabled = false;
            this.txtBoxType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxType.Location = new System.Drawing.Point(123, 68);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.Size = new System.Drawing.Size(273, 20);
            this.txtBoxType.TabIndex = 121;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(41, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 120;
            this.label3.Text = "Availability:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label29.Location = new System.Drawing.Point(54, 71);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(63, 13);
            this.label29.TabIndex = 116;
            this.label29.Text = "Unit Type:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label31.Location = new System.Drawing.Point(50, 45);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 13);
            this.label31.TabIndex = 114;
            this.label31.Text = "Unit Floor:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label32.Location = new System.Drawing.Point(50, 21);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(0, 13);
            this.label32.TabIndex = 113;
            // 
            // txtBoxFloor
            // 
            this.txtBoxFloor.Enabled = false;
            this.txtBoxFloor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFloor.Location = new System.Drawing.Point(123, 42);
            this.txtBoxFloor.Name = "txtBoxFloor";
            this.txtBoxFloor.Size = new System.Drawing.Size(273, 20);
            this.txtBoxFloor.TabIndex = 4;
            // 
            // txtBoxAvailability
            // 
            this.txtBoxAvailability.Enabled = false;
            this.txtBoxAvailability.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAvailability.Location = new System.Drawing.Point(123, 18);
            this.txtBoxAvailability.Name = "txtBoxAvailability";
            this.txtBoxAvailability.Size = new System.Drawing.Size(273, 20);
            this.txtBoxAvailability.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxUnitOwner);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxUnitNumber);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Location = new System.Drawing.Point(187, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 65);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtBoxUnitOwner
            // 
            this.txtBoxUnitOwner.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxUnitOwner.Enabled = false;
            this.txtBoxUnitOwner.Location = new System.Drawing.Point(91, 33);
            this.txtBoxUnitOwner.Name = "txtBoxUnitOwner";
            this.txtBoxUnitOwner.Size = new System.Drawing.Size(305, 20);
            this.txtBoxUnitOwner.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unit Owner:";
            // 
            // txtBoxUnitNumber
            // 
            this.txtBoxUnitNumber.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxUnitNumber.Enabled = false;
            this.txtBoxUnitNumber.Location = new System.Drawing.Point(91, 11);
            this.txtBoxUnitNumber.Name = "txtBoxUnitNumber";
            this.txtBoxUnitNumber.Size = new System.Drawing.Size(305, 20);
            this.txtBoxUnitNumber.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(7, 14);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 14);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Unit Number:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewUnitSearch);
            this.groupBox2.Controls.Add(this.label49);
            this.groupBox2.Controls.Add(this.comboBoxType);
            this.groupBox2.Controls.Add(this.comboBoxFloor);
            this.groupBox2.Controls.Add(this.label50);
            this.groupBox2.Controls.Add(this.comboBoxAvailability);
            this.groupBox2.Controls.Add(this.label48);
            this.groupBox2.Controls.Add(this.txtBoxUnitNoSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 555);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View Avalable/Occupied Units";
            // 
            // listViewUnitSearch
            // 
            this.listViewUnitSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewUnitSearch.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listViewUnitSearch.FullRowSelect = true;
            this.listViewUnitSearch.GridLines = true;
            this.listViewUnitSearch.Location = new System.Drawing.Point(0, 129);
            this.listViewUnitSearch.Name = "listViewUnitSearch";
            this.listViewUnitSearch.Size = new System.Drawing.Size(203, 415);
            this.listViewUnitSearch.TabIndex = 2;
            this.listViewUnitSearch.UseCompatibleStateImageBehavior = false;
            this.listViewUnitSearch.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Unit Number";
            this.columnHeader7.Width = 81;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Unit Owner/Tenant";
            this.columnHeader8.Width = 135;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(111, 89);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 14);
            this.label49.TabIndex = 56;
            this.label49.Text = "Unit Type:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "One Bedroom ",
            "Two Bedroom ",
            "Studio Type",
            "Bachelor\'s Pad"});
            this.comboBoxType.Location = new System.Drawing.Point(96, 104);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(105, 22);
            this.comboBoxType.TabIndex = 55;
            // 
            // comboBoxFloor
            // 
            this.comboBoxFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFloor.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxFloor.FormattingEnabled = true;
            this.comboBoxFloor.Items.AddRange(new object[] {
            "2",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.comboBoxFloor.Location = new System.Drawing.Point(3, 104);
            this.comboBoxFloor.Name = "comboBoxFloor";
            this.comboBoxFloor.Size = new System.Drawing.Size(87, 22);
            this.comboBoxFloor.TabIndex = 53;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(12, 89);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(62, 14);
            this.label50.TabIndex = 54;
            this.label50.Text = "Unit Floor:";
            // 
            // comboBoxAvailability
            // 
            this.comboBoxAvailability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAvailability.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAvailability.FormattingEnabled = true;
            this.comboBoxAvailability.Items.AddRange(new object[] {
            "Available",
            "Occupied"});
            this.comboBoxAvailability.Location = new System.Drawing.Point(3, 64);
            this.comboBoxAvailability.Name = "comboBoxAvailability";
            this.comboBoxAvailability.Size = new System.Drawing.Size(199, 22);
            this.comboBoxAvailability.TabIndex = 46;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(6, 47);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(68, 14);
            this.label48.TabIndex = 45;
            this.label48.Text = "Availability:";
            // 
            // txtBoxUnitNoSearch
            // 
            this.txtBoxUnitNoSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUnitNoSearch.Location = new System.Drawing.Point(93, 21);
            this.txtBoxUnitNoSearch.Multiline = true;
            this.txtBoxUnitNoSearch.Name = "txtBoxUnitNoSearch";
            this.txtBoxUnitNoSearch.Size = new System.Drawing.Size(86, 21);
            this.txtBoxUnitNoSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Tenancy_Management_Information_Systems.Properties.Resources.magnifying_glass34;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(177, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(749, 508);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 33);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(861, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "    Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxTenant
            // 
            this.txtBoxTenant.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxTenant.Enabled = false;
            this.txtBoxTenant.Location = new System.Drawing.Point(143, 105);
            this.txtBoxTenant.Name = "txtBoxTenant";
            this.txtBoxTenant.Size = new System.Drawing.Size(253, 21);
            this.txtBoxTenant.TabIndex = 5;
            // 
            // btnSelectTenant
            // 
            this.btnSelectTenant.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectTenant.Location = new System.Drawing.Point(187, 350);
            this.btnSelectTenant.Name = "btnSelectTenant";
            this.btnSelectTenant.Size = new System.Drawing.Size(156, 24);
            this.btnSelectTenant.TabIndex = 20;
            this.btnSelectTenant.Text = "Select Tenant";
            this.btnSelectTenant.UseVisualStyleBackColor = true;
            // 
            // AvailableUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(986, 568);
            this.Controls.Add(this.unitPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(352, 141);
            this.Name = "AvailableUnitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AvailableUnitForm";
            this.unitPnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel unitPnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewUnits;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUnitOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUnitNumber;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewUnitSearch;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.TextBox txtBoxUnitNoSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBoxFloor;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox comboBoxAvailability;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtBoxFloor;
        private System.Windows.Forms.TextBox txtBoxAvailability;
        private System.Windows.Forms.Button btnTransferOwnership;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxNatureOfOccupancy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxTenant;
        private System.Windows.Forms.Button btnSelectTenant;
    }
}