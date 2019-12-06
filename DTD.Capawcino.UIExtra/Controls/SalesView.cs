using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DTD.Capawcino.ApplicationControllers.PrinterLogic;
using DTD.Capawcino.BusinessLogic;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;
using DTD.Capawcino.UIExtra.CustomUI;
using DTD.Capawcino.UIExtra.Properties;

namespace DTD.Capawcino.UIExtra
{
    public partial class SalesView : BaseControl
    {
        private Bill Bill { get; set; }
        private List<Product> Items { get; }
        private List<ProductType> ProductTypes { get; }

        public SalesView()
        {
            InitializeComponent();
            EventSubscription();
            Bill = new Bill(DateTime.Now,BusinessLogicManager.BusinessConfigurations.VatAmount);
            Items = new CRUDManager().LoadRecords<Product>(DatabaseStrings.ProductTable);
            var typeDataFromDatabase = new CRUDManager().LoadRecords<ProductType>(DatabaseStrings.TypeTable);
            ProductTypes=new List<ProductType>(){ new ProductType() { Name = "All" } };
            ProductTypes.AddRange(typeDataFromDatabase);
            TypeFilterCombo.DataSource = ProductTypes;


            NewBill_Click(new object(), new EventArgs());
            InitializeSalesItems(Items);
            //PrintButton.Click += PrintButton_Click;
            TypeFilterCombo.SelectedIndexChanged += TypeFilterCombo_SelectedIndexChanged;
        }

        private void TypeFilterCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox) sender;
            string type = combo.Items[combo.SelectedIndex].ToString();
            InitializeSalesItems(type != "All" ? Items.Where(r => r.ProductType.Name == type).ToList() : Items);
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
           PrinterController controller=new PrinterController();
           controller.PrintReceiptForTransaction(Bill);
        }

        private void NewBill_Click(object sender, EventArgs e)
        {
            Bill = new Bill(DateTime.Now, BusinessLogicManager.BusinessConfigurations.VatAmount);
            DatagridView.DataSource = Bill.SalesItem;
            Bill.SalesItem.RemoveAt(0); //BUG WORKAROUND
            
            InitalizeBill();

            FlatNumeric.Value = 0;
            PercentNumeric.Value = 0;
            CashNumeric.Value = 0;
        }


        private void AddSalesItem(SalesItem salesItem)
        {
            var item = Bill.SalesItem.FirstOrDefault(r => r.ProductId == salesItem.ProductId);
            if (item != null)
                item.Quantity++;
            else
            {
                salesItem.Quantity = 1;
                Bill.SalesItem.Add(salesItem);
            }
                


            InitalizeBill();
        }


        private void RemoveSalesItem(SalesItem salesItem)
        {
            var item = Bill.SalesItem.First(r => r.ProductId == salesItem.ProductId);
            item.Quantity = 1;
            Bill.SalesItem.Remove(item);
            InitalizeBill();
        }


        private void InitializeSalesItems(List<Product> products)
        {
            SalesLayoutPanel.Controls.Clear();
            foreach (var item in products)
            {
                var uiElement = new SalesItemUI(item);
                uiElement.AddToCartButtonClick += AddSalesItem;
                SalesLayoutPanel.Controls.Add(uiElement);
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
            if (BusinessLogicManager.BusinessConfigurations.VatAmount <= 0)
            {
                VatPanel.Visible = false;
            }
            else
            {
                VatPercentLable.Text = (int)(BusinessLogicManager.BusinessConfigurations.VatAmount * 100)+@"%";
            }
            UpdateView();
        }


        private void ButtonsColumnSetup(DataGridView dataGrid)
        {
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
            
            CashNumeric.ValueChanged += CashNumeric_ValueChanged;
            Template1.Click += OnTemplateButtonClick;
            Template2.Click += OnTemplateButtonClick;
            Template3.Click += OnTemplateButtonClick;
        }

       

        private void OnTemplateButtonClick(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            switch (button.Name)
            {
                case "Template1":
                    CashNumeric.Value = 100;
                    break;
                case "Template2":
                    CashNumeric.Value = 500;
                    break;
                case "Template3":
                    CashNumeric.Value = 1000;
                    break;

            }
        }

        private void CashNumeric_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = (NumericUpDown)sender;
            Bill.Cash = (float)numericUpDown.Value;
            InitalizeBill();
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
            var numericUpDown = (NumericUpDown) sender;
            Bill.DiscountValue = (float) numericUpDown.Value;
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
            ChangeValue.Text = Bill.Change.ToString("N0");
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