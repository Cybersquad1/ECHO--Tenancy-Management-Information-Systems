using System.Collections.Generic;
using System.Windows.Forms;
using Echo.Data.Repository.ViewModel;
using Echo.Data.Repository;

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class SelectUnit : Form
    {
        TextBox txtBoxUnitNo;
        TextBox txtBoxUnitOwner;

        public SelectUnit(TextBox txtBoxUnitNo, TextBox txtBoxUnitOwner)
        {
            InitializeComponent();

            this.txtBoxUnitNo = txtBoxUnitNo;
            this.txtBoxUnitOwner = txtBoxUnitOwner;

            GetUnits();
        }

        private void Okay()
        {
            try
            {
                //asign selected value to parentForm textboxes
                txtBoxUnitNo.Text = listViewUnits.SelectedItems[0].SubItems[0].Text;
                txtBoxUnitOwner.Text = listViewUnits.SelectedItems[0].SubItems[1].Text;

                Close();
            }
            catch
            {
                MessageBox.Show("Please select data from list", "Error");
            }
        }

        private void GetUnits(string _searchKey ="")
        {
            listViewUnits.Items.Clear();

            List<UnitProfile> units = new List<UnitProfile>();
            UnitViewModel vm = new UnitViewModel();
            
            if (_searchKey == "")
                units = vm.GetAll();
            else
                units.Add(vm.GetSelected(_searchKey));

            units.ForEach(item =>
            {                
                ListViewItem lvi = new ListViewItem(item.UnitNumber);

                if (item.Owner != null)
                {
                    var owner = new UserViewModel().GetSelectedUser(item.Owner);
                    lvi.SubItems.Add(owner.FullName);
                }
                else
                {
                    lvi.SubItems.Add("No Owner");
                }

                listViewUnits.Items.Add(lvi);
            });
        }

        private void btnOkay_Click(object sender, System.EventArgs e)
        {
            Okay();
        }

        private void listViewUnits_DoubleClick(object sender, System.EventArgs e)
        {
            Okay();
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            GetUnits(txtBoxSearchKey.Text);
        }
    }
}