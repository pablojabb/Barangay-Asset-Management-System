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
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public partial class Form1 : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900,
                Primary.Grey800,
                Primary.Grey700,
                Accent.Green400,
                TextShade.WHITE);

            LoadThemeFromDatabase(); // ✅ Load saved theme before loading forms

            LoadForm(new dashboard(), tabPage1);
        }

        private void LoadThemeFromDatabase()
        {
            try
            {
                var db = new dbAccess();
                string query = "SELECT is_dark_mode FROM system_info LIMIT 1";
                DataTable dt = db.ExecuteQuery(query);

                if (dt.Rows.Count > 0)
                {
                    bool isDark = Convert.ToBoolean(dt.Rows[0]["is_dark_mode"]);
                    materialSkinManager.Theme = isDark
                        ? MaterialSkinManager.Themes.DARK
                        : MaterialSkinManager.Themes.LIGHT;
                }
                else
                {
                    // Default if no record
                    materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Failed to load theme.\n\n" + ex.Message,
                                "Theme Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        public void LoadForm(Form form, TabPage tabPage)
        {
            tabPage.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            // Optional: set manual position
            form.StartPosition = FormStartPosition.Manual;

            // Center the form manually
            form.Location = new Point(
                (tabPage.ClientSize.Width - form.Width) / 2,
                (tabPage.ClientSize.Height - form.Height) / 2
            );

            tabPage.Controls.Add(form);
            form.Show();
            form.BringToFront();

            // Handle resize (to stay centered)
            tabPage.Resize += (s, e) =>
            {
                form.Location = new Point(
                    (tabPage.ClientSize.Width - form.Width) / 2,
                    (tabPage.ClientSize.Height - form.Height) / 2
                );
            };
        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialTabControl1.SelectedTab == tabPage1)
            {
                LoadForm(new dashboard(), tabPage1);
            }
            if (materialTabControl1.SelectedTab == tabPage2)
            {
                LoadForm(new assets(), tabPage2);
            }
            if (materialTabControl1.SelectedTab == tabPage3)
            {
                LoadForm(new logs(), tabPage3);
            }
            if (materialTabControl1.SelectedTab == tabPage4)
            {
                LoadForm(new records(), tabPage4);
            }
            if (materialTabControl1.SelectedTab == tabPage5)
            {
                LoadForm(new reports(), tabPage5);
            }
            else if (materialTabControl1.SelectedTab == tabPage6)
            {

                LoadForm(new accounts(), tabPage6);
            }
            else if (materialTabControl1.SelectedTab == tabPage8)
            {

                LoadForm(new settings(materialSkinManager), tabPage8);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(
                    "Do you want to log out?",
                    "Logout Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}

