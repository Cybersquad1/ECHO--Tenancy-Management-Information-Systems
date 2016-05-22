using Echo.Data.Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenancy_Management_Information_Systems.Kiosk;
using Tenancy_Management_Information_Systems.UserAccounts;

namespace Tenancy_Management_Information_Systems
{
    public partial class Home : Form
    {
        Home2 parentForm;

        LoginInfo loginInfo;

        public Home(LoginInfo loginInfo, Home2 parentForm)
        {
            InitializeComponent();

            timer1.Start();

            lblUsername.Text = loginInfo.fullName;

            this.parentForm = parentForm;

            this.loginInfo = loginInfo;

            //Show panel depending on user access
            if(loginInfo.accountType.ToLower() == "accountant")
            {
                acPnl.Visible = true;
                clPanel.Visible = false;
                baPanel.Visible = false;
            }
            else if(loginInfo.accountType.ToLower() == "admin")
            {
                acPnl.Visible = false;
                clPanel.Visible = false;
                baPanel.Visible = true;
            }
            else if(loginInfo.accountType.ToLower() == "collector")
            {
                acPnl.Visible = false;
                clPanel.Visible = true;
                baPanel.Visible = false;
            }
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

        private void CreateNewTenantButton_Click(object sender, EventArgs e) //Create new Tenant
        {
            panelMain.Controls.Clear();

            TenancyManagement.CreateNewTenantForm t1 = new TenancyManagement.CreateNewTenantForm();
            t1.NewTenantPnl.Visible = true;
            t1.TopLevel = false;
            t1.Visible = true;
            t1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(t1);
        }

        private void EditTenantInfoButton_Click(object sender, EventArgs e) //Edit Tenant Information
        {
            panelMain.Controls.Clear();

            TenancyManagement.EditTenantInformationForm e2 = new TenancyManagement.EditTenantInformationForm();
            e2.EditTenantPnl.Visible = true;
            e2.TopLevel = false;
            e2.Visible = true;
            e2.Dock = DockStyle.Fill;

            panelMain.Controls.Add(e2);
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

            panelMain.Controls.Clear();
        }

        private void button7_Click(object sender, EventArgs e) //Water Billing
        {
            panelMain.Controls.Clear();

            ReportGeneration.WaterBillingForm w1 = new ReportGeneration.WaterBillingForm();
            w1.waterBillingPnl.Visible = true;
            w1.TopLevel = false;
            w1.Visible = true;
            w1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(w1);
        }

        private void button3_Click(object sender, EventArgs e) //Monthly assoc due
        {
            panelMain.Controls.Clear();

            ReportGeneration.MonthlyAssociationDuesForm m1 = new ReportGeneration.MonthlyAssociationDuesForm();
            m1.AssocDuesPnl.Visible = true;
            m1.TopLevel = false;
            m1.Visible = true;
            m1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(m1);     
        }

        private void button24_Click(object sender, EventArgs e)//Paid and unpaid
        {
            panelMain.Controls.Clear();

            ReportGeneration.TheListForm t1 = new ReportGeneration.TheListForm();
            t1.listPnl.Visible = true;
            t1.Visible = true;
            t1.TopLevel = false;
            t1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(t1);
        }

        private void TenancyArchiveButton_Click(object sender, EventArgs e) //Tenancy Archive
        {
            panelMain.Controls.Clear();

            TenancyManagement.TenancyArchiveForm t2 = new TenancyManagement.TenancyArchiveForm();
            t2.ArchivePnl.Visible = true;
            t2.TopLevel = false;
            t2.Visible = true;
            t2.Dock = DockStyle.Fill;

            panelMain.Controls.Add(t2);
        }

        private void button8_Click(object sender, EventArgs e) //Back
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = true;
            reportsGenPnl.Visible = false;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = false;

            panelMain.Controls.Clear();
        }

        private void tenancyDataButton_Click(object sender, EventArgs e)
        {
            UserAccPnl.Visible = false;
            TenMgmtPnl.Visible = false;
            reportsGenPnl.Visible = false;
            reportsGenPnl2.Visible = false;
            tenancyDatabasePnl.Visible = true;
        }

