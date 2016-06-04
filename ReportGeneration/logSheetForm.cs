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
using Tenancy_Management_Information_Systems.Utilities;

namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    public partial class logSheetForm : Form
    {
        LogSheetViewModel logVM;

        LogSheetActivityViewModel logActivityVM;

        Guid userID;

        FormUtilities utilities = new FormUtilities();

        public logSheetForm(Guid _userID)
        {
            InitializeComponent();

            GetItems();

            userID = _userID;

            GetLogSheetActivity();

            txtBoxDateToday.Text = DateTime.Now.ToShortDateString();
        }

        private void GetLogSheetActivity()
        {
            logActivityVM = new LogSheetActivityViewModel();

            logVM = new LogSheetViewModel();

            lstViewLogSheetRequest.Items.Clear();

            var logActivity = logActivityVM.GetAll();

            logActivity.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.Date.ToString());

                var selectedItem = logVM.GetSelectedID(item.ItemID);

                lvi.SubItems.Add(selectedItem.Item);

                lvi.SubItems.Add(item.Balance.ToString());

                lvi.SubItems.Add(item.Quantity.ToString());

                lvi.SubItems.Add(item.Purpose);

                lvi.SubItems.Add(item.Area);

                var user = new UserViewModel().GetSelectedUser(item.IssuedBy);

                lvi.SubItems.Add(user.FullName);

                lvi.SubItems.Add(item.ReceivedBy);

                lstViewLogSheetRequest.Items.Add(lvi);             
            });
        }
        
        private void Clear(string _type)
        {
            if (_type == "ADD")
            {
                txtBoxAddItem.Text = "";

                txtBoxAddQuantity.Text = "";
            }
            else if(_type =="ACTIVITY")
            {
                txtBoxPurpose.Text = "";

                txtBoxArea.Text = "";

                txtBoxReceivedBy.Text = "";

                txtBoxPieces.Text = "";

                txtBoxQuantity.Text = "";

                txtBoxDateToday.Text = DateTime.Now.ToShortDateString();
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

            lstViewItem.Items.Clear();

            logVM = new LogSheetViewModel();

            var items = logVM.GetItems();

            items.ForEach(item =>
            {
                //DropDown Menu
                cmbBoxItem.Items.Add(item.Item);

                cmbBoxModifyItem.Items.Add(item.Item);

                //List
                ListViewItem lvi = new ListViewItem(item.Item);

                lvi.SubItems.Add(item.Quantity.ToString());

                if (item.DateModified != null)
                    lvi.SubItems.Add(DateTime.Parse(item.DateModified.ToString()).ToShortDateString());
                else
                    lvi.SubItems.Add("N/A");

                if (item.ModifiedBy != null)
                {
                    var user = new UserViewModel().GetSelectedUser(item.ModifiedBy);

                    if (user != null)
                        lvi.SubItems.Add(user.FullName);
                    else
                        lvi.SubItems.Add("N/A");
                }
                else
                    lvi.SubItems.Add("N/A");

                lstViewItem.Items.Add(lvi);
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
            string errorMessage = "";

            if (cmbBoxModifyItem.Text == "")
                errorMessage += "Item is required\n";

            if (txtBoxModifyQuantity.Text == "")
                errorMessage += "Quantity is required\n";

            if (errorMessage == "")
            {
                logVM = new LogSheetViewModel();

                LogSheet editItem = new LogSheet();

                editItem.Quantity = int.Parse(txtBoxModifyQuantity.Text);

                editItem.Item = cmbBoxModifyItem.Text;

                editItem.ModifiedBy = userID;

                var itemID = logVM.GetSelectedItem(cmbBoxModifyItem.Text);

                editItem.ID = itemID.ID;

                if (logVM.Modify(editItem))
                {
                    Clear("EDIT");

                    GetItems();

                    MessageBox.Show("Successfully modified");
                }
                else
                {
                    MessageBox.Show("Error on saving, there was some kind of error", "Error");
                }
            }
            else
                MessageBox.Show(errorMessage, "Error on saving");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (txtBoxAddItem.Text == "")
                errorMessage += "Item is required\n";

            if (txtBoxAddQuantity.Text == "")
                errorMessage += "Quantity is required\n";

            if (errorMessage == "")
            {
                logVM = new LogSheetViewModel();

                LogSheet newItem = new LogSheet();

                newItem.Item = txtBoxAddItem.Text.ToUpper();

                newItem.Quantity = int.Parse(txtBoxAddQuantity.Text);

                if (logVM.Save(newItem))
                {
                    Clear("ADD");

                    GetItems();

                    MessageBox.Show("Successfully saved");
                }
                else
                {
                    MessageBox.Show("Error on saving, there was some kind of error", "Error");
                }
            }
            else
                MessageBox.Show(errorMessage, "Error on saving");
        }

        private void btnModifyClear_Click(object sender, EventArgs e)
        {
            Clear("EDIT");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear("ADD");
        }

        private void btnLogAdd_Click(object sender, EventArgs e)
        {
            string errorMessage = "";

            if (cmbBoxItem.Text == "")
                errorMessage += "Item is required\n";

            if (txtBoxPieces.Text == "")
                errorMessage += "Balance/Pieces is required\n";

            if (txtBoxPurpose.Text == "")
                errorMessage += "Purpose is required\n";

            if (txtBoxArea.Text == "")
                errorMessage += "Area is required\n";

            if (txtBoxReceivedBy.Text == "")
                errorMessage += "Received by is required\n";

            if (errorMessage == "")
            {
                DialogResult result = MessageBox.Show("Proceed on saving Log Sheet? [Y/N]", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //Save to Database
                    LogSheetActivity newLog = new LogSheetActivity();
                    newLog.Date = DateTime.Now;

                    var item = new LogSheetViewModel().GetSelectedItem(cmbBoxItem.Text);

                    newLog.ItemID = item.ID;

                    newLog.Balance = int.Parse(txtBoxPieces.Text);

                    newLog.Quantity = int.Parse(txtBoxQuantity.Text);

                    newLog.Purpose = txtBoxPurpose.Text;

                    newLog.Area = txtBoxArea.Text;

                    newLog.IssuedBy = userID;

                    newLog.ReceivedBy = txtBoxReceivedBy.Text;

                    logActivityVM = new LogSheetActivityViewModel();

                    if (logActivityVM.Save(newLog))
                    {
                        MessageBox.Show("Successfuly saved");

                        GetLogSheetActivity();

                        GetItems();
                    }
                    else
                        MessageBox.Show("Can't save Log sheet there was some kind of error", "Error on saving");
                }
            }
            else
                MessageBox.Show(errorMessage, "Error on saving");
        }

        private void btnLogClear_Click(object sender, EventArgs e)
        {
            Clear("ACTIVITY");
        }

        private void txtBoxModifyQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBoxModifyQuantity_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtBoxModifyQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxAddQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.AllowsNumericOnly(sender, e);
        }

        private void txtBoxPieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilities.AllowsNumericOnly(sender, e);
        }
    }
}
