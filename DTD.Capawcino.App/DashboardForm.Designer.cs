namespace DTD.Capawcino.App
{
    partial class DashboardForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SalesButton = new System.Windows.Forms.Button();
            this.ProductsButton = new System.Windows.Forms.Button();
            this.ClientsButton = new System.Windows.Forms.Button();
            this.BusinessButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.MenuStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1093, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.lockToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.userToolStripMenuItem.Image = global::DTD.Capawcino.App.Properties.Resources.man;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.userToolStripMenuItem.Text = "User";
            // 
            // profileToolStripMenuItem
            // 
            this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            this.profileToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.profileToolStripMenuItem.Text = "Profile";
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Image = global::DTD.Capawcino.App.Properties.Resources._lock;
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.lockToolStripMenuItem.Text = "Lock";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = global::DTD.Capawcino.App.Properties.Resources.exit;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::DTD.Capawcino.App.Properties.Resources.settings;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem});
            this.dataToolStripMenuItem.Image = global::DTD.Capawcino.App.Properties.Resources.archive;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem});
            this.exportToolStripMenuItem.Image = global::DTD.Capawcino.App.Properties.Resources.export;
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem1});
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.allToolStripMenuItem.Text = "All";
            // 
            // jSONToolStripMenuItem1
            // 
            this.jSONToolStripMenuItem1.Name = "jSONToolStripMenuItem1";
            this.jSONToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem1.Text = "JSON";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem});
            this.importToolStripMenuItem.Image = global::DTD.Capawcino.App.Properties.Resources.import;
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excelToolStripMenuItem,
            this.cSVToolStripMenuItem,
            this.jSONToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.productsToolStripMenuItem.Text = "Products";
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.excelToolStripMenuItem.Text = "Excel";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 716);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1093, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.SalesButton);
            this.flowLayoutPanel1.Controls.Add(this.ProductsButton);
            this.flowLayoutPanel1.Controls.Add(this.ClientsButton);
            this.flowLayoutPanel1.Controls.Add(this.BusinessButton);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1093, 77);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // SalesButton
            // 
            this.SalesButton.AutoSize = true;
            this.SalesButton.BackColor = System.Drawing.Color.LightCoral;
            this.SalesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SalesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SalesButton.FlatAppearance.BorderSize = 2;
            this.SalesButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.SalesButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.SalesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SalesButton.Image = global::DTD.Capawcino.App.Properties.Resources.goods;
            this.SalesButton.Location = new System.Drawing.Point(3, 3);
            this.SalesButton.Name = "SalesButton";
            this.SalesButton.Size = new System.Drawing.Size(130, 71);
            this.SalesButton.TabIndex = 10;
            this.SalesButton.Text = "Sales";
            this.SalesButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SalesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.SalesButton.UseVisualStyleBackColor = false;
            this.SalesButton.Click += new System.EventHandler(this.SalesButton_Click);
            // 
            // ProductsButton
            // 
            this.ProductsButton.AutoSize = true;
            this.ProductsButton.BackColor = System.Drawing.Color.LightCoral;
            this.ProductsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ProductsButton.FlatAppearance.BorderSize = 2;
            this.ProductsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.ProductsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.ProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProductsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProductsButton.Image = global::DTD.Capawcino.App.Properties.Resources.burger;
            this.ProductsButton.Location = new System.Drawing.Point(139, 3);
            this.ProductsButton.Name = "ProductsButton";
            this.ProductsButton.Size = new System.Drawing.Size(130, 71);
            this.ProductsButton.TabIndex = 11;
            this.ProductsButton.Text = "Products";
            this.ProductsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ProductsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ProductsButton.UseVisualStyleBackColor = false;
            this.ProductsButton.Click += new System.EventHandler(this.ProductsButton_Click);
            // 
            // ClientsButton
            // 
            this.ClientsButton.AutoSize = true;
            this.ClientsButton.BackColor = System.Drawing.Color.LightCoral;
            this.ClientsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientsButton.FlatAppearance.BorderSize = 2;
            this.ClientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.ClientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.ClientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientsButton.Image = global::DTD.Capawcino.App.Properties.Resources.woman;
            this.ClientsButton.Location = new System.Drawing.Point(275, 3);
            this.ClientsButton.Name = "ClientsButton";
            this.ClientsButton.Size = new System.Drawing.Size(130, 71);
            this.ClientsButton.TabIndex = 12;
            this.ClientsButton.Text = "Clients";
            this.ClientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ClientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ClientsButton.UseVisualStyleBackColor = false;
            this.ClientsButton.Click += new System.EventHandler(this.ClientsButton_Click);
            // 
            // BusinessButton
            // 
            this.BusinessButton.AutoSize = true;
            this.BusinessButton.BackColor = System.Drawing.Color.LightCoral;
            this.BusinessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BusinessButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BusinessButton.FlatAppearance.BorderSize = 2;
            this.BusinessButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.BusinessButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.BusinessButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BusinessButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BusinessButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BusinessButton.Image = global::DTD.Capawcino.App.Properties.Resources.bag;
            this.BusinessButton.Location = new System.Drawing.Point(411, 3);
            this.BusinessButton.Name = "BusinessButton";
            this.BusinessButton.Size = new System.Drawing.Size(132, 71);
            this.BusinessButton.TabIndex = 13;
            this.BusinessButton.Text = "Business";
            this.BusinessButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BusinessButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BusinessButton.UseVisualStyleBackColor = false;
            this.BusinessButton.Click += new System.EventHandler(this.BusinessButton_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::DTD.Capawcino.App.Properties.Resources.profits;
            this.button2.Location = new System.Drawing.Point(549, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 71);
            this.button2.TabIndex = 14;
            this.button2.Text = "Statistics";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(0, 101);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Padding = new System.Windows.Forms.Padding(5);
            this.ContentPanel.Size = new System.Drawing.Size(1093, 615);
            this.ContentPanel.TabIndex = 3;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 738);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MenuStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "DashboardForm";
            this.Text = "Dashboard";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button SalesButton;
        private System.Windows.Forms.Button ProductsButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button ClientsButton;
        private System.Windows.Forms.Button BusinessButton;
        private System.Windows.Forms.Button button2;
    }
}