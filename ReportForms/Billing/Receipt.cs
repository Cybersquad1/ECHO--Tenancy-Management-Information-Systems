using Echo.Data.Repository;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenancy_Management_Information_Systems.ReportForms.Billing
{
    public partial class Receipt : Form
    {
        public Receipt(Guid _paymentHistoryID, string userName)
        {
            InitializeComponent();

            LoadReport(_paymentHistoryID, userName);
        }

        private void LoadReport(Guid _paymentHistoryID, string userName)
        {
            using (var db = new EchoEntities())
            {
                receiptBindingSource.DataSource = db.Receipt(_paymentHistoryID);

                ReportParameter[] rParams = new ReportParameter[]
                {
                    new ReportParameter("ReceiptDate", DateTime.Now.ToShortDateString()),
                    new ReportParameter("PreparedBy", userName)
                };

                reportViewer.LocalReport.SetParameters(rParams);

                reportViewer.RefreshReport();
            }
        }

        private void Receipt_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}
