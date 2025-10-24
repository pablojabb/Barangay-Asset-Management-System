using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public partial class login : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public login()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = false;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey900,
                Primary.Grey800,
                Primary.Grey700,
                Accent.Blue100,
                TextShade.WHITE
            );

            var db = new dbAccess();
            

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            // Ensure MaterialTextBoxes commit their text before reading
            this.ActiveControl = null;

            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var db = new dbAccess("database.db");
                string query = "SELECT COUNT(1) FROM users WHERE username = @u AND password = @p;";

                object result = db.ExecuteScalar(
                    query,
                    new System.Data.SQLite.SQLiteParameter("@u", username),
                    new System.Data.SQLite.SQLiteParameter("@p", password)
                );

                int found = Convert.ToInt32(result ?? 0);
                if (found > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Close app completely if cancel/exit is pressed
            Application.Exit();
        }

        private void passwordTextbox_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
