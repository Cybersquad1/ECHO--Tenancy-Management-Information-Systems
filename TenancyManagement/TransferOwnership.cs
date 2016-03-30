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

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class TransferOwnership : Form
    {
        UserViewModel vm;

        string unitNo;

        public TransferOwnership(string _unitNo)
        {
            InitializeComponent();

            vm = new UserViewModel();

            GetUserList();

            unitNo = _unitNo;
        }

        private void GetUserList(string _searchKey = "")
        {
            listViewUsers.Items.Clear();

            List<UserProfile> users = new List<UserProfile>();

            if (_searchKey != "")
                users = vm.GetUsers(_searchKey);
            else
                users = vm.GetUsers();

            users.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());
                lvi.SubItems.Add(item.FullName);
                listViewUsers.Items.Add(lvi);
            });
        }

        private void TranserOwner(Guid _userID)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to transfer ownership of this unit? (Y/N)", "Confirmation", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                UnitViewModel unitVM = new UnitViewModel();

                if (unitVM.TransferOwnership(unitNo, _userID))
                {
                    MessageBox.Show("Ownership successfully transfer", "Successful");

                    Close();
                }
                else
                {
                    MessageBox.Show("Cannot transfer ownership, there was some kind of error", "Error");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetUserList(txtBoxSearchKey.Text);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                TranserOwner(Guid.Parse(listViewUsers.SelectedItems[0].SubItems[0].Text));
            }
            catch
            {
                MessageBox.Show("Please select new owner", "Error");
            }
        }

        private void listViewUsers_DoubleClick(object sender, EventArgs e)
        {
            TranserOwner(Guid.Parse(listViewUsers.SelectedItems[0].SubItems[0].Text));
        }
    }
}