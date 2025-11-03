using MaterialSkin.Controls;
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

namespace AssetManagementSystem
{
    public partial class reports : MaterialForm
    {
        public reports()
        {
            InitializeComponent();
        }

        private void reports_Load(object sender, EventArgs e)
        {
            var db = new dbAccess();

            string query = "SELECT id, asset_name, location, category, status, condition FROM assets";
            DataTable dt = db.ExecuteQuery(query);


            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = @"Reports\AssetList.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource("assets", dt)
            );
            reportViewer1.RefreshReport();


        }
    }
}
