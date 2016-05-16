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
using Echo.Data.Repository;

namespace Tenancy_Management_Information_Systems.UserAccounts
{
    public partial class CollectorForm : Form
    {
        public CollectorForm()
        {
            InitializeComponent();

            GetUnitDropDown();
        }

        private void GetUnitDropDown()
        {
            cmbBoxUnitNo.Items.Clear();

            var units = new UnitViewModel().GetAll();

            units.ForEach(item =>
            {
                cmbBoxUnitNo.Items.Add(item.UnitNumber);
            });
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxUtilityBilling.Text == "Monthly Association Dues")
            {
                checkBoxAdvancePayment.Visible = true;
            }
            else
            {
                checkBoxAdvancePayment.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdvancePayment.Checked == true)
            {
                comboBoxMonths.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                txtBoxExactNoOfMonths.Visible = true;
                txtBoxDiscount.Visible = true;
            }
            else
            {
                comboBoxMonths.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                txtBoxExactNoOfMonths.Visible = false;
                txtBoxDiscount.Visible = false;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {

        }

        private void cmbBoxUnitNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxUnitNo.Text != "")
            {
                var unitInformation = new UnitViewModel().GetSelected(cmbBoxUnitNo.Text);
                
                //Get Tenant Information
                if (unitInformation.Tenant != null)
                {
                    var tenantInfo = new TenantViewModel().GetSelectedTenant(unitInformation.Tenant);

                    if (tenantInfo != null)
                        txtBoxTenant.Text = tenantInfo.FirstName + " " + tenantInfo.LastName;
                    else
                        txtBoxTenant.Text = "N/A";
                }
                else
                    txtBoxTenant.Text = "N/A";

                if (unitInformation.Owner != null)
                {
                    var ownerInfo = new TenantViewModel().GetSelectedTenant(unitInformation.Owner);

                    if (ownerInfo != null)
                        txtBoxUnitOwner.Text = ownerInfo.FirstName + " " + ownerInfo.LastName;
                    else
                        txtBoxUnitOwner.Text = "N/A";
                }
                else
                    txtBoxUnitOwner.Text = "N/A";

                //Get Particulars
                //Monthly Assoc
                lstBoxParticulars.Items.Clear();
         
                var monthlyAssocs = new MonthlyAssociationDueViewModel().GetAllUnpaid(cmbBoxUnitNo.Text);

                monthlyAssocs.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem("Monthly Association Fee");

                    lvi.SubItems.Add(DateTime.Parse(item.DueDate.ToString()).ToShortDateString());

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.Balance));

                    lstBoxParticulars.Items.Add(lvi);
                });

                //Reservation

                var reservations = new ReservationViewModel().GetAllUnpaid(cmbBoxUnitNo.Text);

                reservations.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem("Reservation Fee");

                    lvi.SubItems.Add(item.DateOfFuntion.AddDays(-3).ToShortDateString());

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.Balance));

                    lstBoxParticulars.Items.Add(lvi);
                });
            }
        }
    }
}
