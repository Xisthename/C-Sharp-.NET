namespace Assignment_2
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startGameButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.dealerBox = new System.Windows.Forms.GroupBox();
            this.dealerHandLabel = new System.Windows.Forms.Label();
            this.decksNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.playerNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playersNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.endGameButton = new System.Windows.Forms.Button();
            this.playerBox = new System.Windows.Forms.GroupBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerHandLabel = new System.Windows.Forms.Label();
            this.scoreTable = new System.Windows.Forms.DataGridView();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.columnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dealerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decksNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersNumericUpDown)).BeginInit();
            this.playerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(6, 183);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(150, 40);
            this.startGameButton.TabIndex = 2;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(1230, 281);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(150, 40);
            this.shuffleButton.TabIndex = 3;
            this.shuffleButton.Text = "Shuffle Deck";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Location = new System.Drawing.Point(1230, 327);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(150, 40);
            this.hitButton.TabIndex = 4;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // standButton
            // 
            this.standButton.Location = new System.Drawing.Point(1230, 373);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(150, 40);
            this.standButton.TabIndex = 5;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // dealerBox
            // 
            this.dealerBox.BackColor = System.Drawing.SystemColors.Control;
            this.dealerBox.Controls.Add(this.dealerHandLabel);
            this.dealerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dealerBox.Location = new System.Drawing.Point(12, 12);
            this.dealerBox.Name = "dealerBox";
            this.dealerBox.Size = new System.Drawing.Size(600, 450);
            this.dealerBox.TabIndex = 6;
            this.dealerBox.TabStop = false;
            this.dealerBox.Text = "Dealer";
            this.dealerBox.Paint += new System.Windows.Forms.PaintEventHandler(this.dealerBox_Paint);
            // 
            // dealerHandLabel
            // 
            this.dealerHandLabel.AutoSize = true;
            this.dealerHandLabel.Location = new System.Drawing.Point(6, 23);
            this.dealerHandLabel.Name = "dealerHandLabel";
            this.dealerHandLabel.Size = new System.Drawing.Size(101, 20);
            this.dealerHandLabel.TabIndex = 1;
            this.dealerHandLabel.Text = "Hand Value:";
            // 
            // decksNumericUpDown
            // 
            this.decksNumericUpDown.Location = new System.Drawing.Point(6, 142);
            this.decksNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.decksNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.decksNumericUpDown.Name = "decksNumericUpDown";
            this.decksNumericUpDown.Size = new System.Drawing.Size(150, 22);
            this.decksNumericUpDown.TabIndex = 8;
            this.decksNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // playerNameLabel
            // 
            this.playerNameLabel.AutoSize = true;
            this.playerNameLabel.Location = new System.Drawing.Point(12, 34);
            this.playerNameLabel.Name = "playerNameLabel";
            this.playerNameLabel.Size = new System.Drawing.Size(123, 17);
            this.playerNameLabel.TabIndex = 9;
            this.playerNameLabel.Text = "How many players";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "How many Decks";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playersNumericUpDown);
            this.groupBox1.Controls.Add(this.playerNameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.decksNumericUpDown);
            this.groupBox1.Controls.Add(this.startGameButton);
            this.groupBox1.Location = new System.Drawing.Point(1224, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Game";
            // 
            // playersNumericUpDown
            // 
            this.playersNumericUpDown.Location = new System.Drawing.Point(6, 72);
            this.playersNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playersNumericUpDown.Name = "playersNumericUpDown";
            this.playersNumericUpDown.Size = new System.Drawing.Size(150, 22);
            this.playersNumericUpDown.TabIndex = 11;
            this.playersNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(1230, 422);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(150, 40);
            this.endGameButton.TabIndex = 8;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // playerBox
            // 
            this.playerBox.Controls.Add(this.playerLabel);
            this.playerBox.Controls.Add(this.playerHandLabel);
            this.playerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerBox.Location = new System.Drawing.Point(618, 12);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(600, 450);
            this.playerBox.TabIndex = 7;
            this.playerBox.TabStop = false;
            this.playerBox.Paint += new System.Windows.Forms.PaintEventHandler(this.playerBox_Paint);
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(6, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(0, 20);
            this.playerLabel.TabIndex = 1;
            // 
            // playerHandLabel
            // 
            this.playerHandLabel.AutoSize = true;
            this.playerHandLabel.Location = new System.Drawing.Point(6, 23);
            this.playerHandLabel.Name = "playerHandLabel";
            this.playerHandLabel.Size = new System.Drawing.Size(101, 20);
            this.playerHandLabel.TabIndex = 0;
            this.playerHandLabel.Text = "Hand Value:";
            // 
            // scoreTable
            // 
            this.scoreTable.AllowUserToAddRows = false;
            this.scoreTable.AllowUserToDeleteRows = false;
            this.scoreTable.AllowUserToResizeColumns = false;
            this.scoreTable.AllowUserToResizeRows = false;
            this.scoreTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.scoreTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.scoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCountry,
            this.ColumnID,
            this.ColumnCity});
            this.scoreTable.Location = new System.Drawing.Point(1409, 12);
            this.scoreTable.MultiSelect = false;
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.ReadOnly = true;
            this.scoreTable.RowHeadersVisible = false;
            this.scoreTable.RowHeadersWidth = 20;
            this.scoreTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.scoreTable.RowTemplate.Height = 64;
            this.scoreTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.scoreTable.Size = new System.Drawing.Size(348, 450);
            this.scoreTable.TabIndex = 18;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 500;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // columnCountry
            // 
            this.columnCountry.FillWeight = 75F;
            this.columnCountry.Frozen = true;
            this.columnCountry.HeaderText = "Name";
            this.columnCountry.MaxInputLength = 200;
            this.columnCountry.Name = "columnCountry";
            this.columnCountry.ReadOnly = true;
            this.columnCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnCountry.Width = 75;
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 45F;
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "Value";
            this.ColumnID.MaxInputLength = 10;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnID.Width = 45;
            // 
            // ColumnCity
            // 
            this.ColumnCity.FillWeight = 125F;
            this.ColumnCity.Frozen = true;
            this.ColumnCity.HeaderText = "State";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            this.ColumnCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCity.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1769, 481);
            this.Controls.Add(this.scoreTable);
            this.Controls.Add(this.endGameButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.dealerBox);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.shuffleButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BlackJack";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.dealerBox.ResumeLayout(false);
            this.dealerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decksNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersNumericUpDown)).EndInit();
            this.playerBox.ResumeLayout(false);
            this.playerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.GroupBox dealerBox;
        private System.Windows.Forms.NumericUpDown decksNumericUpDown;
        private System.Windows.Forms.Label playerNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown playersNumericUpDown;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.GroupBox playerBox;
        private System.Windows.Forms.DataGridView scoreTable;
        private System.Windows.Forms.Label playerHandLabel;
        private System.Windows.Forms.Label dealerHandLabel;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
    }
}

