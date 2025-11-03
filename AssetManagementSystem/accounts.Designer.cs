namespace AssetManagementSystem
{
    partial class accounts
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
            this.clearBtn = new MaterialSkin.Controls.MaterialButton();
            this.deleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.editBtn = new MaterialSkin.Controls.MaterialButton();
            this.addBtn = new MaterialSkin.Controls.MaterialButton();
            this.roleFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.passwordFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.usernameFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.nameFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.idFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.clearBtn);
            this.materialCard1.Controls.Add(this.deleteBtn);
            this.materialCard1.Controls.Add(this.editBtn);
            this.materialCard1.Controls.Add(this.addBtn);
            this.materialCard1.Controls.Add(this.roleFeild);
            this.materialCard1.Controls.Add(this.passwordFeild);
            this.materialCard1.Controls.Add(this.usernameFeild);
            this.materialCard1.Controls.Add(this.nameFeild);
            this.materialCard1.Controls.Add(this.idFeild);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(829, -3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(414, 687);
            this.materialCard1.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = false;
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearBtn.Depth = 0;
            this.clearBtn.HighEmphasis = false;
            this.clearBtn.Icon = null;
            this.clearBtn.Location = new System.Drawing.Point(214, 579);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearBtn.Size = new System.Drawing.Size(182, 60);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear fields";
            this.clearBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.clearBtn.UseAccentColor = false;
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AutoSize = false;
            this.deleteBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteBtn.Depth = 0;
            this.deleteBtn.HighEmphasis = false;
            this.deleteBtn.Icon = null;
            this.deleteBtn.Location = new System.Drawing.Point(18, 579);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteBtn.Size = new System.Drawing.Size(182, 60);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete account";
            this.deleteBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.deleteBtn.UseAccentColor = false;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.AutoSize = false;
            this.editBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.editBtn.Depth = 0;
            this.editBtn.HighEmphasis = false;
            this.editBtn.Icon = null;
            this.editBtn.Location = new System.Drawing.Point(214, 492);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editBtn.Name = "editBtn";
            this.editBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editBtn.Size = new System.Drawing.Size(182, 60);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Edit account";
            this.editBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.editBtn.UseAccentColor = false;
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.AutoSize = false;
            this.addBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addBtn.Depth = 0;
            this.addBtn.HighEmphasis = false;
            this.addBtn.Icon = null;
            this.addBtn.Location = new System.Drawing.Point(18, 492);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addBtn.Size = new System.Drawing.Size(182, 60);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add account";
            this.addBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addBtn.UseAccentColor = false;
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // roleFeild
            // 
            this.roleFeild.AnimateReadOnly = false;
            this.roleFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.roleFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.roleFeild.Depth = 0;
            this.roleFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.roleFeild.HideSelection = true;
            this.roleFeild.Hint = "Role";
            this.roleFeild.LeadingIcon = null;
            this.roleFeild.Location = new System.Drawing.Point(46, 396);
            this.roleFeild.MaxLength = 32767;
            this.roleFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.roleFeild.Name = "roleFeild";
            this.roleFeild.PasswordChar = '\0';
            this.roleFeild.PrefixSuffixText = null;
            this.roleFeild.ReadOnly = false;
            this.roleFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.roleFeild.SelectedText = "";
            this.roleFeild.SelectionLength = 0;
            this.roleFeild.SelectionStart = 0;
            this.roleFeild.ShortcutsEnabled = true;
            this.roleFeild.Size = new System.Drawing.Size(322, 48);
            this.roleFeild.TabIndex = 6;
            this.roleFeild.TabStop = false;
            this.roleFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.roleFeild.TrailingIcon = null;
            this.roleFeild.UseAccent = false;
            this.roleFeild.UseSystemPasswordChar = false;
            // 
            // passwordFeild
            // 
            this.passwordFeild.AnimateReadOnly = false;
            this.passwordFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.passwordFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.passwordFeild.Depth = 0;
            this.passwordFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.passwordFeild.HideSelection = true;
            this.passwordFeild.Hint = "Password";
            this.passwordFeild.LeadingIcon = null;
            this.passwordFeild.Location = new System.Drawing.Point(46, 316);
            this.passwordFeild.MaxLength = 32767;
            this.passwordFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordFeild.Name = "passwordFeild";
            this.passwordFeild.PasswordChar = '*';
            this.passwordFeild.PrefixSuffixText = null;
            this.passwordFeild.ReadOnly = false;
            this.passwordFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passwordFeild.SelectedText = "";
            this.passwordFeild.SelectionLength = 0;
            this.passwordFeild.SelectionStart = 0;
            this.passwordFeild.ShortcutsEnabled = true;
            this.passwordFeild.Size = new System.Drawing.Size(322, 48);
            this.passwordFeild.TabIndex = 5;
            this.passwordFeild.TabStop = false;
            this.passwordFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordFeild.TrailingIcon = null;
            this.passwordFeild.UseAccent = false;
            this.passwordFeild.UseSystemPasswordChar = false;
            // 
            // usernameFeild
            // 
            this.usernameFeild.AnimateReadOnly = false;
            this.usernameFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usernameFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.usernameFeild.Depth = 0;
            this.usernameFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.usernameFeild.HideSelection = true;
            this.usernameFeild.Hint = "Username";
            this.usernameFeild.LeadingIcon = null;
            this.usernameFeild.Location = new System.Drawing.Point(46, 236);
            this.usernameFeild.MaxLength = 32767;
            this.usernameFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameFeild.Name = "usernameFeild";
            this.usernameFeild.PasswordChar = '\0';
            this.usernameFeild.PrefixSuffixText = null;
            this.usernameFeild.ReadOnly = false;
            this.usernameFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.usernameFeild.SelectedText = "";
            this.usernameFeild.SelectionLength = 0;
            this.usernameFeild.SelectionStart = 0;
            this.usernameFeild.ShortcutsEnabled = true;
            this.usernameFeild.Size = new System.Drawing.Size(322, 48);
            this.usernameFeild.TabIndex = 4;
            this.usernameFeild.TabStop = false;
            this.usernameFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usernameFeild.TrailingIcon = null;
            this.usernameFeild.UseAccent = false;
            this.usernameFeild.UseSystemPasswordChar = false;
            // 
            // nameFeild
            // 
            this.nameFeild.AnimateReadOnly = false;
            this.nameFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nameFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.nameFeild.Depth = 0;
            this.nameFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFeild.HideSelection = true;
            this.nameFeild.Hint = "Fullname";
            this.nameFeild.LeadingIcon = null;
            this.nameFeild.Location = new System.Drawing.Point(46, 156);
            this.nameFeild.MaxLength = 32767;
            this.nameFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.nameFeild.Name = "nameFeild";
            this.nameFeild.PasswordChar = '\0';
            this.nameFeild.PrefixSuffixText = null;
            this.nameFeild.ReadOnly = false;
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
            // 
            // idFeild
            // 
            this.idFeild.AnimateReadOnly = false;
            this.idFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.idFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.idFeild.Depth = 0;
            this.idFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idFeild.HideSelection = true;
            this.idFeild.Hint = "ID";
            this.idFeild.LeadingIcon = null;
            this.idFeild.Location = new System.Drawing.Point(46, 76);
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
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.Location = new System.Drawing.Point(145, 4);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 29);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Asset Info";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.materialListView1.Depth = 0;
            this.materialListView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(94, 1);
            this.materialListView1.Margin = new System.Windows.Forms.Padding(0);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(700, 683);
            this.materialListView1.TabIndex = 1;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Username";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = " Password";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = " Role";
            this.columnHeader5.Width = 150;
            // 
            // accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 681);
            this.Controls.Add(this.materialListView1);
            this.Controls.Add(this.materialCard1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "accounts";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "accounts";
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 roleFeild;
        private MaterialSkin.Controls.MaterialTextBox2 passwordFeild;
        private MaterialSkin.Controls.MaterialTextBox2 usernameFeild;
        private MaterialSkin.Controls.MaterialTextBox2 nameFeild;
        private MaterialSkin.Controls.MaterialTextBox2 idFeild;
        private MaterialSkin.Controls.MaterialButton clearBtn;
        private MaterialSkin.Controls.MaterialButton deleteBtn;
        private MaterialSkin.Controls.MaterialButton editBtn;
        private MaterialSkin.Controls.MaterialButton addBtn;
    }
}