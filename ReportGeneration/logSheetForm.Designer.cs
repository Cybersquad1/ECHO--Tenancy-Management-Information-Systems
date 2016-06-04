namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    partial class logSheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logSheetForm));
            this.logPnl = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstViewLogSheetRequest = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxAddItem = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxAddQuantity = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnModifyClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnModifyAdd = new System.Windows.Forms.Button();
            this.cmbBoxModifyItem = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxModifyQuantity = new System.Windows.Forms.TextBox();
            this.lstViewItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxPurpose = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxReceivedBy = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLogClear = new System.Windows.Forms.Button();
            this.btnLogAdd = new System.Windows.Forms.Button();
            this.txtBoxArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxPieces = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBoxItem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxDateToday = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logPnl.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logPnl
            // 
            this.logPnl.Controls.Add(this.btnCancel);
            this.logPnl.Controls.Add(this.tabControl1);
            this.logPnl.Controls.Add(this.groupBox1);
            this.logPnl.Location = new System.Drawing.Point(12, 12);
            this.logPnl.Name = "logPnl";
            this.logPnl.Size = new System.Drawing.Size(962, 529);
            this.logPnl.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(876, 488);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 33);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "    Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 163);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(955, 301);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstViewLogSheetRequest);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(947, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log Sheet Activity";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstViewLogSheetRequest
            // 
            this.lstViewLogSheetRequest.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstViewLogSheetRequest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstViewLogSheetRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewLogSheetRequest.FullRowSelect = true;
            this.lstViewLogSheetRequest.GridLines = true;
            this.lstViewLogSheetRequest.Location = new System.Drawing.Point(3, 3);
            this.lstViewLogSheetRequest.Name = "lstViewLogSheetRequest";
            this.lstViewLogSheetRequest.Size = new System.Drawing.Size(941, 268);
            this.lstViewLogSheetRequest.TabIndex = 3;
            this.lstViewLogSheetRequest.UseCompatibleStateImageBehavior = false;
            this.lstViewLogSheetRequest.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Date Issued";
            this.columnHeader6.Width = 86;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Item";
            this.columnHeader7.Width = 89;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Balance/Pieces";
            this.columnHeader5.Width = 118;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Quantity";
            this.columnHeader8.Width = 65;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Purpose";
            this.columnHeader9.Width = 149;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Area";
            this.columnHeader10.Width = 136;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Issued By";
            this.columnHeader11.Width = 118;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Received By";
            this.columnHeader12.Width = 164;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lstViewItem);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(947, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log Sheet Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxAddItem);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtBoxAddQuantity);
            this.groupBox3.Location = new System.Drawing.Point(6, 144);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(368, 124);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add New Item";
            // 
            // txtBoxAddItem
            // 
            this.txtBoxAddItem.Location = new System.Drawing.Point(108, 19);
            this.txtBoxAddItem.Name = "txtBoxAddItem";
            this.txtBoxAddItem.Size = new System.Drawing.Size(232, 20);
            this.txtBoxAddItem.TabIndex = 113;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(281, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 23);
            this.btnClear.TabIndex = 114;
            this.btnClear.Text = "   Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 14);
            this.label14.TabIndex = 115;
            this.label14.Text = "Item:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(221, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 23);
            this.btnAdd.TabIndex = 113;
            this.btnAdd.Text = "   Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 14);
            this.label16.TabIndex = 117;
            this.label16.Text = "Quantity:";
            // 
            // txtBoxAddQuantity
            // 
            this.txtBoxAddQuantity.BackColor = System.Drawing.Color.White;
            this.txtBoxAddQuantity.Location = new System.Drawing.Point(108, 44);
            this.txtBoxAddQuantity.Name = "txtBoxAddQuantity";
            this.txtBoxAddQuantity.Size = new System.Drawing.Size(231, 20);
            this.txtBoxAddQuantity.TabIndex = 118;
            this.txtBoxAddQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAddQuantity_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnModifyClear);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnModifyAdd);
            this.groupBox2.Controls.Add(this.cmbBoxModifyItem);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBoxModifyQuantity);
            this.groupBox2.Location = new System.Drawing.Point(6, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 128);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modify Item";
            // 
            // btnModifyClear
            // 
            this.btnModifyClear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyClear.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyClear.Image")));
            this.btnModifyClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyClear.Location = new System.Drawing.Point(281, 99);
            this.btnModifyClear.Name = "btnModifyClear";
            this.btnModifyClear.Size = new System.Drawing.Size(59, 23);
            this.btnModifyClear.TabIndex = 114;
            this.btnModifyClear.Text = "   Clear";
            this.btnModifyClear.UseVisualStyleBackColor = true;
            this.btnModifyClear.Click += new System.EventHandler(this.btnModifyClear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 14);
            this.label10.TabIndex = 115;
            this.label10.Text = "Item:";
            // 
            // btnModifyAdd
            // 
            this.btnModifyAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyAdd.Location = new System.Drawing.Point(221, 99);
            this.btnModifyAdd.Name = "btnModifyAdd";
            this.btnModifyAdd.Size = new System.Drawing.Size(59, 23);
            this.btnModifyAdd.TabIndex = 113;
            this.btnModifyAdd.Text = "   Edit";
            this.btnModifyAdd.UseVisualStyleBackColor = true;
            this.btnModifyAdd.Click += new System.EventHandler(this.btnModifyAdd_Click);
            // 
            // cmbBoxModifyItem
            // 
            this.cmbBoxModifyItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxModifyItem.FormattingEnabled = true;
            this.cmbBoxModifyItem.Location = new System.Drawing.Point(106, 21);
            this.cmbBoxModifyItem.Name = "cmbBoxModifyItem";
            this.cmbBoxModifyItem.Size = new System.Drawing.Size(231, 22);
            this.cmbBoxModifyItem.TabIndex = 116;
            this.cmbBoxModifyItem.SelectedIndexChanged += new System.EventHandler(this.cmbBoxModifyItem_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 117;
            this.label9.Text = "Quantity:";
            // 
            // txtBoxModifyQuantity
            // 
            this.txtBoxModifyQuantity.BackColor = System.Drawing.Color.White;
            this.txtBoxModifyQuantity.Location = new System.Drawing.Point(106, 47);
            this.txtBoxModifyQuantity.Name = "txtBoxModifyQuantity";
            this.txtBoxModifyQuantity.Size = new System.Drawing.Size(231, 20);
            this.txtBoxModifyQuantity.TabIndex = 118;
            this.txtBoxModifyQuantity.TextChanged += new System.EventHandler(this.txtBoxModifyQuantity_TextChanged);
            this.txtBoxModifyQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxModifyQuantity_KeyPress);
            this.txtBoxModifyQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxModifyQuantity_KeyUp);
            // 
            // lstViewItem
            // 
            this.lstViewItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstViewItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstViewItem.FullRowSelect = true;
            this.lstViewItem.GridLines = true;
            this.lstViewItem.Location = new System.Drawing.Point(380, 16);
            this.lstViewItem.Name = "lstViewItem";
            this.lstViewItem.Size = new System.Drawing.Size(564, 252);
            this.lstViewItem.TabIndex = 119;
            this.lstViewItem.UseCompatibleStateImageBehavior = false;
            this.lstViewItem.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 112;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 78;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date Modified";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 141;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Last Modified By";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 260;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxPurpose);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtBoxReceivedBy);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnLogClear);
            this.groupBox1.Controls.Add(this.btnLogAdd);
            this.groupBox1.Controls.Add(this.txtBoxArea);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxPieces);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbBoxItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxDateToday);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log Sheet Information";
            // 
            // txtBoxPurpose
            // 
            this.txtBoxPurpose.Location = new System.Drawing.Point(512, 32);
            this.txtBoxPurpose.Name = "txtBoxPurpose";
            this.txtBoxPurpose.Size = new System.Drawing.Size(235, 20);
            this.txtBoxPurpose.TabIndex = 112;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 14);
            this.label8.TabIndex = 111;
            this.label8.Text = "Purpose:";
            // 
            // txtBoxReceivedBy
            // 
            this.txtBoxReceivedBy.Location = new System.Drawing.Point(512, 81);
            this.txtBoxReceivedBy.Name = "txtBoxReceivedBy";
            this.txtBoxReceivedBy.Size = new System.Drawing.Size(235, 20);
            this.txtBoxReceivedBy.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 14);
            this.label7.TabIndex = 109;
            this.label7.Text = "Received by: ";
            // 
            // btnLogClear
            // 
            this.btnLogClear.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogClear.Image = ((System.Drawing.Image)(resources.GetObject("btnLogClear.Image")));
            this.btnLogClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogClear.Location = new System.Drawing.Point(688, 129);
            this.btnLogClear.Name = "btnLogClear";
            this.btnLogClear.Size = new System.Drawing.Size(59, 23);
            this.btnLogClear.TabIndex = 108;
            this.btnLogClear.Text = "   Clear";
            this.btnLogClear.UseVisualStyleBackColor = true;
            this.btnLogClear.Click += new System.EventHandler(this.btnLogClear_Click);
            // 
            // btnLogAdd
            // 
            this.btnLogAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogAdd.Location = new System.Drawing.Point(628, 129);
            this.btnLogAdd.Name = "btnLogAdd";
            this.btnLogAdd.Size = new System.Drawing.Size(59, 23);
            this.btnLogAdd.TabIndex = 107;
            this.btnLogAdd.Text = "   Add";
            this.btnLogAdd.UseVisualStyleBackColor = true;
            this.btnLogAdd.Click += new System.EventHandler(this.btnLogAdd_Click);
            // 
            // txtBoxArea
            // 
            this.txtBoxArea.Location = new System.Drawing.Point(512, 55);
            this.txtBoxArea.Name = "txtBoxArea";
            this.txtBoxArea.Size = new System.Drawing.Size(235, 20);
            this.txtBoxArea.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(414, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Area:";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxQuantity.Enabled = false;
            this.txtBoxQuantity.Location = new System.Drawing.Point(104, 101);
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(231, 20);
            this.txtBoxQuantity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity:";
            // 
            // txtBoxPieces
            // 
            this.txtBoxPieces.Location = new System.Drawing.Point(104, 78);
            this.txtBoxPieces.Name = "txtBoxPieces";
            this.txtBoxPieces.Size = new System.Drawing.Size(231, 20);
            this.txtBoxPieces.TabIndex = 5;
            this.txtBoxPieces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPieces_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance/Pieces:";
            // 
            // cmbBoxItem
            // 
            this.cmbBoxItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxItem.FormattingEnabled = true;
            this.cmbBoxItem.Location = new System.Drawing.Point(104, 53);
            this.cmbBoxItem.Name = "cmbBoxItem";
            this.cmbBoxItem.Size = new System.Drawing.Size(231, 22);
            this.cmbBoxItem.TabIndex = 3;
            this.cmbBoxItem.SelectedIndexChanged += new System.EventHandler(this.cmbBoxItem_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item:";
            // 
            // txtBoxDateToday
            // 
            this.txtBoxDateToday.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxDateToday.Enabled = false;
            this.txtBoxDateToday.Location = new System.Drawing.Point(104, 30);
            this.txtBoxDateToday.Name = "txtBoxDateToday";
            this.txtBoxDateToday.Size = new System.Drawing.Size(231, 20);
            this.txtBoxDateToday.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Today:";
            // 
            // logSheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(986, 545);
            this.Controls.Add(this.logPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(352, 141);
            this.Name = "logSheetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.logPnl.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLogClear;
        private System.Windows.Forms.Button btnLogAdd;
        private System.Windows.Forms.TextBox txtBoxArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxPieces;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBoxItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxDateToday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView lstViewLogSheetRequest;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBoxReceivedBy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxModifyQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbBoxModifyItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxPurpose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModifyClear;
        private System.Windows.Forms.ListView lstViewItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnModifyAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxAddQuantity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.TextBox txtBoxAddItem;
        internal System.Windows.Forms.Panel logPnl;
    }
}