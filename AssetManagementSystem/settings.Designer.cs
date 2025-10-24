namespace AssetManagementSystem
{
    partial class settings
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
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bryFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.cityFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.logoFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.pictureBox1);
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.logoFeild);
            this.materialCard1.Controls.Add(this.cityFeild);
            this.materialCard1.Controls.Add(this.bryFeild);
            this.materialCard1.Controls.Add(this.materialSwitch1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(396, 39);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(497, 602);
            this.materialCard1.TabIndex = 1;
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSwitch1.Location = new System.Drawing.Point(319, 32);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(135, 37);
            this.materialSwitch1.TabIndex = 1;
            this.materialSwitch1.Text = "Dark mode";
            this.materialSwitch1.UseVisualStyleBackColor = true;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(46, 28);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(125, 41);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Settings";
            // 
            // bryFeild
            // 
            this.bryFeild.AnimateReadOnly = false;
            this.bryFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bryFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bryFeild.Depth = 0;
            this.bryFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bryFeild.HideSelection = true;
            this.bryFeild.Hint = "Brgy name";
            this.bryFeild.LeadingIcon = null;
            this.bryFeild.Location = new System.Drawing.Point(43, 269);
            this.bryFeild.MaxLength = 32767;
            this.bryFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.bryFeild.Name = "bryFeild";
            this.bryFeild.PasswordChar = '\0';
            this.bryFeild.PrefixSuffixText = null;
            this.bryFeild.ReadOnly = false;
            this.bryFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bryFeild.SelectedText = "";
            this.bryFeild.SelectionLength = 0;
            this.bryFeild.SelectionStart = 0;
            this.bryFeild.ShortcutsEnabled = true;
            this.bryFeild.Size = new System.Drawing.Size(411, 48);
            this.bryFeild.TabIndex = 2;
            this.bryFeild.TabStop = false;
            this.bryFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bryFeild.TrailingIcon = null;
            this.bryFeild.UseAccent = false;
            this.bryFeild.UseSystemPasswordChar = false;
            // 
            // cityFeild
            // 
            this.cityFeild.AnimateReadOnly = false;
            this.cityFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cityFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cityFeild.Depth = 0;
            this.cityFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cityFeild.HideSelection = true;
            this.cityFeild.Hint = "City";
            this.cityFeild.LeadingIcon = null;
            this.cityFeild.Location = new System.Drawing.Point(43, 344);
            this.cityFeild.MaxLength = 32767;
            this.cityFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.cityFeild.Name = "cityFeild";
            this.cityFeild.PasswordChar = '\0';
            this.cityFeild.PrefixSuffixText = null;
            this.cityFeild.ReadOnly = false;
            this.cityFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cityFeild.SelectedText = "";
            this.cityFeild.SelectionLength = 0;
            this.cityFeild.SelectionStart = 0;
            this.cityFeild.ShortcutsEnabled = true;
            this.cityFeild.Size = new System.Drawing.Size(411, 48);
            this.cityFeild.TabIndex = 3;
            this.cityFeild.TabStop = false;
            this.cityFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.cityFeild.TrailingIcon = null;
            this.cityFeild.UseAccent = false;
            this.cityFeild.UseSystemPasswordChar = false;
            // 
            // logoFeild
            // 
            this.logoFeild.AnimateReadOnly = false;
            this.logoFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logoFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.logoFeild.Depth = 0;
            this.logoFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.logoFeild.HideSelection = true;
            this.logoFeild.Hint = "Logo filepath";
            this.logoFeild.LeadingIcon = null;
            this.logoFeild.Location = new System.Drawing.Point(43, 419);
            this.logoFeild.MaxLength = 32767;
            this.logoFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.logoFeild.Name = "logoFeild";
            this.logoFeild.PasswordChar = '\0';
            this.logoFeild.PrefixSuffixText = null;
            this.logoFeild.ReadOnly = false;
            this.logoFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.logoFeild.SelectedText = "";
            this.logoFeild.SelectionLength = 0;
            this.logoFeild.SelectionStart = 0;
            this.logoFeild.ShortcutsEnabled = true;
            this.logoFeild.Size = new System.Drawing.Size(411, 48);
            this.logoFeild.TabIndex = 4;
            this.logoFeild.TabStop = false;
            this.logoFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoFeild.TrailingIcon = null;
            this.logoFeild.UseAccent = false;
            this.logoFeild.UseSystemPasswordChar = false;
            this.logoFeild.Click += new System.EventHandler(this.logoFeild_Click);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(43, 501);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(185, 61);
            this.materialButton1.TabIndex = 5;
            this.materialButton1.Text = "Cancel";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(269, 501);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(185, 61);
            this.materialButton2.TabIndex = 6;
            this.materialButton2.Text = "Save";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(43, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(411, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 681);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "settings";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "settings";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 logoFeild;
        private MaterialSkin.Controls.MaterialTextBox2 cityFeild;
        private MaterialSkin.Controls.MaterialTextBox2 bryFeild;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}