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

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class SelectTenant : Form
    {
        TenantViewModel vmTenant;

        AvailableUnitForm parentForm;
        public SelectTenant(AvailableUnitForm parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;

            GetTenants();
        }

        private void GetTenants()
        {
            try
            {
                listViewTenant.Items.Clear();

                vmTenant = new TenantViewModel();

                var tenants = vmTenant.GetAll();

                tenants.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(item.ID.ToString());
                    lvi.SubItems.Add(item.FirstName + " " + item.LastName);

                    listViewTenant.Items.Add(lvi);
                });
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void SearchTenant(string _searchKey)
        {
            try
            { 
                listViewTenant.Items.Clear();

                vmTenant = new TenantViewModel();

                var tenants = vmTenant.Search(_searchKey);

                tenants.ForEach(item =>
                {
                    ListViewItem lvi = new ListViewItem(item.ID.ToString());
                    lvi.SubItems.Add(item.FirstName + " " + item.LastName);

                    listViewTenant.Items.Add(lvi);
                });
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTenant(txtBoxSearchKey.Text);
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTenant.SelectedItems != null)
                {
                    parentForm.tenantID = Guid.Parse(listViewTenant.SelectedItems[0].SubItems[0].Text);
                    parentForm.txtBoxTenant.Text = listViewTenant.SelectedItems[0].SubItems[1].Text;
                    Close();
                }
                else
                {
                    MessageBox.Show("Please select data from list", "Error");
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }
    }
}
