using MaterialSkin.Controls;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssetManagementSystem
{
    public partial class assets : MaterialForm
    {
        private string searchterm;
        private CancellationTokenSource debounceToken;
        public assets()
        {
            InitializeComponent();
            LoadComboBoxData();
            loadData();
        }

        private void loadData()
        {
            var db = new dbAccess();
            string query = "SELECT * FROM assets WHERE asset_name LIKE @searchterm OR id LIKE @searchterm";
            new SQLiteParameter("@searchterm", "%" + searchterm + "%");

            var parameters = new List<SQLiteParameter>
                      {
                         new SQLiteParameter("@searchterm", searchterm + "%")
                      };

            DataTable dt = db.ExecuteQuery(query, parameters.ToArray());

            assetListView.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["asset_name"].ToString());
                item.SubItems.Add(row["location"].ToString());
                item.SubItems.Add(row["category"].ToString());
                item.SubItems.Add(row["status"].ToString());
                item.SubItems.Add(row["condition"].ToString());

                assetListView.Items.Add(item);
            }
        }

        public void LoadComboBoxData()
        {
            try
            {
                var db = new dbAccess();

                // Load Categories
                string categoryQuery = "SELECT name FROM categories";
                DataTable dtCategory = db.ExecuteQuery(categoryQuery);
                categoryComboBox.Items.Clear();
                foreach (DataRow row in dtCategory.Rows)
                    categoryComboBox.Items.Add(row["name"].ToString());

                // Load Statuses
                string statusQuery = "SELECT name FROM statuses";
                DataTable dtStatus = db.ExecuteQuery(statusQuery);
                statusComboBox.Items.Clear();
                foreach (DataRow row in dtStatus.Rows)
                    statusComboBox.Items.Add(row["name"].ToString());

                // Load Conditions
                string conditionQuery = "SELECT name FROM conditions";
                DataTable dtCondition = db.ExecuteQuery(conditionQuery);
                conditionComboBox.Items.Clear();
                foreach (DataRow row in dtCondition.Rows)
                    conditionComboBox.Items.Add(row["name"].ToString());

                // Optional: select first item automatically
                if (categoryComboBox.Items.Count > 0) categoryComboBox.SelectedIndex = 0;
                if (statusComboBox.Items.Count > 0) statusComboBox.SelectedIndex = 0;
                if (conditionComboBox.Items.Count > 0) conditionComboBox.SelectedIndex = 0;
                categoryComboBox.Focus();
                statusComboBox.Focus();
                conditionComboBox.Focus();

                this.ActiveControl = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load dropdown data.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void addAsset()
        {
            var db = new dbAccess();
            accounts acc = new accounts();

            if (
                acc.CheckField(nameFeild) &&
                acc.CheckField(locationFeild) &&
                acc.CheckField(categoryComboBox) &&
                acc.CheckField(statusComboBox) &&
                acc.CheckField(conditionComboBox)
                )
            {
                this.ActiveControl = null;

                string assetName = nameFeild.Text.Trim();
                string location = locationFeild.Text.Trim();
                string category = categoryComboBox.Text.Trim();
                string status = statusComboBox.Text.Trim();
                string condition = conditionComboBox.Text.Trim();

                // ✅ Check if asset already exists (by name and location)
                string checkQuery = "SELECT COUNT(*) FROM assets WHERE asset_name = @name";
                int exists = Convert.ToInt32(db.ExecuteScalar(checkQuery,
                    new SQLiteParameter("@name", assetName),
                    new SQLiteParameter("@loc", location)));

                if (exists > 0)
                {
                    MessageBox.Show("Asset already exists with these name!",
                                    "Duplicate Asset", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Insert new asset
                string insertQuery = @"INSERT INTO assets 
                               (asset_name, location, category, status, condition)
                               VALUES (@name, @loc, @cat, @stat, @cond)";
                int rows = db.ExecuteNonQuery(insertQuery,
                    new SQLiteParameter("@name", assetName),
                    new SQLiteParameter("@loc", location),
                    new SQLiteParameter("@cat", category),
                    new SQLiteParameter("@stat", status),
                    new SQLiteParameter("@cond", condition));

                if (rows > 0)
                {
                    MessageBox.Show("✅ Asset added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clearFeilds();
                }
                else
                {
                    MessageBox.Show("❌ Failed to add asset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editAsset()
        {
            var db = new dbAccess();
            accounts acc = new accounts();

            if (
                acc.CheckField(idFeild) &&
                acc.CheckField(nameFeild) &&
                acc.CheckField(locationFeild) &&
                acc.CheckField(categoryComboBox) &&
                acc.CheckField(statusComboBox) &&
                acc.CheckField(conditionComboBox)
                )
            {
                this.ActiveControl = null;

                string id = idFeild.Text.Trim();
                string assetName = nameFeild.Text.Trim();
                string location = locationFeild.Text.Trim();
                string category = categoryComboBox.Text.Trim();
                string status = statusComboBox.Text.Trim();
                string condition = conditionComboBox.Text.Trim();

                // ✅ Check if asset exists
                string checkQuery = "SELECT COUNT(*) FROM assets WHERE id = @id";
                int exists = Convert.ToInt32(db.ExecuteScalar(checkQuery, new SQLiteParameter("@id", id)));

                if (exists == 0)
                {
                    MessageBox.Show("⚠️ Asset not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Update asset
                string updateQuery = @"UPDATE assets 
                               SET asset_name = @name,
                                   location = @loc,
                                   category = @cat,
                                   status = @stat,
                                   condition = @cond
                               WHERE id = @id";

                int rows = db.ExecuteNonQuery(updateQuery,
                    new SQLiteParameter("@name", assetName),
                    new SQLiteParameter("@loc", location),
                    new SQLiteParameter("@cat", category),
                    new SQLiteParameter("@stat", status),
                    new SQLiteParameter("@cond", condition),
                    new SQLiteParameter("@id", id));

                if (rows > 0)
                {
                    MessageBox.Show("✅ Asset updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clearFeilds();
                }
                else
                {
                    MessageBox.Show("❌ Failed to update asset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteAsset()
        {
            var db = new dbAccess();
            accounts acc = new accounts();

            if (!acc.CheckField(idFeild))
                return;

            this.ActiveControl = null;

            string id = idFeild.Text.Trim();

            // ✅ Confirm before deleting
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this asset?",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            // ✅ Check if asset exists
            string checkQuery = "SELECT COUNT(*) FROM assets WHERE id = @id";
            int exists = Convert.ToInt32(db.ExecuteScalar(checkQuery, new SQLiteParameter("@id", id)));

            if (exists == 0)
            {
                MessageBox.Show("⚠️ Asset not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ✅ Delete asset
            string deleteQuery = "DELETE FROM assets WHERE id = @id";
            int rows = db.ExecuteNonQuery(deleteQuery, new SQLiteParameter("@id", id));

            if (rows > 0)
            {
                MessageBox.Show("🗑️ Asset deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clearFeilds();
            }
            else
            {
                MessageBox.Show("❌ Failed to delete asset.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void clearFeilds()
        {
            idFeild.Text = "";
            nameFeild.Text = "";
            locationFeild.Text = "";
            LoadComboBoxData();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addAsset();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editAsset();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteAsset();
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            new cmbBoxForm(cmbBoxForm.ParameterType.Condition).ShowDialog();
        }

        private void materialComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            new cmbBoxForm(cmbBoxForm.ParameterType.Status).ShowDialog();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            new cmbBoxForm(cmbBoxForm.ParameterType.Category).ShowDialog();
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void locationFeild_Click(object sender, EventArgs e)
        {

        }

        private void nameFeild_Click(object sender, EventArgs e)
        {

        }

        private void idFeild_Click(object sender, EventArgs e)
        {

        }

        private void assetListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (assetListView.SelectedItems.Count > 0)
            {
                ListViewItem item = assetListView.SelectedItems[0];

                // Text Fields
                idFeild.Text = item.SubItems[0].Text;
                nameFeild.Text = item.SubItems[1].Text;
                locationFeild.Text = item.SubItems[2].Text;

                // ComboBoxes
                string category = item.SubItems[3].Text;
                string status = item.SubItems[4].Text;
                string condition = item.SubItems[5].Text;

                // Set ComboBox selected values
                categoryComboBox.SelectedIndex = categoryComboBox.FindStringExact(category);
                statusComboBox.SelectedIndex = statusComboBox.FindStringExact(status);
                conditionComboBox.SelectedIndex = conditionComboBox.FindStringExact(condition);

                categoryComboBox.Focus();
                statusComboBox.Focus();
                conditionComboBox.Focus();

                this.ActiveControl = null;
            }
        }

        private void materialButton4_Click(object sender, EventArgs e)
        {
            if (idFeild.Text.Trim() != "")
            {
             imageForm imgForm = new imageForm(idFeild.Text.Trim());
                imgForm.Show();
            }
            else
            {
                MessageBox.Show("⚠️ Please select an asset first.", "No Asset Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    searchterm = searchFeild.Text.Trim();
                    loadData();
                }
            }
            catch (TaskCanceledException) { }

        }
    }
}
