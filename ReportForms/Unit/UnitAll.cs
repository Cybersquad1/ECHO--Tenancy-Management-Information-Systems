﻿using Echo.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.ReportForms
{
    public partial class UnitAll : Form
    {
        public UnitAll()
        {
            InitializeComponent();

            LoadReport();
        }

        private void LoadReport()
        {
            using (var db = new EchoEntities())
            {
                unitAllBindingSource.DataSource =
                    db.UnitAll();

                reportViewer.RefreshReport();
            }
        }

        private void UnitAll_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'echoDataSet1.UnitAll' table. You can move, or remove it, as needed.
            this.unitAllTableAdapter.Fill(this.echoDataSet1.UnitAll);

            this.reportViewer.RefreshReport();
        }
    }
}
