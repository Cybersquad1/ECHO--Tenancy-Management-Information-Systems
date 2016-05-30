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
    public partial class StatementOfAccount : Form
    {
        public StatementOfAccount(Guid _assocID, string _unitNo)
        {
            InitializeComponent();

            LoadReport(_assocID, _unitNo);
        }

        private void LoadReport(Guid _assocID, string _unitNo)
        {
            using (var db = new EchoEntities())
            {
                billingStatementBindingSource.DataSource = db.BillingStatement(_assocID);

               // ReportParameter[] rParams = new ReportParameter[]
               //{
               //     new ReportParameter("UnitNo", _unitNo)
               //};

               // reportViewer.LocalReport.SetParameters(rParams);

                reportViewer.RefreshReport();
            }
        }

        private void StatementOfAccount_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }

        private void billingStatementBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
