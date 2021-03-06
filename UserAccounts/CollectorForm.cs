﻿using System;
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
using Tenancy_Management_Information_Systems.ReportForms.Billing;
using Echo.Data.Repository.Models;
using Tenancy_Management_Information_Systems.TenancyManagement;

namespace Tenancy_Management_Information_Systems.UserAccounts
{
    public partial class CollectorForm : Form
    {
        Guid selectedID;

        string type = "";

        FormUtilities formUlility = new FormUtilities();

        LoginInfo loginInfo;

        Guid paymentID;

        double total = 0;

        double totalAmount = 0;

        double totalAssoc = 0.00;

        double waterBilling = 0;

        double penalty = 0;

        double originalAssoc = 0;

        public CollectorForm(LoginInfo loginInfo)
        {
            InitializeComponent();

            GetUnitDropDown();

            this.loginInfo = loginInfo;
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

        private void Clear()
        {
            lstBoxParticulars.Items.Clear();

            cmbBoxUtilityBilling.Text = comboBoxMonths.Text = txtBoxExactNoOfMonths.Text = txtBoxDiscount.Text = 
                txtBoxBillDate.Text = txtBoxDueDate.Text = txtBoxUnitOwner.Text = txtBoxTenant.Text = txtBoxTenderedAmount.Text =
                txtBoxChange.Text = "";

            txtBoxTotalAmountDue.Text = "0.00";
        }

        private void GetParticulars()
        {
            lstBoxParticulars.Items.Clear();

            if (cmbBoxUtilityBilling.Text == "Monthly Association Dues")
            {
                checkBoxAdvancePayment.Visible = true;

                //Get Particulars
                //Monthly Assoc                

                var monthlyAssocs = new MonthlyAssociationDueViewModel().GetAllUnpaid(cmbBoxUnitNo.Text);

                monthlyAssocs.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(item.ID.ToString());

                    lvi.SubItems.Add("Monthly Association Fee");

                    lvi.SubItems.Add(DateTime.Parse(item.DueDate.ToString()).ToShortDateString());

                    lvi.SubItems.Add(string.Format("{0:0.00}", item.Balance));

                    lstBoxParticulars.Items.Add(lvi);

                });
            }
            else if(cmbBoxUtilityBilling.Text == "Reservation")
            {
                checkBoxAdvancePayment.Visible = false;

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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetParticulars();
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
            string error = "";

            if (txtBoxTenderedAmount.Text == "")
                error += "Tendered Amount is required\n";

            if (error == "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (type == "ASSOC")
                    {
                        var assocVM = new MonthlyAssociationDueViewModel();

                        Guid ID = assocVM.ProcessPayment(selectedID, decimal.Parse(txtBoxTenderedAmount.Text));
                        if (ID != Guid.Empty)
                        {
                            MessageBox.Show("Successfully processed payment");

                            btnPreview.Enabled = true;

                            paymentID = ID;
                        }
                        else
                            MessageBox.Show("Cannot process payment there was some kind of error", "Error");
                    }
                    else
                    {
                        var reservationVM = new ReservationViewModel();

                        if (reservationVM.ProcessPaymenet(selectedID, decimal.Parse(txtBoxTenderedAmount.Text)))
                        {
                            MessageBox.Show("Successfully processed payment");

                            btnPreview.Enabled = true;
                        }
                        else
                            MessageBox.Show("Cannot process payment there was some kind of error", "Error");
                    }
                }

                GetParticulars();
            }
        }

        private void EnablePaymentForm(bool type)
        {
            cmbBoxUtilityBilling.Enabled = comboBoxMonths.Enabled =
                txtBoxTenderedAmount.Enabled = txtBoxExactNoOfMonths.Enabled =
                btnUserCreate.Enabled = type;
        }

        private void cmbBoxUnitNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();

