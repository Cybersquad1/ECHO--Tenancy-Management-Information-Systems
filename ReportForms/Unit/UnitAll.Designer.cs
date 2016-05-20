namespace Tenancy_Management_Information_Systems.ReportForms
{
    partial class UnitAll
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
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.echoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.echoDataSet1 = new Tenancy_Management_Information_Systems.EchoDataSet();
            this.unitAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitAllTableAdapter = new Tenancy_Management_Information_Systems.EchoDataSetTableAdapters.UnitAllTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UnitAllAvailableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitAllBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UnitAllAvailableBindingSource
            // 
            this.UnitAllAvailableBindingSource.DataMember = "UnitAllAvailable";
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UnitAll";
            reportDataSource1.Value = this.unitAllBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Tenancy_Management_Information_Systems.Reports.UnitAll.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(704, 354);
            this.reportViewer.TabIndex = 0;
            // 
            // echoDataSet1
            // 
            this.echoDataSet1.DataSetName = "EchoDataSet";
            this.echoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitAllBindingSource
            // 
            this.unitAllBindingSource.DataMember = "UnitAll";
            this.unitAllBindingSource.DataSource = this.echoDataSet1;
            // 
            // unitAllTableAdapter
            // 
            this.unitAllTableAdapter.ClearBeforeFill = true;
            // 
            // UnitAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 354);
            this.Controls.Add(this.reportViewer);
            this.Name = "UnitAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All Units";
            this.Load += new System.EventHandler(this.UnitAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnitAllAvailableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitAllBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource echoDataSetBindingSource;
        private EchoDataSet echoDataSet;
        private System.Windows.Forms.BindingSource UnitAllAvailableBindingSource;
        private EchoDataSet echoDataSet1;
        private System.Windows.Forms.BindingSource unitAllBindingSource;
        private EchoDataSetTableAdapters.UnitAllTableAdapter unitAllTableAdapter;
    }
}