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
using System.IO;

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class viewUnitNumberForm : Form
    {
        UnitViewModel unitVM = new UnitViewModel();

        TenantViewModel tenantVM = new TenantViewModel();

        public viewUnitNumberForm(string _unitNo)
        {
            InitializeComponent();

            GetInformation(_unitNo);
        }

        private void GetInformation(string _unitNo)
        {
            var unit = unitVM.GetSelected(_unitNo);

            if(unit != null)
            {
                if(unit.Tenant != null)
                {
                    var tenant = tenantVM.GetSelectedTenant(unit.Tenant);

                    if(tenant != null)
                    {
                        txtBoxFirstName.Text = tenant.FirstName;

                        txtBoxMiddleName.Text = tenant.MiddleName;

                        txtBoxLastName.Text = tenant.LastName;

                        txtBoxMaritalStatus.Text = tenant.MaritalStatus;

                        txtBoxDateOfBirth.Text = DateTime.Parse(tenant.DateOfBirth.ToString()).ToShortDateString();

                        txtBoxHomeAddress.Text = tenant.HomeAddress;

                        txtBoxMobileAddress.Text = tenant.MobileNo;

                        txtBoxProvincialAddress.Text = tenant.ProvincialAddress;

                        txtBoxEmailAdd.Text = tenant.Email;

                        txtBoxEndDate.Text = DateTime.Parse(unit.ExpectedEndOfOccupancy.ToString()).ToShortDateString();

                        txtBoxStartDate.Text = DateTime.Parse(unit.StartOfOccupancy.ToString()).ToShortDateString();

                        txtBoxOtherName1.Text = tenant.OtherName1;

                        txtBoxOtherName2.Text = tenant.OtherName2;

                        txtBoxOtheName3.Text = tenant.OtherName3;

                        txtBoxPetName.Text = tenant.PetName;

                        txtBoxPetType.Text = tenant.PetType;

                        txtBoxUsername.Text = tenant.Username;

                        if (tenant.ImageLocation != null)
                        {
                            Stream imgStr = new MemoryStream(tenant.ImageLocation);

                            pictureBox.Image = System.Drawing.Image.FromStream(imgStr);
                        }
                        else
                        {
                            pictureBox.Image = null;
                        }
                    }

                    if (unit.Owner != null)
                    {
                        var owner = tenantVM.GetSelectedTenant(unit.Owner);

                        if(owner != null)
                        {
                            txtBoxUnitOwner.Text = owner.FirstName + " " + owner.LastName;
                        }
                    }

                    txtBoxUnitNo.Text = unit.UnitNumber;


                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
