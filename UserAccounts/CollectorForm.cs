using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.UserAccounts
{
    public partial class CollectorForm : Form
    {
        public CollectorForm()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxUtilityBilling.Text == "Monthly Association Dues")
            {
                checkBoxAdvancePayment.Visible = true;
            }
            else
            {
                checkBoxAdvancePayment.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdvancePayment.Checked == true)
            {
                comboBoxMonths.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                txtBoxExactNoOfMonths.Visible = true;
                txtBoxDiscount.Visible = true;
            }
            else
            {
                comboBoxMonths.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                txtBoxExactNoOfMonths.Visible = false;
                txtBoxDiscount.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
