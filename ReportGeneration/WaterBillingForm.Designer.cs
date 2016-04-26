namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    partial class WaterBillingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterBillingForm));
            this.waterBillingPnl = new System.Windows.Forms.Panel();
            this.btnUserCreate = new System.Windows.Forms.Button();
            this.btnUserCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeDueDate = new System.Windows.Forms.DateTimePicker();
            this.listViewFee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxChargeDate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxDisconnectionFee = new System.Windows.Forms.CheckBox();
            this.checkBoxOverdue = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxBillAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxCurrentReading = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtBoxTotalAmountDue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.listViewPreviousBalance = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBoxPreviousBillAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPreviousReading = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbBoxUnitNo = new System.Windows.Forms.ComboBox();
            this.txtBoxTenant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUnitOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.waterBillingPnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // waterBillingPnl
            // 
            this.waterBillingPnl.Controls.Add(this.btnUserCreate);
            this.waterBillingPnl.Controls.Add(this.btnUserCancel);
            this.waterBillingPnl.Controls.Add(this.groupBox1);
            this.waterBillingPnl.Location = new System.Drawing.Point(2, 1);
            this.waterBillingPnl.Name = "waterBillingPnl";
            this.waterBillingPnl.Size = new System.Drawing.Size(779, 533);
            this.waterBillingPnl.TabIndex = 0;
            // 
            // btnUserCreate
            // 
            this.btnUserCreate.Enabled = false;
            this.btnUserCreate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnUserCreate.Image")));
            this.btnUserCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserCreate.Location = new System.Drawing.Point(571, 489);
            this.btnUserCreate.Name = "btnUserCreate";
            this.btnUserCreate.Size = new System.Drawing.Size(92, 33);
            this.btnUserCreate.TabIndex = 23;
            this.btnUserCreate.Text = "    Update";
            this.btnUserCreate.UseVisualStyleBackColor = true;
            // 
            // btnUserCancel
            // 
            this.btnUserCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnUserCancel.Image")));
            this.btnUserCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserCancel.Location = new System.Drawing.Point(669, 489);
            this.btnUserCancel.Name = "btnUserCancel";
            this.btnUserCancel.Size = new System.Drawing.Size(92, 33);
            this.btnUserCancel.TabIndex = 24;
            this.btnUserCancel.Text = "    Cancel";
            this.btnUserCancel.UseVisualStyleBackColor = true;
            this.btnUserCancel.Click += new System.EventHandler(this.btnUserCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimeDueDate);
            this.groupBox1.Controls.Add(this.listViewFee);
            this.groupBox1.Controls.Add(this.txtBoxChargeDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 477);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Bill Due Date:";
            // 
            // dateTimeDueDate
            // 
            this.dateTimeDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDueDate.Location = new System.Drawing.Point(455, 111);
            this.dateTimeDueDate.Name = "dateTimeDueDate";
            this.dateTimeDueDate.Size = new System.Drawing.Size(223, 20);
            this.dateTimeDueDate.TabIndex = 15;
            // 
            // listViewFee
            // 
            this.listViewFee.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewFee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFee.FullRowSelect = true;
            this.listViewFee.GridLines = true;
            this.listViewFee.Location = new System.Drawing.Point(8, 372);
            this.listViewFee.Name = "listViewFee";
            this.listViewFee.Size = new System.Drawing.Size(725, 85);
            this.listViewFee.TabIndex = 0;
            this.listViewFee.UseCompatibleStateImageBehavior = false;
            this.listViewFee.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tenant Charge Date";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Unit Number";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Previous Reading";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Current Reading";
            this.columnHeader4.Width = 119;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Amount Due";
            this.columnHeader5.Width = 201;
            // 
            // txtBoxChargeDate
            // 
            this.txtBoxChargeDate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxChargeDate.Enabled = false;
            this.txtBoxChargeDate.Location = new System.Drawing.Point(138, 111);
            this.txtBoxChargeDate.Name = "txtBoxChargeDate";
            this.txtBoxChargeDate.Size = new System.Drawing.Size(200, 20);
            this.txtBoxChargeDate.TabIndex = 6;
            this.txtBoxChargeDate.Text = "Date Today";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tenant Charge Date:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.checkBoxDisconnectionFee);
            this.groupBox5.Controls.Add(this.checkBoxOverdue);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.txtBoxBillAmount);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.txtBoxCurrentReading);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Controls.Add(this.txtBoxTotalAmountDue);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.listViewPreviousBalance);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.dateTimeTo);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.dateTimeFrom);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.shapeContainer1);
            this.groupBox5.Location = new System.Drawing.Point(8, 138);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(725, 232);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tenancy_Management_Information_Systems.Properties.Resources.danger;
            this.pictureBox1.Location = new System.Drawing.Point(11, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxDisconnectionFee
            // 
            this.checkBoxDisconnectionFee.AutoSize = true;
            this.checkBoxDisconnectionFee.Enabled = false;
            this.checkBoxDisconnectionFee.Location = new System.Drawing.Point(136, 175);
            this.checkBoxDisconnectionFee.Name = "checkBoxDisconnectionFee";
            this.checkBoxDisconnectionFee.Size = new System.Drawing.Size(127, 18);
            this.checkBoxDisconnectionFee.TabIndex = 35;
            this.checkBoxDisconnectionFee.Text = "Disconnection Fee";
            this.checkBoxDisconnectionFee.UseVisualStyleBackColor = true;
            this.checkBoxDisconnectionFee.CheckedChanged += new System.EventHandler(this.checkBoxDisconnectionFee_CheckedChanged);
            // 
            // checkBoxOverdue
            // 
            this.checkBoxOverdue.AutoSize = true;
            this.checkBoxOverdue.Enabled = false;
            this.checkBoxOverdue.Location = new System.Drawing.Point(136, 158);
            this.checkBoxOverdue.Name = "checkBoxOverdue";
            this.checkBoxOverdue.Size = new System.Drawing.Size(73, 18);
            this.checkBoxOverdue.TabIndex = 34;
            this.checkBoxOverdue.Text = "Overdue";
            this.checkBoxOverdue.UseVisualStyleBackColor = true;
            this.checkBoxOverdue.CheckedChanged += new System.EventHandler(this.checkBoxOverdue_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(29, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 14);
            this.label13.TabIndex = 33;
            this.label13.Text = "Penalties:";
            // 
            // txtBoxBillAmount
            // 
            this.txtBoxBillAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxBillAmount.Location = new System.Drawing.Point(134, 127);
            this.txtBoxBillAmount.Name = "txtBoxBillAmount";
            this.txtBoxBillAmount.Size = new System.Drawing.Size(193, 20);
            this.txtBoxBillAmount.TabIndex = 32;
            this.txtBoxBillAmount.TextChanged += new System.EventHandler(this.txtBoxBillAmount_TextChanged);
            this.txtBoxBillAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxBillAmount_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 14);
            this.label9.TabIndex = 31;
            this.label9.Text = "Bill Amount:";
            // 
            // txtBoxCurrentReading
            // 
            this.txtBoxCurrentReading.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxCurrentReading.Location = new System.Drawing.Point(134, 106);
            this.txtBoxCurrentReading.Name = "txtBoxCurrentReading";
            this.txtBoxCurrentReading.Size = new System.Drawing.Size(193, 20);
            this.txtBoxCurrentReading.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 30;
            this.label6.Text = "Current Reading:";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(5, 76);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(334, 126);
            this.groupBox6.TabIndex = 37;
            this.groupBox6.TabStop = false;
            // 
            // txtBoxTotalAmountDue
            // 
            this.txtBoxTotalAmountDue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBoxTotalAmountDue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalAmountDue.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBoxTotalAmountDue.Location = new System.Drawing.Point(568, 205);
            this.txtBoxTotalAmountDue.Name = "txtBoxTotalAmountDue";
            this.txtBoxTotalAmountDue.Size = new System.Drawing.Size(144, 21);
            this.txtBoxTotalAmountDue.TabIndex = 26;
            this.txtBoxTotalAmountDue.Text = "0.00";
            this.txtBoxTotalAmountDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(565, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 16);
            this.label15.TabIndex = 25;
            this.label15.Text = "TOTAL AMOUNT DUE:";
            // 
            // listViewPreviousBalance
            // 
            this.listViewPreviousBalance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9});
            this.listViewPreviousBalance.GridLines = true;
            this.listViewPreviousBalance.Location = new System.Drawing.Point(404, 33);
            this.listViewPreviousBalance.Name = "listViewPreviousBalance";
            this.listViewPreviousBalance.Size = new System.Drawing.Size(308, 128);
            this.listViewPreviousBalance.TabIndex = 24;
            this.listViewPreviousBalance.UseCompatibleStateImageBehavior = false;
            this.listViewPreviousBalance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date";
            this.columnHeader8.Width = 138;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Amount";
            this.columnHeader9.Width = 163;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(407, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 14);
            this.label14.TabIndex = 23;
            this.label14.Text = "Previous Balance(s):";
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(204, 29);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(126, 20);
            this.dateTimeTo.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(178, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 14);
            this.label12.TabIndex = 17;
            this.label12.Text = "To:";
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(47, 29);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(113, 20);
            this.dateTimeFrom.TabIndex = 11;
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "From:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(118, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 14);
            this.label10.TabIndex = 15;
            this.label10.Text = "Consumption Date";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(719, 213);
            this.shapeContainer1.TabIndex = 22;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 342;
            this.lineShape2.X2 = 342;
            this.lineShape2.Y1 = -26;
            this.lineShape2.Y2 = 206;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxPreviousBillAmount);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtBoxPreviousReading);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(356, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 84);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // txtBoxPreviousBillAmount
            // 
            this.txtBoxPreviousBillAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxPreviousBillAmount.Enabled = false;
            this.txtBoxPreviousBillAmount.Location = new System.Drawing.Point(139, 34);
            this.txtBoxPreviousBillAmount.Name = "txtBoxPreviousBillAmount";
            this.txtBoxPreviousBillAmount.Size = new System.Drawing.Size(222, 20);
            this.txtBoxPreviousBillAmount.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Previous Bill Amount:";
            // 
            // txtBoxPreviousReading
            // 
            this.txtBoxPreviousReading.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxPreviousReading.Enabled = false;
            this.txtBoxPreviousReading.Location = new System.Drawing.Point(139, 11);
            this.txtBoxPreviousReading.Name = "txtBoxPreviousReading";
            this.txtBoxPreviousReading.Size = new System.Drawing.Size(222, 20);
            this.txtBoxPreviousReading.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "Previous Reading:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.cmbBoxUnitNo);
            this.groupBox3.Controls.Add(this.txtBoxTenant);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtBoxUnitOwner);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(8, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 83);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // cmbBoxUnitNo
            // 
            this.cmbBoxUnitNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUnitNo.FormattingEnabled = true;
            this.cmbBoxUnitNo.Location = new System.Drawing.Point(91, 8);
            this.cmbBoxUnitNo.Name = "cmbBoxUnitNo";
            this.cmbBoxUnitNo.Size = new System.Drawing.Size(239, 22);
            this.cmbBoxUnitNo.TabIndex = 6;
            this.cmbBoxUnitNo.SelectedIndexChanged += new System.EventHandler(this.cmbBoxUnitNo_SelectedIndexChanged);
            // 
            // txtBoxTenant
            // 
            this.txtBoxTenant.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxTenant.Enabled = false;
            this.txtBoxTenant.Location = new System.Drawing.Point(91, 55);
            this.txtBoxTenant.Name = "txtBoxTenant";
            this.txtBoxTenant.Size = new System.Drawing.Size(239, 20);
            this.txtBoxTenant.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tenant:";
            // 
            // txtBoxUnitOwner
            // 
            this.txtBoxUnitOwner.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxUnitOwner.Enabled = false;
            this.txtBoxUnitOwner.Location = new System.Drawing.Point(91, 33);
            this.txtBoxUnitOwner.Name = "txtBoxUnitOwner";
            this.txtBoxUnitOwner.Size = new System.Drawing.Size(239, 20);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(539, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 38;
            this.label7.Text = "PHP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 14);
            this.label16.TabIndex = 7;
            this.label16.Text = "Unit Number:";
            // 
            // WaterBillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(783, 539);
            this.Controls.Add(this.waterBillingPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(352, 141);
            this.Name = "WaterBillingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WaterBillingForm";
            this.waterBillingPnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel waterBillingPnl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxPreviousBillAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxPreviousReading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUnitOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxChargeDate;
        private System.Windows.Forms.Label label8;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ListView listViewFee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtBoxTotalAmountDue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListView listViewPreviousBalance;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnUserCreate;
        private System.Windows.Forms.Button btnUserCancel;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeDueDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxDisconnectionFee;
        private System.Windows.Forms.CheckBox checkBoxOverdue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxBillAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxCurrentReading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbBoxUnitNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label16;
    }
}