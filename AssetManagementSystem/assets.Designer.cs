namespace AssetManagementSystem
{
    partial class assets
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
            this.assetListView = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.searchFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton4 = new MaterialSkin.Controls.MaterialButton();
            this.conditionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.statusComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.categoryComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.clearBtn = new MaterialSkin.Controls.MaterialButton();
            this.deleteBtn = new MaterialSkin.Controls.MaterialButton();
            this.editBtn = new MaterialSkin.Controls.MaterialButton();
            this.addBtn = new MaterialSkin.Controls.MaterialButton();
            this.locationFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.nameFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.idFeild = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // assetListView
            // 
            this.assetListView.AutoSizeTable = false;
            this.assetListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.assetListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.assetListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.assetListView.Depth = 0;
            this.assetListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetListView.FullRowSelect = true;
            this.assetListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.assetListView.HideSelection = false;
            this.assetListView.Location = new System.Drawing.Point(37, 0);
            this.assetListView.Margin = new System.Windows.Forms.Padding(0);
            this.assetListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.assetListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.assetListView.MouseState = MaterialSkin.MouseState.OUT;
            this.assetListView.Name = "assetListView";
            this.assetListView.OwnerDraw = true;
            this.assetListView.Size = new System.Drawing.Size(830, 683);
            this.assetListView.TabIndex = 2;
            this.assetListView.UseCompatibleStateImageBehavior = false;
            this.assetListView.View = System.Windows.Forms.View.Details;
            this.assetListView.SelectedIndexChanged += new System.EventHandler(this.assetListView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Location";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Category";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Condition";
            this.columnHeader6.Width = 140;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.searchFeild);
            this.materialCard1.Controls.Add(this.materialButton4);
            this.materialCard1.Controls.Add(this.conditionComboBox);
            this.materialCard1.Controls.Add(this.materialButton3);
            this.materialCard1.Controls.Add(this.statusComboBox);
            this.materialCard1.Controls.Add(this.materialButton2);
            this.materialCard1.Controls.Add(this.categoryComboBox);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.clearBtn);
            this.materialCard1.Controls.Add(this.deleteBtn);
            this.materialCard1.Controls.Add(this.editBtn);
            this.materialCard1.Controls.Add(this.addBtn);
            this.materialCard1.Controls.Add(this.locationFeild);
            this.materialCard1.Controls.Add(this.nameFeild);
            this.materialCard1.Controls.Add(this.idFeild);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(881, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(380, 687);
            this.materialCard1.TabIndex = 3;
            // 
            // searchFeild
            // 
            this.searchFeild.AnimateReadOnly = false;
            this.searchFeild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchFeild.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchFeild.Depth = 0;
            this.searchFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.searchFeild.HideSelection = true;
            this.searchFeild.Hint = "Search";
            this.searchFeild.LeadingIcon = global::AssetManagementSystem.Properties.Resources.search;
            this.searchFeild.Location = new System.Drawing.Point(27, 17);
            this.searchFeild.MaxLength = 32767;
            this.searchFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.searchFeild.Name = "searchFeild";
            this.searchFeild.PasswordChar = '\0';
            this.searchFeild.PrefixSuffixText = null;
            this.searchFeild.ReadOnly = false;
            this.searchFeild.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.searchFeild.SelectedText = "";
            this.searchFeild.SelectionLength = 0;
            this.searchFeild.SelectionStart = 0;
            this.searchFeild.ShortcutsEnabled = true;
            this.searchFeild.Size = new System.Drawing.Size(324, 48);
            this.searchFeild.TabIndex = 18;
            this.searchFeild.TabStop = false;
            this.searchFeild.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchFeild.TrailingIcon = null;
            this.searchFeild.UseSystemPasswordChar = false;
            this.searchFeild.TextChanged += new System.EventHandler(this.materialTextBox21_TextChanged);
            // 
            // materialButton4
            // 
            this.materialButton4.AutoSize = false;
            this.materialButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton4.Depth = 0;
            this.materialButton4.HighEmphasis = false;
            this.materialButton4.Icon = null;
            this.materialButton4.Location = new System.Drawing.Point(29, 464);
            this.materialButton4.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton4.Name = "materialButton4";
            this.materialButton4.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton4.Size = new System.Drawing.Size(321, 49);
            this.materialButton4.TabIndex = 17;
            this.materialButton4.Text = "View Image";
            this.materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton4.UseAccentColor = false;
            this.materialButton4.UseVisualStyleBackColor = true;
            this.materialButton4.Click += new System.EventHandler(this.materialButton4_Click);
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.AutoResize = false;
            this.conditionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.conditionComboBox.Depth = 0;
            this.conditionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.conditionComboBox.DropDownHeight = 174;
            this.conditionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionComboBox.DropDownWidth = 121;
            this.conditionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.conditionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Hint = "Condition";
            this.conditionComboBox.IntegralHeight = false;
            this.conditionComboBox.ItemHeight = 43;
            this.conditionComboBox.Location = new System.Drawing.Point(27, 406);
            this.conditionComboBox.MaxDropDownItems = 4;
            this.conditionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(273, 49);
            this.conditionComboBox.StartIndex = 0;
            this.conditionComboBox.TabIndex = 16;
            this.conditionComboBox.UseAccent = false;
            this.conditionComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox3_SelectedIndexChanged);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = false;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(303, 406);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(47, 49);
            this.materialButton3.TabIndex = 15;
            this.materialButton3.Text = "add";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // statusComboBox
            // 
            this.statusComboBox.AutoResize = false;
            this.statusComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.statusComboBox.Depth = 0;
            this.statusComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.statusComboBox.DropDownHeight = 174;
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.DropDownWidth = 121;
            this.statusComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.statusComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Hint = "Status";
            this.statusComboBox.IntegralHeight = false;
            this.statusComboBox.ItemHeight = 43;
            this.statusComboBox.Location = new System.Drawing.Point(28, 345);
            this.statusComboBox.MaxDropDownItems = 4;
            this.statusComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(272, 49);
            this.statusComboBox.StartIndex = 0;
            this.statusComboBox.TabIndex = 14;
            this.statusComboBox.UseAccent = false;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = false;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(303, 345);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(47, 49);
            this.materialButton2.TabIndex = 13;
            this.materialButton2.Text = "add";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.AutoResize = false;
            this.categoryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryComboBox.Depth = 0;
            this.categoryComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.categoryComboBox.DropDownHeight = 174;
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.DropDownWidth = 121;
            this.categoryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.categoryComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Hint = "Category";
            this.categoryComboBox.IntegralHeight = false;
            this.categoryComboBox.ItemHeight = 43;
            this.categoryComboBox.Location = new System.Drawing.Point(28, 283);
            this.categoryComboBox.MaxDropDownItems = 4;
            this.categoryComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(272, 49);
            this.categoryComboBox.StartIndex = 0;
            this.categoryComboBox.TabIndex = 12;
            this.categoryComboBox.UseAccent = false;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox1_SelectedIndexChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton1.HighEmphasis = false;
            this.materialButton1.Icon = null;
            this.materialButton1.ImageKey = "(none)";
            this.materialButton1.Location = new System.Drawing.Point(303, 284);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(47, 49);
            this.materialButton1.TabIndex = 11;
            this.materialButton1.Text = "add";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = false;
            this.clearBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.clearBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.clearBtn.Depth = 0;
            this.clearBtn.HighEmphasis = false;
            this.clearBtn.Icon = null;
            this.clearBtn.Location = new System.Drawing.Point(200, 600);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.clearBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.clearBtn.Size = new System.Drawing.Size(151, 48);
            this.clearBtn.TabIndex = 10;
            this.clearBtn.Text = "Clear feilds";
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
            this.deleteBtn.Location = new System.Drawing.Point(29, 600);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteBtn.Size = new System.Drawing.Size(151, 48);
            this.deleteBtn.TabIndex = 9;
            this.deleteBtn.Text = "Delete asset";
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
            this.editBtn.Location = new System.Drawing.Point(200, 539);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.editBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.editBtn.Name = "editBtn";
            this.editBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.editBtn.Size = new System.Drawing.Size(151, 49);
            this.editBtn.TabIndex = 8;
            this.editBtn.Text = "Update asset";
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
            this.addBtn.Location = new System.Drawing.Point(28, 539);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addBtn.Name = "addBtn";
            this.addBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addBtn.Size = new System.Drawing.Size(151, 49);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add Asset";
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
            this.locationFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.locationFeild.HideSelection = true;
            this.locationFeild.Hint = "Located at";
            this.locationFeild.LeadingIcon = null;
            this.locationFeild.Location = new System.Drawing.Point(29, 212);
            this.locationFeild.MaxLength = 32767;
            this.locationFeild.MouseState = MaterialSkin.MouseState.OUT;
            this.locationFeild.Name = "locationFeild";
            this.locationFeild.PasswordChar = '\0';
            this.locationFeild.PrefixSuffixText = null;
            this.locationFeild.ReadOnly = false;
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
            this.nameFeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFeild.HideSelection = true;
            this.nameFeild.Hint = "Asset name";
            this.nameFeild.LeadingIcon = null;
            this.nameFeild.Location = new System.Drawing.Point(29, 147);
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
            this.idFeild.Location = new System.Drawing.Point(29, 82);
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
            // assets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 681);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.assetListView);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Name = "assets";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Text = "assets";
            this.materialCard1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListView assetListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton clearBtn;
        private MaterialSkin.Controls.MaterialButton deleteBtn;
        private MaterialSkin.Controls.MaterialButton editBtn;
        private MaterialSkin.Controls.MaterialButton addBtn;
        private MaterialSkin.Controls.MaterialTextBox2 locationFeild;
        private MaterialSkin.Controls.MaterialTextBox2 nameFeild;
        private MaterialSkin.Controls.MaterialTextBox2 idFeild;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialComboBox conditionComboBox;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialComboBox statusComboBox;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialComboBox categoryComboBox;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialTextBox2 searchFeild;
    }
}