        private void ViewTenantProfButton_Click(object sender, EventArgs e) //View Tenant Profile
        {
            panelMain.Controls.Clear();

            TenancyManagement.TenancyDatabaseForm t3 = new TenancyManagement.TenancyDatabaseForm();
            t3.TenancyDBPnl.Visible = true;
            t3.TopLevel = false;
            t3.Visible = true;
            t3.Dock = DockStyle.Fill;

            panelMain.Controls.Add(t3);
        }

        private void PHistoryButton_Click(object sender, EventArgs e)//Payment History
        {
            panelMain.Controls.Clear();

            TenancyManagement.PaymentHistoryForm p1 = new TenancyManagement.PaymentHistoryForm();
            p1.Visible = true;
            p1.TopLevel = false;
            p1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(p1);
        }

        private void AUnitsButton_Click(object sender, EventArgs e)//View Available Units
        {
            panelMain.Controls.Clear();

            TenancyManagement.AvailableUnitForm a1 = new TenancyManagement.AvailableUnitForm();

            a1.TopLevel = false;
            a1.Visible = true;
            a1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(a1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserAccounts.CollectorForm c1 = new UserAccounts.CollectorForm();
            c1.collectorPnl.Visible = true;
            c1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e) //Log sheet
        {
            panelMain.Controls.Clear();

            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm(loginInfo.userID);
            l1.logPnl.Visible = true;
            l1.TopLevel = false;
            l1.Visible = true;
            l1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(l1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            UserAccounts.CollectorForm c1 = new UserAccounts.CollectorForm();
            c1.collectorPnl.Visible = true;
            c1.ShowDialog();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm(loginInfo.userID);
            l1.logPnl.Visible = true;
            l1.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            collectorPnl2.Visible = true;
            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm(loginInfo.userID);
            l1.logPnl.Visible = false;
            UserAccounts.CollectorForm c1 = new UserAccounts.CollectorForm();
            c1.collectorPnl.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            TenancyManagement.TenancyDatabaseForm t3 = new TenancyManagement.TenancyDatabaseForm();
            t3.TenancyDBPnl.Visible = true;
            t3.TopLevel = false;
            t3.Visible = true;
            t3.Dock = DockStyle.Fill;

            panelMain.Controls.Add(t3);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            TenancyManagement.AvailableUnitForm a1 = new TenancyManagement.AvailableUnitForm();
            a1.Visible = true;
            a1.TopLevel = false;
            a1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(a1);
        }

        private void button14_Click(object sender, EventArgs e)//Payment History
        {
            panelMain.Controls.Clear();

            TenancyManagement.PaymentHistoryForm p1 = new TenancyManagement.PaymentHistoryForm();
            p1.paymentHistoryPnl.Visible = true;
            p1.Visible = true;
            p1.TopLevel = false;
            p1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(p1);        
        }

        private void button6_Click(object sender, EventArgs e) //Tenancy Archive
        {
            panelMain.Controls.Clear();

            TenancyManagement.TenancyArchiveForm t2 = new TenancyManagement.TenancyArchiveForm();
            t2.ArchivePnl.Visible = true;
            t2.Visible = true;
            t2.TopLevel = false;
            t2.Dock = DockStyle.Fill;

            panelMain.Controls.Add(t2);
        }

        private void button15_Click(object sender, EventArgs e) //Paid and Unpaid Accounts
        {
            panelMain.Controls.Clear();

            ReportGeneration.TheListForm t1 = new ReportGeneration.TheListForm();
            t1.listPnl.Visible = true;
            t1.TopLevel = false;
            t1.Visible = true;
            t1.Dock = DockStyle.Fill;

            panelMain.Controls.Add(t1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            collectorPnl2.Visible = true;
            reportsGenPnl.Visible = false;
            ReportGeneration.logSheetForm l1 = new ReportGeneration.logSheetForm(loginInfo.userID);
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

        private void lblLogout_Click(object sender, EventArgs e)
        {
            Close();
            parentForm.Show();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Logout
        {
            Close();
        }

        private void btnCollector_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            CollectorForm cf = new CollectorForm();
            cf.TopLevel = false;
            cf.Visible = true;
            cf.Dock = DockStyle.Fill;

            panelMain.Controls.Add(cf);
        }
    }
}
