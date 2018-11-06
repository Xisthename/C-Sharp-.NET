namespace Assignment_1
{
    partial class HomesForSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomesForSale));
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.buildningHeaderBox = new System.Windows.Forms.GroupBox();
            this.editButton = new System.Windows.Forms.Button();
            this.legalBox = new System.Windows.Forms.GroupBox();
            this.legalComboBox = new System.Windows.Forms.ComboBox();
            this.legalLabel = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.GroupBox();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.GroupBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.ResetSearchButton = new System.Windows.Forms.Button();
            this.searchTypeLabel = new System.Windows.Forms.Label();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchCityTextBox = new System.Windows.Forms.TextBox();
            this.searchCityLabel = new System.Windows.Forms.Label();
            this.databaseTable = new System.Windows.Forms.DataGridView();
            this.ColumnLegalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table = new System.Windows.Forms.DataGridView();
            this.buildningHeaderBox.SuspendLayout();
            this.legalBox.SuspendLayout();
            this.typeBox.SuspendLayout();
            this.categoryBox.SuspendLayout();
            this.AddressBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(6, 426);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(343, 38);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove Selected Building";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 390);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 30);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add Building";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // buildningHeaderBox
            // 
            this.buildningHeaderBox.Controls.Add(this.removeButton);
            this.buildningHeaderBox.Controls.Add(this.editButton);
            this.buildningHeaderBox.Controls.Add(this.addButton);
            this.buildningHeaderBox.Controls.Add(this.legalBox);
            this.buildningHeaderBox.Controls.Add(this.typeBox);
            this.buildningHeaderBox.Controls.Add(this.categoryBox);
            this.buildningHeaderBox.Controls.Add(this.AddressBox);
            this.buildningHeaderBox.Location = new System.Drawing.Point(1173, 31);
            this.buildningHeaderBox.Name = "buildningHeaderBox";
            this.buildningHeaderBox.Size = new System.Drawing.Size(360, 470);
            this.buildningHeaderBox.TabIndex = 24;
            this.buildningHeaderBox.TabStop = false;
            this.buildningHeaderBox.Text = "Add, Edit, Insert or Remove Buildings";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(168, 390);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(181, 30);
            this.editButton.TabIndex = 33;
            this.editButton.Text = "Edit Selected Building";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // legalBox
            // 
            this.legalBox.Controls.Add(this.legalComboBox);
            this.legalBox.Controls.Add(this.legalLabel);
            this.legalBox.Location = new System.Drawing.Point(6, 321);
            this.legalBox.Name = "legalBox";
            this.legalBox.Size = new System.Drawing.Size(347, 63);
            this.legalBox.TabIndex = 31;
            this.legalBox.TabStop = false;
            this.legalBox.Text = "Building Legal Form";
            // 
            // legalComboBox
            // 
            this.legalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.legalComboBox.FormattingEnabled = true;
            this.legalComboBox.Location = new System.Drawing.Point(93, 29);
            this.legalComboBox.Name = "legalComboBox";
            this.legalComboBox.Size = new System.Drawing.Size(250, 24);
            this.legalComboBox.TabIndex = 22;
            // 
            // legalLabel
            // 
            this.legalLabel.AutoSize = true;
            this.legalLabel.Location = new System.Drawing.Point(6, 32);
            this.legalLabel.Name = "legalLabel";
            this.legalLabel.Size = new System.Drawing.Size(83, 17);
            this.legalLabel.TabIndex = 21;
            this.legalLabel.Text = "Legal Form:";
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.typeComboBox);
            this.typeBox.Controls.Add(this.typeLabel);
            this.typeBox.Location = new System.Drawing.Point(6, 252);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(349, 63);
            this.typeBox.TabIndex = 30;
            this.typeBox.TabStop = false;
            this.typeBox.Text = "Building Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(93, 29);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(250, 24);
            this.typeComboBox.TabIndex = 22;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 32);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 21;
            this.typeLabel.Text = "Type:";
            // 
            // categoryBox
            // 
            this.categoryBox.Controls.Add(this.categoryComboBox);
            this.categoryBox.Controls.Add(this.categoryLabel);
            this.categoryBox.Location = new System.Drawing.Point(6, 183);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(349, 63);
            this.categoryBox.TabIndex = 29;
            this.categoryBox.TabStop = false;
            this.categoryBox.Text = "Building Category";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(93, 29);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(250, 24);
            this.categoryComboBox.TabIndex = 22;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(6, 32);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(69, 17);
            this.categoryLabel.TabIndex = 21;
            this.categoryLabel.Text = "Category:";
            // 
            // AddressBox
            // 
            this.AddressBox.Controls.Add(this.zipCodeTextBox);
            this.AddressBox.Controls.Add(this.zipCodeLabel);
            this.AddressBox.Controls.Add(this.streetTextBox);
            this.AddressBox.Controls.Add(this.streetLabel);
            this.AddressBox.Controls.Add(this.cityTextBox);
            this.AddressBox.Controls.Add(this.cityLabel);
            this.AddressBox.Controls.Add(this.countriesComboBox);
            this.AddressBox.Controls.Add(this.CountryLabel);
            this.AddressBox.Location = new System.Drawing.Point(6, 21);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(349, 156);
            this.AddressBox.TabIndex = 23;
            this.AddressBox.TabStop = false;
            this.AddressBox.Text = "Buildning Address";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(93, 119);
            this.zipCodeTextBox.MaxLength = 5;
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(250, 22);
            this.zipCodeTextBox.TabIndex = 28;
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipCodeTextBox_KeyPress);
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(6, 126);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(69, 17);
            this.zipCodeLabel.TabIndex = 27;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(93, 91);
            this.streetTextBox.MaxLength = 30;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(250, 22);
            this.streetTextBox.TabIndex = 26;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(6, 98);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(50, 17);
            this.streetLabel.TabIndex = 25;
            this.streetLabel.Text = "Street:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(93, 63);
            this.cityTextBox.MaxLength = 30;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(250, 22);
            this.cityTextBox.TabIndex = 24;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(6, 70);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 17);
            this.cityLabel.TabIndex = 23;
            this.cityLabel.Text = "City:";
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(93, 25);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(250, 24);
            this.countriesComboBox.TabIndex = 22;
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(6, 32);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(61, 17);
            this.CountryLabel.TabIndex = 21;
            this.CountryLabel.Text = "Country:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(168, 92);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(181, 30);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1547, 28);
            this.menuStrip.TabIndex = 26;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 24);
            this.menuFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMLToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.exportToXMLToolStripMenuItem.Text = "Export to XML File";
            this.exportToXMLToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.ResetSearchButton);
            this.SearchBox.Controls.Add(this.searchTypeLabel);
            this.SearchBox.Controls.Add(this.searchTypeComboBox);
            this.SearchBox.Controls.Add(this.searchCityTextBox);
            this.SearchBox.Controls.Add(this.searchButton);
            this.SearchBox.Controls.Add(this.searchCityLabel);
            this.SearchBox.Location = new System.Drawing.Point(1173, 507);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(360, 135);
            this.SearchBox.TabIndex = 29;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search after Buildings";
            // 
            // ResetSearchButton
            // 
            this.ResetSearchButton.Location = new System.Drawing.Point(6, 92);
            this.ResetSearchButton.Name = "ResetSearchButton";
            this.ResetSearchButton.Size = new System.Drawing.Size(147, 30);
            this.ResetSearchButton.TabIndex = 26;
            this.ResetSearchButton.Text = "Reset Search";
            this.ResetSearchButton.UseVisualStyleBackColor = true;
            this.ResetSearchButton.Click += new System.EventHandler(this.ResetSearchButton_Click);
            // 
            // searchTypeLabel
            // 
            this.searchTypeLabel.AutoSize = true;
            this.searchTypeLabel.Location = new System.Drawing.Point(12, 65);
            this.searchTypeLabel.Name = "searchTypeLabel";
            this.searchTypeLabel.Size = new System.Drawing.Size(44, 17);
            this.searchTypeLabel.TabIndex = 23;
            this.searchTypeLabel.Text = "Type:";
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Location = new System.Drawing.Point(96, 62);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(253, 24);
            this.searchTypeComboBox.TabIndex = 23;
            // 
            // searchCityTextBox
            // 
            this.searchCityTextBox.Location = new System.Drawing.Point(96, 32);
            this.searchCityTextBox.MaxLength = 30;
            this.searchCityTextBox.Name = "searchCityTextBox";
            this.searchCityTextBox.Size = new System.Drawing.Size(253, 22);
            this.searchCityTextBox.TabIndex = 24;
            // 
            // searchCityLabel
            // 
            this.searchCityLabel.AutoSize = true;
            this.searchCityLabel.Location = new System.Drawing.Point(12, 32);
            this.searchCityLabel.Name = "searchCityLabel";
            this.searchCityLabel.Size = new System.Drawing.Size(35, 17);
            this.searchCityLabel.TabIndex = 23;
            this.searchCityLabel.Text = "City:";
            // 
            // databaseTable
            // 
            this.databaseTable.AllowUserToAddRows = false;
            this.databaseTable.AllowUserToDeleteRows = false;
            this.databaseTable.AllowUserToResizeColumns = false;
            this.databaseTable.AllowUserToResizeRows = false;
            this.databaseTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.databaseTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.databaseTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.databaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseTable.Location = new System.Drawing.Point(12, 298);
            this.databaseTable.MultiSelect = false;
            this.databaseTable.Name = "databaseTable";
            this.databaseTable.ReadOnly = true;
            this.databaseTable.RowHeadersVisible = false;
            this.databaseTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.databaseTable.RowTemplate.Height = 64;
            this.databaseTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.databaseTable.Size = new System.Drawing.Size(1155, 232);
            this.databaseTable.TabIndex = 30;
            // 
            // ColumnLegalType
            // 
            this.ColumnLegalType.FillWeight = 35F;
            this.ColumnLegalType.Frozen = true;
            this.ColumnLegalType.HeaderText = "Legal Form";
            this.ColumnLegalType.Name = "ColumnLegalType";
            this.ColumnLegalType.ReadOnly = true;
            this.ColumnLegalType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnLegalType.Width = 80;
            // 
            // ColumnType
            // 
            this.ColumnType.FillWeight = 35F;
            this.ColumnType.Frozen = true;
            this.ColumnType.HeaderText = "Building Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnType.Width = 80;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.FillWeight = 35F;
            this.ColumnCategory.Frozen = true;
            this.ColumnCategory.HeaderText = "Building Category";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCategory.Width = 95;
            // 
            // ColumnZipCode
            // 
            this.ColumnZipCode.Frozen = true;
            this.ColumnZipCode.HeaderText = "Zip Code";
            this.ColumnZipCode.Name = "ColumnZipCode";
            this.ColumnZipCode.ReadOnly = true;
            this.ColumnZipCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnZipCode.Width = 60;
            // 
            // ColumnStreet
            // 
            this.ColumnStreet.Frozen = true;
            this.ColumnStreet.HeaderText = "Street";
            this.ColumnStreet.Name = "ColumnStreet";
            this.ColumnStreet.ReadOnly = true;
            this.ColumnStreet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnStreet.Width = 175;
            // 
            // ColumnCity
            // 
            this.ColumnCity.Frozen = true;
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            this.ColumnCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCity.Width = 150;
            // 
            // columnCountry
            // 
            this.columnCountry.FillWeight = 35F;
            this.columnCountry.Frozen = true;
            this.columnCountry.HeaderText = "Country";
            this.columnCountry.MaxInputLength = 200;
            this.columnCountry.Name = "columnCountry";
            this.columnCountry.ReadOnly = true;
            this.columnCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnCountry.Width = 175;
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 35F;
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MaxInputLength = 100;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnID.Width = 30;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.columnCountry,
            this.ColumnCity,
            this.ColumnStreet,
            this.ColumnZipCode,
            this.ColumnCategory,
            this.ColumnType,
            this.ColumnLegalType});
            this.table.Location = new System.Drawing.Point(12, 31);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 20;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.table.RowTemplate.Height = 64;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(1155, 232);
            this.table.TabIndex = 17;
            // 
            // HomesForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1547, 733);
            this.Controls.Add(this.databaseTable);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.buildningHeaderBox);
            this.Controls.Add(this.table);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "HomesForSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homes for Sale";
            this.Load += new System.EventHandler(this.HomesForSale_Load);
            this.buildningHeaderBox.ResumeLayout(false);
            this.legalBox.ResumeLayout(false);
            this.legalBox.PerformLayout();
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.categoryBox.ResumeLayout(false);
            this.categoryBox.PerformLayout();
            this.AddressBox.ResumeLayout(false);
            this.AddressBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox buildningHeaderBox;
        private System.Windows.Forms.GroupBox AddressBox;
        private System.Windows.Forms.ComboBox countriesComboBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.GroupBox categoryBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.GroupBox legalBox;
        private System.Windows.Forms.ComboBox legalComboBox;
        private System.Windows.Forms.Label legalLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.TextBox searchCityTextBox;
        private System.Windows.Forms.Label searchCityLabel;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.Label searchTypeLabel;
        private System.Windows.Forms.Button ResetSearchButton;
        private System.Windows.Forms.DataGridView databaseTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLegalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridView table;
    }
}

