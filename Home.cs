using Echo.Data.Repository.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems
{
    public partial class Home : Form
    {
        public Home(LoginInfo loginInfo)
        {
            InitializeComponent();

            timer1.Start();

            lblUsername.Text = loginInfo.username;
        }

        private void AccountsButton_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = true;
            TenMgmtPnl.Visible = false;
            reportsGenPnl.Visible = false;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = false;
        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            User_Accounts.CreateNewUserForm c1 = new User_Accounts.CreateNewUserForm();
            c1.NewUserPnl.Visible = true;

            c1.TopLevel = false;
            c1.Visible = true;
            c1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(c1);
        }

        private void EditUserInfoButton_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            User_Accounts.Edit_User_Info e1 = new User_Accounts.Edit_User_Info();
            e1.EditUserPnl.Visible = true;

            e1.TopLevel = false;
            e1.Visible = true;
            e1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(e1);
        }

        private void TenancyMgmtButton_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = true;
            reportsGenPnl.Visible = false;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = false;
        }

        private void CreateNewTenantButton_Click(object sender, EventArgs e)
        {
            TenancyManagement.CreateNewTenantForm t1 = new TenancyManagement.CreateNewTenantForm();
            t1.NewTenantPnl.Visible = true;
            t1.ShowDialog();
        }

        private void EditTenantInfoButton_Click(object sender, EventArgs e)
        {
            TenancyManagement.EditTenantInformationForm e2 = new TenancyManagement.EditTenantInformationForm();
            e2.EditTenantPnl.Visible = true;
            e2.ShowDialog();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = false;
            reportsGenPnl.Visible = true;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = false;
            reportsGenPnl.Visible = false;
            reportsGenPnl2.Visible = true;
            tenancyDatabasePnl.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = false;
            reportsGenPnl.Visible = true;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReportGeneration.WaterBillingForm w1 = new ReportGeneration.WaterBillingForm();
            w1.waterBillingPnl.Visible = true;
            w1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportGeneration.MonthlyAssociationDuesForm m1 = new ReportGeneration.MonthlyAssociationDuesForm();
            m1.AssocDuesPnl.Visible = true;
            m1.ShowDialog();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            ReportGeneration.TheListForm t1 = new ReportGeneration.TheListForm();
            t1.listPnl.Visible = true;
            t1.ShowDialog();
        }

        private void TenancyArchiveButton_Click(object sender, EventArgs e)
        {
            TenancyManagement.TenancyArchiveForm t2 = new TenancyManagement.TenancyArchiveForm();
            t2.ArchivePnl.Visible = true;
            t2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = true;
            reportsGenPnl.Visible = false;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = false;
        }

        private void tenancyDataButton_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = false;
            reportsGenPnl.Visible = false;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = true;
        }

        private void ViewTenantProfButton_Click(object sender, EventArgs e)
        {
            TenancyManagement.TenancyDatabaseForm t3 = new TenancyManagement.TenancyDatabaseForm();
            t3.TenancyDBPnl.Visible = true;
            t3.ShowDialog();
        }

        private void PHistoryButton_Click(object sender, EventArgs e)
        {
            TenancyManagement.PaymentHistoryForm p1 = new TenancyManagement.PaymentHistoryForm();
            p1.paymentHistoryPnl.Visible = true;
            p1.ShowDialog();
        }

        private void AUnitsButton_Click(object sender, EventArgs e)
        {
            TenancyManagement.AvailableUnitForm a1 = new TenancyManagement.AvailableUnitForm();
            a1.unitPnl.Visible = true;
            a1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserAccounts.CollectorForm c1 = new UserAccounts.CollectorForm();
            c1.collectorPnl.Visible = true;
            c1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm();
            l1.logPnl.Visible = true;
            l1.ShowDialog();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            UserAccounts.CollectorForm c1 = new UserAccounts.CollectorForm();
            c1.collectorPnl.Visible = true;
            c1.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm();
            l1.logPnl.Visible = true;
            l1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            collectorPnl2.Visible = true;
            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm();
            l1.logPnl.Visible = false;
            UserAccounts.CollectorForm c1 = new UserAccounts.CollectorForm();
            c1.collectorPnl.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TenancyManagement.TenancyDatabaseForm t3 = new TenancyManagement.TenancyDatabaseForm();
            t3.TenancyDBPnl.Visible = true;
            t3.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            TenancyManagement.AvailableUnitForm a1 = new TenancyManagement.AvailableUnitForm();
            a1.unitPnl.Visible = true;
            a1.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            TenancyManagement.PaymentHistoryForm p1 = new TenancyManagement.PaymentHistoryForm();
            p1.paymentHistoryPnl.Visible = true;
            p1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TenancyManagement.TenancyArchiveForm t2 = new TenancyManagement.TenancyArchiveForm();
            t2.ArchivePnl.Visible = true;
            t2.ShowDialog();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ReportGeneration.TheListForm t1 = new ReportGeneration.TheListForm();
            t1.listPnl.Visible = true;
            t1.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            collectorPnl2.Visible = true;
            reportsGenPnl.Visible = false;
            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm();
            l1.logPnl.Visible = false;
            UserAccounts.CollectorForm c1 = new UserAccounts.CollectorForm();
            c1.collectorPnl.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            reportsGenPnl.Visible = true;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = false;
            collectorPnl2.Visible = false;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
