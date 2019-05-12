using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Capawcino.UIExtra;
using DTD.Capawcino.UIExtra.Controls;

namespace DTD.Capawcino.App
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
           
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsView productsView=new ProductsView(){Dock = DockStyle.Fill};
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(productsView);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesView productsView = new SalesView() { Dock = DockStyle.Fill };
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(productsView);
        }

        protected override void OnClosed(EventArgs e)
        {
            Owner.Show();
            base.OnClosed(e);
           
        }
    }
}
