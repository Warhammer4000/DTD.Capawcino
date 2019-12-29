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
            this.Sales = new System.Windows.Forms.Button();
            this.Products = new System.Windows.Forms.Button();
            this.Clients = new System.Windows.Forms.Button();
            this.Business = new System.Windows.Forms.Button();
            this.Statistics = new System.Windows.Forms.Button();
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
            this.flowLayoutPanel1.Controls.Add(this.Sales);
            this.flowLayoutPanel1.Controls.Add(this.Products);
            this.flowLayoutPanel1.Controls.Add(this.Clients);
            this.flowLayoutPanel1.Controls.Add(this.Business);
            this.flowLayoutPanel1.Controls.Add(this.Statistics);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1093, 77);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Sales
            // 
            this.Sales.AutoSize = true;
            this.Sales.BackColor = System.Drawing.Color.LightCoral;
            this.Sales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Sales.FlatAppearance.BorderSize = 2;
            this.Sales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.Sales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sales.Image = global::DTD.Capawcino.App.Properties.Resources.goods;
            this.Sales.Location = new System.Drawing.Point(3, 3);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(130, 71);
            this.Sales.TabIndex = 10;
            this.Sales.Text = "Sales";
            this.Sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sales.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Sales.UseVisualStyleBackColor = false;
            this.Sales.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.BackColor = System.Drawing.Color.LightCoral;
            this.Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Products.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Products.FlatAppearance.BorderSize = 2;
            this.Products.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.Products.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Products.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Products.Image = global::DTD.Capawcino.App.Properties.Resources.burger;
            this.Products.Location = new System.Drawing.Point(139, 3);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(130, 71);
            this.Products.TabIndex = 11;
            this.Products.Text = "Products";
            this.Products.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Products.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Products.UseVisualStyleBackColor = false;
            this.Products.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // Clients
            // 
            this.Clients.AutoSize = true;
            this.Clients.BackColor = System.Drawing.Color.LightCoral;
            this.Clients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Clients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Clients.FlatAppearance.BorderSize = 2;
            this.Clients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.Clients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.Clients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clients.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clients.Image = global::DTD.Capawcino.App.Properties.Resources.woman;
            this.Clients.Location = new System.Drawing.Point(275, 3);
            this.Clients.Name = "Clients";
            this.Clients.Size = new System.Drawing.Size(130, 71);
            this.Clients.TabIndex = 12;
            this.Clients.Text = "Clients";
            this.Clients.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clients.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Clients.UseVisualStyleBackColor = false;
            this.Clients.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // Business
            // 
            this.Business.AutoSize = true;
            this.Business.BackColor = System.Drawing.Color.LightCoral;
            this.Business.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Business.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Business.FlatAppearance.BorderSize = 2;
            this.Business.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.Business.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.Business.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Business.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Business.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Business.Image = global::DTD.Capawcino.App.Properties.Resources.bag;
            this.Business.Location = new System.Drawing.Point(411, 3);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(132, 71);
            this.Business.TabIndex = 13;
            this.Business.Text = "Business";
            this.Business.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Business.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Business.UseVisualStyleBackColor = false;
            this.Business.Click += new System.EventHandler(this.NavButton_Click);
            // 
            // Statistics
            // 
            this.Statistics.AutoSize = true;
            this.Statistics.BackColor = System.Drawing.Color.LightCoral;
            this.Statistics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Statistics.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Statistics.FlatAppearance.BorderSize = 2;
            this.Statistics.FlatAppearance.MouseDownBackColor = System.Drawing.Color.HotPink;
            this.Statistics.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepPink;
            this.Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Statistics.Image = global::DTD.Capawcino.App.Properties.Resources.profits;
            this.Statistics.Location = new System.Drawing.Point(549, 3);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(132, 71);
            this.Statistics.TabIndex = 14;
            this.Statistics.Text = "Statistics";
            this.Statistics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Statistics.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Statistics.UseVisualStyleBackColor = false;
            this.Statistics.Click += new System.EventHandler(this.NavButton_Click);
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
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button Products;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button Clients;
        private System.Windows.Forms.Button Business;
        private System.Windows.Forms.Button Statistics;
    }
}