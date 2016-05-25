using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tenancy_Management_Information_Systems.Utilities;
using Echo.Data.Repository;
using Echo.Data.Repository.ViewModel;
using System.Text.RegularExpressions;

namespace Tenancy_Management_Information_Systems.User_Accounts
{
    public partial class CreateNewUserForm : Form
    {
        UserUtilities userUtilities = new UserUtilities();

        FormUtilities formUtilities = new FormUtilities();

        public CreateNewUserForm()
        {
            InitializeComponent();
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateUsernameAndPassword()
        {
            if (txtBoxFirstName.Text != "" && txtBoxLastName.Text != "")
            {
                txtBoxUserName.Text = userUtilities.GenerateUsername
                    (txtBoxFirstName.Text, txtBoxLastName.Text, txtBoxMiddleName.Text);

                txtBoxPassword.Text = userUtilities.GeneratePassword(10);
            }
        }

        private UserProfile SetUserValues()
        {
            UserProfile user = new UserProfile();

            if (pictureBoxUser.Image != null)
            {
                using (var imgStr = new System.IO.MemoryStream())
                {
                    pictureBoxUser.Image.Save(imgStr, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.ImageContent = imgStr.ToArray();
                }
            }
           
            user.Username = txtBoxUserName.Text;
            user.FirstName = txtBoxFirstName.Text;
            user.MiddleName = txtBoxMiddleName.Text;
            user.LastName = txtBoxLastName.Text;
            user.DateOfBirth = datePickerDateOfBirth.Value;
            user.MaritalStatus = comboBoxMaritalStatus.Text.ToUpper();
            user.HomeAddress = txtBoxHomeAddress.Text;
            user.ProvincialAddress = txtBoxProvincialAddress.Text;
            user.Password = txtBoxPassword.Text;
            user.MobileNo = txtBoxMobileNo.Text;
            user.TelephoneNo = txtBoxTelNo.Text;
            user.Email = txtBoxEmail.Text;
            user.ContactPerson = txtBoxContactPerson.Text;
            user.ContactNo = txtBoxContactNo.Text;
            user.RelationshipToContact = txtBoxRelationToContactPerson.Text;
            user.Type = comboBoxAccountType.Text.ToUpper();
                  
            return user;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Regex EmailAddress = new Regex(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");

            Regex Letters = new Regex(@"^[a-zA-Z]+$");

            string errorMessage = "";

            //Required field validation
            if (txtBoxFirstName.Text == "")
                errorMessage += "First name is required\n";
            else
            {
                if (!Letters.IsMatch(txtBoxFirstName.Text))
                    errorMessage += "First name must not contain number and special character\n";
            }
            
            if (txtBoxLastName.Text == "")
                errorMessage += "Last name is required\n";
            else
            {
                if (!Letters.IsMatch(txtBoxLastName.Text))
                    errorMessage += "Last name name must not contain number and special character\n";
            }

            if(txtBoxMiddleName.Text != "")
            {
                if (!Letters.IsMatch(txtBoxMiddleName.Text))
                    errorMessage += "Middle name must not contain number and special character\n";
            }

            if (comboBoxMaritalStatus.Text == "")
                errorMessage += "Marital status is required\n";

            if (comboBoxAccountType.Text == "")
                errorMessage += "Account type is required\n";

            if (txtBoxContactNo.Text == "")
                errorMessage += "Contact Number is required\n";

            if (txtBoxContactPerson.Text == "")
                errorMessage += "Contact Person is required\n";
            else
            {
                if (!Letters.IsMatch(txtBoxContactPerson.Text))
                    errorMessage += "Contact Person must not consist of Numbers and Special Characters\n";
            }

            if (txtBoxRelationToContactPerson.Text == "")
                errorMessage += "Relation to contact person is required\n";
            else
            {
                if (!Letters.IsMatch(txtBoxRelationToContactPerson.Text))
                    errorMessage += "Relation to Contact Person must not consist of Numbers and Special Characters\n";
            }

            if (datePickerDateOfBirth.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                errorMessage += "Date of Birth is required\n";

            if (DateTime.Now.Year - datePickerDateOfBirth.Value.Year < 18)
                errorMessage += "User must be atleast 18yrs old\n";                               

            //Email validation
            if (txtBoxEmail.Text != "") 
            {
                if (!EmailAddress.IsMatch(txtBoxEmail.Text))
                    errorMessage += "Invalid Email\n";
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error on saving");
            }
            else
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to save? \n Y/N", "Confirmation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    UserProfile newUser = SetUserValues();

                    UserViewModel vm = new UserViewModel();

                    if (vm.AddUser(newUser))
                        MessageBox.Show("Successfully saved");
                    else
                        MessageBox.Show("Cannot save new user", "Error on saving");
                }
            }
        }

        private void txtBoxLastName_Leave(object sender, EventArgs e)
        {
            GenerateUsernameAndPassword();
        }

        private void Error5_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            lblFirstName.Visible = formUtilities.ShowRequiredLabel(txtBoxFirstName.Text);
        }

        private void txtBoxLastName_TextChanged(object sender, EventArgs e)
        {
            lblLastName.Visible = formUtilities.ShowRequiredLabel(txtBoxLastName.Text);
        }

        private void datePickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            lblDateOfBirth.Visible = formUtilities.ShowRequiredLabel
                (datePickerDateOfBirth.Value.ToShortDateString());
        }

        private void txtBoxHomeAddress_TextChanged(object sender, EventArgs e)
        {
            lblHomeAddress.Visible = formUtilities.ShowRequiredLabel(txtBoxHomeAddress.Text);
        }

        private void comboBoxAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAccountType.Visible = formUtilities.ShowRequiredLabel(comboBoxAccountType.Text);
        }

        private void txtBoxContactPerson_TextChanged(object sender, EventArgs e)
        {
            lblContactPerson.Visible = formUtilities.ShowRequiredLabel(txtBoxContactPerson.Text);
        }

        private void txtBoxContactNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            lblContactNo.Visible = formUtilities.ShowRequiredLabel(txtBoxContactNo.Text);
        }

        private void txtBoxRelationToContactPerson_TextChanged(object sender, EventArgs e)
        {
            lblRelationToContactPerson.Visible = formUtilities.ShowRequiredLabel
                (txtBoxRelationToContactPerson.Text);
        }

        private void txtBoxMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxTelNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxContactNo_TextChanged(object sender, EventArgs e)
        {
            lblContactNo.Visible = formUtilities.ShowRequiredLabel(txtBoxContactNo.Text);
        }

        private void btnAddPicture_Click(object sender, EventArgs e)
        {
            //upload image to picture box
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files | *.jpg";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUser.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnTakePicture_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Webcam photo not yet available", "Error");
        }

        private void txtBoxContactPerson_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBoxContactNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxTelNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxMobileNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void CreateNewUserForm_Load(object sender, EventArgs e)
        {

        }

        private void txtBoxFirstName_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void comboBoxMaritalStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMaritalStatus.Visible = formUtilities.ShowRequiredLabel(comboBoxMaritalStatus.Text);
        }
    }
}
