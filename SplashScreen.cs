using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems
{
    public partial class SplashScreen : Form
    {
        int count = 0, buffer = 0;
        public SplashScreen()
        {
            InitializeComponent();
            Opacity = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 3000;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (buffer == 3)
            {
                timer3.Start();
                timer2.Stop();
            }

            else
            {
                buffer++;
            }

        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Kiosk.Home2 h2 = new Kiosk.Home2();
                h2.Show();

                timer3.Stop();
                this.Hide();
            }

            else
            {
                count--;
                Opacity = count * 3000;
            }
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (buffer == 3)
            {
                timer3.Start();
                timer2.Stop();
            }

            else
            {
                buffer++;
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer2.Start();
                timer1.Stop();
            }
            else
            {
                count++;
                Opacity = count * 3000;
            }
        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                Kiosk.Home2 h2 = new Kiosk.Home2();
                h2.Show();

                timer3.Stop();
                this.Hide();
            }

            else
            {
                count--;
                Opacity = count * 3000;
            }
        }
    }
}
