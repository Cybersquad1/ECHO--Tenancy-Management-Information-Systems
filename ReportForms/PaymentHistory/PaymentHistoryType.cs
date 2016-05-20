using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.ReportForms.PaymentHistory
{
    public partial class PaymentHistoryType : Form
    {
        string unitNo;
        public PaymentHistoryType(string _unitNo)
        {
            InitializeComponent();

            unitNo = _unitNo;
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            if(comboBoxSelection.Text == "Monthly Assoc Due")
            {
                MonthlyAssociationDue form = new MonthlyAssociationDue(unitNo);

                form.Show();

                Close();
            }
            else if(comboBoxSelection.Text == "Water Billing")
            {
                WaterBilling form = new WaterBilling(unitNo);

                form.Show();

                Close();
            }
            else
            {
                MessageBox.Show("Please select type");
            }
        }
    }
}
