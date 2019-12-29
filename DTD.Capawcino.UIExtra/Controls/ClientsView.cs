using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;
using DTD.Capawcino.UIExtra.Properties;

namespace DTD.Capawcino.UIExtra.Controls
{
    public partial class ClientsView : BaseControl
    {
        private List<Client> Clients;


        internal ClientsView()
        {
            InitializeComponent();
            EventSubscription();
            RefreshDataGrid();
        }


        private void EventSubscription()
        {
            DatagridView.CellPainting += grid_CellPainting;
        }


        private void RefreshDataGrid()
        {
            DatagridView.Columns.Clear();
            DatagridView.DataSource = null;
            Clients = new CRUDManager().LoadRecords<Client>(DatabaseStrings.ClientsTable);
            DatagridView.DataSource = Clients;
            ButtonsColumnSetup(DatagridView);
        }


        private void ButtonsColumnSetup(DataGridView dataGrid)
        {
            var updatebuttons = new DataGridViewButtonColumn();
            {
                updatebuttons.HeaderText = @"Update";
                updatebuttons.FlatStyle = FlatStyle.Flat;
                updatebuttons.CellTemplate.Style.BackColor = Color.LightSeaGreen;
                updatebuttons.CellTemplate.Style.ForeColor = Color.White;
            }

            dataGrid.Columns.Add(updatebuttons);


            var removebuttons = new DataGridViewButtonColumn();
            {
                removebuttons.HeaderText = @"Remove";

                removebuttons.FlatStyle = FlatStyle.Flat;
                removebuttons.CellTemplate.Style.BackColor = Color.Red;
                removebuttons.CellTemplate.Style.ForeColor = Color.White;
            }

            dataGrid.Columns.Add(removebuttons);
        }


        private void grid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var dataGrid = (DataGridView) sender;

            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Update")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var resource = Resources.diskette;
                var w = resource.Width;
                var h = resource.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(resource, new Rectangle(x, y, w, h));
                e.Handled = true;
            }


            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var resource = Resources.rubbish_bin;
                var w = resource.Width;
                var h = resource.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(resource, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }



    }
}
