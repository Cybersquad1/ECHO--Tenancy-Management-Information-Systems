namespace Tenancy_Management_Information_Systems.ReportForms.Billing
{
    partial class StatementOfAccount
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.echoDataSet = new Tenancy_Management_Information_Systems.EchoDataSet();
            this.billingStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingStatementTableAdapter = new Tenancy_Management_Information_Systems.EchoDataSetTableAdapters.BillingStatementTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingStatementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MonthlyAssoc";
            reportDataSource1.Value = this.billingStatementBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Tenancy_Management_Information_Systems.Reports.MonthlyAssocPaymentHistory.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(697, 416);
            this.reportViewer.TabIndex = 0;
            // 
            // echoDataSet
            // 
            this.echoDataSet.DataSetName = "EchoDataSet";
            this.echoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billingStatementBindingSource
            // 
            this.billingStatementBindingSource.DataMember = "BillingStatement";
            this.billingStatementBindingSource.DataSource = this.echoDataSet;
            // 
            // billingStatementTableAdapter
            // 
            this.billingStatementTableAdapter.ClearBeforeFill = true;
            // 
            // StatementOfAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 416);
            this.Controls.Add(this.reportViewer);
            this.Name = "StatementOfAccount";
            this.Text = "Statement Of Account";
            this.Load += new System.EventHandler(this.StatementOfAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingStatementBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource billingStatementBindingSource;
        private EchoDataSet echoDataSet;
        private EchoDataSetTableAdapters.BillingStatementTableAdapter billingStatementTableAdapter;
    }
}