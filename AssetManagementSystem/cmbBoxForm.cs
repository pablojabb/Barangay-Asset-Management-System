using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public partial class cmbBoxForm : MaterialForm
    {
        private readonly ParameterType _parameterType;
        private string type = "";
        public enum ParameterType
        {
            Category,
            Status,
            Condition
        }

        public cmbBoxForm(ParameterType parameterType)
        {
            InitializeComponent();
            _parameterType = parameterType;

            switch (_parameterType)
            {
                case ParameterType.Category:
                    // load categories
                    typeLoad("Category");
                    type = "categories";
                    break;
                case ParameterType.Status:
                    // load statuses
                    typeLoad("Status");
                    type = "statuses";
                    break;
                case ParameterType.Condition:
                    // load conditions
                    typeLoad("Condition");
                    type = "conditions";
                    break;
            }

            loadData(type);

        }

        private void typeLoad(string type)
        {
            materialLabel1.Text = "Manage " + type;
            addBtn.Text = "Add " + type;
            editBtn.Text = "Edit " + type;
            deleteBtn.Text = "Delete " + type;
            nameFeild.Hint = type + " Name";
            columnHeader2.Text = type + " Name";
            this.ActiveControl = null;
        }

        private void loadData(string type)
        {
            var db = new dbAccess();
            string query = $"SELECT * FROM {type}";

            DataTable dt = db.ExecuteQuery(query);

            materialListView1.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                materialListView1.Items.Add(item);
            }
        }

        private void clearFeilds()
        {
            nameFeild.Text = "";
            materialTextBox21.Text = "";
        }


        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // Confirm before adding
            DialogResult confirm = MessageBox.Show(
                "Are all fields correct before saving?",
                "Confirm Add",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
                return;

            var db = new dbAccess();

            // Check for duplicate
            string checkQuery = $"SELECT COUNT(*) FROM {type} WHERE name = @name";
            var checkParam = new SQLiteParameter[]
            {
        new SQLiteParameter("@name", nameFeild.Text)
            };

            DataTable checkResult = db.ExecuteQuery(checkQuery, checkParam);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("This name already exists. Please use a different name.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert new record
            string query = $"INSERT INTO {type} (name) VALUES (@name)";
            var parameters = new SQLiteParameter[]
            {
        new SQLiteParameter("@name", nameFeild.Text)
            };

            int result = db.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData(type);
                clearFeilds();
            }
            else
            {
                MessageBox.Show("Failed to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected record ID
            string id = materialListView1.SelectedItems[0].SubItems[0].Text;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.No)
                return;

            var db = new dbAccess();

            string query = $"DELETE FROM {type} WHERE id = @id";
            var parameters = new SQLiteParameter[]
            {
        new SQLiteParameter("@id", id)
            };

            int result = db.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Record deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData(type);
                clearFeilds();
            }
            else
            {
                MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
           

            // Get selected record ID
            string id = materialTextBox21.Text;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to update this record?",
                "Confirm Edit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.No)
                return;

            var db = new dbAccess();

            // Duplicate check (exclude current record)
            string checkQuery = $"SELECT COUNT(*) FROM {type} WHERE name = @name AND id != @id";
            var checkParams = new SQLiteParameter[]
            {
        new SQLiteParameter("@name", nameFeild.Text),
        new SQLiteParameter("@id", id)
            };

            DataTable checkResult = db.ExecuteQuery(checkQuery, checkParams);
            int count = Convert.ToInt32(checkResult.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("This name already exists. Please use a different name.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with update
            string query = $"UPDATE {type} SET name = @name WHERE id = @id";
            var parameters = new SQLiteParameter[]
            {
        new SQLiteParameter("@name", nameFeild.Text),
        new SQLiteParameter("@id", id)
            };

            int result = db.ExecuteNonQuery(query, parameters);

            if (result > 0)
            {
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData(type);
                clearFeilds();
            }
            else
            {
                MessageBox.Show("Failed to update record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView1.SelectedItems[0];

                // Text Fields
                materialTextBox21.Text = item.SubItems[0].Text;
                nameFeild.Text = item.SubItems[1].Text;
            }

        }
    }


}
