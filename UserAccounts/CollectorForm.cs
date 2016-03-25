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
            if (comboBox2.Text == "Monthly Association Dues")
            {
                checkBox1.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox3.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
            }
            else
            {
                comboBox3.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
