using Echo.Data.Repository.Models;
using Echo.Data.Repository.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tenancy_Management_Information_Systems.Kiosk
{
    public partial class Home2 : Form
    {
        
        public Home2()
        {
            InitializeComponent();
        }

        private void Login()
        {
            //check if login is in user table
            var user = new UserViewModel().TryLogin(txtBoxUsername.Text, txtBoxPassword.Text);
            //check if login is in tenant table
            var tenant = new TenantViewModel().TryLogin(txtBoxUsername.Text, txtBoxPassword.Text);

            if (user != null)//user login
            {
                if (user.Status == "Y")
                {
                    lblErrorLogin.Hide();

                    LoginInfo loginInfo = new LoginInfo
                    {
                        username = user.Username,
                        fullName = user.FirstName + " " + user.LastName,
                        accountType = user.Type,
                        userID = user.ID
                    };

                    if (loginInfo.accountType.ToUpper() == "ADMIN")
                    {
                        Home h1 = new Home(loginInfo, this);
                        h1.Show();

                        Hide();
                    }
                    else //If unit owner | accounting
                    {

                    }
                }
                else
                {
                    lblErrorLogin.Text = "This account is currently disabled";
                    txtBoxPassword.Text = "";
                }
            }

            if(tenant != null) //tenant login
            {
                if(tenant.Status == "Y")
                {
                    lblErrorLogin.Hide();

                    LoginInfo loginInfo = new LoginInfo
                    {
                        username = tenant.Username,
                        fullName = tenant.FirstName + " " +tenant.LastName,
                        accountType = "TENANT"
                    };

                    if (tenant.UnitNumber != null && tenant.UnitNumber != "")
                    {
                        HomeTenantForm ht1 = new HomeTenantForm(this,tenant.ID, tenant.UnitNumber, tenant.FirstName + " " + tenant.LastName);
                        ht1.Show();

                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("No assign unit, please contact administrator for this issue", "Warning");
                    }
                }
            }

            //if username and password not match in user and tenant profile table
            if(user == null && tenant == null)
            {
                lblErrorLogin.Show();
                lblErrorLogin.Text = "Incorrect username or password";
                txtBoxPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)//Login button
        {
            Login();           
        }

        private void Home2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //closed the program when this form is closed
        }

        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)//press enter on password textbox to login
            {
                Login();
            }
        }
    }
}
