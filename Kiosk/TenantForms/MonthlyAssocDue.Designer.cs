namespace Tenancy_Management_Information_Systems.Kiosk.TenantForms
{
    partial class MonthlyAssocDue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthlyAssocDue));
            this.panel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.lblTotalWithVAT = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.lblAssocPenaltyAmount = new System.Windows.Forms.Label();
            this.lblAssocPenalty = new System.Windows.Forms.Label();
            this.lblWaterBillAmount = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.lblAssocDueAmount = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.lblAssocTime = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOtherPenaltyAmount = new System.Windows.Forms.Label();
            this.lblAssocOtherPenalty = new System.Windows.Forms.Label();
            this.lblWaterDisconnectionAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWaterOverdueAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.Controls.Add(this.lblWaterDisconnectionAmount);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.lblWaterOverdueAmount);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.lblOtherPenaltyAmount);
            this.panel.Controls.Add(this.lblAssocOtherPenalty);
            this.panel.Controls.Add(this.btnClose);
            this.panel.Controls.Add(this.lblDueDate);
            this.panel.Controls.Add(this.label90);
            this.panel.Controls.Add(this.lblTotalWithVAT);
            this.panel.Controls.Add(this.label86);
            this.panel.Controls.Add(this.lblVAT);
            this.panel.Controls.Add(this.lblTotalAmount);
            this.panel.Controls.Add(this.label83);
            this.panel.Controls.Add(this.label79);
            this.panel.Controls.Add(this.lblAssocPenaltyAmount);
            this.panel.Controls.Add(this.lblAssocPenalty);
            this.panel.Controls.Add(this.lblWaterBillAmount);
            this.panel.Controls.Add(this.label81);
            this.panel.Controls.Add(this.lblAssocDueAmount);
            this.panel.Controls.Add(this.label73);
            this.panel.Controls.Add(this.lblAssocTime);
            this.panel.Controls.Add(this.label23);
            this.panel.Controls.Add(this.label4);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(928, 486);
            this.panel.TabIndex = 123;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAssocDues_Paint);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(828, 432);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(70, 29);
            this.btnClose.TabIndex = 153;
            this.btnClose.Text = "    Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDueDate.Location = new System.Drawing.Point(258, 432);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(70, 15);
            this.lblDueDate.TabIndex = 151;
            this.lblDueDate.Text = "<due date>";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label90.Location = new System.Drawing.Point(11, 432);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(247, 15);
            this.label90.TabIndex = 150;
            this.label90.Text = "*Please settle your accounts on or before:";
            // 
            // lblTotalWithVAT
            // 
            this.lblTotalWithVAT.AutoSize = true;
            this.lblTotalWithVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWithVAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWithVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalWithVAT.Location = new System.Drawing.Point(621, 303);
            this.lblTotalWithVAT.Name = "lblTotalWithVAT";
            this.lblTotalWithVAT.Size = new System.Drawing.Size(92, 14);
            this.lblTotalWithVAT.TabIndex = 148;
            this.lblTotalWithVAT.Text = "<Total Amount>";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.Color.Transparent;
            this.label86.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label86.Location = new System.Drawing.Point(478, 303);
            this.label86.Name = "label86";
            this.label86.Padding = new System.Windows.Forms.Padding(1);
            this.label86.Size = new System.Drawing.Size(118, 16);
            this.label86.TabIndex = 147;
            this.label86.Text = "TOTAL AMOUNT DUE";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVAT.Location = new System.Drawing.Point(623, 289);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(56, 14);
            this.lblVAT.TabIndex = 146;
            this.lblVAT.Text = "<Amount>";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(621, 275);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(92, 14);
            this.lblTotalAmount.TabIndex = 145;
            this.lblTotalAmount.Text = "<Total Amount>";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label83.Location = new System.Drawing.Point(542, 289);
            this.label83.Name = "label83";
            this.label83.Padding = new System.Windows.Forms.Padding(1);
            this.label83.Size = new System.Drawing.Size(54, 16);
            this.label83.TabIndex = 144;
            this.label83.Text = "12% VAT";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.BackColor = System.Drawing.Color.Transparent;
            this.label79.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label79.Location = new System.Drawing.Point(551, 275);
            this.label79.Name = "label79";
            this.label79.Padding = new System.Windows.Forms.Padding(1);
            this.label79.Size = new System.Drawing.Size(45, 16);
            this.label79.TabIndex = 143;
            this.label79.Text = "TOTAL";
            // 
            // lblAssocPenaltyAmount
            // 
            this.lblAssocPenaltyAmount.AutoSize = true;
            this.lblAssocPenaltyAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAssocPenaltyAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssocPenaltyAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAssocPenaltyAmount.Location = new System.Drawing.Point(427, 141);
            this.lblAssocPenaltyAmount.Name = "lblAssocPenaltyAmount";
            this.lblAssocPenaltyAmount.Size = new System.Drawing.Size(56, 14);
            this.lblAssocPenaltyAmount.TabIndex = 142;
            this.lblAssocPenaltyAmount.Text = "<Amount>";
            // 
            // lblAssocPenalty
            // 
            this.lblAssocPenalty.AutoSize = true;
            this.lblAssocPenalty.BackColor = System.Drawing.Color.Transparent;
            this.lblAssocPenalty.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssocPenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAssocPenalty.Location = new System.Drawing.Point(170, 141);
            this.lblAssocPenalty.Name = "lblAssocPenalty";
            this.lblAssocPenalty.Size = new System.Drawing.Size(71, 14);
            this.lblAssocPenalty.TabIndex = 141;
            this.lblAssocPenalty.Text = "Overdue Fee";
            // 
            // lblWaterBillAmount
            // 
            this.lblWaterBillAmount.AutoSize = true;
            this.lblWaterBillAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblWaterBillAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterBillAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWaterBillAmount.Location = new System.Drawing.Point(428, 204);
            this.lblWaterBillAmount.Name = "lblWaterBillAmount";
            this.lblWaterBillAmount.Size = new System.Drawing.Size(56, 14);
            this.lblWaterBillAmount.TabIndex = 136;
            this.lblWaterBillAmount.Text = "<Amount>";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.BackColor = System.Drawing.Color.Transparent;
            this.label81.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label81.Location = new System.Drawing.Point(160, 191);
            this.label81.Name = "label81";
            this.label81.Padding = new System.Windows.Forms.Padding(1);
            this.label81.Size = new System.Drawing.Size(127, 16);
            this.label81.TabIndex = 132;
            this.label81.Text = "WATER CONSUMPTION";
            // 
            // lblAssocDueAmount
            // 
            this.lblAssocDueAmount.AutoSize = true;
            this.lblAssocDueAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssocDueAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAssocDueAmount.Location = new System.Drawing.Point(427, 122);
            this.lblAssocDueAmount.Name = "lblAssocDueAmount";
            this.lblAssocDueAmount.Size = new System.Drawing.Size(56, 14);
            this.lblAssocDueAmount.TabIndex = 128;
            this.lblAssocDueAmount.Text = "<Amount>";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BackColor = System.Drawing.Color.Transparent;
            this.label73.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label73.Location = new System.Drawing.Point(154, 99);
            this.label73.Name = "label73";
            this.label73.Padding = new System.Windows.Forms.Padding(1);
            this.label73.Size = new System.Drawing.Size(112, 16);
            this.label73.TabIndex = 126;
            this.label73.Text = "ASSOCIATION DUES";
            // 
            // lblAssocTime
            // 
            this.lblAssocTime.AutoSize = true;
            this.lblAssocTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssocTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAssocTime.Location = new System.Drawing.Point(402, 68);
            this.lblAssocTime.Name = "lblAssocTime";
            this.lblAssocTime.Size = new System.Drawing.Size(85, 15);
            this.lblAssocTime.TabIndex = 124;
            this.lblAssocTime.Text = "<month/year>";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(345, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(202, 18);
            this.label23.TabIndex = 123;
            this.label23.Text = "STATEMENT OF ACCOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(332, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 18);
            this.label4.TabIndex = 122;
            this.label4.Text = "MONTHLY ASSOCIATION DUES";
            // 
            // lblOtherPenaltyAmount
            // 
            this.lblOtherPenaltyAmount.AutoSize = true;
            this.lblOtherPenaltyAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblOtherPenaltyAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtherPenaltyAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblOtherPenaltyAmount.Location = new System.Drawing.Point(427, 159);
            this.lblOtherPenaltyAmount.Name = "lblOtherPenaltyAmount";
            this.lblOtherPenaltyAmount.Size = new System.Drawing.Size(56, 14);
            this.lblOtherPenaltyAmount.TabIndex = 157;
            this.lblOtherPenaltyAmount.Text = "<Amount>";
            // 
            // lblAssocOtherPenalty
            // 
            this.lblAssocOtherPenalty.AutoSize = true;
            this.lblAssocOtherPenalty.BackColor = System.Drawing.Color.Transparent;
            this.lblAssocOtherPenalty.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssocOtherPenalty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAssocOtherPenalty.Location = new System.Drawing.Point(170, 159);
            this.lblAssocOtherPenalty.Name = "lblAssocOtherPenalty";
            this.lblAssocOtherPenalty.Size = new System.Drawing.Size(96, 14);
            this.lblAssocOtherPenalty.TabIndex = 156;
            this.lblAssocOtherPenalty.Text = "Other Penalty Fee";
            // 
            // lblWaterDisconnectionAmount
            // 
            this.lblWaterDisconnectionAmount.AutoSize = true;
            this.lblWaterDisconnectionAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblWaterDisconnectionAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterDisconnectionAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWaterDisconnectionAmount.Location = new System.Drawing.Point(428, 238);
            this.lblWaterDisconnectionAmount.Name = "lblWaterDisconnectionAmount";
            this.lblWaterDisconnectionAmount.Size = new System.Drawing.Size(56, 14);
            this.lblWaterDisconnectionAmount.TabIndex = 161;
            this.lblWaterDisconnectionAmount.Text = "<Amount>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(170, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 14);
            this.label2.TabIndex = 160;
            this.label2.Text = "Disconnection Fee";
            // 
            // lblWaterOverdueAmount
            // 
            this.lblWaterOverdueAmount.AutoSize = true;
            this.lblWaterOverdueAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblWaterOverdueAmount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaterOverdueAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWaterOverdueAmount.Location = new System.Drawing.Point(428, 220);
            this.lblWaterOverdueAmount.Name = "lblWaterOverdueAmount";
            this.lblWaterOverdueAmount.Size = new System.Drawing.Size(56, 14);
            this.lblWaterOverdueAmount.TabIndex = 159;
            this.lblWaterOverdueAmount.Text = "<Amount>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(170, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 14);
            this.label5.TabIndex = 158;
            this.label5.Text = "Overdue Fee";
            // 
            // MonthlyAssocDue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 486);
            this.Controls.Add(this.panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyAssocDue";
            this.Text = "MonthlyAssocDue";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label lblTotalWithVAT;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label lblAssocPenaltyAmount;
        private System.Windows.Forms.Label lblAssocPenalty;
        private System.Windows.Forms.Label lblWaterBillAmount;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label lblAssocDueAmount;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label lblAssocTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOtherPenaltyAmount;
        private System.Windows.Forms.Label lblAssocOtherPenalty;
        private System.Windows.Forms.Label lblWaterDisconnectionAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWaterOverdueAmount;
        private System.Windows.Forms.Label label5;
    }
}