namespace DTD.Capawcino.UIExtra.Controls
{
    partial class ClientsView
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
            this.ClientViewBox = new System.Windows.Forms.GroupBox();
            this.DatagridView = new System.Windows.Forms.DataGridView();
            this.ClientTopPanel = new System.Windows.Forms.Panel();
            this.ExportButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ClientViewBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridView)).BeginInit();
            this.ClientTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientViewBox
            // 
            this.ClientViewBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientViewBox.Controls.Add(this.DatagridView);
            this.ClientViewBox.Controls.Add(this.ClientTopPanel);
            this.ClientViewBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientViewBox.Location = new System.Drawing.Point(0, 0);
            this.ClientViewBox.Name = "ClientViewBox";
            this.ClientViewBox.Padding = new System.Windows.Forms.Padding(5);
            this.ClientViewBox.Size = new System.Drawing.Size(1084, 715);
            this.ClientViewBox.TabIndex = 1;
            this.ClientViewBox.TabStop = false;
            this.ClientViewBox.Text = "Clients";
            // 
            // DatagridView
            // 
            this.DatagridView.AllowUserToAddRows = false;
            this.DatagridView.AllowUserToDeleteRows = false;
            this.DatagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatagridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.DatagridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatagridView.GridColor = System.Drawing.Color.SlateBlue;
            this.DatagridView.Location = new System.Drawing.Point(5, 231);
            this.DatagridView.MultiSelect = false;
            this.DatagridView.Name = "DatagridView";
            this.DatagridView.RowHeadersVisible = false;
            this.DatagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatagridView.Size = new System.Drawing.Size(1074, 479);
            this.DatagridView.TabIndex = 5;
            // 
            // ClientTopPanel
            // 
            this.ClientTopPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientTopPanel.Controls.Add(this.ExportButton);
            this.ClientTopPanel.Controls.Add(this.ImportButton);
            this.ClientTopPanel.Controls.Add(this.AddButton);
            this.ClientTopPanel.Controls.Add(this.groupBox1);
            this.ClientTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientTopPanel.Location = new System.Drawing.Point(5, 27);
            this.ClientTopPanel.Name = "ClientTopPanel";
            this.ClientTopPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ClientTopPanel.Size = new System.Drawing.Size(1074, 204);
            this.ClientTopPanel.TabIndex = 1;
            // 
            // ExportButton
            // 
            this.ExportButton.AutoSize = true;
            this.ExportButton.BackColor = System.Drawing.Color.Honeydew;
            this.ExportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ExportButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ExportButton.FlatAppearance.BorderSize = 2;
            this.ExportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.ExportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExportButton.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.export;
            this.ExportButton.Location = new System.Drawing.Point(275, 5);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(130, 55);
            this.ExportButton.TabIndex = 18;
            this.ExportButton.Text = "Export";
            this.ExportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExportButton.UseVisualStyleBackColor = false;
            // 
            // ImportButton
            // 
            this.ImportButton.AutoSize = true;
            this.ImportButton.BackColor = System.Drawing.Color.Honeydew;
            this.ImportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ImportButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ImportButton.FlatAppearance.BorderSize = 2;
            this.ImportButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.ImportButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ImportButton.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.import;
            this.ImportButton.Location = new System.Drawing.Point(135, 5);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(140, 55);
            this.ImportButton.TabIndex = 17;
            this.ImportButton.Text = "Import";
            this.ImportButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ImportButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.BackColor = System.Drawing.Color.Honeydew;
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.AddButton.FlatAppearance.BorderSize = 2;
            this.AddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddButton.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.add;
            this.AddButton.Location = new System.Drawing.Point(5, 5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(130, 55);
            this.AddButton.TabIndex = 16;
            this.AddButton.Text = "Add";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1062, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // ClientsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ClientViewBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ClientsView";
            this.Size = new System.Drawing.Size(1084, 715);
            this.ClientViewBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridView)).EndInit();
            this.ClientTopPanel.ResumeLayout(false);
            this.ClientTopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ClientViewBox;
        private System.Windows.Forms.Panel ClientTopPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DatagridView;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Button AddButton;
    }
}
