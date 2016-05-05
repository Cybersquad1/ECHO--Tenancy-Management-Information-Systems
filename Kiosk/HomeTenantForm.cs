using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenancy_Management_Information_Systems.Kiosk.TenantForms;

namespace Tenancy_Management_Information_Systems.Kiosk
{
    public partial class HomeTenantForm : Form
    {
        Guid tenantID;

        Home2 parentForm;

        public HomeTenantForm(Home2 parentForm, Guid _tenantID, string _unitNo, string _name)
        {
            InitializeComponent();

            tenantID = _tenantID;

            lblUnitNo.Text = _unitNo;

            lblTenantName.Text = _name;

            this.parentForm = parentForm;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ViewTenantProfButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            TenantInformation form = new TenantInformation(tenantID);
            form.Visible = true;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(form);
        }

        private void AssocDuesButton_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            MonthlyAssocDue form = new MonthlyAssocDue(lblUnitNo.Text);
            form.TopLevel = false;
            form.Visible = true;
            form.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(form);
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
            Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
        }

        private void HomeTenantForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void HomeTenantForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void HomeTenantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }
    }
}
