namespace Tenancy_Management_Information_Systems.ReportForms.UserList
{
    partial class UserList
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
            this.echoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userListTableAdapter = new Tenancy_Management_Information_Systems.EchoDataSetTableAdapters.UserListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UserList";
            reportDataSource1.Value = this.userListBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "Tenancy_Management_Information_Systems.Reports.UserList.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(755, 443);
            this.reportViewer.TabIndex = 0;
            // 
            // echoDataSet
            // 
            this.echoDataSet.DataSetName = "EchoDataSet";
            this.echoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // echoDataSetBindingSource
            // 
            this.echoDataSetBindingSource.DataSource = this.echoDataSet;
            this.echoDataSetBindingSource.Position = 0;
            // 
            // userListBindingSource
            // 
            this.userListBindingSource.DataMember = "UserList";
            this.userListBindingSource.DataSource = this.echoDataSet;
            // 
            // userListTableAdapter
            // 
            this.userListTableAdapter.ClearBeforeFill = true;
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 443);
            this.Controls.Add(this.reportViewer);
            this.Name = "UserList";
            this.Text = "User List";
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private EchoDataSet echoDataSet;
        private System.Windows.Forms.BindingSource echoDataSetBindingSource;
        private System.Windows.Forms.BindingSource userListBindingSource;
        private EchoDataSetTableAdapters.UserListTableAdapter userListTableAdapter;
    }
}