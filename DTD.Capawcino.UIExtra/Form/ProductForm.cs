using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTD.Capawcino.Entities;

namespace DTD.Capawcino.UIExtra.Form
{
    public partial class ProductForm : BaseForm
    {
        public Product Product { get; set; }

        private bool FlatProfit => Flat.Checked;
        private bool FlatDiscount => FlatDiscountButton.Checked;

        public ProductForm()
        {
            InitializeComponent();
            Product = new Product(){Name = "New Product"};
            EventSubscription();
       
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

        }

        private void UpdateComuptedData(bool fromEvent=false)
        {
            if (!fromEvent)
            {
                ProfitValue_ValueChanged(new Object(), new EventArgs());
                DiscountValue_ValueChanged(new Object(), new EventArgs());
            }
            

            Total.Value = (decimal) Product.Total;
            DiscountAmount.Value = (decimal)Product.DiscountAmount;
           
            Profit.Value = (decimal) Product.Profit;

            GrandTotalNumeric.Value = (decimal)Product.GrandTotal;
           
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void NewImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Product.ImagePath = openFileDialog.FileName;
                pictureBox.BackgroundImage=Image.FromFile(Product.ImagePath);
            }
        }

       

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            Product.Name = NameTextBox.Text;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product.ProductType = (ProductType) TypeComboBox.SelectedItem;
            UpdateComuptedData();
        }


        private void CostNumeric_ValueChanged(object sender, EventArgs e)
        {
            Product.Cost = (float)CostNumeric.Value;
            UpdateComuptedData();
        }


        

        private void Royalty_ValueChanged(object sender, EventArgs e)
        {
            Product.Royality = (float)Royalty.Value;
            UpdateComuptedData();
        }

        private void ProfitValue_ValueChanged(object sender, EventArgs e)
        {
            if (FlatProfit)
            {
                Profit.Value = ProfitValue.Value;
            }
            else
            {
                Profit.Value = CostNumeric.Value * ProfitValue.Value/100;
            }

            Product.FlatProfit = FlatProfit;
            Product.ProfitValue = (float)ProfitValue.Value;
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

            Product.FlatDiscount = FlatDiscount;
            Product.DiscountValue = (float)DiscountValue.Value;
            UpdateComuptedData(true);
        }


        private void Percent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComuptedData();
            
        }

        
    }
}
