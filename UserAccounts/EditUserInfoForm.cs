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
using System.IO;
using System.Text.RegularExpressions;
using Tenancy_Management_Information_Systems.ReportForms.UserList;

namespace Tenancy_Management_Information_Systems.User_Accounts
{
    public partial class Edit_User_Info : Form
    {
        UserViewModel vm;

        Guid userID = Guid.Empty;

        FormUtilities formUtilities = new FormUtilities();

        public Edit_User_Info()
        {
            InitializeComponent();

            vm = new UserViewModel();

            GetUsers();            
        }

        private void GetUsers(string _searchKey = "")
        {
            listViewUser.Items.Clear();

            List<UserProfile> userList = new List<UserProfile>();

            if (_searchKey == "")
                userList = vm.GetUsers();
            else
                userList = vm.GetUsers(_searchKey);

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
            try
            {
                var user = vm.GetSelectedUser(_userID); //get selected user

                if (user != null)
                {
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

                    if (user.ImageContent != null)
                    {
                        Stream imgStr = new MemoryStream(user.ImageContent);

                        pictureBoxUser.Image = System.Drawing.Image.FromStream(imgStr);
                    }
                    else
                    {
                        pictureBoxUser.Image = null;
                    }

                    if (user.Status == "Y")
                        btnDeactivate.Text = "Deactivate";
                    else
                        btnDeactivate.Text = "Activate";
                }
                else
                {
                    MessageBox.Show("No data found", "Error");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void EnableDisableUserFields(bool _value)
        {
            txtBoxMiddleName.Enabled = txtBoxLastName.Enabled = datePickerDateOfBirth.Enabled =
                comboBoxMaritalStatus.Enabled = txtBoxHomeAddress.Enabled = txtBoxProvincialAddress.Enabled =
                txtBoxMobileNo.Enabled = txtBoxTelNo.Enabled = txtBoxEmail.Enabled = txtBoxContactNo.Enabled =
                txtBoxContactPerson.Enabled = txtBoxRelationToContactPerson.Enabled = btnSave.Enabled =
                btnGeneratePassword.Enabled = txtBoxFirstName.Enabled = btnDeactivate.Enabled = _value;
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
            try
            {
                TabPage openTab = tabControl1.TabPages[1];
                tabControl1.SelectedTab = openTab;

                userID = Guid.Parse(listViewUser.SelectedItems[0].SubItems[0].Text);

                GetSelectedUser(userID);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (userID == Guid.Empty)
            {
                MessageBox.Show("Please select data from grid", "Error");
            }
            else
            {
                EnableDisableUserFields(true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Regex EmailAddress = new Regex(@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$");

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

            if(DateTime.Now.Year - datePickerDateOfBirth.Value.Year < 18)
                errorMessage += "User must be atleast 18yrs old";

            //Email validation
            if (txtBoxEmail.Text != "")
            {
                if (!EmailAddress.IsMatch(txtBoxEmail.Text))
                {
                    errorMessage += "-Invalid Email\n";
                }
            }

            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage, "Error on updating");
            }
            else
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to save? \n Y/N", "Confirmation", MessageBoxButtons.YesNo);

                if (confirmation == DialogResult.Yes)
                {
                        try
                        {
                            Save();

                            MessageBox.Show("Successfully updated " + txtBoxUsername.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Cannot update user some kind of error found", "Error");
                        }                    
                }
            }
        }

        private void Save(string _status = "Y")
        {
            using (var db = new EchoEntities())
            {
                //assign field to class
                var editUser = db.UserProfile.FirstOrDefault(r => r.ID == userID);

                //will only change password if user clicks "Generate Password"
                if (txtBoxPassword.Text != "")
                {
                    editUser.Password = txtBoxPassword.Text;
                    editUser.IfGeneratedPassword = "Y";
                }

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
                editUser.Status = _status;

                db.Entry(editUser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                EnableDisableUserFields(false);

                GetSelectedUser(userID);
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
                Save("N");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image files | *.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxUser.Image = Image.FromFile(openFileDialog.FileName);
            }
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
 
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            UserList form = new UserList();

            form.Show();
        }
    }
}
