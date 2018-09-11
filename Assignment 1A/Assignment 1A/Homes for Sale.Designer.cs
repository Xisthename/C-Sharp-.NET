namespace Assignment_1A
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
            this.columnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLegalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.idNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.buildningHeaderBox = new System.Windows.Forms.GroupBox();
            this.idBox = new System.Windows.Forms.GroupBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.GroupBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).BeginInit();
            this.buildningHeaderBox.SuspendLayout();
            this.idBox.SuspendLayout();
            this.AddressBox.SuspendLayout();
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
            this.columnAddress,
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
            this.table.Size = new System.Drawing.Size(911, 716);
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
            // columnAddress
            // 
            this.columnAddress.FillWeight = 35F;
            this.columnAddress.Frozen = true;
            this.columnAddress.HeaderText = "Address";
            this.columnAddress.MaxInputLength = 200;
            this.columnAddress.Name = "columnAddress";
            this.columnAddress.ReadOnly = true;
            this.columnAddress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnAddress.Width = 200;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.FillWeight = 35F;
            this.ColumnCategory.Frozen = true;
            this.ColumnCategory.HeaderText = "Building Category";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCategory.Width = 130;
            // 
            // ColumnType
            // 
            this.ColumnType.FillWeight = 35F;
            this.ColumnType.Frozen = true;
            this.ColumnType.HeaderText = "Building Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnType.Width = 130;
            // 
            // ColumnLegalType
            // 
            this.ColumnLegalType.FillWeight = 35F;
            this.ColumnLegalType.Frozen = true;
            this.ColumnLegalType.HeaderText = "Legal Form";
            this.ColumnLegalType.Name = "ColumnLegalType";
            this.ColumnLegalType.ReadOnly = true;
            this.ColumnLegalType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnLegalType.Width = 130;
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
            this.removeButton.Location = new System.Drawing.Point(1077, 694);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(116, 36);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(944, 695);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 35);
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
            this.buildningHeaderBox.Controls.Add(this.AddressBox);
            this.buildningHeaderBox.Controls.Add(this.idBox);
            this.buildningHeaderBox.Location = new System.Drawing.Point(929, 14);
            this.buildningHeaderBox.Name = "buildningHeaderBox";
            this.buildningHeaderBox.Size = new System.Drawing.Size(295, 346);
            this.buildningHeaderBox.TabIndex = 24;
            this.buildningHeaderBox.TabStop = false;
            this.buildningHeaderBox.Text = "Add Buildning";
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
            this.AddressBox.Size = new System.Drawing.Size(283, 227);
            this.AddressBox.TabIndex = 23;
            this.AddressBox.TabStop = false;
            this.AddressBox.Text = "Address";
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
            // countriesComboBox
            // 
            this.countriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(73, 29);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(204, 24);
            this.countriesComboBox.TabIndex = 22;
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
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(73, 67);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(204, 22);
            this.cityTextBox.TabIndex = 24;
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(73, 95);
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(204, 22);
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
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(73, 123);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(204, 22);
            this.zipCodeTextBox.TabIndex = 28;
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
            // HomesForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1389, 945);
            this.Controls.Add(this.buildningHeaderBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomesForSale";
            this.Text = "Homes for Sale";
            this.Load += new System.EventHandler(this.HomesForSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNumericUpDown)).EndInit();
            this.buildningHeaderBox.ResumeLayout(false);
            this.idBox.ResumeLayout(false);
            this.idBox.PerformLayout();
            this.AddressBox.ResumeLayout(false);
            this.AddressBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLegalType;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImage;
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
    }
}

