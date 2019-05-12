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
            this.TypeGroupBox = new System.Windows.Forms.GroupBox();
            this.TypeText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TypeGrid = new System.Windows.Forms.DataGridView();
            this.TypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TypeGroupBox
            // 
            this.TypeGroupBox.Controls.Add(this.TypeGrid);
            this.TypeGroupBox.Controls.Add(this.AddButton);
            this.TypeGroupBox.Controls.Add(this.TypeText);
            this.TypeGroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeGroupBox.Location = new System.Drawing.Point(5, 5);
            this.TypeGroupBox.Name = "TypeGroupBox";
            this.TypeGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.TypeGroupBox.Size = new System.Drawing.Size(390, 745);
            this.TypeGroupBox.TabIndex = 0;
            this.TypeGroupBox.TabStop = false;
            this.TypeGroupBox.Text = "Product Type";
            // 
            // TypeText
            // 
            this.TypeText.Dock = System.Windows.Forms.DockStyle.Top;
            this.TypeText.Location = new System.Drawing.Point(5, 27);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(380, 29);
            this.TypeText.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.Color.Honeydew;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.add;
            this.AddButton.Location = new System.Drawing.Point(5, 56);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(380, 42);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TypeGrid
            // 
            this.TypeGrid.AllowUserToAddRows = false;
            this.TypeGrid.AllowUserToDeleteRows = false;
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
            this.TypeGrid.Size = new System.Drawing.Size(380, 642);
            this.TypeGrid.TabIndex = 14;
            // 
            // ProductConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1114, 755);
            this.Controls.Add(this.TypeGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ProductConfigForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.Text = "Product Configuration";
            this.TypeGroupBox.ResumeLayout(false);
            this.TypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TypeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TypeGroupBox;
        private System.Windows.Forms.TextBox TypeText;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView TypeGrid;
    }
}