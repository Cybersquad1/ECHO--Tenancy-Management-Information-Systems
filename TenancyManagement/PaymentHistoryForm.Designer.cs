namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    partial class PaymentHistoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentHistoryForm));
            this.paymentHistoryPnl = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewMonthlyAssoc = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listViewWaterBilling = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBoxTenant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxUnitOwner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUnitNo = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewUnit = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.paymentHistoryPnl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paymentHistoryPnl
            // 
            this.paymentHistoryPnl.Controls.Add(this.groupBox1);
            this.paymentHistoryPnl.Controls.Add(this.groupBox2);
            this.paymentHistoryPnl.Controls.Add(this.btnExport);
            this.paymentHistoryPnl.Controls.Add(this.btnCancel);
            this.paymentHistoryPnl.Location = new System.Drawing.Point(10, 10);
            this.paymentHistoryPnl.Name = "paymentHistoryPnl";
            this.paymentHistoryPnl.Size = new System.Drawing.Size(967, 557);
            this.paymentHistoryPnl.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(216, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 498);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment History";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(8, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 387);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewMonthlyAssoc);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monthly Association Dues";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewMonthlyAssoc
            // 
            this.listViewMonthlyAssoc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewMonthlyAssoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader16});
            this.listViewMonthlyAssoc.GridLines = true;
            this.listViewMonthlyAssoc.Location = new System.Drawing.Point(3, 3);
            this.listViewMonthlyAssoc.Name = "listViewMonthlyAssoc";
            this.listViewMonthlyAssoc.Size = new System.Drawing.Size(710, 357);
            this.listViewMonthlyAssoc.TabIndex = 1;
            this.listViewMonthlyAssoc.UseCompatibleStateImageBehavior = false;
            this.listViewMonthlyAssoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tenant Charge Date";
            this.columnHeader9.Width = 136;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Association Dues";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 132;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Penalties";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 176;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Discounts";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 175;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Total Amount Due";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listViewWaterBilling);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Water Billing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listViewWaterBilling
            // 
            this.listViewWaterBilling.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewWaterBilling.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader6});
            this.listViewWaterBilling.GridLines = true;
            this.listViewWaterBilling.Location = new System.Drawing.Point(3, 2);
            this.listViewWaterBilling.Name = "listViewWaterBilling";
            this.listViewWaterBilling.Size = new System.Drawing.Size(710, 357);
            this.listViewWaterBilling.TabIndex = 0;
            this.listViewWaterBilling.UseCompatibleStateImageBehavior = false;
            this.listViewWaterBilling.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tenant Charge Date";
            this.columnHeader1.Width = 142;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Reading";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 122;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total Amount Due";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 159;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBoxTenant);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtBoxUnitOwner);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtBoxUnitNo);
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Location = new System.Drawing.Point(8, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 83);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
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
            // txtBoxUnitNo
            // 
            this.txtBoxUnitNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBoxUnitNo.Enabled = false;
            this.txtBoxUnitNo.Location = new System.Drawing.Point(91, 11);
            this.txtBoxUnitNo.Name = "txtBoxUnitNo";
            this.txtBoxUnitNo.Size = new System.Drawing.Size(239, 20);
            this.txtBoxUnitNo.TabIndex = 1;
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
            this.groupBox2.Controls.Add(this.listViewUnit);
            this.groupBox2.Controls.Add(this.txtBoxSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 555);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // listViewUnit
            // 
            this.listViewUnit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewUnit.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7});
            this.listViewUnit.FullRowSelect = true;
            this.listViewUnit.GridLines = true;
            this.listViewUnit.Location = new System.Drawing.Point(4, 50);
            this.listViewUnit.Name = "listViewUnit";
            this.listViewUnit.Size = new System.Drawing.Size(203, 491);
            this.listViewUnit.TabIndex = 2;
            this.listViewUnit.UseCompatibleStateImageBehavior = false;
            this.listViewUnit.View = System.Windows.Forms.View.Details;
            this.listViewUnit.DoubleClick += new System.EventHandler(this.listViewUnit_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Unit Number";
            this.columnHeader7.Width = 81;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearch.Location = new System.Drawing.Point(98, 21);
            this.txtBoxSearch.Multiline = true;
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(86, 21);
            this.txtBoxSearch.TabIndex = 1;
            this.txtBoxSearch.Text = "Unit Number";
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Tenancy_Management_Information_Systems.Properties.Resources.magnifying_glass34;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(182, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(749, 503);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(106, 33);
            this.btnExport.TabIndex = 18;
            this.btnExport.Text = "Preview";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(861, 503);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "    Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PaymentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(986, 568);
            this.Controls.Add(this.paymentHistoryPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(352, 141);
            this.Name = "PaymentHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PaymentHistoryForm";
            this.paymentHistoryPnl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel paymentHistoryPnl;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewUnit;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtBoxTenant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxUnitOwner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUnitNo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ListView listViewWaterBilling;
        private System.Windows.Forms.ListView listViewMonthlyAssoc;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}