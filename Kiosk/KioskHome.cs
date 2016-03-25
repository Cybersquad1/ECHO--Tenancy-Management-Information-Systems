using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Echo.Data.Repository.Repository;

namespace Tenancy_Management_Information_Systems.Kiosk
{
    public partial class Home2 : Form
    {
        UserRepository userRepository;

        public Home2()
        {
            InitializeComponent();

            userRepository = new UserRepository();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var user = userRepository.Login(txtBoxUsername.Text, txtBoxPassword.Text);

            if(user != null)
            {
                if(user.Type == "ADMIN")
                {
                    Home h1 = new Home();
                    h1.Show();
                }
                else //if user is Tenant or Unit Owner
                {
                    HomeTenantForm ht1 = new HomeTenantForm();
                    ht1.Show();
                }
            }
           
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
    }
}
