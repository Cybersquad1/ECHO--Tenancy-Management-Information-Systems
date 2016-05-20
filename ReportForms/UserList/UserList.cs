using Echo.Data.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.ReportForms.UserList
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();

            LoadReport();
        }

        private void LoadReport()
        {
            using (var db = new EchoEntities())
            {
                userListBindingSource.DataSource =
                    db.UserList();

                reportViewer.RefreshReport();
            }
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'echoDataSet.UserList' table. You can move, or remove it, as needed.
            this.userListTableAdapter.Fill(this.echoDataSet.UserList);

            this.reportViewer.RefreshReport();
        }
    }
}
