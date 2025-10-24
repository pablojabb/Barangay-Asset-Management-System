using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public partial class settings : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private int systemInfoId = 0; // Track if record exists

        public settings(MaterialSkinManager materialSkinManager)
        {
            InitializeComponent();
            this.materialSkinManager = materialSkinManager;
            loadData();
        }

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitch1.Checked)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        public void loadData()
        {
            try
            {
                var db = new dbAccess();
                string query = "SELECT rowid, logo, name, city, is_dark_mode FROM system_info LIMIT 1";
                DataTable dt = db.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    systemInfoId = Convert.ToInt32(row["rowid"]);

                    bryFeild.Text = row["name"].ToString();
                    cityFeild.Text = row["city"].ToString();

                    bool isDark = Convert.ToBoolean(row["is_dark_mode"]);
                    materialSwitch1.Checked = isDark;
                    materialSkinManager.Theme = isDark
                        ? MaterialSkinManager.Themes.DARK
                        : MaterialSkinManager.Themes.LIGHT;

                    if (row["logo"] != DBNull.Value)
                    {
                        byte[] logoBytes = (byte[])row["logo"];
                        using (var ms = new MemoryStream(logoBytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    systemInfoId = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to load system info.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveData()
        {
            try
            {
                var db = new dbAccess();

                string name = bryFeild.Text.Trim();
                string city = cityFeild.Text.Trim();
                bool isDark = materialSwitch1.Checked;
                byte[] logoBytes = null;

                if (pictureBox1.Image != null)
                {
                    using (var ms = new MemoryStream())
                    {
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                        logoBytes = ms.ToArray();
                    }
                }

                if (systemInfoId > 0)
                {
                    // ✅ Update existing record
                    string updateQuery = @"UPDATE system_info 
                                           SET logo = @logo, name = @name, city = @city, is_dark_mode = @dark";
                    db.ExecuteNonQuery(updateQuery,
                        new SQLiteParameter("@logo", (object)logoBytes ?? DBNull.Value),
                        new SQLiteParameter("@name", name),
                        new SQLiteParameter("@city", city),
                        new SQLiteParameter("@dark", isDark));
                }
                else
                {
                    // ✅ Insert new record
                    string insertQuery = @"INSERT INTO system_info (logo, name, city, is_dark_mode)
                                           VALUES (@logo, @name, @city, @dark)";
                    db.ExecuteNonQuery(insertQuery,
                        new SQLiteParameter("@logo", (object)logoBytes ?? DBNull.Value),
                        new SQLiteParameter("@name", name),
                        new SQLiteParameter("@city", city),
                        new SQLiteParameter("@dark", isDark));
                }

                MessageBox.Show("✅ System info saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Failed to save system info.\n\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            logoFeild.Text = "";
            loadData();
        }

        private void logoFeild_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Save file path only to the textbox (not to DB)
                    logoFeild.Text = ofd.FileName;

                    // Preview image in PictureBox
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            saveData();
        }
    }
}