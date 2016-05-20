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

namespace Tenancy_Management_Information_Systems.ReportForms.Unit
{
    public partial class UnitOccupied : Form
    {
        public UnitOccupied()
        {
            InitializeComponent();

            LoadReport();
        }


        private void LoadReport()
        {
            using (var db = new EchoEntities())
            {
                unitAllOccupiedBindingSource.DataSource =
                    db.UnitAllOccupied();

                reportViewer.RefreshReport();
            }
        }
        private void UnitOccupied_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'echoDataSet.UnitAllOccupied' table. You can move, or remove it, as needed.
            this.unitAllOccupiedTableAdapter.Fill(this.echoDataSet.UnitAllOccupied);

            this.reportViewer.RefreshReport();
        }
    }
}
