
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using MaterialSkin;
using MaterialSkin.Controls;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public partial class dashboard : MaterialForm
    {
        public dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadDashboardData()
        {
            try
            {
                var db = new dbAccess();

                // 🔹 Summary Counts
                string totalAssetsQuery = "SELECT COUNT(*) FROM assets";
                string availableAssetsQuery = "SELECT COUNT(*) FROM assets WHERE status = 'Available'";
                string maintenanceAssetsQuery = "SELECT COUNT(*) FROM assets WHERE status = 'Under Maintenance'";

                int totalAssets = Convert.ToInt32(db.ExecuteScalar(totalAssetsQuery));
                int availableAssets = Convert.ToInt32(db.ExecuteScalar(availableAssetsQuery));
                int maintenanceAssets = Convert.ToInt32(db.ExecuteScalar(maintenanceAssetsQuery));

                // 🔹 Labels
                materialLabel1.Text = totalAssets.ToString();
                materialLabel4.Text = $"{availableAssets}/{totalAssets}";
                materialLabel6.Text = $"{maintenanceAssets}/{totalAssets}";

                // 🔹 ProgressBars
                materialProgressBar1.Maximum = totalAssets;
                materialProgressBar1.Value = totalAssets; // full

                materialProgressBar2.Maximum = totalAssets;
                materialProgressBar2.Value = availableAssets;

                materialProgressBar3.Maximum = totalAssets;
                materialProgressBar3.Value = maintenanceAssets;


                // 🔹 Bar Chart: Number of Assets by Category
                string categoryQuery = @"
            SELECT category AS Category, COUNT(*) AS Count 
            FROM assets 
            GROUP BY category";

                DataTable categoryData = db.ExecuteQuery(categoryQuery);

                var categories = categoryData.AsEnumerable().Select(r => r["Category"].ToString()).ToArray();
                var counts = categoryData.AsEnumerable().Select(r => Convert.ToDouble(r["Count"])).ToArray();

                cartesianChart1.Series = new SeriesCollection
        {
            new ColumnSeries
            {
                Title = "Assets per Category",
                Values = new ChartValues<double>(counts)
            }
        };

                cartesianChart1.AxisX.Clear();
                cartesianChart1.AxisY.Clear();

                cartesianChart1.AxisX.Add(new Axis
                {
                    Title = "Category",
                    Labels = categories
                });

                cartesianChart1.AxisY.Add(new Axis
                {
                    Title = "Count",
                    LabelFormatter = value => value.ToString("N0")
                });

                cartesianChart1.LegendLocation = LegendLocation.Top;

                // 🔹 Pie Chart: Asset Condition Breakdown
                string conditionQuery = @"
            SELECT condition AS Condition, COUNT(*) AS Count 
            FROM assets 
            GROUP BY condition";

                DataTable conditionData = db.ExecuteQuery(conditionQuery);

                var pieSeries = new SeriesCollection();

                foreach (DataRow row in conditionData.Rows)
                {
                    string condition = row["Condition"].ToString();
                    double count = Convert.ToDouble(row["Count"]);

                    pieSeries.Add(new PieSeries
                    {
                        Title = condition,
                        Values = new ChartValues<double> { count },
                        DataLabels = true,
                        LabelPoint = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P1})"
                    });
                }

                pieChart1.Series = pieSeries;
                pieChart1.LegendLocation = LegendLocation.Top; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load dashboard data.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();


            // Switch to tab 3
            mainForm.MainTabControl.SelectedTab = mainForm.TabPage1;

            mainForm.LoadForm(new assets(), mainForm.TabPage1);


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();


            // Switch to tab 3
            mainForm.MainTabControl.SelectedTab = mainForm.TabPage3;

            mainForm.LoadForm(new logs(), mainForm.TabPage3);

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();


            // Switch to tab 3
            mainForm.MainTabControl.SelectedTab = mainForm.TabPage3;

            mainForm.LoadForm(new logs(), mainForm.TabPage3);

        }
    }
}
