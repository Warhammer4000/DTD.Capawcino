using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Capawcino.Entities;

namespace DTD.Capawcino.UIExtra
{
    public partial class SalesView : BaseControl
    {
        private Bill Bill { get; set; }

        public SalesView()
        {
            
            InitializeComponent();
            EventSubscription();
            Bill = new Bill(DateTime.Now);
            InitalizeView();
        }

        private void NewBill_Click(object sender, EventArgs e)
        {
            Bill=new Bill(DateTime.Now);
            InitalizeView();

        }

        private void InitalizeView()
        {
            DatagridView.Columns.Clear();
            DatagridView.DataSource = null;
            DatagridView.DataSource = Bill.SalesItem;
            ButtonsColumnSetup(DatagridView);
            DatagridView.Columns[0].ReadOnly = true;
            DatagridView.Columns[1].ReadOnly = true;
            UpdateView();
        }


        private void ButtonsColumnSetup(DataGridView dataGrid)
        {
            DataGridViewButtonColumn removebuttons = new DataGridViewButtonColumn();
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
            DataGridView dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var resource = Properties.Resources.rubbish_bin;
                var w = resource.Width;
                var h = resource.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(resource, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }



        private void EventSubscription()
        {
            DatagridView.CellPainting += grid_CellPainting;
            PaidCheckbox.CheckedChanged += PaidCheckbox_CheckedChanged;
            FlatDiscount.CheckedChanged += PercentDiscount_CheckedChanged;
            PercentDiscount.CheckedChanged += PercentDiscount_CheckedChanged;
        }

        private void EventUnSubscription()
        {

        }


        private void UpdateView()
        {
            TotalLable.Text = Bill.Total.ToString("N0");
            DiscountTotal.Text = Bill.DiscountedTotal.ToString("N0");
            VatTotal.Text = Bill.Vat.ToString("N0");
            GrandTotal.Text = Bill.Vat.ToString("N0");
        }

        private void PaidCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Bill.Paid = PaidCheckbox.Checked;
        }

        private void PercentDiscount_CheckedChanged(object sender, EventArgs e)
        {
            PercentNumeric.Visible = PercentDiscount.Checked;
            FlatNumeric.Visible = FlatDiscount.Checked;
            Bill.FlatDiscount = FlatDiscount.Checked;
        }
    }
}
