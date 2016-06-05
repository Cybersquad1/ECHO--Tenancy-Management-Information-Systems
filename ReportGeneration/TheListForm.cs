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

namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    public partial class TheListForm : Form
    {
        public class Accounts
        {
            public Guid ID { get; set; }

            public string UnitNo { get; set; }

            private string _owner;

            public string UnitOwner
            {
                get
                {
                    if (_owner != "")
                    {
                        Guid ownerID = Guid.Parse(_owner);

                        var owner = new TenantViewModel().GetSelectedTenant(ownerID);

                        if (owner != null)
                            return owner.FirstName + " " + owner.LastName;
                    }
                    return "";
                }
                set
                {
                    _owner = value;
                }
            }

            private string _tenant;
            public string Tenant
            {
                get
                {
                    if (_tenant != "")
                    {
                        Guid tenantID = Guid.Parse(_tenant);

                        var tenant = new TenantViewModel().GetSelectedTenant(tenantID);

                        if (tenant != null)
                            return tenant.FirstName + " " + tenant.LastName;
                    }
                    return "";
                }
                set
                {
                    _tenant = value;
                }
            }

            public DateTime tenantChargeDate { get; set; }

            public string TotalAmountDue { get; set; }
        
        }

        public TheListForm()
        {
            InitializeComponent();

            GetReservations();

            GetUnpaidAccounts();

            GetPaidAccounts();
        }

        private void GetUnpaidAccounts(string _unitNo)
        {

        }

        private int ConvertMonthToInt(string _month)
        {
            if (_month == "January")
                return 1;
            else if (_month == "February")
                return 2;
            else if (_month == "March")
                return 3;
            else if (_month == "April")
                return 4;
            else if (_month == "May")
                return 5;
            else if (_month == "June")
                return 6;
            else if (_month == "July")
                return 7;
            else if (_month == "August")
                return 8;
            else if (_month == "September")
                return 9;
            else if (_month == "October")
                return 10;
            else if (_month == "November")
                return 11;
            else if (_month == "December")
                return 12;
            else
                return 0;
        }

        private void GetUnpaidAccounts()
        {
            List<Accounts> unpaidAccounts = new List<Accounts>();

            var unpaidAssoc = new MonthlyAssociationDueViewModel().GetAllUnpaid();

            //unpaid monthly assoc
            unpaidAssoc.ForEach(item =>
            {
                Accounts temp = new Accounts();

                temp.ID = item.ID;

                if (item.UnitNumber != "")
                {
                    var unit = new UnitViewModel().GetSelected(item.UnitNumber);

                    if (unit != null)
                    {
                        temp.UnitNo = item.UnitNumber;

                        temp.Tenant = unit.Tenant.ToString();

                        temp.UnitOwner = unit.Owner.ToString();
                    }
                }

                temp.tenantChargeDate = DateTime.Parse(item.ChargeDate.ToString());

                temp.TotalAmountDue = string.Format("{0:0.00}", item.TotalAmount);

                unpaidAccounts.Add(temp);
            });

            //unpaid reservation
            var reservation = new ReservationViewModel().GetAllPaid();

            reservation.ForEach(item =>
            {
                Accounts temp = new Accounts();

                if (item.UnitNumber != "")
                {
                    var unit = new UnitViewModel().GetSelected(item.UnitNumber);

                    if (unit != null)
                    {
                        temp.UnitNo = item.UnitNumber;

                        temp.Tenant = unit.Tenant.ToString();

                        temp.UnitOwner = unit.Owner.ToString();
                    }
                }

                temp.tenantChargeDate = DateTime.Parse(item.Date.ToString());

                temp.TotalAmountDue = string.Format("{0:0.00}", item.Amount);

                unpaidAccounts.Add(temp);
            });

            if (cmbBoxUnpaidMonth.Text != "")
            {
                unpaidAccounts = unpaidAccounts.Where(r => r.tenantChargeDate.Month == ConvertMonthToInt(cmbBoxUnpaidMonth.Text)).ToList();
            }

            if (cmbBoxUnpaidYear.Text != "")
            {
                unpaidAccounts = unpaidAccounts.Where(r => r.tenantChargeDate.Year == int.Parse(cmbBoxUnpaidYear.Text)).ToList();
            }

            if (txtBoxUnpaidUnitNo.Text != "")
            {
                unpaidAccounts = unpaidAccounts.Where(r => r.UnitNo == txtBoxUnpaidUnitNo.Text).ToList();
            }

            unpaidAccounts = unpaidAccounts.OrderByDescending(r => r.tenantChargeDate).ToList();

            listViewUnpaid.Items.Clear();

            unpaidAccounts.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());

                lvi.SubItems.Add(item.UnitNo);

                lvi.SubItems.Add(item.UnitOwner);

                lvi.SubItems.Add(item.Tenant);

                lvi.SubItems.Add(item.tenantChargeDate.ToShortDateString());

                lvi.SubItems.Add(item.TotalAmountDue);

                listViewUnpaid.Items.Add(lvi);
            });
        }

        private void GetPaidAccounts()
        {
            List<Accounts> paidAccounts = new List<Accounts>();

            //Monthly Assoc Due
            var paidAssoc = new MonthlyAssociationDueViewModel().GetAllPaid();

            paidAssoc.ForEach(item =>
            {
                Accounts paidAccount = new Accounts();

                paidAccount.ID = item.ID;

                if(item.UnitNumber != "")
                {
                    var unit = new UnitViewModel().GetSelected(item.UnitNumber);

                    paidAccount.UnitNo = item.UnitNumber;

                    if(unit != null)
                    {
                        paidAccount.Tenant = unit.Tenant.ToString();

                        paidAccount.UnitOwner = unit.Owner.ToString();
                    }
                }

                paidAccount.tenantChargeDate = DateTime.Parse(item.ChargeDate.ToString());

                paidAccount.TotalAmountDue = string.Format("{0:0.00}", item.TotalAmount);

                paidAccounts.Add(paidAccount);
            });

            //Reservation
            var reservation = new ReservationViewModel().GetAllPaid();

            reservation.ForEach(item =>
            {
                Accounts paidAccount = new Accounts();

                if (item.UnitNumber != "")
                {
                    var unit = new UnitViewModel().GetSelected(item.UnitNumber);

                    if (unit != null)
                    {
                        paidAccount.UnitNo = item.UnitNumber;

                        paidAccount.Tenant = unit.Tenant.ToString();

                        paidAccount.UnitOwner = unit.Owner.ToString();
                    }
                }

                paidAccount.tenantChargeDate = DateTime.Parse(item.Date.ToString());

                paidAccount.TotalAmountDue = string.Format("{0:0.00}", item.Amount);

                paidAccounts.Add(paidAccount);
            });

            if(cmbBoxPaidMonth.Text != "")
            {
                paidAccounts = paidAccounts.Where(r => r.tenantChargeDate.Month == ConvertMonthToInt(cmbBoxPaidMonth.Text)).ToList();
            }

            if(cmbBoxPaidMonth.Text != "")
            {
                paidAccounts = paidAccounts.Where(r => r.tenantChargeDate.Year == int.Parse(cmbBoxPaidYear.Text)).ToList();
            }

            if(txtBoxPaidUnitNo.Text != "")
            {
                paidAccounts = paidAccounts.Where(r => r.UnitNo == txtBoxPaidUnitNo.Text).ToList();
            }

            paidAccounts = paidAccounts.OrderByDescending(r => r.tenantChargeDate).ToList();

            listViewPaidAccounts.Items.Clear();

            paidAccounts.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());

                lvi.SubItems.Add(item.UnitNo);

                lvi.SubItems.Add(item.UnitOwner);

                lvi.SubItems.Add(item.Tenant);

                lvi.SubItems.Add(item.tenantChargeDate.ToShortDateString());

                lvi.SubItems.Add(item.TotalAmountDue);

                listViewPaidAccounts.Items.Add(lvi);
            });
        }

        private void GetReservations()
        {
            listViewReservation.Items.Clear();

            var reservation = new ReservationViewModel().GetAll();

            reservation.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());//ID

                lvi.SubItems.Add(item.UnitNumber); //Unit No

                if (item.UnitNumber != "" && item.UnitNumber != null)//Unit owner
                {
                    var unit = new UnitViewModel().GetSelected(item.UnitNumber);

                    if (unit != null)
                    {
                        if (unit.Owner != null)
                        {
                            var owner = new TenantViewModel().GetSelectedTenant(unit.Owner);

                            if (owner != null)
                            {
                                lvi.SubItems.Add(owner.FirstName + " " + owner.LastName);
                            }
                            else
                                lvi.SubItems.Add("N/A");
                        }
                        else
                            lvi.SubItems.Add("N/A");

                        if(unit.Tenant != null)
                        {
                            var tenant = new TenantViewModel().GetSelectedTenant(unit.Tenant);

                            if (tenant != null)
                            {
                                lvi.SubItems.Add(tenant.FirstName + " " + tenant.LastName);
                            }
                            else
                                lvi.SubItems.Add("N/A");
                        }
                        else
                            lvi.SubItems.Add("N/A");
                    }
                    else
                    {
                        lvi.SubItems.Add("N/A");

                        lvi.SubItems.Add("N/A");
                    }
                }
                else
                {
                    lvi.SubItems.Add("N/A");

                    lvi.SubItems.Add("N/A");
                }

                lvi.SubItems.Add(item.DateOfFuntion.ToShortDateString());

                lvi.SubItems.Add(item.Facility);

                lvi.SubItems.Add("");

                listViewReservation.Items.Add(lvi);
            });
        }

        private void GetSelectedReservation(Guid _reservationID)
        {
            var reservation = new ReservationViewModel().GetSelected(_reservationID);

            if(reservation != null)
            {
                var unit = new UnitViewModel().GetSelected(reservation.UnitNumber);

                if(unit != null)
                {
                    if (unit.Tenant != null)
                    {
                        var tenant = new TenantViewModel().GetSelectedTenant(unit.Tenant);

                        if(tenant != null)
                        {
                            //Personal Information
                            txtBoxFirstName.Text = tenant.FirstName;

                            txtBoxMiddleName.Text = tenant.MiddleName;

                            txtBoxLastName.Text = tenant.LastName;

                            txtBoxUnitNo.Text = reservation.UnitNumber;

                            if(unit.Owner != null)
                            {
                                var owner = new TenantViewModel().GetSelectedTenant(unit.Owner);

                                if (owner != null)
                                {
                                    txtBoxUnitOwner.Text = owner.FirstName + " " + owner.LastName;
                                }
                            }

                            txtBoxNatureOfOccupancy.Text = tenant.NatureOfOccupancy;

                            txtBoxMobileNo.Text = tenant.MobileNo;

                            txtBoxTelNo.Text = tenant.TelephoneNo;

                            txtBoxEmail.Text = tenant.Email;
                        }
                    }
                }

                //Reservation information
                txtBoxDateOfEvent.Text = reservation.DateOfFuntion.ToShortDateString();

                txtBoxEventName.Text = "N/A";

                txtBoxPurpose.Text = reservation.Purpose;

                txtBoxNumberOfGuest.Text = reservation.NoOfGuest;

                cmbBoxReservationFacility.Text = reservation.Facility;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox4.Visible = true;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void listViewReservation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Guid reservationID = Guid.Parse(listViewReservation.SelectedItems[0].SubItems[0].Text);

                GetSelectedReservation(reservationID);

                TabPage openTab = tabControl1.TabPages[1];

                tabControl1.SelectedTab = openTab;
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void btnUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearchPaid_Click(object sender, EventArgs e)
        {
            GetPaidAccounts();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnUnpaidSearch_Click(object sender, EventArgs e)
        {
            GetUnpaidAccounts();
        }
    }
}
