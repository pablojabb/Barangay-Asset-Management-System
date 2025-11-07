using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssetManagementSystem
{
    public partial class logs : MaterialForm
    {
        private string searchTerm;
        private string assetSearchTerm;
        private string category;
        private string status;
        private string condition;
        private string startDate;
        private string endDate;
        private CancellationTokenSource debounceToken;
        public logs()
        {
            InitializeComponent();
            FilterLoadComboBoxData();
            LoadComboBoxData();
            loadData();
            loadAsset();
        }

        public void LoadComboBoxData()
        {
            try
            {
                var db = new dbAccess();


                // Load Statuses
                string statusQuery = "SELECT name FROM statuses";
                DataTable dtStatus = db.ExecuteQuery(statusQuery);
                materialComboBox1.Items.Clear();
                foreach (DataRow row in dtStatus.Rows)
                    materialComboBox1.Items.Add(row["name"].ToString());

                // Load Conditions
                string conditionQuery = "SELECT name FROM conditions";
                DataTable dtCondition = db.ExecuteQuery(conditionQuery);
                materialComboBox2.Items.Clear();
                foreach (DataRow row in dtCondition.Rows)
                    materialComboBox2.Items.Add(row["name"].ToString());

                if (materialComboBox2.Items.Count > 0) materialComboBox2.SelectedIndex = 0;
                if (materialComboBox1.Items.Count > 0) materialComboBox1.SelectedIndex = 0;
                materialComboBox2.Focus();
                materialComboBox1.Focus();


                this.ActiveControl = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load dropdown data.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void FilterLoadComboBoxData()
        {
            try
            {
                var db = new dbAccess();

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


        public void loadData()
        {
            try
            {
                var db = new dbAccess();
                DataTable dt;

                // ✅ Base query
                string query = "SELECT asset_name, status, condition, assigned_to, date " +
                               "FROM asset_logs WHERE asset_name LIKE @searchTerm ";

                // ✅ Dynamic filters
                if (!string.IsNullOrEmpty(status) && status != "All")
                    query += "AND status LIKE @status ";
                if (!string.IsNullOrEmpty(condition) && condition != "All")
                    query += "AND condition LIKE @condition ";
                if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
                    query += "AND date BETWEEN @startDate AND @endDate ";

                // ✅ Parameters
                var parameters = new List<SQLiteParameter>
        {
            new SQLiteParameter("@searchTerm", $"{searchTerm}%")
        };

                if (!string.IsNullOrEmpty(status) && status != "All")
                    parameters.Add(new SQLiteParameter("@status", $"{status}%"));
                if (!string.IsNullOrEmpty(condition) && condition != "All")
                    parameters.Add(new SQLiteParameter("@condition", $"{condition}%"));
                if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
                {
                    parameters.Add(new SQLiteParameter("@startDate", startDate));
                    parameters.Add(new SQLiteParameter("@endDate", endDate));
                }

                dt = db.ExecuteQuery(query, parameters.ToArray());

                // ✅ Handle no results
                materialListView1.Items.Clear();
                materialListView1.Columns.Clear();

                if (dt == null || dt.Rows.Count == 0)
                {
                    var col = materialListView1.Columns.Add("No Data");
                    var noDataItem = new ListViewItem("No matching records found.");
                    materialListView1.Items.Add(noDataItem);
                    col.Width = materialListView1.ClientSize.Width - 4;
                    return;
                }

                // ✅ Generate columns dynamically
                foreach (DataColumn col in dt.Columns)
                    materialListView1.Columns.Add(col.ColumnName);

                // ✅ Populate rows
                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < dt.Columns.Count; i++)
                        item.SubItems.Add(row[i].ToString());
                    materialListView1.Items.Add(item);
                }

                // ✅ Auto-size columns
                int colWidth = materialListView1.ClientSize.Width / materialListView1.Columns.Count;
                foreach (ColumnHeader col in materialListView1.Columns)
                    col.Width = colWidth;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading data:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void loadAsset()
        {
            try
            {
                var db = new dbAccess();
                DataTable dt;

                // ✅ Fetch all data but filter by name
                string query = "SELECT * FROM assets WHERE asset_name LIKE @searchTerm";
                var parameters = new List<SQLiteParameter>
        {
            new SQLiteParameter("@searchTerm", $"{assetSearchTerm}%")
        };

                dt = db.ExecuteQuery(query, parameters.ToArray());

                materialListView2.Items.Clear();
                materialListView2.Columns.Clear();

                // ✅ Handle no data
                if (dt == null || dt.Rows.Count == 0)
                {
                    var col = materialListView2.Columns.Add("No Data");
                    var noDataItem = new ListViewItem("No matching records found.");
                    materialListView2.Items.Add(noDataItem);
                    col.Width = materialListView2.ClientSize.Width - 4;
                    return;
                }

                // ✅ Only display asset_name
                var visibleCol = materialListView2.Columns.Add("Asset Name");
                visibleCol.Width = materialListView2.ClientSize.Width - 4;

                // ✅ Populate only asset_name, but store all data in Tag
                foreach (DataRow row in dt.Rows)
                {
                    var item = new ListViewItem(row["asset_name"].ToString())
                    {
                        Tag = row // Store the full row data for later use (hidden)
                    };
                    materialListView2.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error loading data:\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void createLog()
        {
            var acc = new accounts();

            if (
                acc.CheckField(materialTextBox23) &&
                acc.CheckField(materialComboBox1) &&
                acc.CheckField(materialComboBox2) &&
                acc.CheckField(materialTextBox24)
            )
            {
                this.ActiveControl = null;

                string assetName = materialTextBox23.Text.Trim();
                string status = materialComboBox1.Text.Trim();
                string condition = materialComboBox2.Text.Trim();
                string handler = materialTextBox24.Text.Trim();
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                var db = new dbAccess();

                try
                {
                    // ✅ Insert into asset_logs table
                    string insertQuery = @"
                INSERT INTO asset_logs (asset_name, status, condition, assigned_to, date)
                VALUES (@asset_name, @status, @condition, @handler, @date);
            ";

                    var insertParams = new List<SQLiteParameter>
            {
                new SQLiteParameter("@asset_name", assetName),
                new SQLiteParameter("@status", status),
                new SQLiteParameter("@condition", condition),
                new SQLiteParameter("@handler", handler),
                   new SQLiteParameter("@date", date)
            };

                    db.ExecuteNonQuery(insertQuery, insertParams.ToArray());

                    // ✅ Update assets table
                    string updateQuery = @"
                UPDATE assets
                SET status = @status, condition = @condition
                WHERE asset_name = @asset_name;
            ";

                    var updateParams = new List<SQLiteParameter>
            {
                new SQLiteParameter("@asset_name", assetName),
                new SQLiteParameter("@status", status),
                new SQLiteParameter("@condition", condition)
            };

                    db.ExecuteNonQuery(updateQuery, updateParams.ToArray());

                    MessageBox.Show("✅ Log created and asset updated successfully.",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error creating log:\n" + ex.Message,
                                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loadAsset();
                loadData();
                resetFeilds();
            }
         
        }


        private async void materialTextBox21_TextChanged(object sender, EventArgs e)
        {
           

            debounceToken?.Cancel();
            debounceToken = new CancellationTokenSource();
            var token = debounceToken.Token;


            try
            {
                await Task.Delay(400, token);
                if (!token.IsCancellationRequested)
                {
                    assetSearchTerm = materialTextBox21.Text.Trim();
                    loadAsset();
                }
            }
            catch (TaskCanceledException) { }

        }
        

        private async void materialTextBox22_TextChanged(object sender, EventArgs e)
        {
            

            debounceToken?.Cancel();
            debounceToken = new CancellationTokenSource();
            var token = debounceToken.Token;


            try
            {
                await Task.Delay(400, token);
                if (!token.IsCancellationRequested)
                {
                    searchTerm = materialTextBox22.Text.Trim();
                    loadData();
                }
            }
            catch (TaskCanceledException) { }

        }

        private void materialListView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView2.SelectedItems.Count > 0)
            {
                var item = materialListView2.SelectedItems[0];
                var row = item.Tag as DataRow; // ✅ Retrieve hidden data

                if (row != null)
                {
                    // ✅ Display asset name
                    materialTextBox23.Text = row["asset_name"].ToString();

                    // ✅ Get other hidden fields
                    string status = row["status"].ToString();
                    string condition = row["condition"].ToString();
                    materialComboBox1.SelectedIndex = materialComboBox1.FindStringExact(status);
                    materialComboBox2.SelectedIndex = materialComboBox2.FindStringExact(condition);

                    materialComboBox1.Focus();
                    materialComboBox2.Focus();

                    this.ActiveControl = null;
                   
                }
            }
        }

        public void resetFeilds()
        {
            materialComboBox1.SelectedIndex = 0;
            materialComboBox2.SelectedIndex = 0;
            materialTextBox23.Text = "";
            materialTextBox24.Text = "";


        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            createLog();
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            resetFeilds();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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

        private void materialExpansionPanel1_CancelClick(object sender, EventArgs e)
        {
            FilterLoadComboBoxData();

            // ✅ Reset DateTimePicker to current date and time
            
            dateTimePicker1.Value = DateTime.Now;

            // ✅ Reset filters
            condition = null;
            status = null;
            startDate = null;
            endDate = null;
            loadData();
        }

        private void materialExpansionPanel1_SaveClick(object sender, EventArgs e)
        {
            status = statusComboBox.SelectedItem?.ToString();
            condition = conditionComboBox.SelectedItem?.ToString();
            if (materialSwitch1.Checked)
            {
                startDate = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
                
                endDate = dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss");
            }
            loadData();
        }
    }

}
