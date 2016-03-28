using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;;
using Echo.Data.Repository;
using Echo.Data.Repository.ViewModel;
using Tenancy_Management_Information_Systems.Utilities;

namespace Tenancy_Management_Information_Systems.User_Accounts
{
    public partial class Edit_User_Info : Form
    {
        
        public Edit_User_Info()
        {
            InitializeComponent();

            GetUsers();
        }

        private void GetUsers(string _searchKey = "")
        {
            listViewUser.Items.Clear();

            var userList = new UserRepository().GetUserList(_searchKey);

            userList.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());
                lvi.SubItems.Add(item.Status == "Y" ? "Active" : "Inactive");
                lvi.SubItems.Add(item.FullName);
                lvi.SubItems.Add(item.Type);
                lvi.SubItems.Add(item.Username);

                listViewUser.Items.Add(lvi);
            });
        }

        private void GetSelectedUser(Guid _userID)
        {
            var user = new UserViewModel().GetSelectedUser(_userID); //get selected user

            //Assign value to corresponding fields
            txtBoxFirstName.Text = user.FirstName;
            txtBoxMiddleName.Text = user.MiddleName;
            txtBoxLastName.Text = user.LastName;
            txtBoxUsername.Text = user.Username;
            datePickerDateOfBirth.Value = user.DateOfBirth;
            comboBoxMaritalStatus.Text = user.MaritalStatus;
            txtBoxHomeAddress.Text = user.HomeAddress;
            txtBoxProvincialAddress.Text = user.ProvincialAddress;
            txtBoxMobileNo.Text = user.MobileNo;
            txtBoxTelNo.Text = user.TelephoneNo;
            txtBoxEmail.Text = user.Email;
            txtBoxContactNo.Text = user.ContactNo;
            txtBoxContactPerson.Text = user.ContactPerson;
            txtBoxRelationToContactPerson.Text = user.RelationshipToContact;
        }

        private void EnableDisableUserFields(bool _value)
        {
            txtBoxMiddleName.Enabled = txtBoxLastName.Enabled = datePickerDateOfBirth.Enabled =
                comboBoxMaritalStatus.Enabled = txtBoxHomeAddress.Enabled = txtBoxProvincialAddress.Enabled =
                txtBoxMobileNo.Enabled = txtBoxTelNo.Enabled = txtBoxEmail.Enabled = txtBoxContactNo.Enabled =
                txtBoxContactPerson.Enabled = txtBoxRelationToContactPerson.Enabled = btnSave.Enabled =
                btnGeneratePassword.Enabled = txtBoxFirstName.Enabled = _value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Enter Name to search..")
                txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetUsers(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetUsers(txtSearch.Text);
        }

        private void listViewUser_DoubleClick(object sender, EventArgs e)
        {
            TabPage openTab = tabControl1.TabPages[1];
            tabControl1.SelectedTab = openTab;

            GetSelectedUser(Guid.Parse(listViewUser.SelectedItems[0].SubItems[0].Text));
            //MessageBox.Show(listViewUser.SelectedItems[0].SubItems[0].Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EnableDisableUserFields(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxFirstName.Text == "")
                errorMessage += "First name is required\n";

            if (txtBoxLastName.Text == "")
                errorMessage += "Last name is required\n";

            if (comboBoxMaritalStatus.Text == "")
                errorMessage += "Marital status is required\n";

            if (datePickerDateOfBirth.Value.ToShortDateString()
                == DateTime.Now.ToShortDateString())
                errorMessage += "Date of birth is required\n";


            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error on updating");
            }
            else
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to save? \n Y/N", "Confirmation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                    //assign field to class
                    UserProfile editUser = new UserProfile();

                    //will only change password if user clicks "Generate Password"
                    if (txtBoxPassword.Text != "")
                        editUser.Password = txtBoxPassword.Text;

                    editUser.FirstName = txtBoxFirstName.Text;
                    editUser.MiddleName = txtBoxMiddleName.Text;
                    editUser.LastName = txtBoxLastName.Text;
                    editUser.DateOfBirth = datePickerDateOfBirth.Value;
                    editUser.MaritalStatus = comboBoxMaritalStatus.Text;
                    editUser.HomeAddress = txtBoxHomeAddress.Text;
                    editUser.ProvincialAddress = txtBoxProvincialAddress.Text;
                    editUser.MobileNo = txtBoxMobileNo.Text;
                    editUser.TelephoneNo = txtBoxTelNo.Text;
                    editUser.Email = txtBoxEmail.Text;
                    editUser.ContactNo = txtBoxContactNo.Text;
                    editUser.ContactPerson = txtBoxContactPerson.Text;
                    editUser.RelationshipToContact = txtBoxRelationToContactPerson.Text;

                    UserViewModel vm = new UserViewModel();


                    EnableDisableUserFields(false);
                }
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            txtBoxPassword.Show();
            txtBoxPassword.Text = new UserUtilities().GeneratePassword(10);
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Are you sure you wan to deactivate?\n Y/N", "Confirmation", MessageBoxButtons.YesNo);

            if(confirmation == DialogResult.Yes)
            {

            }
        }
    }
}
