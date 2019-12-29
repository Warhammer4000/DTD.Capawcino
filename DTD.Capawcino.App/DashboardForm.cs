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
        private readonly ViewFactory _viewFactory;

        public DashboardForm()
        {
            InitializeComponent();
            _viewFactory=new ViewFactory();
            NavButton_Click(new Button(){Name = "sales"}, new EventArgs());
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NavButton_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;

            BaseControl view = _viewFactory.GetView(button.Name);

            view.Dock = DockStyle.Fill;
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
