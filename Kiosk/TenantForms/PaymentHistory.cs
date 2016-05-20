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
        public PaymentHistory(string _unitNo)
        {
            InitializeComponent();

            GetAssocDue(_unitNo);

            GetReservation(_unitNo);
        }

        private void GetAssocDue(string _unitNo)
        {
            listViewAssoc.Items.Clear();

            var assocDue = new MonthlyAssociationDueViewModel().GetAll(_unitNo);

            assocDue.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(DateTime.Parse
                    (item.ChargeDate.ToString()).ToShortDateString());//Charge Date

                lvi.SubItems.Add(DateTime.Parse(item.DueDate.ToString()).ToShortDateString());//Due Date

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Paid));//Amount Paid

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Balance)); //Balance

                lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalAmount)); //Total        

                listViewAssoc.Items.Add(lvi);
            });
        }

        private void GetReservation(string _unitNo)
        {
            listViewReservation.Items.Clear();

            var reservation = new ReservationViewModel().GetAll(_unitNo);

            reservation.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.Date.ToShortDateString());

                lvi.SubItems.Add("Reservation for " + item.Facility);

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Amount));

                lvi.SubItems.Add(item.DateOfFuntion.AddDays(-7).ToShortDateString());

                listViewReservation.Items.Add(lvi);
            });
        }
    }
}
