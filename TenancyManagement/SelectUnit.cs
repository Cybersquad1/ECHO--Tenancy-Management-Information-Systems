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
        }

        private void GetUnits(string _searchKey ="")
        {
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
            });

        }

    }
}
