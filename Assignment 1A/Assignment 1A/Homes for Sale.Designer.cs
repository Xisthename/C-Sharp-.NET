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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomesForSale));
            this.table = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLegalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildningHeaderBox = new System.Windows.Forms.GroupBox();
            this.imageLabel = new System.Windows.Forms.Label();
            this.clearImageButton = new System.Windows.Forms.Button();
            this.displayImage = new System.Windows.Forms.PictureBox();
            this.imagebutton = new System.Windows.Forms.Button();
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
            this.idBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.buildningHeaderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).BeginInit();
            this.legalBox.SuspendLayout();
            this.typeBox.SuspendLayout();
            this.categoryBox.SuspendLayout();
            this.AddressBox.SuspendLayout();
            this.idBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToResizeColumns = false;
            this.table.AllowUserToResizeRows = false;
            this.table.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.columnCountry,
            this.ColumnCity,
            this.ColumnStreet,
            this.ColumnZipCode,
            this.ColumnCategory,
            this.ColumnType,
            this.ColumnLegalType,
            this.ColumnImage});
            this.table.Location = new System.Drawing.Point(12, 14);
            this.table.MultiSelect = false;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowHeadersVisible = false;
            this.table.RowHeadersWidth = 20;
            this.table.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.table.RowTemplate.Height = 64;
            this.table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table.Size = new System.Drawing.Size(1349, 665);
            this.table.TabIndex = 17;
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 35F;
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MaxInputLength = 10;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnID.Width = 30;
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
            this.columnCountry.Width = 200;
            // 
            // ColumnCity
            // 
            this.ColumnCity.Frozen = true;
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            this.ColumnCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCity.Width = 200;
            // 
            // ColumnStreet
            // 
            this.ColumnStreet.Frozen = true;
            this.ColumnStreet.HeaderText = "Street";
            this.ColumnStreet.Name = "ColumnStreet";
            this.ColumnStreet.ReadOnly = true;
            this.ColumnStreet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnStreet.Width = 200;
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
            // ColumnImage
            // 
            this.ColumnImage.FillWeight = 64F;
            this.ColumnImage.Frozen = true;
            this.ColumnImage.HeaderText = "Image";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.ReadOnly = true;
            this.ColumnImage.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnImage.Width = 64;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(1367, 634);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(363, 45);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove Selected Building";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1367, 583);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(175, 45);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add Building";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // idNumericUpDown
            // 
            this.idNumericUpDown.Location = new System.Drawing.Point(37, 30);
            this.idNumericUpDown.Name = "idNumericUpDown";
            this.idNumericUpDown.Size = new System.Drawing.Size(72, 22);
            this.idNumericUpDown.TabIndex = 20;
            // 
            // buildningHeaderBox
            // 
            this.buildningHeaderBox.Controls.Add(this.imageLabel);
            this.buildningHeaderBox.Controls.Add(this.clearImageButton);
            this.buildningHeaderBox.Controls.Add(this.displayImage);
            this.buildningHeaderBox.Controls.Add(this.imagebutton);
            this.buildningHeaderBox.Controls.Add(this.legalBox);
            this.buildningHeaderBox.Controls.Add(this.typeBox);
            this.buildningHeaderBox.Controls.Add(this.categoryBox);
            this.buildningHeaderBox.Controls.Add(this.AddressBox);
            this.buildningHeaderBox.Controls.Add(this.idBox);
            this.buildningHeaderBox.Location = new System.Drawing.Point(1367, 14);
            this.buildningHeaderBox.Name = "buildningHeaderBox";
            this.buildningHeaderBox.Size = new System.Drawing.Size(363, 560);
            this.buildningHeaderBox.TabIndex = 24;
            this.buildningHeaderBox.TabStop = false;
            this.buildningHeaderBox.Text = "Buildning Information";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLabel.Location = new System.Drawing.Point(260, 492);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(80, 20);
            this.imageLabel.TabIndex = 35;
            this.imageLabel.Text = "No Image\r\n";
            // 
            // clearImageButton
            // 
            this.clearImageButton.Location = new System.Drawing.Point(6, 517);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(243, 35);
            this.clearImageButton.TabIndex = 34;
            this.clearImageButton.Text = "Clear selected Image";
            this.clearImageButton.UseVisualStyleBackColor = true;
            this.clearImageButton.Click += new System.EventHandler(this.clearImageButton_Click);
            // 
            // displayImage
            // 
            this.displayImage.Location = new System.Drawing.Point(264, 467);
            this.displayImage.Name = "displayImage";
            this.displayImage.Size = new System.Drawing.Size(85, 85);
            this.displayImage.TabIndex = 25;
            this.displayImage.TabStop = false;
            // 
            // imagebutton
            // 
            this.imagebutton.Location = new System.Drawing.Point(6, 467);
            this.imagebutton.Name = "imagebutton";
            this.imagebutton.Size = new System.Drawing.Size(243, 45);
            this.imagebutton.TabIndex = 32;
            this.imagebutton.Text = "Select an Image";
            this.imagebutton.UseVisualStyleBackColor = true;
            this.imagebutton.Click += new System.EventHandler(this.imagebutton_Click);
            // 
            // legalBox
            // 
            this.legalBox.Controls.Add(this.legalComboBox);
            this.legalBox.Controls.Add(this.legalLabel);
            this.legalBox.Location = new System.Drawing.Point(6, 398);
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
            this.typeBox.Location = new System.Drawing.Point(6, 329);
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
            this.categoryBox.Location = new System.Drawing.Point(6, 260);
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
            this.AddressBox.Location = new System.Drawing.Point(6, 98);
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
            // idBox
            // 
            this.idBox.Controls.Add(this.idNumericUpDown);
            this.idBox.Controls.Add(this.idLabel);
            this.idBox.Location = new System.Drawing.Point(6, 30);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(123, 62);
            this.idBox.TabIndex = 22;
            this.idBox.TabStop = false;
            this.idBox.Text = "ID";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(6, 32);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(25, 17);
            this.idLabel.TabIndex = 21;
            this.idLabel.Text = "ID:";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(1550, 583);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(180, 45);
            this.editButton.TabIndex = 33;
            this.editButton.Text = "Edit Selected Building";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // HomesForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1778, 945);
            this.Controls.Add(this.buildningHeaderBox);
            this.Controls.Add(this.table);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomesForSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homes for Sale";
            this.Load += new System.EventHandler(this.HomesForSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.buildningHeaderBox.ResumeLayout(false);
            this.buildningHeaderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayImage)).EndInit();
            this.legalBox.ResumeLayout(false);
            this.legalBox.PerformLayout();
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.categoryBox.ResumeLayout(false);
            this.categoryBox.PerformLayout();
            this.AddressBox.ResumeLayout(false);
            this.AddressBox.PerformLayout();
            this.idBox.ResumeLayout(false);
            this.idBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.NumericUpDown idNumericUpDown;
        private System.Windows.Forms.GroupBox buildningHeaderBox;
        private System.Windows.Forms.GroupBox AddressBox;
        private System.Windows.Forms.ComboBox countriesComboBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.GroupBox idBox;
        private System.Windows.Forms.Label idLabel;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLegalType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
        private System.Windows.Forms.Button imagebutton;
        private System.Windows.Forms.PictureBox displayImage;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.Label imageLabel;
    }
}

