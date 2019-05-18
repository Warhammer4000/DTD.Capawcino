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
using DTD.Capawcino.UIExtra.CustomUI;

namespace DTD.Capawcino.UIExtra
{
    public partial class SalesView : BaseControl
    {
        private Bill Bill { get; set; }
        private List<Product> Items { get; set; }


        public SalesView()
        {
            InitializeComponent();
            EventSubscription();
            Bill = new Bill(DateTime.Now);
            Items = new CRUDManager().LoadRecords<Product>(DatabaseStrings.ProductTable);
            NewBill_Click(new object(), new EventArgs());
            InitializeSalesItems();
        }

        private void NewBill_Click(object sender, EventArgs e)
        {

            Bill=new Bill(DateTime.Now);
            DatagridView.DataSource = Bill.SalesItem;
            Bill.SalesItem.RemoveAt(0);//BUG WORKAROUND
            InitalizeBill();

        }


        private void AddSalesItem(SalesItem salesItem)
        {
            SalesItem item = Bill.SalesItem.FirstOrDefault(r => r.ProductId == salesItem.ProductId);
            if (item!=null)
            {
                item.Quantity++;
            }
            else
            {
                Bill.SalesItem.Add(salesItem);
            }

            


            InitalizeBill();
        }


        private void RemoveSalesItem(SalesItem salesItem)
        {
            SalesItem item = Bill.SalesItem.First(r => r.ProductId == salesItem.ProductId);
            item.Quantity = 1;
            Bill.SalesItem.Remove(item);
            InitalizeBill();
        }


        private void InitializeSalesItems()
        {
            SalesLayoutPanel.Controls.Clear();
            foreach (var item in Items)
            {
                SalesItemUI UIElement = new SalesItemUI(item);
                UIElement.AddToCartButtonClick += AddSalesItem;
                SalesLayoutPanel.Controls.Add(UIElement);
            }
        }

        private void InitalizeBill()
        {
           
            DatagridView.DataSource = null;
            DatagridView.Columns.Clear();
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
            NewBill.Click += NewBill_Click;
            DatagridView.CellPainting += grid_CellPainting;
            DatagridView.CellValueChanged += DatagridView_CellValueChanged;
            DatagridView.CellContentClick += Grid_CellContentClick;
            PaidCheckbox.CheckedChanged += PaidCheckbox_CheckedChanged;
            FlatDiscount.CheckedChanged += PercentDiscount_CheckedChanged;
            PercentDiscount.CheckedChanged += PercentDiscount_CheckedChanged;
            MemberCheckBox.CheckStateChanged += MemberCheckBox_CheckStateChanged;
            FlatNumeric.ValueChanged += FlatNumeric_ValueChanged;
            PercentNumeric.ValueChanged += FlatNumeric_ValueChanged;
        }


        private void Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var dataGrid = (DataGridView) sender;

            if (dataGrid.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                var item = (SalesItem) dataGrid.Rows[e.RowIndex].DataBoundItem;
                RemoveSalesItem(item);
            }
        }



        private void FlatNumeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown) sender;
            Bill.DiscountValue = (float)numericUpDown.Value;
            Bill.FlatDiscount = FlatDiscount.Checked;
            InitalizeBill();
        }

        private void DatagridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            InitalizeBill();
        }

        private void MemberCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            MemberBox.Visible = MemberCheckBox.Checked;
        }

        private void EventUnSubscription()
        {

        }


        private void UpdateView()
        {
            TotalLable.Text = Bill.Total.ToString("N0");
            DiscountAmount.Text = Bill.Discount.ToString("N0");
            VatTotal.Text = Bill.Vat.ToString("N0");
            GrandTotal.Text = Bill.GrandTotal.ToString("N0");
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
