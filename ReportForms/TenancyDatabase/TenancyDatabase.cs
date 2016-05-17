using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Echo.Data.Repository;
using Microsoft.Reporting.WinForms;

namespace Tenancy_Management_Information_Systems.ReportForms
{
    public partial class TenancyDatabase : Form
    {
        public TenancyDatabase(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();

            LoadReport(startDate, endDate);
        }

        private void LoadReport(DateTime? startDate, DateTime? endDate)
        {
            using (var db = new EchoEntities())
            {
                tenancyDatabaseByOccupancyYearBindingSource.DataSource =
                    db.TenancyDatabaseByOccupancyYear(startDate, endDate);

                ReportParameter[] rParams = new ReportParameter[]
                {
                    new ReportParameter("StartDate", DateTime.Parse(startDate.ToString()).ToShortDateString()),
                    new ReportParameter("EndDate",DateTime.Parse(endDate.ToString()).ToShortDateString())
                };

                reportViewer1.LocalReport.SetParameters(rParams);

                reportViewer1.RefreshReport();
            }
        }

        private void TenancyDatabase_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
