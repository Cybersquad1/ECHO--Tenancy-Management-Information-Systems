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
using Tenancy_Management_Information_Systems.ReportForms.PaymentHistory;

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class PaymentHistoryForm : Form
    {
        string unitNo = "";
        public PaymentHistoryForm()
        {
            InitializeComponent();

            GetUnitList();
        }

        private void GetUnitList()
        {
            listViewUnit.Items.Clear();

            var units = new UnitViewModel().GetAll();

            units.ForEach(item =>
            {
                listViewUnit.Items.Add(item.UnitNumber);
            });
        }

        private void GetUnitInformation(string _unitNo)
        {
            var unit = new UnitViewModel().GetSelected(_unitNo);

            if(unit != null)
            {
                txtBoxUnitNo.Text = _unitNo;

                if (unit.Owner != null)
                {
                    var owner = new TenantViewModel().GetSelectedTenant(unit.Owner);

                    if (owner != null)
                        txtBoxUnitOwner.Text = owner.FirstName + " " + owner.LastName;
                    else
                        txtBoxUnitOwner.Text = "N/A";
                }
                else
                    txtBoxUnitOwner.Text = "N/A";

                if (unit.Tenant != null)
                {
                    var tenant = new TenantViewModel().GetSelectedTenant(unit.Tenant);

                    if (tenant != null)
                        txtBoxTenant.Text = tenant.FirstName + " " + tenant.LastName;
                    else
                        txtBoxTenant.Text = "N/A";
                }
                else
                    txtBoxTenant.Text = "N/A";
            }
        }

        private void GetMonthlyAssoc(string _unitNo)
        {
            listViewMonthlyAssoc.Items.Clear();

            var monthlyAssocs = new MonthlyAssociationDueViewModel().GetAll(_unitNo);

            monthlyAssocs.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(DateTime.Parse(item.ChargeDate.ToString()).ToShortDateString());

                lvi.SubItems.Add(string.Format("{0:0.00}", item.AssociationDue));

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Penalty + item.OtherPenaltyAmount));

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Discounts));

                lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalAmount));

                listViewMonthlyAssoc.Items.Add(lvi);
            });
        }

        private void GetWaterBilling(string _unitNo)
        {
            listViewWaterBilling.Items.Clear();

            var waterBilling = new WaterBillingViewModel().GetAll(_unitNo);

            waterBilling.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(DateTime.Parse(item.ChargeDate.ToString()).ToShortDateString());

                lvi.SubItems.Add(item.CurrentReading);

                lvi.SubItems.Add(string.Format("{0:0.00}", item.TotalAmount));
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtBoxUnitNo.Text != "")
            {
                TenancyManagement.viewUnitNumberForm v1 = new viewUnitNumberForm(txtBoxUnitNo.Text);
                v1.Show();
            }
            else
            {
                MessageBox.Show("Please select unit no", "Warning");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listViewUnit_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                unitNo = listViewUnit.SelectedItems[0].SubItems[0].Text;

                GetUnitInformation(unitNo);

                GetWaterBilling(unitNo);

                GetMonthlyAssoc(unitNo);

            }
            catch
            {
                MessageBox.Show("Please select data from list","Warning");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            PaymentHistoryType form = new PaymentHistoryType(unitNo);
            form.ShowDialog();
        }
    }
}
