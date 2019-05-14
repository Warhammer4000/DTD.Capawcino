using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace DTD.Capawcino.Entities
{
    public class SalesItem
    {
        [Browsable(false)]
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        [BsonIgnore][DisplayName("Total Price")]public float TotalPrice => Price * Quantity;

        public SalesItem() { }

        public SalesItem(Product product)
        {
            ProductId = product.Id;
            Name = product.Name;
            Price = product.GrandTotal;
        }


    }
}
