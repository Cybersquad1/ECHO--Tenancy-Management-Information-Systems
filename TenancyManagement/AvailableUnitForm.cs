﻿using Echo.Data.Repository.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.TenancyManagement
{
    public partial class AvailableUnitForm : Form
    {
        UnitViewModel vm;

        string unitNo = "";

        public AvailableUnitForm()
        {
            InitializeComponent();

            vm = new UnitViewModel();

            GetUnits();
        }

        private void Search(string unitNo, string avail, string unitFloor, string unitType)
        {
            listViewUnitSearch.Items.Clear();

            var units = vm.GetAll().AsQueryable();

            if(unitNo != "")
            {
                units = units.Where(r => r.UnitNumber.Contains(unitNo));
            }

            if(avail == "Available")
            {
                units = units.Where(r => r.ExpectedEndOfOccupancy == null || r.ExpectedEndOfOccupancy > DateTime.Now);
            }
            else //Occupied
            {
                units = units.Where(r => r.ExpectedEndOfOccupancy < DateTime.Now);
            }

            if(unitFloor != "")
            {
                units = units.Where(r => r.Floor == unitFloor);
            }

            if(unitType != "")
            {
                units = units.Where(r => r.Type == unitType);
            }

            units.ToList().ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.UnitNumber);

                if(avail == "Available")
                {
                    //Unit Owner
                    if (item.Owner != null)
                    {
                        var owner = new UserViewModel().GetSelectedUser(item.Owner);

                        lvi.SubItems.Add(owner.FullName);
                    }
                    else
                    {
                        lvi.SubItems.Add("No Owner");
                    }
                }
                else
                {
                    // Tenant
                    if (item.ExpectedEndOfOccupancy == null ||
                    item.ExpectedEndOfOccupancy > DateTime.Now) //Availability
                    {
                        lvi.SubItems.Add("");
                    }
                    else
                    {
                        var tenant = new TenantViewModel().GetSelectedTenant(item.Tenant);

                        lvi.SubItems.Add(tenant.FirstName + " " + tenant.LastName);
                    }
                }

                listViewUnitSearch.Items.Add(lvi);
            });
        }

        private void GetUnits()
        {
            vm = new UnitViewModel();

            listViewUnits.Items.Clear();

            var units = vm.GetAll();

            units.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.UnitNumber); //Unit No

                if (item.ExpectedEndOfOccupancy == null ||
                item.ExpectedEndOfOccupancy > DateTime.Now) //Availability
                    lvi.SubItems.Add("Available");
                else
                    lvi.SubItems.Add("Not available");

                lvi.SubItems.Add(item.Floor); //Unit Floor
                lvi.SubItems.Add(item.Type); //Unit Type

                //Unit Owner
                if(item.Owner != null)
                {
                    var owner = new UserViewModel().GetSelectedUser(item.Owner);

                    lvi.SubItems.Add(owner.FullName);
                }
                else
                {
                    lvi.SubItems.Add("No Owner");
                }

                //Tenant
                if (item.ExpectedEndOfOccupancy == null || 
                    item.ExpectedEndOfOccupancy > DateTime.Now) //Availability
                {
                    lvi.SubItems.Add("");
                }
                else
                {
                    var tenant = new TenantViewModel().GetSelectedTenant(item.Tenant);

                    lvi.SubItems.Add(tenant.FirstName + " " + tenant.LastName);
                }

                listViewUnits.Items.Add(lvi);
            });
        }

        private void GetSelectedUnit()
        {
            vm = new UnitViewModel();

            var selectedUnit = vm.GetSelected(unitNo);

            txtBoxUnitNumber.Text = selectedUnit.UnitNumber;
            
            if(selectedUnit.Tenant != null)//Tenant
            {
                var tenant = new TenantViewModel().GetSelectedTenant(selectedUnit.Tenant);

                txtBoxTenant.Text = tenant.FirstName + " " + tenant.LastName;
            }
            else
            {
                txtBoxTenant.Text = "None";
            }

            if(selectedUnit.Owner != null) //Owner 
            {
                var owner = new UserViewModel().GetSelectedUser(selectedUnit.Owner);

                txtBoxUnitOwner.Text = owner.FullName;
            }
            else
            {
                txtBoxUnitOwner.Text = "None";
            }

            //availability
            if(selectedUnit.ExpectedEndOfOccupancy == null ||
                selectedUnit.ExpectedEndOfOccupancy < DateTime.Now)
            {
                txtBoxAvailability.Text = "Available";
            }
            else
            {
                txtBoxAvailability.Text = "Occupied";
            }

            if(selectedUnit.StartOfOccupancy != null)
                datePickerStart.Value = DateTime.Parse(selectedUnit.StartOfOccupancy.ToString());

            if (selectedUnit.ExpectedEndOfOccupancy != null)
                datePickerEnd.Value = DateTime.Parse(selectedUnit.ExpectedEndOfOccupancy.ToString());

            txtBoxFloor.Text = selectedUnit.Floor;
            txtBoxType.Text = selectedUnit.Type;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TenancyManagement.viewUnitNumberForm v1 = new viewUnitNumberForm();
            v1.Show();
        }

        private void button2_Click(object sender, EventArgs e) //Cancel
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search(txtBoxUnitNoSearch.Text, comboBoxAvailability.Text, 
                comboBoxFloor.Text, comboBoxType.Text);
        }

        private void listViewUnits_DoubleClick(object sender, EventArgs e)
        {
            TabPage openTab = tabControl1.TabPages[1];
            tabControl1.SelectedTab = openTab;

            unitNo = listViewUnits.SelectedItems[0].SubItems[0].Text;

            GetSelectedUnit();
        }

        private void btnTransferOwnership_Click(object sender, EventArgs e)
        {
            if (txtBoxUnitNumber.Text == "")
            {
                MessageBox.Show("Please select unit to transfer", "Error");
            }
            else
            {             
                    TransferOwnership form = new TransferOwnership(txtBoxUnitNumber.Text);
                    form.ShowDialog();

                    GetUnits();

                    GetSelectedUnit(); //Refresh data
            }
        }

        private void listViewUnits_DoubleClick_1(object sender, EventArgs e)
        {
            TabPage openTab = tabControl1.TabPages[1];
            tabControl1.SelectedTab = openTab;

            unitNo = listViewUnits.SelectedItems[0].SubItems[0].Text;

            GetSelectedUnit();
        }
    }
}