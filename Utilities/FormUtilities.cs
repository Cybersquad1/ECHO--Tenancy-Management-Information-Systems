using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.Utilities
{ 
    public class FormUtilities
    {
        //hide and show required label
        public bool ShowRequiredLabel(string _value)//if true show if false hide
        {
            //if date is today
            if (_value == DateTime.Now.ToShortDateString())
                return true;

            if (_value == "")
                return true;
            else
                return false;
        }

        //Allows numeric only in textbox
        public void AllowsNumericOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
