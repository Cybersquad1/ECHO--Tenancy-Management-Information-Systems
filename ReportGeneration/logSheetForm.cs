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

namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    public partial class logSheetForm : Form
    {
        LogSheetViewModel logVM;

        public logSheetForm()
        {
            InitializeComponent();

            GetItems();
        }
        
        private void Clear(string _type)
        {
            if (_type == "ADD")
            {
                txtBoxAddItem.Text = "";
                txtBoxAddQuantity.Text = "";
            }
            else
            {
                txtBoxModifyQuantity.Text = "";
                cmbBoxModifyItem.Text = "";
            }
        }

        private LogSheet GetItemInformation(string _item)
        {
            logVM = new LogSheetViewModel();

            var log = logVM.GetSelectedItem(_item);

            return log;
        }

        private void GetItems()
        {
            cmbBoxItem.Items.Clear();
            cmbBoxModifyItem.Items.Clear();

            logVM = new LogSheetViewModel();

            var items = logVM.GetItems();

            items.ForEach(item =>
            {
                cmbBoxItem.Items.Add(item.Item);
                cmbBoxModifyItem.Items.Add(item.Item);
            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = GetItemInformation(cmbBoxItem.Text);

            txtBoxQuantity.Text = item.Quantity.ToString();
        }

        private void cmbBoxModifyItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = GetItemInformation(cmbBoxModifyItem.Text);

            txtBoxModifyQuantity.Text = item.Quantity.ToString();
        }

        private void btnModifyAdd_Click(object sender, EventArgs e)
        {
            logVM = new LogSheetViewModel();

            LogSheet newItem = new LogSheet();

            if(logVM.Save(newItem))
            {
                Clear("EDIT");
            }
            else
            {
                MessageBox.Show("Error on saving, there was some kind of error", "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            logVM = new LogSheetViewModel();

            LogSheet newItem = new LogSheet();
            newItem.Item = txtBoxAddItem.Text;
            newItem.Quantity = int.Parse(txtBoxQuantity.Text);

            if (logVM.Save(newItem))
            {
                Clear("ADD");

                MessageBox.Show("Successfully saved");
            }
            else
            {
                MessageBox.Show("Error on saving, there was some kind of error", "Error");
            }
        }
    }
}
