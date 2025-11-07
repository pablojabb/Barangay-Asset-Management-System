using AssetManagementSystem.Reports;
using MaterialSkin.Controls;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementSystem
{
  
    public partial class reports : MaterialForm
    {
        private string query;
        private string searchTerm;
        private string category;
        private string status;
        private string condition;
        private DataTable dt;
        private CancellationTokenSource debounceToken;
        public reports()
        {
            InitializeComponent();
            loadData();
            LoadComboBoxData();
        }

        public void loadData()
        {
            string typeFilter = materialComboBox1.SelectedItem?.ToString();
            string type = "";
            var db = new dbAccess();
            DataTable dt = null;

            switch (typeFilter)
            {
                case "Assets Information":
                    type = "assets";
                    query = $"SELECT id, asset_name, location, category, status, condition FROM {type} " +
                            "WHERE asset_name LIKE @searchTerm " +
                            (category != "All" ? "AND category LIKE @category " : "") +
                            (status != "All" ? "AND status LIKE @status " : "") +
                            (condition != "All" ? "AND condition LIKE @condition " : "");

                    var parameters = new List<SQLiteParameter>
                      {
                         new SQLiteParameter("@searchTerm", searchTerm + "%")
                      };

                    if (category != "All")
                        parameters.Add(new SQLiteParameter("@category", category + "%"));
                    if (status != "All")
                        parameters.Add(new SQLiteParameter("@status", status + "%"));
                    if (condition != "All")
                        parameters.Add(new SQLiteParameter("@condition", condition + "%"));

                    dt = db.ExecuteQuery(query, parameters.ToArray());
                    break;


                case "Asset Log":
                    type = "asset_log";
                    query = $"SELECT * FROM {type}";
                    dt = db.ExecuteQuery(query);
                    break;

                case "Maintenance Log":
                    type = "maintenance";
                    query = $"SELECT * FROM {type}";
                    dt = db.ExecuteQuery(query);
                    break;

                default:
                    query = "SELECT * FROM assets";
                    dt = db.ExecuteQuery(query);
                    break;
            }

            if (dt == null || dt.Rows.Count == 0)
            {
                materialListView1.Items.Clear();
                materialListView1.Columns.Clear();
                return;
            }

            // 🔹 Auto-generate columns based on DataTable
            materialListView1.Columns.Clear();
            foreach (DataColumn col in dt.Columns)
            {
                materialListView1.Columns.Add(col.ColumnName);
            }

            // 🔹 Populate rows
            materialListView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                var item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                materialListView1.Items.Add(item);
            }

            // 🔹 Adjust column widths safely
            if (materialListView1.Columns.Count > 0)
            {
                int colWidth = materialListView1.ClientSize.Width / materialListView1.Columns.Count;
                foreach (ColumnHeader col in materialListView1.Columns)
                    col.Width = colWidth;
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            var parameters = new List<SQLiteParameter>
              {
              new SQLiteParameter("@searchTerm", searchTerm + "%")
             };

                if (category != "All")
                    parameters.Add(new SQLiteParameter("@category", category + "%"));
                if (status != "All")
                    parameters.Add(new SQLiteParameter("@status", status + "%"));
                if (condition != "All")
                    parameters.Add(new SQLiteParameter("@condition", condition + "%"));

                // Pass both query and parameters
                var RV = new reportViewer(query, parameters.ToArray());
                RV.ShowDialog();
            }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void toggleDateFilter(bool status)
        {
            if (status)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                toggleDateFilter(true);
            }
            else
            {
                toggleDateFilter(false);
            }
        }

        public void LoadComboBoxData()
        {
            try
            {
                var db = new dbAccess();

                // --- Categories ---
                string categoryQuery = "SELECT name FROM categories";
                DataTable dtCategory = db.ExecuteQuery(categoryQuery);
                categoryComboBox.Items.Clear();
                categoryComboBox.Items.Add("All"); // 🔹 Add default option
                foreach (DataRow row in dtCategory.Rows)
                    categoryComboBox.Items.Add(row["name"].ToString());

                // --- Statuses ---
                string statusQuery = "SELECT name FROM statuses";
                DataTable dtStatus = db.ExecuteQuery(statusQuery);
                statusComboBox.Items.Clear();
                statusComboBox.Items.Add("All"); // 🔹 Add default option
                foreach (DataRow row in dtStatus.Rows)
                    statusComboBox.Items.Add(row["name"].ToString());

                // --- Conditions ---
                string conditionQuery = "SELECT name FROM conditions";
                DataTable dtCondition = db.ExecuteQuery(conditionQuery);
                conditionComboBox.Items.Clear();
                conditionComboBox.Items.Add("All"); // 🔹 Add default option
                foreach (DataRow row in dtCondition.Rows)
                    conditionComboBox.Items.Add(row["name"].ToString());

                // --- Default select "All" ---
                categoryComboBox.SelectedIndex = 0;
                statusComboBox.SelectedIndex = 0;
                conditionComboBox.SelectedIndex = 0;

                this.ActiveControl = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dropdown data.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void materialTextBox21_TextChanged(object sender, EventArgs e)
        {
            debounceToken?.Cancel();
            debounceToken = new CancellationTokenSource();
            var token = debounceToken.Token;

            string term = materialTextBox21.Text.Trim();

            try
            {
                await Task.Delay(400, token); 
                if (!token.IsCancellationRequested)
                {
                    searchTerm = term;
                    loadData();
                }
            }
            catch (TaskCanceledException) { }
        }

        private void materialExpansionPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialExpansionPanel1_CancelClick(object sender, EventArgs e)
        {
            //reset date filter

        }


        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            category = categoryComboBox.SelectedItem?.ToString();
            loadData();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            status = statusComboBox.SelectedItem?.ToString();
            loadData();
        }

        private void conditionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            condition = conditionComboBox.SelectedItem?.ToString();
            loadData();
        }

        private void materialExpansionPanel2_CancelClick(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = 0;
            statusComboBox.SelectedIndex = 0;
            conditionComboBox.SelectedIndex = 0;

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
