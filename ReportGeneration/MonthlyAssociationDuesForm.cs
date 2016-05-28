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
using Tenancy_Management_Information_Systems.ReportForms.Billing;

namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    public partial class MonthlyAssociationDuesForm : Form
    {
        //Database Connection per table
        WaterBillingViewModel waterBillingVM;
        UnitViewModel unitVM;
        TenantViewModel tenantVM;   
        PaymentHistoryViewModel paymentHistoryVM;
        MonthlyAssociationDueViewModel assocVM;

        FormUtilities formUtilities = new FormUtilities();
     
        double penalty = 0;

        Guid assocID = Guid.Empty;

        WaterBilling waterBilling;

        public MonthlyAssociationDuesForm()
        {
            InitializeComponent();

            txtBoxTotalAmountDue.Text = "0.00";

            txtBoxChargeDate.Text = DateTime.Now.ToShortDateString(); // assign charge date

            dateTimeDueDate.Value = DateTime.Now.AddDays(15); // 15 days deadline

            GetUnitDropDown();
        }

        private void GetUnitDropDown()
        {
            cmbBoxUnitNo.Items.Clear();

            unitVM = new UnitViewModel(); //refresh database connection

            var units = unitVM.GetAll();

            units.ForEach(item =>
            {
                cmbBoxUnitNo.Items.Add(item.UnitNumber);
            });
        }

        private void AddDuesToSummaryTable()
        {
            ListViewItem lvi = new ListViewItem(txtBoxChargeDate.Text);
            lvi.SubItems.Add(txtBoxPrevBillAmount.Text);
            lvi.SubItems.Add(txtBoxTotalAmountDue.Text);

            listViewSummary.Items.Add(lvi);
        }

        private void GetPreviousBilling()
        {
            //Previous billing amount
            assocVM = new MonthlyAssociationDueViewModel();

            var prevBillin = assocVM.GetPreviousBilling(cmbBoxUnitNo.Text);

            if(prevBillin!=null)
            {
                txtBoxPrevBillAmount.Text = string.Format("{0:0.00}", prevBillin.TotalAmount);
            }
            else
            {
                txtBoxPrevBillAmount.Text = "N/A";
            }

            //Date of last payment
            paymentHistoryVM = new PaymentHistoryViewModel();

            var paymentHistory = paymentHistoryVM.GetLastPayment(cmbBoxUnitNo.Text);

            if (paymentHistory != null)
            {
                txtBoxDateOfLastPayment.Text = paymentHistory.ToString();
            }
            else
            {
                txtBoxDateOfLastPayment.Text = "N/A";
            }
        }

        private void Clear()
        {
            txtBoxAssociationDues.Text = "";

            txtBoxWaterBilling.Text = "";

            txtBoxDiscount.Text = "";

            txtBoxOtherAmount.Text = "";

            txtBoxOtherDesc.Text = "";

            txtBoxTotalAmountDue.Text = "0.00";
        }

        private void GetUnitInformation(string _unitNo)
        {
            Clear();

            unitVM = new UnitViewModel();

            tenantVM = new TenantViewModel();

            var unit = unitVM.GetSelected(_unitNo);

            //Assign unit information
            //Owner Information
            if (unit.Owner != null)
            {
                var owner = tenantVM.GetSelectedTenant(unit.Owner);

                if (owner != null)
                    txtBoxUnitOwner.Text = owner.FirstName + " " + owner.LastName;
                else
                    txtBoxUnitOwner.Text = "N/A";
            }
            else
            {
                txtBoxUnitOwner.Text = "N/A";
            }
            //Tenant Information
            if (unit.Tenant != null)
            {
                var tenant = tenantVM.GetSelectedTenant(unit.Tenant);

                if (tenant != null)
                    txtBoxTenant.Text = tenant.FirstName + " " + tenant.LastName;
                else
                    txtBoxTenant.Text = "N/A";
            }
            else
            {
                txtBoxTenant.Text = "N/A";
            }

            GetWaterBilling();
        }

        private void GetWaterBilling()
        {
            waterBillingVM = new WaterBillingViewModel(); //Refresh connection

            waterBilling = waterBillingVM.GetPrevBilling(cmbBoxUnitNo.Text);

            if(waterBilling != null)
            {
                txtBoxWaterBilling.Text = string.Format("{0:0.00}",waterBilling.TotalAmount);

                ComputeTotal();
            }
            else
            {
                txtBoxWaterBilling.Text = "0.00";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cmbBoxUnitNo.Text != "")
            {
                TenancyManagement.viewUnitNumberForm v1 = new TenancyManagement.viewUnitNumberForm(cmbBoxUnitNo.Text);
                v1.Show();
            }
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxOthers_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxOthers.Checked)
            {
                txtBoxOtherDesc.Enabled = true;
                txtBoxOtherAmount.Enabled = true;
            }
            else
            {
                txtBoxOtherDesc.Enabled = false;
                txtBoxOtherAmount.Enabled = false;
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (cmbBoxUnitNo.Text == "")
                errorMessage += "Unit no is required\n";

            if (txtBoxAssociationDues.Text == "")
                errorMessage += "Month association fee is required\n";

            if(errorMessage =="")
            {
                assocVM = new MonthlyAssociationDueViewModel();

                MonthlyAssociationDue newAssoc = new MonthlyAssociationDue();
                newAssoc.UnitNumber = cmbBoxUnitNo.Text;
                newAssoc.ChargeDate = DateTime.Now;
                newAssoc.DueDate = dateTimeDueDate.Value;
                newAssoc.AssociationDue = decimal.Parse(txtBoxAssociationDues.Text);

                if (txtBoxWaterBilling.Text == "N/A")
                    newAssoc.WaterBillTotalDue = 0;
                else
                    newAssoc.WaterBillTotalDue = decimal.Parse(txtBoxWaterBilling.Text);

                if (txtBoxDiscount.Text == "")
                    newAssoc.Discounts = 0;
                else
                    newAssoc.Discounts = decimal.Parse(txtBoxDiscount.Text);



                newAssoc.Balance = newAssoc.TotalAmount = decimal.Parse(txtBoxTotalAmountDue.Text);
                newAssoc.Paid = 0;

                if(waterBilling != null)
                {
                    newAssoc.WaterCurrentReading = waterBilling.CurrentReading;

                    newAssoc.WaterPreviousReading = waterBilling.PreviousReading;

                    newAssoc.WaterDate = waterBilling.ChargeDate;
                }

                if (checkBoxOverdue.Checked)
                    newAssoc.Penalty = decimal.Parse((double.Parse(
                        txtBoxAssociationDues.Text) * 0.04).ToString());
                else
                    newAssoc.Penalty = 0;

                if (txtBoxOtherAmount.Text != "")
                    newAssoc.OtherPenaltyAmount = decimal.Parse(txtBoxOtherAmount.Text);
                else
                    newAssoc.OtherPenaltyAmount = 0;

                if (txtBoxOtherDesc.Text != "")
                    newAssoc.OtherPenalty = txtBoxOtherDesc.Text;
                else
                    newAssoc.OtherPenalty = "N/A";

                DialogResult result = MessageBox.Show("Are you sure you want to save? Y/N", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    assocID = assocVM.CreateMonthlyAssoc(newAssoc);

                    if (assocID!= Guid.Empty)
                    {
                        AddDuesToSummaryTable();

                        MessageBox.Show("Successfully save");

                        btnPreview.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cannot save association dues. There was some kind of error", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Warning");
            }
        }

        private void cmbBoxUnitNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetUnitInformation(cmbBoxUnitNo.Text);
        }

        private void txtBoxOtherAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void checkBoxOverdue_CheckedChanged(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private void txtBoxDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            //Auto deduction of discount to total amount due
            if(txtBoxDiscount.Text != "")
            txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", 
                decimal.Parse(txtBoxTotalAmountDue.Text) - decimal.Parse(txtBoxDiscount.Text));
        }

        private void txtBoxAssociationDues_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void ComputeTotal()
        {
            double total = 0;

            if (txtBoxAssociationDues.Text != "")
            {
                total += double.Parse(txtBoxAssociationDues.Text);
            }

            if (txtBoxWaterBilling.Text != "")
            {
                total += double.Parse(txtBoxWaterBilling.Text);
            }

            if (txtBoxAssociationDues.Text != "")
            {
                if (checkBoxOverdue.Checked)
                {
                    total += double.Parse(txtBoxAssociationDues.Text) * 0.04;
                }
            }

            if(txtBoxOtherAmount.Text !="")
            {
                total += double.Parse(txtBoxOtherAmount.Text);
            }

            txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", total);
        }

        private void txtBoxAssociationDues_TextChanged(object sender, EventArgs e)
        {
                ComputeTotal();
        }

        private void txtBoxOtherAmount_TextChanged(object sender, EventArgs e)
        {
                ComputeTotal();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            StatementOfAccount form = new StatementOfAccount(assocID);

            form.Show();
        }
    } 
}
