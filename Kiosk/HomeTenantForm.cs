using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.Kiosk
{
    public partial class HomeTenantForm : Form
    {
        public HomeTenantForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ViewTenantProfButton_Click(object sender, EventArgs e)
        {
            HomeKioskForms hk = new HomeKioskForms();
            hk.pnlTenancyInfo.Visible = true;
            hk.pnlRequest.Visible = false;
            hk.pnlPaymentHistory.Visible = false;
            hk.pnlReservation.Visible = false;
            hk.pnlAssocDues.Visible = false;
            hk.ShowDialog();

        }

        private void AssocDuesButton_Click(object sender, EventArgs e)
        {
            HomeKioskForms hk = new HomeKioskForms();
            hk.pnlTenancyInfo.Visible = false;
            hk.pnlRequest.Visible = false;
            hk.pnlPaymentHistory.Visible = false;
            hk.pnlReservation.Visible = false;
            hk.pnlAssocDues.Visible = true;
            hk.ShowDialog();
        }

        private void PHistoryButton_Click(object sender, EventArgs e)
        {
            HomeKioskForms hk = new HomeKioskForms();
            hk.pnlTenancyInfo.Visible = false;
            hk.pnlRequest.Visible = false;
            hk.pnlPaymentHistory.Visible = true;
            hk.pnlReservation.Visible = false;
            hk.pnlAssocDues.Visible = false;
            hk.ShowDialog();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            HomeKioskForms hk = new HomeKioskForms();
            hk.pnlTenancyInfo.Visible = false;
            hk.pnlRequest.Visible = true;
            hk.pnlPaymentHistory.Visible = false;
            hk.pnlReservation.Visible = false;
            hk.pnlAssocDues.Visible = false;
            hk.ShowDialog();
        }

        private void ReservationButton_Click(object sender, EventArgs e)
        {
            HomeKioskForms hk = new HomeKioskForms();
            hk.pnlTenancyInfo.Visible = false;
            hk.pnlRequest.Visible = false;
            hk.pnlPaymentHistory.Visible = false;
            hk.pnlReservation.Visible = true;
            hk.pnlAssocDues.Visible=false;
            hk.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            HomeKioskForms hk = new HomeKioskForms();
            hk.pnlTenancyInfo.Visible = false;
            hk.pnlRequest.Visible = false;
            hk.pnlPaymentHistory.Visible = false;
            hk.pnlReservation.Visible = false;
            hk.pnlAssocDues.Visible = false;
            hk.ShowDialog();
        }
    }
}
