using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Echo.Data.Repository;
using Tenancy_Management_Information_Systems.Utilities;
using Echo.Data.Repository.ViewModel;

namespace Tenancy_Management_Information_Systems.Kiosk.TenantForms
{
    public partial class RequestForm : Form
    {
        FormUtilities utilities = new FormUtilities();

        UnitProfile unitProfile;

        public RequestForm()
        {
            InitializeComponent();
        }

        private void GetUnitProfile()
        {
            if (txtBoxUnitNo.Text != "")
            {
                unitProfile = new UnitViewModel().GetSelected(txtBoxUnitNo.Text);

                if (unitProfile != null)
                {
                    if (unitProfile.Tenant != null)
                    {
                        var tenant = new TenantViewModel().GetSelectedTenant(unitProfile.Tenant);

                        txtBoxUnitOwner.Text = tenant.FirstName + " " + tenant.LastName;

                    }
                    else
                        txtBoxUnitOwner.Text = "N/A";
                }
                else
                {
                    MessageBox.Show("Invalid Unit no", "Warning");

                    txtBoxUnitNo.Text = "";

                    txtBoxUnitOwner.Text = "";
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBoxUnitNo_KeyUp(object sender, KeyEventArgs e)
        {
 
        }

        private void txtBoxUnitNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxRequest1_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxRequest1.Text != "")
                txtBoxRequest2.Enabled = true;
            else
                txtBoxRequest2.Enabled = false;
        }

        private void txtBoxRequest2_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxRequest2.Text != "")
                txtBoxRequest3.Enabled = true;
            else
                txtBoxRequest3.Enabled = false;
        }

        private void txtBoxRequest3_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxRequest3.Text != "")
                txtBoxRequest4.Enabled = true;
            else
                txtBoxRequest4.Enabled = false;
        }

        private void txtBoxUnitNo_Leave(object sender, EventArgs e)
        {
            GetUnitProfile();
        }

        private void txtBoxUnitOwner_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBoxUnitOwner_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetUnitProfile(); 
            }
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxUnitNo.Text == "")
                errorMessage += "Unit no is required\n";

            if (cmbBoxProject.Text == "")
                errorMessage +="Project type is required\n";

            if (datePickerPrefferedDate.Value <= DateTime.Now)
                errorMessage += "Preffered date must be greater that today's date";

            if (txtBoxTime.Text == "")
                errorMessage += "Preffered time is required\n";

            try
            {
                DateTime time = DateTime.Parse(txtBoxTime.Text);
            }
            catch
            {
                errorMessage += "Invalid time";

                txtBoxTime.Text = "";
            }

            if (errorMessage == "")
            {
                var requestVM = new RequestViewModel();

                Request request = new Request();

                request.ContactNo = txtBoxContactNo.Text;

                request.Date = DateTime.Now;

                request.Owner = txtBoxUnitOwner.Text;

                request.Request1 = txtBoxRequest1.Text;

                request.Request2 = txtBoxRequest2.Text;

                request.Request3 = txtBoxRequest3.Text;

                request.Request4 = txtBoxRequest4.Text;

                request.Time = txtBoxTime.Text;

                request.Project = cmbBoxProject.Text;

                request.UnitNumber = txtBoxUnitNo.Text;

                request.ScheduleDate = datePickerPrefferedDate.Value;

                //request.UnitProfile = unitProfile;

                if (requestVM.Save(request))
                {
                    MessageBox.Show("Successfully saved");
                }
                else
                    MessageBox.Show("Cannot save request. There was some kind of error", "Error on saving");

            }
            else
                MessageBox.Show(errorMessage, "Error on saving");
        }
    }
}