            if (cmbBoxUnitNo.Text != "")
            {
                EnablePaymentForm(true);

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
            }
            else
            {
                EnablePaymentForm(false);
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

                    total = double.Parse(monthlyAssoc.Balance.ToString());

                    totalAmount = double.Parse(monthlyAssoc.AssociationDue.ToString());

                    waterBilling = double.Parse(monthlyAssoc.WaterBillTotalDue.ToString());

                    totalAssoc = double.Parse(monthlyAssoc.AssociationDue.ToString());

                    penalty = double.Parse((monthlyAssoc.Penalty + monthlyAssoc.OtherPenaltyAmount).ToString());

                    originalAssoc = double.Parse(monthlyAssoc.AssociationDue.ToString());
                }
                else if (reservation != null)
                {
                    txtBoxBillAmount.Text = string.Format("{0:0.00}", reservation.Amount);

                    txtBoxBillDate.Text = reservation.Date.ToShortDateString();

                    txtBoxDueDate.Text = reservation.DateOfFuntion.AddDays(7).ToShortDateString();

                    txtBoxPenalties.Text = "0.00";

                    txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", reservation.Balance);

                    type = "RESERVATION";

                    total = double.Parse(reservation.Balance.ToString());
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
                decimal total = decimal.Parse(txtBoxTenderedAmount.Text);

                total -= decimal.Parse(txtBoxTotalAmountDue.Text);

                if (total < 0)
                    txtBoxChange.Text = "0.00";
                else
                    txtBoxChange.Text = string.Format("{0:0.00}", total);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            double tempTotal = 0;

            double tempDiscount = 0;

            tempTotal = totalAssoc;

            if (comboBoxMonths.Text == "2-5 mo.")
            {
                txtBoxDiscount.Text = "0%";

                txtBoxExactNoOfMonths.Text ="2";
            }
            else if (comboBoxMonths.Text == "6-11 mo. -- 2.5%")
            {
                txtBoxDiscount.Text = "2.5%";

                tempDiscount = totalAssoc * 0.025;

                txtBoxExactNoOfMonths.Text = "6";
            }
            else if(comboBoxMonths.Text == "12-17 mo. -- 5.0%")
            {
                txtBoxDiscount.Text = "5%";

                tempDiscount = totalAssoc * 0.05;

                txtBoxExactNoOfMonths.Text = "12";
            }
            else if(comboBoxMonths.Text == "18-23 mo. -- 8.0%")
            {
                txtBoxDiscount.Text = "8%";

                tempDiscount = totalAssoc * 0.08;

                txtBoxExactNoOfMonths.Text = "18";
            }
            else if(comboBoxMonths.Text == "24 mo. & up -- 11.0%")
            {
                txtBoxDiscount.Text = "11%";

                tempDiscount = totalAssoc * 0.11;

                txtBoxExactNoOfMonths.Text = "24";
            }

            tempTotal = tempTotal - tempDiscount;

            txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", tempTotal + waterBilling + penalty);

            txtBoxDiscounts.Text = string.Format("{0:0.00}", tempDiscount);

            ComputeAdvance();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            double temp = 0;

            if (totalAssoc != originalAssoc)
                temp = totalAssoc;

            Receipt form = new Receipt(paymentID,loginInfo.fullName, temp);

            form.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtBoxExactNoOfMonths_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUlility.AllowsNumericOnly(sender, e);
        }

        private void txtBoxExactNoOfMonths_TextChanged(object sender, EventArgs e)
        {
            ComputeAdvance();
        }

        private void ComputeAdvance()
        {
            double temp = 0;

            if (txtBoxExactNoOfMonths.Text != "")
            {
                totalAssoc = totalAmount * double.Parse(txtBoxExactNoOfMonths.Text);
            }

            temp += totalAssoc;

            temp += waterBilling;

            txtBoxBillAmount.Text = string.Format("{0:0.00}", temp);

            temp += penalty;

            temp -= double.Parse(txtBoxDiscounts.Text);

            txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", temp);
        }

        private void txtBoxExactNoOfMonths_KeyUp(object sender, KeyEventArgs e)
        {
            ComputeAdvance();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbBoxUnitNo.Text != "")
            {
                viewUnitNumberForm form = new viewUnitNumberForm(cmbBoxUnitNo.Text);

                form.ShowDialog();
            }
        }
    }
}
