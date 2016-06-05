namespace Tenancy_Management_Information_Systems.Kiosk.TenantForms
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.txtBoxContactNo = new System.Windows.Forms.TextBox();
            this.txtBoxUnitOwner = new System.Windows.Forms.TextBox();
            this.txtBoxUnitNo = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOkay = new System.Windows.Forms.Button();
            this.label36 = new System.Windows.Forms.Label();
            this.datePickerPrefferedDate = new System.Windows.Forms.DateTimePicker();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.datePickerDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbBoxProject = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.txtBoxRequest4 = new System.Windows.Forms.TextBox();
            this.txtBoxRequest3 = new System.Windows.Forms.TextBox();
            this.txtBoxRequest2 = new System.Windows.Forms.TextBox();
            this.txtBoxRequest1 = new System.Windows.Forms.TextBox();
            this.pnlRequest.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRequest
            // 
            this.pnlRequest.BackColor = System.Drawing.Color.White;
            this.pnlRequest.Controls.Add(this.txtBoxTime);
            this.pnlRequest.Controls.Add(this.txtBoxContactNo);
            this.pnlRequest.Controls.Add(this.txtBoxUnitOwner);
            this.pnlRequest.Controls.Add(this.txtBoxUnitNo);
            this.pnlRequest.Controls.Add(this.btnCancel);
            this.pnlRequest.Controls.Add(this.btnOkay);
            this.pnlRequest.Controls.Add(this.label36);
            this.pnlRequest.Controls.Add(this.datePickerPrefferedDate);
            this.pnlRequest.Controls.Add(this.label35);
            this.pnlRequest.Controls.Add(this.label34);
            this.pnlRequest.Controls.Add(this.label33);
            this.pnlRequest.Controls.Add(this.label32);
            this.pnlRequest.Controls.Add(this.label31);
            this.pnlRequest.Controls.Add(this.label30);
            this.pnlRequest.Controls.Add(this.datePickerDate);
            this.pnlRequest.Controls.Add(this.label17);
            this.pnlRequest.Controls.Add(this.cmbBoxProject);
            this.pnlRequest.Controls.Add(this.label18);
            this.pnlRequest.Controls.Add(this.label6);
            this.pnlRequest.Controls.Add(this.label19);
            this.pnlRequest.Controls.Add(this.label24);
            this.pnlRequest.Controls.Add(this.groupBox3);
            this.pnlRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlRequest.Location = new System.Drawing.Point(0, 0);
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.Size = new System.Drawing.Size(928, 472);
            this.pnlRequest.TabIndex = 122;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(700, 283);
            this.txtBoxTime.MaxLength = 10;
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(132, 20);
            this.txtBoxTime.TabIndex = 159;
            // 
            // txtBoxContactNo
            // 
            this.txtBoxContactNo.Location = new System.Drawing.Point(571, 89);
            this.txtBoxContactNo.MaxLength = 10;
            this.txtBoxContactNo.Name = "txtBoxContactNo";
            this.txtBoxContactNo.Size = new System.Drawing.Size(185, 20);
            this.txtBoxContactNo.TabIndex = 158;
            this.txtBoxContactNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxContactNo_KeyPress);
            // 
            // txtBoxUnitOwner
            // 
            this.txtBoxUnitOwner.Enabled = false;
            this.txtBoxUnitOwner.Location = new System.Drawing.Point(275, 86);
            this.txtBoxUnitOwner.Name = "txtBoxUnitOwner";
            this.txtBoxUnitOwner.Size = new System.Drawing.Size(185, 20);
            this.txtBoxUnitOwner.TabIndex = 157;
            this.txtBoxUnitOwner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUnitOwner_KeyPress);
            this.txtBoxUnitOwner.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxUnitOwner_KeyUp);
            // 
            // txtBoxUnitNo
            // 
            this.txtBoxUnitNo.Enabled = false;
            this.txtBoxUnitNo.Location = new System.Drawing.Point(438, 53);
            this.txtBoxUnitNo.Name = "txtBoxUnitNo";
            this.txtBoxUnitNo.Size = new System.Drawing.Size(135, 20);
            this.txtBoxUnitNo.TabIndex = 156;
            this.txtBoxUnitNo.TextChanged += new System.EventHandler(this.txtBoxUnitNo_TextChanged);
            this.txtBoxUnitNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxUnitNo_KeyPress);
            this.txtBoxUnitNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxUnitNo_KeyUp);
            this.txtBoxUnitNo.Leave += new System.EventHandler(this.txtBoxUnitNo_Leave);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(825, 421);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 29);
            this.btnCancel.TabIndex = 155;
            this.btnCancel.Text = "    Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkay
            // 
            this.btnOkay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkay.Image = ((System.Drawing.Image)(resources.GetObject("btnOkay.Image")));
            this.btnOkay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOkay.Location = new System.Drawing.Point(747, 421);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(72, 29);
            this.btnOkay.TabIndex = 149;
            this.btnOkay.Text = "   Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label36.Location = new System.Drawing.Point(659, 284);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(35, 15);
            this.label36.TabIndex = 146;
            this.label36.Text = "Time";
            // 
            // datePickerPrefferedDate
            // 
            this.datePickerPrefferedDate.CustomFormat = "mm/dd/yyyy";
            this.datePickerPrefferedDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerPrefferedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerPrefferedDate.Location = new System.Drawing.Point(504, 281);
            this.datePickerPrefferedDate.Name = "datePickerPrefferedDate";
            this.datePickerPrefferedDate.Size = new System.Drawing.Size(138, 20);
            this.datePickerPrefferedDate.TabIndex = 145;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label35.Location = new System.Drawing.Point(465, 283);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(33, 15);
            this.label35.TabIndex = 144;
            this.label35.Text = "Date";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label34.Location = new System.Drawing.Point(459, 241);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(196, 15);
            this.label34.TabIndex = 143;
            this.label34.Text = "Preffered Schedule of Inspection:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(214, 189);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(469, 15);
            this.label33.TabIndex = 142;
            this.label33.Text = "FROM MONDAT TO FRIDAY 8:30AM TO 5:30PM AND SATURDAY 8:30AM TO 12:00NN.";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(77, 162);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(755, 15);
            this.label32.TabIndex = 141;
            this.label32.Text = "PLS. INDICATE PREFERRED SCHEDULE AND TIME FOR INSPECTION/REPAIR. ADMINISTRATOR & " +
    "BUILDING MAINTENANCE AREAVAILABLE ";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(64, 131);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(168, 16);
            this.label31.TabIndex = 140;
            this.label31.Text = "IMPORTANT REMINDERS!";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label30.Location = new System.Drawing.Point(158, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(111, 15);
            this.label30.TabIndex = 138;
            this.label30.Text = "Unit Owner/Tenant";
            // 
            // datePickerDate
            // 
            this.datePickerDate.CustomFormat = "mm/dd/yyyy";
            this.datePickerDate.Enabled = false;
            this.datePickerDate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerDate.Location = new System.Drawing.Point(618, 56);
            this.datePickerDate.Name = "datePickerDate";
            this.datePickerDate.Size = new System.Drawing.Size(138, 20);
            this.datePickerDate.TabIndex = 135;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label17.Location = new System.Drawing.Point(579, 58);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 15);
            this.label17.TabIndex = 134;
            this.label17.Text = "Date";
            // 
            // cmbBoxProject
            // 
            this.cmbBoxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProject.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxProject.FormattingEnabled = true;
            this.cmbBoxProject.Items.AddRange(new object[] {
            "Inspection",
            "Repair"});
            this.cmbBoxProject.Location = new System.Drawing.Point(213, 54);
            this.cmbBoxProject.Name = "cmbBoxProject";
            this.cmbBoxProject.Size = new System.Drawing.Size(138, 23);
            this.cmbBoxProject.TabIndex = 133;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label18.Location = new System.Drawing.Point(159, 58);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 15);
            this.label18.TabIndex = 125;
            this.label18.Text = "Project";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(397, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 121;
            this.label6.Text = "REQUEST FORM";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(355, 58);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 15);
            this.label19.TabIndex = 126;
            this.label19.Text = "Unit Number";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label24.Location = new System.Drawing.Point(466, 91);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 15);
            this.label24.TabIndex = 128;
            this.label24.Text = "Contact Number";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label40);
            this.groupBox3.Controls.Add(this.label39);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.txtBoxRequest4);
            this.groupBox3.Controls.Add(this.txtBoxRequest3);
            this.groupBox3.Controls.Add(this.txtBoxRequest2);
            this.groupBox3.Controls.Add(this.txtBoxRequest1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(67, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 182);
            this.groupBox3.TabIndex = 148;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requesting for inspection/repair of the following items:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(15, 132);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(25, 15);
            this.label40.TabIndex = 7;
            this.label40.Text = "(4)";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(15, 106);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(25, 15);
            this.label39.TabIndex = 6;
            this.label39.Text = "(3)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(15, 77);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(25, 15);
            this.label38.TabIndex = 5;
            this.label38.Text = "(2)";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(15, 50);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 15);
            this.label37.TabIndex = 4;
            this.label37.Text = "(1)";
            // 
            // txtBoxRequest4
            // 
            this.txtBoxRequest4.Enabled = false;
            this.txtBoxRequest4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRequest4.Location = new System.Drawing.Point(44, 129);
            this.txtBoxRequest4.MaxLength = 200;
            this.txtBoxRequest4.Name = "txtBoxRequest4";
            this.txtBoxRequest4.Size = new System.Drawing.Size(288, 21);
            this.txtBoxRequest4.TabIndex = 3;
            // 
            // txtBoxRequest3
            // 
            this.txtBoxRequest3.Enabled = false;
            this.txtBoxRequest3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRequest3.Location = new System.Drawing.Point(44, 102);
            this.txtBoxRequest3.MaxLength = 200;
            this.txtBoxRequest3.Name = "txtBoxRequest3";
            this.txtBoxRequest3.Size = new System.Drawing.Size(288, 21);
            this.txtBoxRequest3.TabIndex = 2;
            this.txtBoxRequest3.TextChanged += new System.EventHandler(this.txtBoxRequest3_TextChanged);
            // 
            // txtBoxRequest2
            // 
            this.txtBoxRequest2.Enabled = false;
            this.txtBoxRequest2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRequest2.Location = new System.Drawing.Point(44, 74);
            this.txtBoxRequest2.MaxLength = 200;
            this.txtBoxRequest2.Name = "txtBoxRequest2";
            this.txtBoxRequest2.Size = new System.Drawing.Size(288, 21);
            this.txtBoxRequest2.TabIndex = 1;
            this.txtBoxRequest2.TextChanged += new System.EventHandler(this.txtBoxRequest2_TextChanged);
            // 
            // txtBoxRequest1
            // 
            this.txtBoxRequest1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRequest1.Location = new System.Drawing.Point(44, 47);
            this.txtBoxRequest1.MaxLength = 200;
            this.txtBoxRequest1.Name = "txtBoxRequest1";
            this.txtBoxRequest1.Size = new System.Drawing.Size(288, 21);
            this.txtBoxRequest1.TabIndex = 0;
            this.txtBoxRequest1.TextChanged += new System.EventHandler(this.txtBoxRequest1_TextChanged);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 472);
            this.Controls.Add(this.pnlRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.pnlRequest.ResumeLayout(false);
            this.pnlRequest.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DateTimePicker datePickerPrefferedDate;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DateTimePicker datePickerDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cmbBoxProject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtBoxRequest4;
        private System.Windows.Forms.TextBox txtBoxRequest3;
        private System.Windows.Forms.TextBox txtBoxRequest2;
        private System.Windows.Forms.TextBox txtBoxRequest1;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.TextBox txtBoxContactNo;
        private System.Windows.Forms.TextBox txtBoxUnitOwner;
        private System.Windows.Forms.TextBox txtBoxUnitNo;
    }
}