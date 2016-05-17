namespace Tenancy_Management_Information_Systems.ReportForms
{
    partial class TenancyDatabase
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.echoDataSet = new Tenancy_Management_Information_Systems.EchoDataSet();
            this.tenancyDatabaseByOccupancyYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tenancyDatabaseByOccupancyYearTableAdapter = new Tenancy_Management_Information_Systems.EchoDataSetTableAdapters.TenancyDatabaseByOccupancyYearTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenancyDatabaseByOccupancyYearBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "TenantProfile";
            reportDataSource1.Value = this.tenancyDatabaseByOccupancyYearBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tenancy_Management_Information_Systems.Reports.TenancyDatabaseByOccupancyDate.rdl" +
    "c";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(801, 443);
            this.reportViewer1.TabIndex = 1;
            // 
            // echoDataSet
            // 
            this.echoDataSet.DataSetName = "EchoDataSet";
            this.echoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tenancyDatabaseByOccupancyYearBindingSource
            // 
            this.tenancyDatabaseByOccupancyYearBindingSource.DataMember = "TenancyDatabaseByOccupancyYear";
            this.tenancyDatabaseByOccupancyYearBindingSource.DataSource = this.echoDataSet;
            // 
            // tenancyDatabaseByOccupancyYearTableAdapter
            // 
            this.tenancyDatabaseByOccupancyYearTableAdapter.ClearBeforeFill = true;
            // 
            // TenancyDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 443);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TenancyDatabase";
            this.Text = "Tenancy Database";
            this.Load += new System.EventHandler(this.TenancyDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenancyDatabaseByOccupancyYearBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tenancyDatabaseByOccupancyYearBindingSource;
        private EchoDataSet echoDataSet;
        private EchoDataSetTableAdapters.TenancyDatabaseByOccupancyYearTableAdapter tenancyDatabaseByOccupancyYearTableAdapter;
    }
}