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
            SalesButton_Click(new object(), new EventArgs());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsView view=new ProductsView(){Dock = DockStyle.Fill};
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(view);
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            SalesView view = new SalesView() { Dock = DockStyle.Fill };
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(view);
        }


        private void ClientsButton_Click(object sender, EventArgs e)
        {
            ClientsView view = new ClientsView() { Dock = DockStyle.Fill };
            ContentPanel.Controls.Clear();
            ContentPanel.Controls.Add(view);
        }

        protected override void OnClosed(EventArgs e)
        {
            Owner.Show();
            base.OnClosed(e);
           
        }

        
    }
}
