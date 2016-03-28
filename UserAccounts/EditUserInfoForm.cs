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
using Echo.Data.Repository;

namespace Tenancy_Management_Information_Systems.User_Accounts
{
    public partial class Edit_User_Info : Form
    {
        public Edit_User_Info()
        {
            InitializeComponent();

            GetUser();
        }

        private void GetUser(string _searchKey = "")
        {
            listViewUser.Items.Clear();

            var userList = new UserRepository().GetUserList(_searchKey);

            userList.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.Status == "Y" ? "Active" : "Inactive");
                lvi.SubItems.Add(item.FullName);
                lvi.SubItems.Add(item.Type);
                lvi.SubItems.Add(item.Username);

                listViewUser.Items.Add(lvi);
            });
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
            GetUser(txtSearch.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetUser(txtSearch.Text);
        }
    }
}
