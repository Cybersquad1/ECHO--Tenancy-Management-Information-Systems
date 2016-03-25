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
using Echo.Data.Repository.Repository;
using Echo.Data.Repository;

namespace Tenancy_Management_Information_Systems.User_Accounts
{
    public partial class Create_New_User : Form
    {
        UserUtilities userUtilities = new UserUtilities();

        public Create_New_User()
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
            UserProfile user = new UserProfile
            {
                Username = txtBoxUserName.Text,
                FirstName = txtBoxFirstName.Text,
                MiddleName = txtBoxMiddleName.Text,
                LastName = txtBoxLastName.Text,
                DateOfBirth = datePickerDateOfBirth.Value,
                MaritalStatus = comboBoxMaritalStatus.Text.ToUpper(),
                HomeAddress = txtBoxHomeAddress.Text,
                ProvincialAddress = txtBoxProvincialAddress.Text,
                Password = txtBoxPassword.Text,
                MobileNo = txtBoxMobileNo.Text,
                TelephoneNo = txtBoxTelNo.Text,
                Email = txtBoxEmail.Text,
                ContactPerson = txtBoxContactPerson.Text,
                ContactNo = txtBoxContactNo.Text,
                RelationshipToContact = txtBoxRelationToContactPerson.Text,
                Type = comboBoxAccountType.Text.ToUpper()
            };

            return user;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxFirstName.Text == "")
                errorMessage += "-First name\n";

            if (txtBoxLastName.Text == "")
                errorMessage += "-Last name\n";

            if (comboBoxMaritalStatus.Text == "")
                errorMessage += "-Marital status\n";

            if (comboBoxAccountType.Text == "")
                errorMessage += "-Account type\n";

            if (errorMessage != "")
            {
                errorMessage = "Please fill up missing fields \n\n" + errorMessage;

                MessageBox.Show(errorMessage, "Error on saving");
            }
            else
            {
                UserProfile newUser = SetUserValues();

                UserRepository repository = new UserRepository();

                if (repository.CreateUser(newUser))
                    MessageBox.Show("Successfully saved");
                else
                    MessageBox.Show("Cannot save new user", "Error on saving");
            }
        }

        private void txtBoxLastName_Leave(object sender, EventArgs e)
        {
            GenerateUsernameAndPassword();
        }
    }
}
