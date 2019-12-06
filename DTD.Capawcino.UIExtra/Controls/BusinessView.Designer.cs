namespace DTD.Capawcino.UIExtra
{
    partial class BusinessView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.VatPanel = new System.Windows.Forms.Panel();
            this.VatNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.VatPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VatNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 519);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Business";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.VatPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(142, 448);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // VatPanel
            // 
            this.VatPanel.Controls.Add(this.VatNumeric);
            this.VatPanel.Controls.Add(this.label2);
            this.VatPanel.Controls.Add(this.label1);
            this.VatPanel.Location = new System.Drawing.Point(3, 3);
            this.VatPanel.Name = "VatPanel";
            this.VatPanel.Size = new System.Drawing.Size(136, 28);
            this.VatPanel.TabIndex = 0;
            // 
            // VatNumeric
            // 
            this.VatNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VatNumeric.Location = new System.Drawing.Point(48, 0);
            this.VatNumeric.Name = "VatNumeric";
            this.VatNumeric.Size = new System.Drawing.Size(63, 29);
            this.VatNumeric.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(111, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "VAT";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Teal;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.BlueViolet;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SaveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SaveButton.Image = global::DTD.Capawcino.UIExtra.Properties.Resources.diskette;
            this.SaveButton.Location = new System.Drawing.Point(3, 473);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(616, 43);
            this.SaveButton.TabIndex = 27;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // BusinessView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "BusinessView";
            this.Size = new System.Drawing.Size(622, 519);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.VatPanel.ResumeLayout(false);
            this.VatPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VatNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel VatPanel;
        private System.Windows.Forms.NumericUpDown VatNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
