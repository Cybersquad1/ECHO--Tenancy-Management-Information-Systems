namespace Tenancy_Management_Information_Systems.ReportForms.Unit
{
    partial class UnitOccupied
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
            this.unitAllOccupiedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitAllOccupiedTableAdapter = new Tenancy_Management_Information_Systems.EchoDataSetTableAdapters.UnitAllOccupiedTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitAllOccupiedBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UnitOccupied";
            reportDataSource1.Value = this.unitAllOccupiedBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Tenancy_Management_Information_Systems.Reports.UnitOccupiedrdlc.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(798, 380);
            this.reportViewer.TabIndex = 0;
            // 
            // echoDataSet
            // 
            this.echoDataSet.DataSetName = "EchoDataSet";
            this.echoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unitAllOccupiedBindingSource
            // 
            this.unitAllOccupiedBindingSource.DataMember = "UnitAllOccupied";
            this.unitAllOccupiedBindingSource.DataSource = this.echoDataSet;
            // 
            // unitAllOccupiedTableAdapter
            // 
            this.unitAllOccupiedTableAdapter.ClearBeforeFill = true;
            // 
            // UnitOccupied
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 380);
            this.Controls.Add(this.reportViewer);
            this.Name = "UnitOccupied";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Occupied";
            this.Load += new System.EventHandler(this.UnitOccupied_Load);
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitAllOccupiedBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private EchoDataSet echoDataSet;
        private System.Windows.Forms.BindingSource unitAllOccupiedBindingSource;
        private EchoDataSetTableAdapters.UnitAllOccupiedTableAdapter unitAllOccupiedTableAdapter;
    }
}