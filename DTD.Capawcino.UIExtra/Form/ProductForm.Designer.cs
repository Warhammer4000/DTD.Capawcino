namespace DTD.Capawcino.UIExtra.Form
{
    partial class ProductForm
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
            this.PicturePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TagBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GrandTotalNumeric = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Royalty = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.CostNumeric = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Percent = new System.Windows.Forms.RadioButton();
            this.Flat = new System.Windows.Forms.RadioButton();
            this.ProfitValue = new System.Windows.Forms.NumericUpDown();
            this.Profit = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DiscountAmount = new System.Windows.Forms.NumericUpDown();
            this.DiscountValue = new System.Windows.Forms.NumericUpDown();
            this.DiscountBox = new System.Windows.Forms.GroupBox();
            this.PercentDiscount = new System.Windows.Forms.RadioButton();
            this.FlatDiscountButton = new System.Windows.Forms.RadioButton();
            this.PicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrandTotalNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Royalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNumeric)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profit)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountValue)).BeginInit();
            this.DiscountBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicturePanel
            // 
            this.PicturePanel.Controls.Add(this.pictureBox);
            this.PicturePanel.Controls.Add(this.button1);
            this.PicturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PicturePanel.Location = new System.Drawing.Point(0, 0);
            this.PicturePanel.Name = "PicturePanel";
            this.PicturePanel.Padding = new System.Windows.Forms.Padding(10);
            this.PicturePanel.Size = new System.Drawing.Size(338, 262);
            this.PicturePanel.TabIndex = 14;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Gray;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(10, 50);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(318, 202);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.image;
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 40);
            this.button1.TabIndex = 14;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.NewImage_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.BackColor = System.Drawing.Color.LightBlue;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkOliveGreen;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SaveButton.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.save;
            this.SaveButton.Location = new System.Drawing.Point(0, 953);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(338, 48);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // TagBox
            // 
            this.TagBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagBox.Location = new System.Drawing.Point(0, 262);
            this.TagBox.Name = "TagBox";
            this.TagBox.Size = new System.Drawing.Size(338, 100);
            this.TagBox.TabIndex = 23;
            this.TagBox.TabStop = false;
            this.TagBox.Text = "Tags";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GrandTotalNumeric, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.Total, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.Royalty, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TypeComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CostNumeric, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ProfitValue, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Profit, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 362);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 591);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // GrandTotalNumeric
            // 
            this.GrandTotalNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrandTotalNumeric.Enabled = false;
            this.GrandTotalNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalNumeric.Location = new System.Drawing.Point(172, 488);
            this.GrandTotalNumeric.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.GrandTotalNumeric.Name = "GrandTotalNumeric";
            this.GrandTotalNumeric.ReadOnly = true;
            this.GrandTotalNumeric.Size = new System.Drawing.Size(155, 29);
            this.GrandTotalNumeric.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 35);
            this.label8.TabIndex = 19;
            this.label8.Text = "Grand Total";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 338);
            this.label7.Name = "label7";
            this.tableLayoutPanel1.SetRowSpan(this.label7, 4);
            this.label7.Size = new System.Drawing.Size(155, 147);
            this.label7.TabIndex = 14;
            this.label7.Text = "Discount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Total
            // 
            this.Total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Total.Enabled = false;
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(172, 306);
            this.Total.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(155, 29);
            this.Total.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Royalty
            // 
            this.Royalty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Royalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Royalty.Location = new System.Drawing.Point(172, 271);
            this.Royalty.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.Royalty.Name = "Royalty";
            this.Royalty.Size = new System.Drawing.Size(155, 29);
            this.Royalty.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 116);
            this.label4.Name = "label4";
            this.tableLayoutPanel1.SetRowSpan(this.label4, 3);
            this.label4.Size = new System.Drawing.Size(155, 152);
            this.label4.TabIndex = 6;
            this.label4.Text = "Profit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(172, 11);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(155, 29);
            this.NameTextBox.TabIndex = 1;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(172, 46);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(155, 32);
            this.TypeComboBox.TabIndex = 3;
            // 
            // CostNumeric
            // 
            this.CostNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CostNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostNumeric.Location = new System.Drawing.Point(172, 84);
            this.CostNumeric.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.CostNumeric.Name = "CostNumeric";
            this.CostNumeric.Size = new System.Drawing.Size(155, 29);
            this.CostNumeric.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(172, 119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(155, 76);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.Percent);
            this.groupBox1.Controls.Add(this.Flat);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select One";
            // 
            // Percent
            // 
            this.Percent.AutoSize = true;
            this.Percent.Dock = System.Windows.Forms.DockStyle.Top;
            this.Percent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Percent.Location = new System.Drawing.Point(3, 44);
            this.Percent.Name = "Percent";
            this.Percent.Size = new System.Drawing.Size(149, 28);
            this.Percent.TabIndex = 1;
            this.Percent.Text = "Percent";
            this.Percent.UseVisualStyleBackColor = true;
            // 
            // Flat
            // 
            this.Flat.AutoSize = true;
            this.Flat.Checked = true;
            this.Flat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Flat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flat.Location = new System.Drawing.Point(3, 16);
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(149, 28);
            this.Flat.TabIndex = 0;
            this.Flat.TabStop = true;
            this.Flat.Text = "Flat";
            this.Flat.UseVisualStyleBackColor = true;
            // 
            // ProfitValue
            // 
            this.ProfitValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProfitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfitValue.Location = new System.Drawing.Point(172, 201);
            this.ProfitValue.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.ProfitValue.Name = "ProfitValue";
            this.ProfitValue.Size = new System.Drawing.Size(155, 29);
            this.ProfitValue.TabIndex = 8;
            // 
            // Profit
            // 
            this.Profit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Profit.Enabled = false;
            this.Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit.Location = new System.Drawing.Point(172, 236);
            this.Profit.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Size = new System.Drawing.Size(155, 29);
            this.Profit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "Royalty";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DiscountAmount);
            this.panel2.Controls.Add(this.DiscountValue);
            this.panel2.Controls.Add(this.DiscountBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(172, 341);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.SetRowSpan(this.panel2, 4);
            this.panel2.Size = new System.Drawing.Size(155, 141);
            this.panel2.TabIndex = 18;
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiscountAmount.Enabled = false;
            this.DiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountAmount.Location = new System.Drawing.Point(5, 109);
            this.DiscountAmount.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.ReadOnly = true;
            this.DiscountAmount.Size = new System.Drawing.Size(145, 29);
            this.DiscountAmount.TabIndex = 10;
            // 
            // DiscountValue
            // 
            this.DiscountValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiscountValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountValue.Location = new System.Drawing.Point(5, 80);
            this.DiscountValue.Maximum = new decimal(new int[] {
            9999990,
            0,
            0,
            0});
            this.DiscountValue.Name = "DiscountValue";
            this.DiscountValue.Size = new System.Drawing.Size(145, 29);
            this.DiscountValue.TabIndex = 9;
            // 
            // DiscountBox
            // 
            this.DiscountBox.AutoSize = true;
            this.DiscountBox.Controls.Add(this.PercentDiscount);
            this.DiscountBox.Controls.Add(this.FlatDiscountButton);
            this.DiscountBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.DiscountBox.Location = new System.Drawing.Point(5, 5);
            this.DiscountBox.Name = "DiscountBox";
            this.DiscountBox.Size = new System.Drawing.Size(145, 75);
            this.DiscountBox.TabIndex = 2;
            this.DiscountBox.TabStop = false;
            this.DiscountBox.Text = "Select One";
            // 
            // PercentDiscount
            // 
            this.PercentDiscount.AutoSize = true;
            this.PercentDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.PercentDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PercentDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentDiscount.Location = new System.Drawing.Point(3, 44);
            this.PercentDiscount.Name = "PercentDiscount";
            this.PercentDiscount.Size = new System.Drawing.Size(139, 28);
            this.PercentDiscount.TabIndex = 1;
            this.PercentDiscount.Text = "Percent";
            this.PercentDiscount.UseVisualStyleBackColor = true;
            // 
            // FlatDiscountButton
            // 
            this.FlatDiscountButton.AutoSize = true;
            this.FlatDiscountButton.Checked = true;
            this.FlatDiscountButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FlatDiscountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatDiscountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatDiscountButton.Location = new System.Drawing.Point(3, 16);
            this.FlatDiscountButton.Name = "FlatDiscountButton";
            this.FlatDiscountButton.Size = new System.Drawing.Size(139, 28);
            this.FlatDiscountButton.TabIndex = 0;
            this.FlatDiscountButton.TabStop = true;
            this.FlatDiscountButton.Text = "Flat";
            this.FlatDiscountButton.UseVisualStyleBackColor = true;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(338, 1001);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.TagBox);
            this.Controls.Add(this.PicturePanel);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.TopMost = true;
            this.PicturePanel.ResumeLayout(false);
            this.PicturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrandTotalNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Royalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNumeric)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfitValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Profit)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiscountValue)).EndInit();
            this.DiscountBox.ResumeLayout(false);
            this.DiscountBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel PicturePanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox TagBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Royalty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.NumericUpDown CostNumeric;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown ProfitValue;
        private System.Windows.Forms.NumericUpDown Profit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown GrandTotalNumeric;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Percent;
        private System.Windows.Forms.RadioButton Flat;
        private System.Windows.Forms.NumericUpDown DiscountAmount;
        private System.Windows.Forms.NumericUpDown DiscountValue;
        private System.Windows.Forms.GroupBox DiscountBox;
        private System.Windows.Forms.RadioButton PercentDiscount;
        private System.Windows.Forms.RadioButton FlatDiscountButton;
    }
}