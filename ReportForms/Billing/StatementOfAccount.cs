using Echo.Data.Repository;
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
        public StatementOfAccount(Guid _assocID)
        {
            InitializeComponent();

            LoadReport(_assocID);
        }

        private void LoadReport(Guid _assocID)
        {
            using (var db = new EchoEntities())
            {
                billingStatementBindingSource.DataSource =
                    db.BillingStatement(_assocID);

                reportViewer.RefreshReport();
            }
        }

        private void StatementOfAccount_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}
