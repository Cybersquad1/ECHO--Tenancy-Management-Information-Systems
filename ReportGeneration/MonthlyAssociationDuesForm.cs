using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    public partial class MonthlyAssociationDuesForm : Form
    {
        public MonthlyAssociationDuesForm()
        {
            InitializeComponent();
        }

        private void AssocDuesPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TenancyManagement.viewUnitNumberForm v1 = new TenancyManagement.viewUnitNumberForm();
            v1.Show();
        }
    }
}
