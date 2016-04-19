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
using Echo.Data.Repository.ViewModel;
using Tenancy_Management_Information_Systems.Utilities;

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class CreateNewTenantForm : Form
    {
        string unitNo = "";

        TenantViewModel vm = new TenantViewModel();

        public CreateNewTenantForm()
        {
            InitializeComponent();
        }

        private void Save()
        {
            TenantProfile newTenantProfile = new TenantProfile();

            //Login Credentials
            newTenantProfile.Username = txtBoxUsername.Text;
            newTenantProfile.Password = txtBoxPassword.Text;

            //Personal Information
            newTenantProfile.FirstName = txtBoxFirstname.Text;
            newTenantProfile.MiddleName = txtBoxMiddleName.Text;
            newTenantProfile.LastName = txtBoxLastname.Text;
            newTenantProfile.DateOfBirth = datePickerDateOfBirth.Value;
            newTenantProfile.MaritalStatus = comboBoxMaritalStatus.Text;
            newTenantProfile.UnitNumber = unitNo;
            newTenantProfile.NatureOfOccupancy = txtBoxNatureOfOccupancy.Text;
            newTenantProfile.HomeAddress = txtBoxHomeAddress.Text;
            newTenantProfile.ProvincialAddress = txtBoxProvincialAddress.Text;
            newTenantProfile.MobileNo = txtBoxMobileNo.Text;
            newTenantProfile.TelephoneNo = txtBoxTelNo.Text;
            newTenantProfile.Email = txtBoxEmail.Text;

            //Fire Extinguisher
            if (checkBoxFireExtinguisher.Checked)
                newTenantProfile.WithFireExtinguisher = "Y";
            else
                newTenantProfile.WithFireExtinguisher = "N";

            //With Pet
            if (checkBoxPets.Checked)
                newTenantProfile.WithPets = "Y";
            else
                newTenantProfile.WithPets = "N";

            //With Other
            if (checkBoxWithOther.Checked)
                newTenantProfile.WithOtherOccupants = "Y";
            else
                newTenantProfile.WithOtherOccupants = "N";

            //Other Occupants Information
            if (txtBoxOtherName1.Text != "")
            {
                newTenantProfile.OtherName1 = txtBoxOtherName1.Text;
                newTenantProfile.OtherRelation1 = txtBoxOtherRelation1.Text;
                newTenantProfile.OtherDateOfBirth1 = datePickerOtherDateOfBirth1.Value;
            }

            if(txtBoxOtherName2.Text != "")
            {
                newTenantProfile.OtherName2 = txtBoxOtherName2.Text;
                newTenantProfile.OtherRelation2 = txtBoxOtherRelation2.Text;
                newTenantProfile.OtherDateOfBirth2 = datePickerOtherDateOfBirth2.Value;
            }

            if(txtBoxOtherName3.Text != "")
            {
                newTenantProfile.OtherName3 = txtBoxOtherName3.Text;
                newTenantProfile.OtherRelation3 = txtBoxOtherRelation3.Text;
                newTenantProfile.OtherDateOfBirth3 = datePickerOtherDateOfBirth3.Value;
            }

            //Pets Information
            newTenantProfile.PetBreed = txtBoxPetBreed.Text;
            newTenantProfile.PetQuantity = txtBoxPetQuantity.Text;
            newTenantProfile.PetType = txtBoxPetType.Text;
            newTenantProfile.PetName = txtBoxPetName.Text;

            //Image upload
            if(pictureBoxTenant.Image != null)
            {
                using (var imgStr = new System.IO.MemoryStream())
                {
                    pictureBoxTenant.Image.Save(imgStr, System.Drawing.Imaging.ImageFormat.Jpeg);
                    newTenantProfile.ImageLocation = imgStr.ToArray();
                }
            }

            //Saving process
            vm = new TenantViewModel(); //Refresh Database connection

            if(vm.AddTenant(newTenantProfile))
            {
                MessageBox.Show("Successfully saved");
            }
            else
            {
                MessageBox.Show("Cannot saved new tenant there was some kind or error", "Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWebcam_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Webcam function is not yet available", "Error");
        }

        private void gbPets_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxFirstname.Text == "")
                errorMessage += "Firstname is required\n";

            if (txtBoxLastname.Text == "")
                errorMessage += "Lastname is required\n";

            if (datePickerDateOfBirth.Value >= DateTime.Now)
                errorMessage += "Date of birth must no be equal or exceed from date today\n";

            if (comboBoxMaritalStatus.Text == "")
                errorMessage += "Marital status is required\n";

            if (errorMessage == "")
                Save();
            else
                MessageBox.Show(errorMessage, "Error");
        }

        private void checkBoxWithOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWithOther.Checked)
                groupBoxOtherOccupants.Enabled = true;
            else
                groupBoxOtherOccupants.Enabled = false;
        }

        private void grpboxnew_Enter(object sender, EventArgs e)
        {

        }

        private void checkBoxPets_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPets.Checked)
                groupBoxPets.Enabled = true;
            else
                groupBoxPets.Enabled = false;
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            //upload image to picture box
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files | *.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxTenant.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void txtBoxLastname_Leave(object sender, EventArgs e)
        {
            UserUtilities userUtilities = new UserUtilities();

            txtBoxUsername.Text = userUtilities.GenerateUsername(txtBoxFirstname.Text, txtBoxLastname.Text, txtBoxMiddleName.Text);
            txtBoxPassword.Text = userUtilities.GeneratePassword(10);
        }

    }
}
