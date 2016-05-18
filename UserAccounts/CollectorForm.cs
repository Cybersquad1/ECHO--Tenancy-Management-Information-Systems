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
using Tenancy_Management_Information_Systems.Utilities;

namespace Tenancy_Management_Information_Systems.UserAccounts
{
    public partial class CollectorForm : Form
    {
        Guid selectedID;

        string type = "";

        FormUtilities formUlility = new FormUtilities();

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
            if(type == "ASSOC")
            {
                var assocVM = new MonthlyAssociationDueViewModel();

                if (assocVM.ProcessPayment(selectedID, decimal.Parse(txtBoxTenderedAmount.Text)))
                {
                    MessageBox.Show("Successfully processed payment");
                }
                else
                    MessageBox.Show("Cannot process payment there was some kind of error", "Error");
            }
            else
            {
                var reservationVM = new ReservationViewModel();

                if(reservationVM.ProcessPaymenet(selectedID,decimal.Parse(txtBoxTenderedAmount.Text)))
                {
                    MessageBox.Show("Successfully processed payment");
                }
                else
                    MessageBox.Show("Cannot process payment there was some kind of error", "Error");
            }
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
                    ListViewItem lvi = new ListViewItem(item.ID.ToString());

                    lvi.SubItems.Add("Monthly Association Fee");

                    lvi.SubItems.Add(DateTime.Parse(item.DueDate.ToString()).ToShortDateString());

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.Balance));

                    lstBoxParticulars.Items.Add(lvi);
                });

                //Reservation

                var reservations = new ReservationViewModel().GetAllUnpaid(cmbBoxUnitNo.Text);

                reservations.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(item.ID.ToString());

                    lvi.SubItems.Add("Reservation Fee");

                    lvi.SubItems.Add(item.DateOfFuntion.AddDays(-3).ToShortDateString());

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.Balance));

                    lstBoxParticulars.Items.Add(lvi);
                });
            }
        }

        private void lstBoxParticulars_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                selectedID = Guid.Parse(lstBoxParticulars.SelectedItems[0].SubItems[0].Text);

                var monthlyAssoc = new MonthlyAssociationDueViewModel().GetSelected(selectedID);

                var reservation = new ReservationViewModel().GetSelected(selectedID);

                if (monthlyAssoc != null)
                {
                    txtBoxBillAmount.Text = string.Format("{0:0.00}", monthlyAssoc.TotalAmount - (monthlyAssoc.Penalty + monthlyAssoc.OtherPenaltyAmount));

                    txtBoxBillDate.Text = DateTime.Parse(monthlyAssoc.ChargeDate.ToString()).ToShortDateString();

                    txtBoxDueDate.Text = DateTime.Parse(monthlyAssoc.DueDate.ToString()).ToShortDateString();

                    txtBoxPenalties.Text = string.Format("{0:0.00}", monthlyAssoc.Penalty + monthlyAssoc.OtherPenaltyAmount);

                    txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", monthlyAssoc.Balance);

                    type = "ASSOC";
                }
                else if (reservation != null)
                {
                    txtBoxBillAmount.Text = string.Format("{0:0.00}", reservation.Amount);

                    txtBoxBillDate.Text = reservation.Date.ToShortDateString();

                    txtBoxDueDate.Text = reservation.DateOfFuntion.AddDays(7).ToShortDateString();

                    txtBoxPenalties.Text = "0.00";

                    txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", reservation.Balance);

                    type = "RESERVATION";
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void txtBoxTenderedAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUlility.AllowsNumericOnly(sender, e);
        }

        private void txtBoxTenderedAmount_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxTenderedAmount.Text != "")
            {
                decimal total = decimal.Parse(txtBoxTotalAmountDue.Text);

                total -= decimal.Parse(txtBoxTenderedAmount.Text);

                txtBoxChange.Text = string.Format("{0:0.00}", total);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
