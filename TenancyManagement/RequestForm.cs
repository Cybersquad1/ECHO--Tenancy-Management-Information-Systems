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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();

            GetAllRequest();
        }

        public void GetAllRequest(string _unitNo = "")
        {
            listViewRequest.Items.Clear();

            var reservation = new RequestViewModel().GetAll();

            if (_unitNo != "")
                reservation = reservation.Where(r => r.UnitNumber == _unitNo).ToList();

            reservation.ForEach(item =>
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());

                lvi.SubItems.Add(item.UnitNumber);

                lvi.SubItems.Add(item.Date.ToShortDateString());

                lvi.SubItems.Add(item.ScheduleDate.ToShortDateString());

                lvi.SubItems.Add(item.Time);

                string request = "";

                if (item.Request1 != "")
                    request += item.Request1;

                if (item.Request2 != "")
                    request += " | " + item.Request2;

                if (item.Request3 != "")
                    request += " | " + item.Request3;

                if (item.Request4 != "")
                    request += " | " + item.Request4;

                lvi.SubItems.Add(request);

                listViewRequest.Items.Add(lvi);
            });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GetAllRequest(txtBoxUnitNo.Text);
        }
    }
}