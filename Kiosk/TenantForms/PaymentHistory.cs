using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Echo.Data.Repository.ViewModel;

namespace Tenancy_Management_Information_Systems.Kiosk.TenantForms
{
    public partial class PaymentHistory : Form
    {
        public PaymentHistory()
        {
            InitializeComponent();
        }

        private void GetBillingHistory(string _unitNo)
        {
            var billings = new MonthlyAssociationDueViewModel().GetAll(_unitNo);

            billings.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(DateTime.Parse
                    (item.ChargeDate.ToString()).ToShortDateString());//Charge Date

                lvi.SubItems.Add(DateTime.Parse(item.DueDate.ToString()).ToShortDateString());//Due Date

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Paid));//Amount Paid

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Balance)); //Balance

                lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalAmount)); //Total        
            });
        }
    }
}
