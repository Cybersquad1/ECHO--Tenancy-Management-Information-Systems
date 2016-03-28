using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class PaymentHistoryForm : Form
    {
        public PaymentHistoryForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TenancyManagement.viewUnitNumberForm v1 = new viewUnitNumberForm();
            v1.Show();
        }
    }
}
