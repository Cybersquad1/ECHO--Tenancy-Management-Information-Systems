using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tenancy_Management_Information_Systems.ReportForms
{
    public partial class TenancyDatabaseParameter : Form
    {
        public TenancyDatabaseParameter()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TenancyDatabase form = new TenancyDatabase(datePickerStart.Value, datePickerEnd.Value);

            form.Show();

            Close();
        }
    }
}
