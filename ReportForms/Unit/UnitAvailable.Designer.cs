namespace Tenancy_Management_Information_Systems.ReportForms.Unit
{
    partial class UnitAvailable
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
            this.UnitAllAvailableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.echoDataSet = new Tenancy_Management_Information_Systems.EchoDataSet();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.echoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UnitAllAvailableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitAllAvailableBindingSource
            // 
            this.UnitAllAvailableBindingSource.DataMember = "UnitAllAvailable";
            this.UnitAllAvailableBindingSource.DataSource = this.echoDataSet;
            // 
            // echoDataSet
            // 
            this.echoDataSet.DataSetName = "EchoDataSet";
            this.echoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UnitAvailable";
            reportDataSource1.Value = this.UnitAllAvailableBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Tenancy_Management_Information_Systems.Reports.UnitAvailable.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(723, 316);
            this.reportViewer.TabIndex = 0;
            // 
            // echoDataSetBindingSource
            // 
            this.echoDataSetBindingSource.DataSource = this.echoDataSet;
            this.echoDataSetBindingSource.Position = 0;
            // 
            // UnitAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 316);
            this.Controls.Add(this.reportViewer);
            this.Name = "UnitAvailable";
            this.Text = "Available Units";
            this.Load += new System.EventHandler(this.UnitAvailable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitAllAvailableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource UnitAllAvailableBindingSource;
        private EchoDataSet echoDataSet;
        private System.Windows.Forms.BindingSource echoDataSetBindingSource;
    }
}