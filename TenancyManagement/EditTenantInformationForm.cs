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
    public partial class EditTenantInformationForm : Form
    {
        TenantViewModel vm;

        public EditTenantInformationForm()
        {
            InitializeComponent();

            GetTenantList();//get all data
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GetTenantList(string _searchKey = "")
        {
            listViewTenants.Items.Clear();

            vm = new TenantViewModel(); //Referesh database connection

            string startDate = "";
            string endDate = "";

            List<TenantProfile> tenants = new List<TenantProfile>();

            if (_searchKey == "") //Get all data
                tenants = vm.GetAll();
            else //if have search filer
                tenants = vm.Search(_searchKey);

            tenants.ForEach(item =>
            {
                var unit = new UnitViewModel().GetSelected(item.UnitNumber);
                
                ListViewItem lvi = new ListViewItem(item.ID.ToString()); //ID
                lvi.SubItems.Add(item.UnitNumber); //Unit No
                
                if(unit != null)
                {
                    var owner = new UserViewModel().GetSelectedUser(unit.Owner);
                    startDate = unit.StartOfOccupancy.ToString();
                    endDate = unit.ExpectedEndOfOccupancy.ToString();
                    lvi.SubItems.Add(owner.FullName); //owner
                }
                else
                {
                    lvi.SubItems.Add(""); //blank
                }

                lvi.SubItems.Add(item.FirstName + " " + item.LastName); //Tenant
                lvi.SubItems.Add(startDate); //Start Date of Occupancy
                lvi.SubItems.Add(endDate); //End Date of Occupancy

                listViewTenants.Items.Add(lvi);   
            });
        }
    }
}
