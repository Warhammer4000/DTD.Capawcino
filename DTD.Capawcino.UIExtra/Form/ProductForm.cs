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

        public ProductForm()
        {
            InitializeComponent();
            Product = new Product(){Name = "New Product"};
       
       
        }

      
        private void UpdateComuptedData()
        {
            Total.Value = (decimal) Product.Total;
            VatNumeric.Value = (decimal) Product.Vat;
            GrandTotalNumeric.Value = (decimal) Product.GrandTotal;
            Profit.Value = (decimal) Product.Profit;
            ProfitValue_ValueChanged(new Object(),new EventArgs());
            
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
            Product.ProductType = TypeComboBox.SelectedItem.ToString();
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
        }

        private void Percent_CheckedChanged(object sender, EventArgs e)
        {
            UpdateComuptedData();
            
        }
    }
}
