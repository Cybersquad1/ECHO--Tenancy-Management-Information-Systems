namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    partial class SelectUnit
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
            this.listViewUnits = new System.Windows.Forms.ListView();
            this.btnOkay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxSearchKey = new System.Windows.Forms.TextBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewUnits
            // 
            this.listViewUnits.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listViewUnits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewUnits.FullRowSelect = true;
            this.listViewUnits.GridLines = true;
            this.listViewUnits.Location = new System.Drawing.Point(12, 73);
            this.listViewUnits.MultiSelect = false;
            this.listViewUnits.Name = "listViewUnits";
            this.listViewUnits.Size = new System.Drawing.Size(451, 418);
            this.listViewUnits.TabIndex = 28;
            this.listViewUnits.UseCompatibleStateImageBehavior = false;
            this.listViewUnits.View = System.Windows.Forms.View.Details;
            this.listViewUnits.DoubleClick += new System.EventHandler(this.listViewUnits_DoubleClick);
            // 
            // btnOkay
            // 
            this.btnOkay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOkay.Location = new System.Drawing.Point(379, 497);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(84, 28);
            this.btnOkay.TabIndex = 29;
            this.btnOkay.Text = "      Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::Tenancy_Management_Information_Systems.Properties.Resources.magnifying_glass34;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(421, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(24, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxSearchKey);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 54);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // txtBoxSearchKey
            // 
            this.txtBoxSearchKey.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchKey.Location = new System.Drawing.Point(231, 19);
            this.txtBoxSearchKey.Multiline = true;
            this.txtBoxSearchKey.Name = "txtBoxSearchKey";
            this.txtBoxSearchKey.Size = new System.Drawing.Size(191, 21);
            this.txtBoxSearchKey.TabIndex = 27;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 448;
            // 
            // SelectUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 541);
            this.Controls.Add(this.listViewUnits);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.groupBox1);
            this.Name = "SelectUnit";
            this.Text = "Search";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUnits;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxSearchKey;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}