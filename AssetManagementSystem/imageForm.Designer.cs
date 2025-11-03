namespace AssetManagementSystem
{
    partial class imageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.deleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.addBtn = new MaterialSkin.Controls.MaterialButton();
            this.locationFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.nameFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.idFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.imgLabel = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.deleteBtn);
            this.materialCard1.Controls.Add(this.addBtn);
            this.materialCard1.Controls.Add(this.locationFeild);
            this.materialCard1.Controls.Add(this.nameFeild);
            this.materialCard1.Controls.Add(this.idFeild);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(440, 24);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(363, 489);
            this.materialCard1.TabIndex = 7;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(24, 279);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(314, 62);
            this.materialButton1.TabIndex = 19;
            this.materialButton1.Text = "Add Image";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(102, 30);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(166, 24);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Image Infotmation";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = false;
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteBtn.Depth = 0;
            this.deleteBtn.HighEmphasis = false;
            this.deleteBtn.Icon = null;
            this.deleteBtn.Location = new System.Drawing.Point(189, 387);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteBtn.Size = new System.Drawing.Size(149, 55);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete Image";
            this.deleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.deleteBtn.UseAccentColor = false;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = false;
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addBtn.Depth = 0;
            this.addBtn.HighEmphasis = false;
            this.addBtn.Icon = null;
            this.addBtn.Location = new System.Drawing.Point(24, 387);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addBtn.Size = new System.Drawing.Size(149, 55);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Save Image";
            this.addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addBtn.UseAccentColor = false;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // locationFeild
            // 
            this.locationFeild.AnimateReadOnly = false;
            this.locationFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.locationFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.locationFeild.Depth = 0;
            this.locationFeild.Enabled = false;
            this.locationFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.locationFeild.HideSelection = true;
            this.locationFeild.Hint = "filepath:";
            this.locationFeild.LeadingIcon = null;
            this.locationFeild.Location = new System.Drawing.Point(21, 212);
            this.locationFeild.MaxLength = 32767;
            this.locationFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.locationFeild.Name = "locationFeild";
            this.locationFeild.PasswordChar = '\0';
            this.locationFeild.PrefixSuffixText = null;
            this.locationFeild.ReadOnly = true;
            this.locationFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.locationFeild.SelectedText = "";
            this.locationFeild.SelectionLength = 0;
            this.locationFeild.SelectionStart = 0;
            this.locationFeild.ShortcutsEnabled = true;
            this.locationFeild.Size = new System.Drawing.Size(322, 48);
            this.locationFeild.TabIndex = 6;
            this.locationFeild.TabStop = false;
            this.locationFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.locationFeild.TrailingIcon = null;
            this.locationFeild.UseAccent = false;
            this.locationFeild.UseSystemPasswordChar = false;
            this.locationFeild.Click += new System.EventHandler(this.locationFeild_Click);
            // 
            // nameFeild
            // 
            this.nameFeild.AnimateReadOnly = false;
            this.nameFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameFeild.Depth = 0;
            this.nameFeild.Enabled = false;
            this.nameFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFeild.HideSelection = true;
            this.nameFeild.Hint = "Image name";
            this.nameFeild.LeadingIcon = null;
            this.nameFeild.Location = new System.Drawing.Point(21, 147);
            this.nameFeild.MaxLength = 32767;
            this.nameFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.nameFeild.Name = "nameFeild";
            this.nameFeild.PasswordChar = '\0';
            this.nameFeild.PrefixSuffixText = null;
            this.nameFeild.ReadOnly = true;
            this.nameFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nameFeild.SelectedText = "";
            this.nameFeild.SelectionLength = 0;
            this.nameFeild.SelectionStart = 0;
            this.nameFeild.ShortcutsEnabled = true;
            this.nameFeild.Size = new System.Drawing.Size(322, 48);
            this.nameFeild.TabIndex = 3;
            this.nameFeild.TabStop = false;
            this.nameFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameFeild.TrailingIcon = null;
            this.nameFeild.UseAccent = false;
            this.nameFeild.UseSystemPasswordChar = false;
            this.nameFeild.Click += new System.EventHandler(this.nameFeild_Click);
            // 
            // idFeild
            // 
            this.idFeild.AnimateReadOnly = false;
            this.idFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.idFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idFeild.Depth = 0;
            this.idFeild.Enabled = false;
            this.idFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.idFeild.HideSelection = true;
            this.idFeild.Hint = "ID";
            this.idFeild.LeadingIcon = null;
            this.idFeild.Location = new System.Drawing.Point(21, 82);
            this.idFeild.MaxLength = 32767;
            this.idFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.idFeild.Name = "idFeild";
            this.idFeild.PasswordChar = '\0';
            this.idFeild.PrefixSuffixText = null;
            this.idFeild.ReadOnly = true;
            this.idFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idFeild.SelectedText = "";
            this.idFeild.SelectionLength = 0;
            this.idFeild.SelectionStart = 0;
            this.idFeild.ShortcutsEnabled = true;
            this.idFeild.Size = new System.Drawing.Size(322, 48);
            this.idFeild.TabIndex = 2;
            this.idFeild.TabStop = false;
            this.idFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.idFeild.TrailingIcon = null;
            this.idFeild.UseAccent = false;
            this.idFeild.UseSystemPasswordChar = false;
            this.idFeild.Click += new System.EventHandler(this.idFeild_Click);
            // 
            // imgLabel
            // 
            this.imgLabel.Depth = 0;
            this.imgLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.imgLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.imgLabel.Location = new System.Drawing.Point(5, 14);
            this.imgLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(432, 77);
            this.imgLabel.TabIndex = 9;
            this.imgLabel.Text = "Asset name";
            this.imgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imgLabel.Click += new System.EventHandler(this.imgLabel_Click);
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pictureBox1);
            this.materialCard2.Controls.Add(this.imgLabel);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(1, 24);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(443, 489);
            this.materialCard2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::AssetManagementSystem.Properties.Resources._9776924;
            this.pictureBox1.InitialImage = global::AssetManagementSystem.Properties.Resources.nrtGQr;
            this.pictureBox1.Location = new System.Drawing.Point(0, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(443, 323);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // imageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 516);
            this.Controls.Add(this.materialCard2);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "imageForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "imageForm";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton deleteBtn;
        private MaterialSkin.Controls.MaterialButton addBtn;
        private MaterialSkin.Controls.MaterialTextBox2 locationFeild;
        private MaterialSkin.Controls.MaterialTextBox2 nameFeild;
        private MaterialSkin.Controls.MaterialTextBox2 idFeild;
        private MaterialSkin.Controls.MaterialLabel imgLabel;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
    }
}