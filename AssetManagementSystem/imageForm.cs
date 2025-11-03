using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace AssetManagementSystem
{
    public partial class imageForm : MaterialForm
    {
        private string id;
        public imageForm(string id)
        {
            this.id = id;
            InitializeComponent();
            loadData(id);
            this.ActiveControl = null;
        }
        private void loadData(string assetId)
        {
            var db = new dbAccess();
            string query = "SELECT asset_name, image FROM assets WHERE id = @id";

            var param = new SQLiteParameter("@id", assetId);
            DataTable dt = db.ExecuteQuery(query, param);

            if (dt.Rows.Count > 0)
            {
                imgLabel.Text = dt.Rows[0]["asset_name"].ToString();
                idFeild.Text = id;
                var imgData = dt.Rows[0]["image"];
                if (imgData != DBNull.Value)
                {
                    try
                    {
                        

                        // If image stored as BLOB (uncomment this part instead)
                    
                        byte[] bytes = (byte[])imgData;
                        using (var ms = new MemoryStream(bytes))
                        {
                            pictureBox1.Image = Image.FromStream(ms);
                        }
                      
                    }
                    catch
                    {
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    
                }
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Remove the image from this asset?",
                                "Confirm",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var db = new dbAccess();
                string query = "UPDATE assets SET image = NULL WHERE id = @id";

                var parameters = new SQLiteParameter[]
                {
            new SQLiteParameter("@id", id) // replace with your selected asset ID variable
                };

                db.ExecuteNonQuery(query, parameters);

                pictureBox1.Image = null;
                MessageBox.Show("Image removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void editBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
           

            // Insert into database
            var db = new dbAccess();
            string filePath = locationFeild.Text;
            byte[] imageBytes = File.ReadAllBytes(filePath);
            string query = "UPDATE assets SET image = @image WHERE id = @id";

                    var parameters = new SQLiteParameter[]
                    {
                     new SQLiteParameter("@image", imageBytes),
                     new SQLiteParameter("@id", id) // use your variable here
                    };


                    db.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Image successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
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

        private void imgLabel_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string filePath = ofd.FileName;
                    string fileName = Path.GetFileName(filePath);
                    byte[] imageBytes = File.ReadAllBytes(filePath);

                    nameFeild.Text = fileName;
                    locationFeild.Text = filePath;

                    // Display preview
                    pictureBox1.Image = Image.FromFile(filePath);

                }
            }
        }
    }
}
