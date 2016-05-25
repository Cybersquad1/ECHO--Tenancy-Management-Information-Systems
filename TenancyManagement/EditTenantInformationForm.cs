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
using System.IO;
using Tenancy_Management_Information_Systems.Utilities;

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class EditTenantInformationForm : Form
    {
        TenantViewModel vm;

        Guid tenantID = Guid.Empty;

        string IfChangePassword = "N";

        FormUtilities formUtilities = new FormUtilities();

        UserUtilities userUtilities = new UserUtilities();

        public EditTenantInformationForm()
        {
            InitializeComponent();

            GetTenantList();//get all data
        }

        private void GetSelectedTenant(Guid _tenantID)
        {
            try
            {
                vm = new TenantViewModel(); //refresh database connection

                var tenant = vm.GetSelectedTenant(_tenantID);

                if (tenant != null)
                {
                    //Assign value to its corresponding fields
                    //Personal Information
                    txtBoxFirstName.Text = tenant.FirstName;

                    txtBoxMiddleName.Text = tenant.MiddleName;

                    txtBoxLastName.Text = tenant.LastName;

                    datePickerDateOfBirth.Value = DateTime.Parse(tenant.DateOfBirth.ToString());

                    comboBoxMaritalStatus.Text = tenant.MaritalStatus;

                    txtBoxNatureOfOccupancy.Text = tenant.NatureOfOccupancy;

                    txtBoxHomeAddress.Text = tenant.HomeAddress;

                    txtBoxProvincialAddress.Text = tenant.ProvincialAddress;

                    txtBoxMobileNo.Text = tenant.MobileNo;

                    txtBoxTelephoneNo.Text = tenant.TelephoneNo;

                    txtBoxEmail.Text = tenant.Email;

                    //Unit Information
                    if (tenant.UnitNumber == "" || tenant.UnitNumber == null)
                    {
                        txtBoxUnitNo.Text = txtBoxUnitOwner.Text =
                            txtBoxStartDateOfOccupancy.Text = txtBoxEndDateOfOccupancy.Text = "N/A";
                    }
                    else
                    {
                        txtBoxUnitNo.Text = tenant.UnitNumber;

                        var unitInfo = new UnitViewModel().GetSelected(tenant.UnitNumber);

                        var owner = new UserViewModel().GetSelectedUser(unitInfo.Owner);

                        if (owner == null)
                            txtBoxUnitOwner.Text = "N/A";
                        else
                            txtBoxUnitOwner.Text = owner.FullName;

                        //duration of stay
                        txtBoxStartDateOfOccupancy.Text = unitInfo.StartOfOccupancy.ToString();

                        txtBoxEndDateOfOccupancy.Text = unitInfo.ExpectedEndOfOccupancy.ToString();
                    }

                    //Other Information
                    txtBoxOtherName1.Text = tenant.OtherName1;

                    txtBoxOtherName2.Text = tenant.OtherName2;

                    txtBoxOtherName3.Text = tenant.OtherName3;

                    txtBoxPetName.Text = tenant.PetName;

                    txtBoxPetType.Text = tenant.PetType;

                    //Login Info
                    txtBoxUsername.Text = tenant.Username;

                    //Profile Pic
                    if (tenant.ImageLocation != null)
                    {
                        Stream imgStr = new MemoryStream(tenant.ImageLocation);

                        pictureBox.Image = System.Drawing.Image.FromStream(imgStr);
                    }
                    else
                    {
                        pictureBox.Image = null;
                    }

                    EnableDisableFields(false); //Disable fields
                }
                else
                    MessageBox.Show("No data found", "Error");
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void EnableDisableFields(bool _input)
        {
            txtBoxFirstName.Enabled = 
                txtBoxMiddleName.Enabled = 
                txtBoxLastName.Enabled = 
                datePickerDateOfBirth.Enabled = 
                txtBoxNatureOfOccupancy.Enabled = 
                txtBoxHomeAddress.Enabled =
                txtBoxProvincialAddress.Enabled = 
                txtBoxMobileNo.Enabled = 
                txtBoxTelephoneNo.Enabled = 
                txtBoxEmail.Enabled = 
                txtBoxOtherName1.Enabled = 
                txtBoxOtherName2.Enabled = 
                txtBoxOtherName3.Enabled = 
                txtBoxPetName.Enabled = 
                txtBoxPetType.Enabled =
                btnSave.Enabled = 
                btnActivate.Enabled =_input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void GetTenantList(string _searchKey = "")
        {
            listViewTenants.Items.Clear();

            vm = new TenantViewModel(); //Referesh database connection

            string startDate = "";
            string endDate = "";

            List<TenantProfile> tenants = new List<TenantProfile>();

            if (_searchKey == "") //Get all data
                tenants = vm.GetAll("Y");
            else //if have search filer
                tenants = vm.Search(_searchKey, "Y");

            tenants.ForEach(item =>
            {
                var unit = new UnitViewModel().GetSelected(item.UnitNumber);
                
                ListViewItem lvi = new ListViewItem(item.ID.ToString()); //ID

                if (item.UnitNumber == "" && item.UnitNumber == null)
                    lvi.SubItems.Add(item.UnitNumber); //Unit No         
                else
                    lvi.SubItems.Add("N/A");

                if (unit != null)
                {
                    var owner = new TenantViewModel().GetSelectedTenant(unit.Owner);
                    startDate = unit.StartOfOccupancy.ToString();
                    endDate = unit.ExpectedEndOfOccupancy.ToString();
                    if (owner != null)
                        lvi.SubItems.Add(owner.FirstName + " " + owner.LastName); //owner
                    else
                        lvi.SubItems.Add("N/A");
                }
                else
                {
                    lvi.SubItems.Add("N/A"); //blank
                }

                lvi.SubItems.Add(item.FirstName + " " + item.LastName); //Tenant

                if (startDate == "")
                    lvi.SubItems.Add("N/A");
                else
                    lvi.SubItems.Add(startDate); //Start Date of Occupancy

                if (endDate == "")
                    lvi.SubItems.Add("N/A");
                else
                    lvi.SubItems.Add(endDate); //End Date of Occupancy

                listViewTenants.Items.Add(lvi);   
            });
        }

        private void listViewTenants_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                TabPage openTab = tabControl1.TabPages[1];

                tabControl1.SelectedTab = openTab;

                tenantID = Guid.Parse(listViewTenants.SelectedItems[0].SubItems[0].Text);

                GetSelectedTenant(tenantID);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        //Search Filters
        private void Go_Click(object sender, EventArgs e)
        {
            GetTenantList(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetTenantList(txtSearch.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tenantID == Guid.Empty)
                MessageBox.Show("Please select data from list", "Error");
            else
                EnableDisableFields(true); //enable fields
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to "
                    + btnActivate.Text + "?", "Warning", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    string status = "N";

                    if (vm.ChangeTenantStatus(tenantID, status))
                    {
                        MessageBox.Show("Successfully " + btnActivate.Text);

                        btnSave.Enabled = false;
                        btnEdit.Enabled = true;
                        btnActivate.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Can't " + btnActivate.Text + " Tenant", "Error");
                    }
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string errorMessage = "";

                if (txtBoxFirstName.Text == "")
                    errorMessage += "Firstname is required\n";

                if (txtBoxLastName.Text == "")
                    errorMessage += "Lastname is required\n";

                if (datePickerDateOfBirth.Value >= DateTime.Now)
                    errorMessage += "Date of birth must no be equal or exceed from date today\n";

                if (datePickerDateOfBirth.Value.Year < 18)
                    errorMessage += "Tenant must be atleast 18yrs old\n";

                if (comboBoxMaritalStatus.Text == "")
                    errorMessage += "Marital status is required\n";

                if (errorMessage == "")
                {
                    using (var db = new EchoEntities())
                    {
                        var editTenant = db.TenantProfile.FirstOrDefault(r => r.ID == tenantID);

                        //Personal Information
                        editTenant.FirstName = txtBoxFirstName.Text;
                        editTenant.MiddleName = txtBoxMiddleName.Text;
                        editTenant.LastName = txtBoxLastName.Text;
                        editTenant.DateOfBirth = datePickerDateOfBirth.Value;
                        editTenant.NatureOfOccupancy = txtBoxNatureOfOccupancy.Text;
                        editTenant.HomeAddress = txtBoxHomeAddress.Text;
                        editTenant.ProvincialAddress = txtBoxProvincialAddress.Text;
                        editTenant.MobileNo = txtBoxMobileNo.Text;
                        editTenant.TelephoneNo = txtBoxTelephoneNo.Text;
                        editTenant.Email = txtBoxEmail.Text;

                        //Other Information
                        editTenant.OtherName1 = txtBoxOtherName1.Text;
                        editTenant.OtherName2 = txtBoxOtherName2.Text;
                        editTenant.OtherName3 = txtBoxOtherName3.Text;
                        editTenant.PetName = txtBoxPetName.Text;
                        editTenant.PetType = txtBoxPetType.Text;

                        //will change password if it generates new one
                        if (txtBoxPassword.Text != "")
                            editTenant.Password = txtBoxPassword.Text;

                        db.Entry(editTenant).State = System.Data.Entity.EntityState.Modified;

                        db.SaveChanges();

                        MessageBox.Show("Successfully updated tenant information");

                        btnActivate.Enabled = false;

                        btnSave.Enabled = false;

                        btnEdit.Enabled = true;

                        GetTenantList();
                    }
                }
                else
                    MessageBox.Show(errorMessage, "Error");              
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            IfChangePassword = "Y";

            txtBoxPassword.Text = userUtilities.GeneratePassword(8);
        }

        private void txtBoxTelephoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            formUtilities.AllowsNumericOnly(sender, e);
        }
    }
}
