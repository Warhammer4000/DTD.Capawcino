namespace DTD.Capawcino.UIExtra.Form
{
    partial class ProductConfigForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.TypeGrid = new System.Windows.Forms.DataGridView();
            this.TypeText = new System.Windows.Forms.TextBox();
            this.AddButtonType = new System.Windows.Forms.Button();
            this.TagGroupBox = new System.Windows.Forms.GroupBox();
            this.TagGrid = new System.Windows.Forms.DataGridView();
            this.AddButtonTag = new System.Windows.Forms.Button();
            this.TagText = new System.Windows.Forms.TextBox();
            this.TypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGrid)).BeginInit();
            this.TagGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.TypeGrid);
            this.TypeGroupBox.Controls.Add(this.AddButtonType);
            this.TypeGroupBox.Controls.Add(this.TypeText);
            this.TypeGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeGroupBox.Location = new System.Drawing.Point(5, 5);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.TypeGroupBox.Size = new System.Drawing.Size(390, 681);
            this.TypeGroupBox.TabIndex = 0;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Product Type";
            // 
            // TypeGrid
            // 
            this.TypeGrid.AllowUserToAddRows = false;
            this.TypeGrid.AllowUserToDeleteRows = false;
            this.TypeGrid.AllowUserToResizeColumns = false;
            this.TypeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TypeGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TypeGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TypeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TypeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TypeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TypeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.TypeGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeGrid.GridColor = System.Drawing.Color.SlateBlue;
            this.TypeGrid.Location = new System.Drawing.Point(5, 98);
            this.TypeGrid.MultiSelect = false;
            this.TypeGrid.Name = "TypeGrid";
            this.TypeGrid.RowHeadersVisible = false;
            this.TypeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TypeGrid.Size = new System.Drawing.Size(380, 578);
            this.TypeGrid.TabIndex = 14;
            // 
            // TypeText
            // 
            this.TypeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeText.Location = new System.Drawing.Point(5, 27);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(380, 29);
            this.TypeText.TabIndex = 0;
            // 
            // AddButtonType
            // 
            this.AddButtonType.AutoSize = true;
            this.AddButtonType.BackColor = System.Drawing.Color.Honeydew;
            this.AddButtonType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButtonType.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButtonType.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddButtonType.FlatAppearance.BorderSize = 2;
            this.AddButtonType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.AddButtonType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.AddButtonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButtonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButtonType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButtonType.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.add;
            this.AddButtonType.Location = new System.Drawing.Point(5, 56);
            this.AddButtonType.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AddButtonType.Name = "AddButtonType";
            this.AddButtonType.Size = new System.Drawing.Size(380, 42);
            this.AddButtonType.TabIndex = 13;
            this.AddButtonType.Text = "Add";
            this.AddButtonType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButtonType.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddButtonType.UseVisualStyleBackColor = false;
            this.AddButtonType.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TagGroupBox
            // 
            this.TagGroupBox.Controls.Add(this.TagGrid);
            this.TagGroupBox.Controls.Add(this.AddButtonTag);
            this.TagGroupBox.Controls.Add(this.TagText);
            this.TagGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TagGroupBox.Location = new System.Drawing.Point(395, 5);
            this.TagGroupBox.Name = "TagGroupBox";
            this.TagGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.TagGroupBox.Size = new System.Drawing.Size(390, 681);
            this.TagGroupBox.TabIndex = 1;
            this.TagGroupBox.TabStop = false;
            this.TagGroupBox.Text = "Tags";
            // 
            // TagGrid
            // 
            this.TagGrid.AllowUserToAddRows = false;
            this.TagGrid.AllowUserToDeleteRows = false;
            this.TagGrid.AllowUserToResizeColumns = false;
            this.TagGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TagGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.TagGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TagGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TagGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TagGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TagGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TagGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.TagGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagGrid.GridColor = System.Drawing.Color.SlateBlue;
            this.TagGrid.Location = new System.Drawing.Point(5, 98);
            this.TagGrid.MultiSelect = false;
            this.TagGrid.Name = "TagGrid";
            this.TagGrid.RowHeadersVisible = false;
            this.TagGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.TagGrid.Size = new System.Drawing.Size(380, 578);
            this.TagGrid.TabIndex = 14;
            // 
            // AddButtonTag
            // 
            this.AddButtonTag.AutoSize = true;
            this.AddButtonTag.BackColor = System.Drawing.Color.Honeydew;
            this.AddButtonTag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButtonTag.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButtonTag.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddButtonTag.FlatAppearance.BorderSize = 2;
            this.AddButtonTag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.AddButtonTag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.AddButtonTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButtonTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButtonTag.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButtonTag.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.add;
            this.AddButtonTag.Location = new System.Drawing.Point(5, 56);
            this.AddButtonTag.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AddButtonTag.Name = "AddButtonTag";
            this.AddButtonTag.Size = new System.Drawing.Size(380, 42);
            this.AddButtonTag.TabIndex = 13;
            this.AddButtonTag.Text = "Add";
            this.AddButtonTag.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButtonTag.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddButtonTag.UseVisualStyleBackColor = false;
            this.AddButtonTag.Click += new System.EventHandler(this.AddButtonTag_Click);
            // 
            // TagText
            // 
            this.TagText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagText.Location = new System.Drawing.Point(5, 27);
            this.TagText.Name = "TagText";
            this.TagText.Size = new System.Drawing.Size(380, 29);
            this.TagText.TabIndex = 0;
            // 
            // ProductConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(794, 691);
            this.Controls.Add(this.TagGroupBox);
            this.Controls.Add(this.TypeGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "ProductConfigForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Configuration";
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGrid)).EndInit();
            this.TagGroupBox.ResumeLayout(false);
            this.TagGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TagGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.TextBox TypeText;
        private System.Windows.Forms.Button AddButtonType;
        private System.Windows.Forms.DataGridView TypeGrid;
        private System.Windows.Forms.GroupBox TagGroupBox;
        private System.Windows.Forms.DataGridView TagGrid;
        private System.Windows.Forms.Button AddButtonTag;
        private System.Windows.Forms.TextBox TagText;
    }
}