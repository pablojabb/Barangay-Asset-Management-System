using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public partial class reportViewer : MaterialForm
    {
        private readonly string query;
        private readonly string type;
        private readonly SQLiteParameter[] parameters; // ✅ store parameters

        public reportViewer(string query, string type, SQLiteParameter[] parameters = null)
        {
            InitializeComponent();
            this.query = query ?? ""; 
            this.parameters = parameters;
            this.type = type;
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("No query specified for report.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var db = new dbAccess();

                // ✅ Execute query with parameters if provided
                DataTable dt = db.ExecuteQuery(query, parameters);
                DataTable dt2 = db.ExecuteQuery("SELECT * FROM system_info");

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data returned for this report.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.DataSources.Clear();

                if (type == "assets")
                {
                    reportViewer1.LocalReport.ReportPath = @"Reports\AssetList.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("assets", dt));
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("brgyInfo", dt2));
                }
                else if (type == "asset_logs")
                {
                    reportViewer1.LocalReport.ReportPath = @"Reports\logs.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("logs", dt));
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("brgyInfo", dt2));
                }

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load report.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
