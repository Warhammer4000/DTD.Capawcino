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

namespace DTD.Capawcino.UIExtra.CustomUI
{
    public partial class SalesItemUI : BaseControl
    {
        public SalesItem SalesItem { get; set; }

        public delegate void OnAddToCart(SalesItem salesItem);

        public OnAddToCart AddToCartButtonClick;

        public SalesItemUI(Product product)
        {
            InitializeComponent();
            SalesItem=new SalesItem(product);
            NameLable.Text = product.Name;
            if(product.ImagePath!=null)
            pictureBox1.BackgroundImage=Image.FromFile(product.ImagePath);
            AddButton.Click += AddButton_Click;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddToCartButtonClick?.Invoke(SalesItem);
        }
    }
}
