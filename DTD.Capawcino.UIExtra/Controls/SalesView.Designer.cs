namespace DTD.Capawcino.UIExtra
{
    partial class SalesView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BillBox = new System.Windows.Forms.GroupBox();
            this.PaidCheckbox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.GrandTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.VatTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PercentNumeric = new System.Windows.Forms.NumericUpDown();
            this.FlatNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PercentDiscount = new System.Windows.Forms.RadioButton();
            this.FlatDiscount = new System.Windows.Forms.RadioButton();
            this.DiscountTotal = new System.Windows.Forms.Label();
            this.TotalPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalLable = new System.Windows.Forms.Label();
            this.DatagridView = new System.Windows.Forms.DataGridView();
            this.BillTopPanel = new System.Windows.Forms.Panel();
            this.NewBill = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ProductsBox = new System.Windows.Forms.GroupBox();
            this.BillBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumeric)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TotalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BillBox
            // 
            this.BillBox.Controls.Add(this.PaidCheckbox);
            this.BillBox.Controls.Add(this.panel3);
            this.BillBox.Controls.Add(this.panel2);
            this.BillBox.Controls.Add(this.panel1);
            this.BillBox.Controls.Add(this.TotalPanel);
            this.BillBox.Controls.Add(this.DatagridView);
            this.BillBox.Controls.Add(this.BillTopPanel);
            this.BillBox.Controls.Add(this.NewBill);
            this.BillBox.Controls.Add(this.PrintButton);
            this.BillBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.BillBox.Location = new System.Drawing.Point(471, 5);
            this.BillBox.Name = "BillBox";
            this.BillBox.Padding = new System.Windows.Forms.Padding(5);
            this.BillBox.Size = new System.Drawing.Size(669, 828);
            this.BillBox.TabIndex = 0;
            this.BillBox.TabStop = false;
            this.BillBox.Text = "Bill";
            // 
            // PaidCheckbox
            // 
            this.PaidCheckbox.AutoSize = true;
            this.PaidCheckbox.Checked = true;
            this.PaidCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PaidCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PaidCheckbox.Location = new System.Drawing.Point(5, 758);
            this.PaidCheckbox.Name = "PaidCheckbox";
            this.PaidCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PaidCheckbox.Size = new System.Drawing.Size(659, 28);
            this.PaidCheckbox.TabIndex = 24;
            this.PaidCheckbox.Text = "Paid";
            this.PaidCheckbox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.GrandTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 729);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 29);
            this.panel3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(529, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Grand Total";
            // 
            // GrandTotal
            // 
            this.GrandTotal.AutoSize = true;
            this.GrandTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.GrandTotal.Location = new System.Drawing.Point(637, 0);
            this.GrandTotal.Name = "GrandTotal";
            this.GrandTotal.Size = new System.Drawing.Size(20, 24);
            this.GrandTotal.TabIndex = 0;
            this.GrandTotal.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.VatTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 700);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(659, 29);
            this.panel2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(542, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Vat(+15%)";
            // 
            // VatTotal
            // 
            this.VatTotal.AutoSize = true;
            this.VatTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.VatTotal.Location = new System.Drawing.Point(637, 0);
            this.VatTotal.Name = "VatTotal";
            this.VatTotal.Size = new System.Drawing.Size(20, 24);
            this.VatTotal.TabIndex = 0;
            this.VatTotal.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PercentNumeric);
            this.panel1.Controls.Add(this.FlatNumeric);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DiscountTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 654);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 46);
            this.panel1.TabIndex = 21;
            // 
            // PercentNumeric
            // 
            this.PercentNumeric.Dock = System.Windows.Forms.DockStyle.Left;
            this.PercentNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentNumeric.Location = new System.Drawing.Point(251, 0);
            this.PercentNumeric.Name = "PercentNumeric";
            this.PercentNumeric.Size = new System.Drawing.Size(120, 45);
            this.PercentNumeric.TabIndex = 3;
            this.PercentNumeric.Visible = false;
            // 
            // FlatNumeric
            // 
            this.FlatNumeric.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlatNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlatNumeric.Location = new System.Drawing.Point(131, 0);
            this.FlatNumeric.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.FlatNumeric.Name = "FlatNumeric";
            this.FlatNumeric.Size = new System.Drawing.Size(120, 45);
            this.FlatNumeric.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PercentDiscount);
            this.groupBox1.Controls.Add(this.FlatDiscount);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 44);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discount";
            // 
            // PercentDiscount
            // 
            this.PercentDiscount.AutoSize = true;
            this.PercentDiscount.Dock = System.Windows.Forms.DockStyle.Left;
            this.PercentDiscount.FlatAppearance.BorderSize = 0;
            this.PercentDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PercentDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PercentDiscount.Location = new System.Drawing.Point(51, 19);
            this.PercentDiscount.Name = "PercentDiscount";
            this.PercentDiscount.Size = new System.Drawing.Size(74, 22);
            this.PercentDiscount.TabIndex = 1;
            this.PercentDiscount.Text = "Percent";
            this.PercentDiscount.UseVisualStyleBackColor = true;
            // 
            // FlatDiscount
            // 
            this.FlatDiscount.AutoSize = true;
            this.FlatDiscount.Checked = true;
            this.FlatDiscount.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlatDiscount.FlatAppearance.BorderSize = 0;
            this.FlatDiscount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FlatDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatDiscount.Location = new System.Drawing.Point(3, 19);
            this.FlatDiscount.Name = "FlatDiscount";
            this.FlatDiscount.Size = new System.Drawing.Size(48, 22);
            this.FlatDiscount.TabIndex = 0;
            this.FlatDiscount.TabStop = true;
            this.FlatDiscount.Text = "Flat";
            this.FlatDiscount.UseVisualStyleBackColor = true;
            // 
            // DiscountTotal
            // 
            this.DiscountTotal.AutoSize = true;
            this.DiscountTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.DiscountTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTotal.Location = new System.Drawing.Point(621, 0);
            this.DiscountTotal.Name = "DiscountTotal";
            this.DiscountTotal.Size = new System.Drawing.Size(36, 39);
            this.DiscountTotal.TabIndex = 0;
            this.DiscountTotal.Text = "0";
            this.DiscountTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalPanel
            // 
            this.TotalPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPanel.Controls.Add(this.label1);
            this.TotalPanel.Controls.Add(this.TotalLable);
            this.TotalPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TotalPanel.Location = new System.Drawing.Point(5, 625);
            this.TotalPanel.Name = "TotalPanel";
            this.TotalPanel.Size = new System.Drawing.Size(659, 29);
            this.TotalPanel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(581, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalLable
            // 
            this.TotalLable.AutoSize = true;
            this.TotalLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.TotalLable.Location = new System.Drawing.Point(637, 0);
            this.TotalLable.Name = "TotalLable";
            this.TotalLable.Size = new System.Drawing.Size(20, 24);
            this.TotalLable.TabIndex = 0;
            this.TotalLable.Text = "0";
            // 
            // DatagridView
            // 
            this.DatagridView.AllowUserToAddRows = false;
            this.DatagridView.AllowUserToDeleteRows = false;
            this.DatagridView.AllowUserToOrderColumns = true;
            this.DatagridView.AllowUserToResizeColumns = false;
            this.DatagridView.AllowUserToResizeRows = false;
            this.DatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatagridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DatagridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DatagridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DatagridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.DatagridView.GridColor = System.Drawing.Color.SlateBlue;
            this.DatagridView.Location = new System.Drawing.Point(5, 130);
            this.DatagridView.MultiSelect = false;
            this.DatagridView.Name = "DatagridView";
            this.DatagridView.RowHeadersVisible = false;
            this.DatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DatagridView.Size = new System.Drawing.Size(659, 495);
            this.DatagridView.TabIndex = 19;
            // 
            // BillTopPanel
            // 
            this.BillTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BillTopPanel.Location = new System.Drawing.Point(5, 70);
            this.BillTopPanel.Name = "BillTopPanel";
            this.BillTopPanel.Size = new System.Drawing.Size(659, 60);
            this.BillTopPanel.TabIndex = 18;
            // 
            // NewBill
            // 
            this.NewBill.BackColor = System.Drawing.Color.CadetBlue;
            this.NewBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewBill.FlatAppearance.BorderSize = 0;
            this.NewBill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.NewBill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BurlyWood;
            this.NewBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewBill.Location = new System.Drawing.Point(5, 27);
            this.NewBill.Name = "NewBill";
            this.NewBill.Size = new System.Drawing.Size(659, 43);
            this.NewBill.TabIndex = 11;
            this.NewBill.Text = "New";
            this.NewBill.UseVisualStyleBackColor = false;
            this.NewBill.Click += new System.EventHandler(this.NewBill_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.Color.Crimson;
            this.PrintButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PrintButton.FlatAppearance.BorderSize = 0;
            this.PrintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.PrintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrintButton.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.printer;
            this.PrintButton.Location = new System.Drawing.Point(5, 780);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(659, 43);
            this.PrintButton.TabIndex = 10;
            this.PrintButton.Text = "Print";
            this.PrintButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PrintButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // ProductsBox
            // 
            this.ProductsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductsBox.Location = new System.Drawing.Point(5, 5);
            this.ProductsBox.Name = "ProductsBox";
            this.ProductsBox.Padding = new System.Windows.Forms.Padding(5);
            this.ProductsBox.Size = new System.Drawing.Size(466, 828);
            this.ProductsBox.TabIndex = 1;
            this.ProductsBox.TabStop = false;
            this.ProductsBox.Text = "Products";
            // 
            // SalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.ProductsBox);
            this.Controls.Add(this.BillBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SalesView";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(1145, 838);
            this.BillBox.ResumeLayout(false);
            this.BillBox.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PercentNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FlatNumeric)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TotalPanel.ResumeLayout(false);
            this.TotalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox BillBox;
        private System.Windows.Forms.GroupBox ProductsBox;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button NewBill;
        private System.Windows.Forms.CheckBox PaidCheckbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GrandTotal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label VatTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DiscountTotal;
        private System.Windows.Forms.Panel TotalPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TotalLable;
        private System.Windows.Forms.DataGridView DatagridView;
        private System.Windows.Forms.Panel BillTopPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PercentDiscount;
        private System.Windows.Forms.RadioButton FlatDiscount;
        private System.Windows.Forms.NumericUpDown FlatNumeric;
        private System.Windows.Forms.NumericUpDown PercentNumeric;
    }
}
