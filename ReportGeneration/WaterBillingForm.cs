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
using Tenancy_Management_Information_Systems.Utilities;
using Echo.Data.Repository;

namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    public partial class WaterBillingForm : Form
    {
        TenantViewModel tenantVm; //database connection for tenant

        WaterBillingViewModel billingVm; //database conneciton for water billing

        UnitViewModel unitVm; //database connection for Unit

        public WaterBillingForm()
        {
            InitializeComponent();

            GetUnits(); //Get combo box data upon loading

            txtBoxChargeDate.Text = DateTime.Now.ToShortDateString(); //Get today's Date         
        }

        private void ClearFields()
        {
            txtBoxBillAmount.Text = txtBoxPreviousBillAmount.Text = txtBoxCurrentReading.Text =
                txtBoxPreviousReading.Text = txtBoxUnitOwner.Text = txtBoxTenant.Text = "";

            //dates
            dateTimeFrom.Value = DateTime.Now;
            dateTimeTo.Value = dateTimeFrom.Value.AddMonths(1);
            dateTimeDueDate.Value = dateTimeFrom.Value.AddMonths(1).AddDays(15);
        }

        private void GetBalance(string _unitNo)
        {
            decimal totalBalance = 0;

            listViewPreviousBalance.Items.Clear(); //clear existing record on table

            billingVm = new WaterBillingViewModel(); //refresh db connection

            var balance = billingVm.GetPreviousBalance(_unitNo);

            balance.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.Date.ToShortDateString());

                lvi.SubItems.Add(string.Format("{0:0.00}", item.Amount));

                listViewPreviousBalance.Items.Add(lvi);

                totalBalance += item.Amount; //Get total amount remaining balance
            });

            txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", totalBalance);
        }

        private void GetUnitInformation(string _unitNo)
        {
            unitVm = new UnitViewModel();
            tenantVm = new TenantViewModel();

            var unit = unitVm.GetSelected(_unitNo);

            //Assign unit information
            //Owner Information
            if (unit.Owner != null)
            {
                var owner = tenantVm.GetSelectedTenant(unit.Owner);

                txtBoxUnitOwner.Text = owner.FirstName + " " + owner.LastName;
            }
            else
            {
                txtBoxUnitOwner.Text = "N/A";
            }
            //Tenant Information
            if (unit.Tenant != null)
            {
                var tenant = tenantVm.GetSelectedTenant(unit.Tenant);

                txtBoxTenant.Text = tenant.FirstName + " " + tenant.LastName;
            }
            else
            {
                txtBoxTenant.Text = "N/A";
            }

            GetPreviousBilling(_unitNo); //Fetch previous billing

            GetBalance(_unitNo); //Fetch Remaining Balance
        }

        private void GetPreviousBilling(string _unitNo)
        {
            billingVm = new WaterBillingViewModel(); //releoad database connection

            var previousBilling = billingVm.GetPreviousBilling(_unitNo);

            if (previousBilling != null)
            {
                txtBoxPreviousReading.Text = previousBilling[0]; //Reading

                txtBoxPreviousBillAmount.Text = previousBilling[1]; //Amount
            }
            else //If no previous Billing Record found
            {
                txtBoxPreviousBillAmount.Text = "0.00";

                txtBoxPreviousReading.Text = "N/A";
            }
        }

        private void AddSummary()
        {
            lstViewSummary.Items.Clear();

            ListViewItem lvi = new ListViewItem(txtBoxChargeDate.Text);

            lvi.SubItems.Add(cmbBoxUnitNo.Text);

            lvi.SubItems.Add(txtBoxPreviousReading.Text);

            lvi.SubItems.Add(txtBoxCurrentReading.Text);

            lvi.SubItems.Add(txtBoxTotalAmountDue.Text);

            lstViewSummary.Items.Add(lvi);
        }

        private void GetUnits()
        {
            cmbBoxUnitNo.Items.Clear(); //Clear Combo box

            unitVm = new UnitViewModel(); //reload database connection

            var unitNumbers = unitVm.GetAll().OrderBy(r => r.UnitNumber).ToList();

            unitNumbers.ForEach(item =>
            {
                cmbBoxUnitNo.Items.Add(item.UnitNumber);
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TenancyManagement.viewUnitNumberForm v2 = new TenancyManagement.viewUnitNumberForm();
            v2.Show();
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBoxUnitNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load unit information upon selecting value
            ClearFields();

            GetUnitInformation(cmbBoxUnitNo.Text);
        }

        private void dateTimeFrom_ValueChanged(object sender, EventArgs e)
        {
            //automatically assign 1 month advance in TO Date
            dateTimeTo.Value = dateTimeFrom.Value.AddMonths(1);

            //assign 15 days for due date
            dateTimeDueDate.Value = dateTimeTo.Value.AddDays(15);
        }

        private void txtBoxBillAmount_TextChanged(object sender, EventArgs e)
        {
            //disable checkboxes if no amount
            if(txtBoxBillAmount.Text != "")
            {
                //To enable Fee checkboxes
                checkBoxDisconnectionFee.Enabled = true;

                checkBoxOverdue.Enabled = true;

                txtBoxTotalAmountDue.Text = 
                    string.Format("{0:0.00}",decimal.Parse(txtBoxBillAmount.Text));
            }
            else
            {
                checkBoxDisconnectionFee.Enabled = false;

                checkBoxOverdue.Enabled = false;

                txtBoxTotalAmountDue.Text = "0.00";
            }
        }

        private void txtBoxBillAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormUtilities formUtilities = new FormUtilities();

            formUtilities.AllowsNumericOnly(sender, e); //allows numeric only
        }

        private void checkBoxOverdue_CheckedChanged(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(txtBoxTotalAmountDue.Text);

            if (checkBoxOverdue.Checked)
            {
                total += 250;
            }
            else
            {
                total -= 250;
            }

            txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", total);
        }

        private void checkBoxDisconnectionFee_CheckedChanged(object sender, EventArgs e)
        {
            decimal total = decimal.Parse(txtBoxTotalAmountDue.Text);

            if (checkBoxDisconnectionFee.Checked)
            {
                total += 250;
            }
            else
            {
                total -= 250;
            }

            txtBoxTotalAmountDue.Text = string.Format("{0:0.00}", total);
        }

        private void btnUserCreate_Click(object sender, EventArgs e)
        {
            //check required fields
            string errorMessage = "";

            if (cmbBoxUnitNo.Text == "")
                errorMessage += "Unit number is required\n";
            else
            {
                if (billingVm.IfBillingAlreadyExist(cmbBoxUnitNo.Text))
                {
                    errorMessage += "There is already existing billing for this month\n";
                }
            }

            if (txtBoxCurrentReading.Text == "")
                errorMessage += "Current reading is required\n";

            if (txtBoxBillAmount.Text == "")
                errorMessage += "Bill amount is required\n";

            if (dateTimeFrom.Value == dateTimeTo.Value)
                errorMessage += "Consumption date must be a date-range\n";

            if (dateTimeDueDate.Value <= dateTimeTo.Value)
                errorMessage += "Due date must be greater than From date\n";

            if (dateTimeFrom.Value > dateTimeTo.Value)
                errorMessage += "To date must be greater than From date\n";            

            if (errorMessage == "")
            {
                DialogResult result = MessageBox.Show("Are you sure you want to save? Y/N", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)//Confirmation 
                {
                    //asign values
                    WaterBilling waterBilling = new WaterBilling();

                    waterBilling.ChargeDate = DateTime.Now; //Get today's date

                    waterBilling.CurrentReading = txtBoxCurrentReading.Text;

                    waterBilling.TotalAmount = waterBilling.Balance =
                        decimal.Parse(txtBoxTotalAmountDue.Text);

                    waterBilling.UnitNumber = cmbBoxUnitNo.Text;

                    waterBilling.Paid = 0;

                    //dates
                    waterBilling.ToDate = dateTimeTo.Value;

                    waterBilling.FromDate = dateTimeFrom.Value;

                    waterBilling.DueDate = dateTimeDueDate.Value;

                    //previous
                    waterBilling.PreviousAmount = decimal.Parse(txtBoxPreviousBillAmount.Text);

                    waterBilling.PreviousReading = txtBoxPreviousReading.Text;

                    billingVm.CreateWaterBilling(waterBilling); //save water billing

                    AddSummary(); //add data on table
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Warning");
            }
        }
    }
}
