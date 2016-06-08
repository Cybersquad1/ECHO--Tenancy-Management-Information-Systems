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

namespace Tenancy_Management_Information_Systems.Kiosk.TenantForms
{
    public partial class ReservationForm : Form
    {
        ReservationViewModel reservationVM;

        decimal amount = 0;

        public ReservationForm(string _unitNo)
        {
            InitializeComponent();

            datePickerDate.Value = DateTime.Now;

            reservationVM = new ReservationViewModel();

            txtBoxUnitNo.Text = _unitNo;

            GetUnitInformation(_unitNo);
        }

        private void GetUnitInformation(string _unitNo)
        {
            var unitInfo = new UnitViewModel().GetSelected(_unitNo);

            if(unitInfo != null)
            {
                if (unitInfo.Owner != null)
                {
                    var tenant = new TenantViewModel().GetSelectedTenant(unitInfo.Owner);

                    if(tenant != null)
                    {
                        txtBoxUnitOwner.Text = tenant.FirstName + " " + tenant.LastName;
                    }
                    else
                    {
                        txtBoxUnitOwner.Text = "N/A";
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Unit No", "Warning");

                txtBoxUnitNo.Text = "";

                txtBoxUnitNo.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxUnitNo_Leave(object sender, EventArgs e)
        {
            GetUnitInformation(txtBoxUnitNo.Text);
        }

        private void cmbBoxReservedFacility_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxReservedFacility.Text != "")
                datePickerFunction.Enabled = true;

             if (cmbBoxReservedFacility.Text == "Function Room")
                amount = 5500;
             else
                amount = 4000;
        }

        private void datePickerFunction_ValueChanged(object sender, EventArgs e)
        {
            if(!reservationVM.CheckIfAvailable(cmbBoxReservedFacility.Text, datePickerFunction.Value))
                MessageBox.Show("Date selected is already reserved", "Warning");
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (!reservationVM.CheckIfAvailable(cmbBoxReservedFacility.Text, datePickerFunction.Value))
                errorMessage += "Date selected is already reserved\n";

            if (txtBoxUnitNo.Text == "")
                errorMessage += "Unit no is required\n";

            if (txtBoxTime.Text == "")
                errorMessage += "Time is required\n";

            if (txtBoxPurpose.Text == "")
                errorMessage += "Purpose is required\n";

            if (txtBoxNoOfGuests.Text == "")
                errorMessage += "No of Guests is required";

            if(errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error on saving");
            }
            else
            {
                Reservation newReservation = new Reservation();

                newReservation.Amount = amount;

                newReservation.Balance = amount;

                newReservation.Paid = 0;

                newReservation.NoOfGuest = txtBoxNoOfGuests.Text;

                newReservation.Purpose = txtBoxPurpose.Text;

                newReservation.UnitNumber = txtBoxUnitNo.Text;

                newReservation.Time = txtBoxTime.Text;

                newReservation.ContactNo = txtBoxContactNo.Text;

                newReservation.Facility = cmbBoxReservedFacility.Text;

                newReservation.Date = datePickerDate.Value;

                newReservation.DateOfFuntion = datePickerFunction.Value;

                //Default status for new reservation
                newReservation.Status = "To Start";

                if (reservationVM.Save(newReservation))
                {
                    MessageBox.Show("Successfully reserved " + cmbBoxReservedFacility.Text);

                    btnOkay.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Cannot save reservation there was some kind of error", "Error on saving");
                }
            }
        }
    }
}
