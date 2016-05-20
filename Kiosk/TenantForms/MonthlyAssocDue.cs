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

namespace Tenancy_Management_Information_Systems.Kiosk.TenantForms
{
    public partial class MonthlyAssocDue : Form
    {
        MonthlyAssociationDueViewModel assocVM;
        WaterBillingViewModel waterVM;

        public MonthlyAssocDue(string _unitNo)
        {
            InitializeComponent();

            assocVM = new MonthlyAssociationDueViewModel();
            waterVM = new WaterBillingViewModel();

            GetAssocDue(_unitNo);
        }

        private void GetAssocDue(string _unitNo)
        {
            var assoc = assocVM.GetPreviousBilling(_unitNo);
            var water = waterVM.GetPrevBilling(_unitNo);

            //Monthly Assoc Due
            if (assoc != null)
            {
                lblAssocTime.Text = DateTime.Parse(assoc.ChargeDate.ToString()).ToShortDateString();
                lblDueDate.Text = DateTime.Parse(assoc.DueDate.ToString()).ToShortDateString();

                lblAssocDueAmount.Text = string.Format("{0:0.00}", assoc.AssociationDue);
                
                //Penalty
                if (assoc.Penalty > 0 && assoc.Penalty != null)
                    lblAssocPenaltyAmount.Text = string.Format("{0:0.00}", assoc.Penalty);
                else
                    lblAssocPenaltyAmount.Text = "0.00";

                if (assoc.OtherPenaltyAmount > 0 && assoc.OtherPenaltyAmount != null)
                    lblOtherPenaltyAmount.Text = string.Format("{0:0.00}", assoc.OtherPenaltyAmount);
                else
                    lblOtherPenaltyAmount.Text = "0.00";
            }
            else
            {
                lblAssocDueAmount.Text = "0.00";
                lblAssocPenaltyAmount.Text = "0.00";
                lblOtherPenaltyAmount.Text = "0.00";
            }

            //Water Billing
            if(water!=null)
            {
                var total = water.TotalAmount;

                if(water.DisconnectionFee != null && water.DisconnectionFee != 0)
                {
                    total -= water.DisconnectionFee;

                    lblWaterDisconnectionAmount.Text = string.Format("{0:0.00}", water.DisconnectionFee);
                }
                else
                {
                    lblWaterDisconnectionAmount.Text = "0.00";
                }

                if(water.OverdueAmount != null && water.OverdueAmount != 0)
                {
                    total -= water.OverdueAmount;

                    lblWaterOverdueAmount.Text = string.Format("{0:0.00}", water.OverdueAmount);
                }
                else
                {
                    lblWaterOverdueAmount.Text = "0.00";
                }

                lblWaterBillAmount.Text = string.Format("{0:0.00}", total);
            }
            else
            {
                lblWaterDisconnectionAmount.Text = "0.00";
                lblWaterOverdueAmount.Text = "0.00";
                lblWaterBillAmount.Text = "0.00";
            }

            //Total
            double totalAmount = 0;
            //Assoc Due
            totalAmount += double.Parse(lblAssocDueAmount.Text);
            totalAmount += double.Parse(lblAssocPenaltyAmount.Text);
            totalAmount += double.Parse(lblOtherPenaltyAmount.Text);
            //Water
            totalAmount += double.Parse(lblWaterBillAmount.Text);
            totalAmount += double.Parse(lblWaterOverdueAmount.Text);
            totalAmount += double.Parse(lblWaterDisconnectionAmount.Text);

            lblVAT.Text = string.Format("{0:0.00}", totalAmount * 0.12);
            lblTotalAmount.Text = string.Format("{0:0.00}", totalAmount - double.Parse(lblVAT.Text));
           
            lblTotalWithVAT.Text = string.Format("{0:0.00}", totalAmount);
        }

        private void pnlAssocDues_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
