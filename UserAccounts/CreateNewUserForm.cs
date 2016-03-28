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

            if (txtBoxContactNo.Text == "")
                errorMessage += "-Contact Number\n";

            if (txtBoxContactPerson.Text == "")
                errorMessage += "-Contact Person\n";

            if (txtBoxRelationToContactPerson.Text == "")
                errorMessage += "-Relation to contact person\n";

            if (datePickerDateOfBirth.Value.ToShortDateString() == DateTime.Now.ToShortDateString())
                errorMessage += "-Date of Birth\n";

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
    }
}
