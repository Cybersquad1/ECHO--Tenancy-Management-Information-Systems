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
    public partial class ChangePassword : Form
    {
        Guid tenantID;

        public ChangePassword(Guid tenantID)
        {
            InitializeComponent();

            this.tenantID = tenantID;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxNewPassword.Text.Count() < 6)
                errorMessage += "Password must have more than 6 characters\n";

            if (txtBoxNewPassword.Text != txtBoxConfirmPassword.Text)
                errorMessage += "Password not match\n";

            if (errorMessage == "")
            {
                var tenantVM = new TenantViewModel();

                if (tenantVM.ChangePassword(tenantID, txtBoxNewPassword.Text))
                {
                    MessageBox.Show("Password changed", "Successfully");

                    Close();
                }
                else
                    MessageBox.Show("Cannot change password there was some kind of error", "Error");
            }
            else
                MessageBox.Show(errorMessage, "Warning");
        }
    }
}
