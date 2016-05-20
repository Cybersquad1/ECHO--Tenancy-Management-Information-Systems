namespace Tenancy_Management_Information_Systems.Kiosk.TenantForms
{
    partial class PaymentHistory
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
            this.pnlPaymentHistory = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listViewReservation = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listViewAssoc = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlPaymentHistory.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPaymentHistory
            // 
            this.pnlPaymentHistory.BackColor = System.Drawing.Color.White;
            this.pnlPaymentHistory.Controls.Add(this.label5);
            this.pnlPaymentHistory.Controls.Add(this.tabControl1);
            this.pnlPaymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPaymentHistory.Location = new System.Drawing.Point(0, 0);
            this.pnlPaymentHistory.Name = "pnlPaymentHistory";
            this.pnlPaymentHistory.Size = new System.Drawing.Size(916, 473);
            this.pnlPaymentHistory.TabIndex = 121;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(367, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 121;
            this.label5.Text = "PAYMENT HISTORY";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(890, 439);
            this.tabControl1.TabIndex = 121;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listViewReservation);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(882, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservation";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listViewReservation
            // 
            this.listViewReservation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewReservation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader16});
            this.listViewReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.listViewReservation.FullRowSelect = true;
            this.listViewReservation.GridLines = true;
            this.listViewReservation.Location = new System.Drawing.Point(3, 6);
            this.listViewReservation.Name = "listViewReservation";
            this.listViewReservation.Size = new System.Drawing.Size(880, 401);
            this.listViewReservation.TabIndex = 1;
            this.listViewReservation.UseCompatibleStateImageBehavior = false;
            this.listViewReservation.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tenant Charge Date";
            this.columnHeader9.Width = 175;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Description";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 437;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Total Amount Due";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 200;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Date Due";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listViewAssoc);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(882, 413);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Association Dues";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listViewAssoc
            // 
            this.listViewAssoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listViewAssoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAssoc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader13,
            this.columnHeader15,
            this.columnHeader17});
            this.listViewAssoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAssoc.FullRowSelect = true;
            this.listViewAssoc.GridLines = true;
            this.listViewAssoc.Location = new System.Drawing.Point(0, 0);
            this.listViewAssoc.Name = "listViewAssoc";
            this.listViewAssoc.Size = new System.Drawing.Size(882, 413);
            this.listViewAssoc.TabIndex = 1;
            this.listViewAssoc.UseCompatibleStateImageBehavior = false;
            this.listViewAssoc.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tenant Charge Date";
            this.columnHeader7.Width = 133;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date Due";
            this.columnHeader8.Width = 132;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Amount Paid";
            this.columnHeader13.Width = 132;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Balance";
            this.columnHeader15.Width = 110;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Total";
            this.columnHeader17.Width = 118;
            // 
            // PaymentHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 473);
            this.Controls.Add(this.pnlPaymentHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentHistory";
            this.Text = "PaymentHistory";
            this.pnlPaymentHistory.ResumeLayout(false);
            this.pnlPaymentHistory.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlPaymentHistory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listViewReservation;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listViewAssoc;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader17;
    }
}