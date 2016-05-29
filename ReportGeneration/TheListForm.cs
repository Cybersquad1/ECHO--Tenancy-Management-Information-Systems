using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Echo.Data.Repository.ViewModel();

namespace Tenancy_Management_Information_Systems.ReportGeneration
{
    public partial class TheListForm : Form
    {
        public TheListForm()
        {
            InitializeComponent();

            GetReservations();
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
    }
}
