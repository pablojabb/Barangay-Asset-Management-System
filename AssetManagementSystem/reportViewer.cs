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
        private readonly SQLiteParameter[] parameters; // ✅ store parameters

        public reportViewer(string query, SQLiteParameter[] parameters = null)
        {
            InitializeComponent();
            this.query = query ?? ""; // ✅ Prevent null query
            this.parameters = parameters; // ✅ Store parameters
        }

        private void reportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(query))
                {
                    MessageBox.Show("⚠ No query specified for report.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var db = new dbAccess();
                // ✅ Execute query with parameters if provided
                DataTable dt = db.ExecuteQuery(query, parameters);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("⚠ No data returned for this report.", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = @"Reports\AssetList.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("assets", dt)
                );

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
