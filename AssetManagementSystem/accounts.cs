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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssetManagementSystem
{
    public partial class accounts : MaterialForm
    {
        public accounts()
        {
            InitializeComponent();

            loadData();


        }

        private void addUser()
        {
            var db = new dbAccess();

            if (
                CheckField(nameFeild) &&
                CheckField(usernameFeild) &&
                CheckField(passwordFeild) &&
                CheckField(roleFeild)
                )
            {
                this.ActiveControl = null;

                string name = nameFeild.Text.Trim();
                string username = usernameFeild.Text.Trim();
                string password = passwordFeild.Text.Trim();
                string role = roleFeild.Text.Trim();

                // ✅ Check if username already exists
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @u";
                int exists = Convert.ToInt32(db.ExecuteScalar(checkQuery, new SQLiteParameter("@u", username)));

                if (exists > 0)
                {
                    MessageBox.Show("⚠️ Username already exists. Please choose another one.",
                                    "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Insert new user
                string insertQuery = "INSERT INTO users (name, username, password, role) VALUES (@n, @u, @p, @r)";
                int rows = db.ExecuteNonQuery(insertQuery,
                    new SQLiteParameter("@n", name),
                    new SQLiteParameter("@u", username),
                    new SQLiteParameter("@p", password),
                    new SQLiteParameter("@r", role));

                if (rows > 0)
                {
                    MessageBox.Show("✅ User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clearFeilds();
                }
                else
                {
                    MessageBox.Show("❌ Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editUser()
        {
            

            if (
                CheckField(nameFeild) &&
                CheckField(usernameFeild) &&
                CheckField(passwordFeild) &&
                CheckField(roleFeild)
                )
            {
                this.ActiveControl = null;

                var db = new dbAccess();
                ListViewItem item = materialListView1.SelectedItems[0];
                string userId = idFeild.Text;

                string name = nameFeild.Text.Trim();
                string username = usernameFeild.Text.Trim();
                string password = passwordFeild.Text.Trim();
                string role = roleFeild.Text.Trim();

                // ✅ Check if new username already exists for a different user
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @u AND id != @id";
                int exists = Convert.ToInt32(db.ExecuteScalar(checkQuery,
                    new SQLiteParameter("@u", username),
                    new SQLiteParameter("@id", userId)));

                if (exists > 0)
                {
                    MessageBox.Show("⚠️ Username already taken by another user.",
                                    "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // ✅ Update user record
                string updateQuery = "UPDATE users SET name = @n, username = @u, password = @p, role = @r WHERE id = @id";
                int rows = db.ExecuteNonQuery(updateQuery,
                    new SQLiteParameter("@n", name),
                    new SQLiteParameter("@u", username),
                    new SQLiteParameter("@p", password),
                    new SQLiteParameter("@r", role),
                    new SQLiteParameter("@id", userId));

                if (rows > 0)
                {
                    MessageBox.Show("✅ User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clearFeilds();
                }
                else
                {
                    MessageBox.Show("❌ Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void deleteUser()
        {
            var db = new dbAccess();
            string id = idFeild.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please select a user to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string deleteQuery = "DELETE FROM users WHERE id = @id";
                int rows = db.ExecuteNonQuery(deleteQuery, new SQLiteParameter("@id", id));
                if (rows > 0)
                {
                    MessageBox.Show("✅ User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                    clearFeilds();
                }
                else
                {
                    MessageBox.Show("❌ Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
       
        }

        private void loadData()
        {
            var db = new dbAccess();
            DataTable dt = db.ExecuteQuery("SELECT id, name, username, password, role FROM users");

            materialListView1.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["username"].ToString());

                // Mask password
                string maskedPassword = passToAsterisk(row["password"].ToString());
                item.SubItems.Add(maskedPassword);

                item.SubItems.Add(row["role"].ToString());

                materialListView1.Items.Add(item);
            }
        }


        public bool CheckField(MaterialTextBox2 txt)
        {
            this.ActiveControl = null;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                MessageBox.Show($"{txt.Hint} field cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Focus();
                return false;
            }
            return true;
        }

        public void clearFeilds()
        {
            idFeild.Text = "";
            nameFeild.Text = "";
            usernameFeild.Text = "";
            passwordFeild.Text = "";
            roleFeild.Text = "";
        }

        public string passToAsterisk(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            return new string('*', s.Length);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addUser();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clearFeilds();
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count > 0)
            {
                ListViewItem item = materialListView1.SelectedItems[0];

                idFeild.Text = item.SubItems[0].Text;
                nameFeild.Text = item.SubItems[1].Text;
                usernameFeild.Text = item.SubItems[2].Text;
                passwordFeild.Text = passToAsterisk(item.SubItems[3].Text);
                roleFeild.Text = item.SubItems[4].Text;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Are you sure you want to delete this user?",
        "Confirm Delete",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                deleteUser();
            }
            else
            {
                // User canceled the delete operation
                return;
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            editUser();
        }
    }
}
