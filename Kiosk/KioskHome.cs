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
            var user = new UserViewModel().TryLogin(txtBoxUsername.Text, txtBoxPassword.Text);

            if (user != null)
            {
                if (user.Status == "Y")
                {
                    lblErrorLogin.Hide();

                    LoginInfo loginInfo = new LoginInfo
                    {
                        username = user.Username,
                        fullName = user.FirstName + " " + user.LastName,
                        accountType = user.Type
                    };

                    if (loginInfo.accountType == "ADMIN")
                    {
                        Home h1 = new Home(loginInfo, this);
                        h1.Show();

                        Hide();
                    }
                    else //if user is Tenant or Unit Owner
                    {
                        HomeTenantForm ht1 = new HomeTenantForm();
                        ht1.Show();

                        Hide();
                    }
                }
                else
                {
                    lblErrorLogin.Text = "This account is currently disabled";
                    txtBoxPassword.Text = "";
                }
            }
            else
            {
                lblErrorLogin.Show();
                lblErrorLogin.Text = "Incorrect username or password";
                txtBoxPassword.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeTenantForm ht1 = new HomeTenantForm();
            ht1.Show();
        }

        private void Home2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                Login();
            }
        }
    }
}
