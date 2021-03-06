﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DTD.Capawcino.DatabaseManager;
using DTD.Capawcino.Entities;
using DTD.Capawcino.UIExtra.Form;

namespace DTD.Capawcino.UIExtra.Controls
{
    public partial class ProductsView : BaseControl
    {
        public List<Product> Products;
        public Product SelectedProduct;


        internal ProductsView()
        {
            InitializeComponent();
            UpdateGrid();
            if (Products.Count > 0)
            {
                SelectedProduct = Products[0];
                InitializeData();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ProductForm productForm=new ProductForm();
            if (productForm.ShowDialog()==DialogResult.OK)
            {
                CRUDManager crudManager=new CRUDManager();
                crudManager.InsertRecord(DatabaseStrings.ProductTable,productForm.Product);
            }
            UpdateGrid();
           
        }

        private void UpdateGrid()
        {
            CRUDManager crudManager = new CRUDManager();
            Products = crudManager.LoadRecords<Product>(DatabaseStrings.ProductTable);
            DatagridView.DataSource = null;
            DatagridView.DataSource = Products;
           
        }

        private void DatagridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateGrid();
        }


        #region ProductView

        private bool FlatProfit => Flat.Checked;
        private bool FlatDiscount => FlatDiscountButton.Checked;
        private List<ProductType> ProductTypes=>new CRUDManager().LoadRecords<ProductType>(DatabaseStrings.TypeTable);

        private void InitializeData()
        {
            EventUnSubscription();
            try
            {
                pictureBox.BackgroundImage = Image.FromFile(SelectedProduct.ImagePath);
            }
            catch (Exception e)
            {
                pictureBox.BackgroundImage = null;
            }
           
            NameTextBox.Text = SelectedProduct.Name;
            TypeComboBox.DataSource = null;
            TypeComboBox.DataSource = ProductTypes;
            TypeComboBox.SelectedItem = SelectedProduct.ProductType;
            ProfitValue.Value = (decimal)SelectedProduct.ProfitValue;
            CostNumeric.Value = (decimal) SelectedProduct.Cost;
            Royalty.Value = (decimal) SelectedProduct.Royality;
            if (!SelectedProduct.FlatProfit) Percent.Checked = true;
            if (!SelectedProduct.FlatDiscount) PercentDiscount.Checked = true;
            DiscountValue.Value = (decimal)SelectedProduct.DiscountValue;

            EventSubscription();

            UpdateComuptedData();
        }


        private void EventSubscription()
        {
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            TypeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            ProfitValue.ValueChanged += ProfitValue_ValueChanged;
            CostNumeric.ValueChanged += CostNumeric_ValueChanged;
            Royalty.ValueChanged += Royalty_ValueChanged;
            Percent.CheckedChanged += Percent_CheckedChanged;
            Flat.CheckedChanged += Percent_CheckedChanged;
            FlatDiscountButton.CheckedChanged += Percent_CheckedChanged;
            PercentDiscount.CheckedChanged += Percent_CheckedChanged;
            DiscountValue.ValueChanged += DiscountValue_ValueChanged;

            DatagridView.CellMouseClick += DatagridView_CellMouseClick;
            DatagridView.CellValueChanged += DatagridView_CellValueChanged;
        }


        private void EventUnSubscription()
        {
            NameTextBox.TextChanged -= NameTextBox_TextChanged;
            TypeComboBox.SelectedIndexChanged -= TypeComboBox_SelectedIndexChanged;
            ProfitValue.ValueChanged -= ProfitValue_ValueChanged;
            CostNumeric.ValueChanged -= CostNumeric_ValueChanged;
            Royalty.ValueChanged -= Royalty_ValueChanged;
            Percent.CheckedChanged -= Percent_CheckedChanged;
            Flat.CheckedChanged -= Percent_CheckedChanged;
            FlatDiscountButton.CheckedChanged -= Percent_CheckedChanged;
            PercentDiscount.CheckedChanged -= Percent_CheckedChanged;
            DiscountValue.ValueChanged -= DiscountValue_ValueChanged;

            DatagridView.CellMouseClick -= DatagridView_CellMouseClick;
            DatagridView.CellValueChanged -= DatagridView_CellValueChanged;
        }

        private void UpdateComuptedData(bool fromEvent=false)
        {
            if (!fromEvent)
            {
                ProfitValue_ValueChanged(new object(), new EventArgs());
                DiscountValue_ValueChanged(new object(), new EventArgs());
            }
            

            Total.Value = (decimal) SelectedProduct.Total;
            Profit.Value = (decimal)SelectedProduct.Profit;
            DiscountAmount.Value = (decimal) SelectedProduct.DiscountAmount;
            GrandTotalNumeric.Value = (decimal) SelectedProduct.GrandTotal;
          
            
        }


        private void NewImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                SelectedProduct.ImagePath = openFileDialog.FileName;
                pictureBox.BackgroundImage = Image.FromFile(SelectedProduct.ImagePath);
            }
        }


        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SelectedProduct.Name = NameTextBox.Text;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProduct.ProductType = (ProductType) TypeComboBox.SelectedItem;
            UpdateComuptedData();
        }


        private void CostNumeric_ValueChanged(object sender, EventArgs e)
        {
            SelectedProduct.Cost = (float) CostNumeric.Value;
            UpdateComuptedData();
        }


       

        private void Royalty_ValueChanged(object sender, EventArgs e)
        {
            SelectedProduct.Royality = (float) Royalty.Value;
            UpdateComuptedData();
        }






        private void ProfitValue_ValueChanged(object sender, EventArgs e)
        {
            SelectedProduct.FlatProfit = FlatProfit;
            SelectedProduct.ProfitValue = (float)ProfitValue.Value;

            if (FlatProfit)
                Profit.Value = ProfitValue.Value;
            else
                Profit.Value = CostNumeric.Value * ProfitValue.Value / 100;

            UpdateComuptedData(true);
            
        }




        private void DiscountValue_ValueChanged(object sender, EventArgs e)
        {
            if (FlatDiscount)
            {
                DiscountAmount.Value = DiscountValue.Value;
            }
            else
            {
                DiscountAmount.Value = Total.Value * DiscountValue.Value / 100;
            }

            SelectedProduct.FlatDiscount = FlatDiscount;
            SelectedProduct.DiscountValue = (float)DiscountValue.Value;
            UpdateComuptedData(true);
        }


        private void Percent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComuptedData();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;
            new CRUDManager().UpsertRecord(DatabaseStrings.ProductTable, SelectedProduct.Id, SelectedProduct);
            UpdateGrid();
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (SelectedProduct == null) return;
            if(MessageBox.Show(@"This will delete from Database",@"Are you sure?",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)!=DialogResult.OK)return;


            new CRUDManager().DeleteRecord<Product>(DatabaseStrings.ProductTable, SelectedProduct.Id);
            UpdateGrid();
        }

        #endregion

        private void DatagridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            if (index<=0)
            {
                index= 0;
            }
            SelectedProduct = (Product)DatagridView.Rows[index].DataBoundItem;
            InitializeData();
        }

        private void ProductConfigButton_Click(object sender, EventArgs e)
        {
            ProductConfigForm productConfigForm=new ProductConfigForm();
            productConfigForm.ShowDialog();
        }

       
    }
}
