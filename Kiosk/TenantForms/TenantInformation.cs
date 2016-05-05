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
    public partial class TenantInformation : Form
    {
        public TenantInformation(Guid _tenantID)
        {
            InitializeComponent();

            GetTenantInformation(_tenantID);
        }

        private void GetTenantInformation(Guid _tenantID)
        {
            TenantViewModel tenantVM = new TenantViewModel();

            var tenant = tenantVM.GetSelectedTenant(_tenantID);

            if (tenant != null)
            {
                //Personal Information
                txtBoxFirstName.Text = tenant.FirstName;
                txtBoxMiddleName.Text = tenant.MiddleName;
                txtBoxLastName.Text = tenant.LastName;
                datePickerDateOfBirth.Value = DateTime.Parse(tenant.DateOfBirth.ToString());
                cmbBoxMaritalStatus.Text = tenant.MaritalStatus;
                txtBoxHomeAddress.Text = tenant.HomeAddress;
                txtBoxProvincialAddress.Text = tenant.ProvincialAddress;
                txtBoxUnitNo.Text = tenant.UnitNumber;

                if(tenant.UnitNumber != null && tenant.UnitNumber != "")
                {
                    var unit = new UnitViewModel().GetSelected(tenant.UnitNumber);

                    if (unit != null)
                    {
                        if(unit.Owner != null && unit.Owner != Guid.Empty)
                        {
                            var owner = tenantVM.GetSelectedTenant(unit.Owner);

                            txtBoxOwner.Text = owner.FirstName + " " + owner.LastName;
                        }
                        else
                        {
                            txtBoxOwner.Text = "N/A";
                        }
                    }
                }
                else
                {
                    txtBoxUnitNo.Text = "N/A";
                }


                comboBoxNatureOfOccupancy.Text = tenant.NatureOfOccupancy;
                txtBoxMobileNo.Text = tenant.MobileNo;
                txtBoxTelNo.Text = tenant.TelephoneNo;
                txtBoxEmail.Text = tenant.Email;

                //Other Information
                txtBoxOtherName1.Text = tenant.OtherName1;
                txtBoxOtherName2.Text = tenant.OtherName2;
                txtBoxOtherName3.Text = tenant.OtherName3;
                txtBoxRelation1.Text = tenant.OtherRelation1;
                txtBoxRelation2.Text = tenant.OtherRelation2;
                txtBoxRelation3.Text = tenant.OtherRelation3;

                //Duration Stay
                if (tenant.StartOfOccupancy != null && tenant.EndOfOccupancy != null)
                {
                    txtBoxStartDate.Text = DateTime.Parse(tenant.StartOfOccupancy.ToString()).ToShortDateString();
                    txtBoxEndDate.Text = DateTime.Parse(tenant.EndOfOccupancy.ToString()).ToShortDateString();
                }
                else
                {
                    txtBoxStartDate.Text = "N/A";
                    txtBoxEndDate.Text = "N/A";
                }
            }
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
