using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.ReportForms.Unit
{
    public partial class UnitCategory : Form
    {
        public UnitCategory()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "All")
            {
                UnitAll form = new UnitAll();

                form.Show();

                Close();
            }
            else if(comboBox1.Text == "Available")
            {
                UnitAvailable form = new UnitAvailable();

                form.Show();

                Close();
            }
            else if(comboBox1.Text== "Occupied")
            {
                UnitOccupied form = new UnitOccupied();

                form.Show();

                Close();
            }
        }
    }
}
