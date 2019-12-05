using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace DTD.Capawcino.Entities
{
    public class Bill
    {
        [Browsable(false)] [BsonId(IdGenerator = typeof(GuidGenerator))] public Guid BillId { get; set; }

        [Browsable(false)] public Guid CustomerID { get; set; }
        public DateTime DateTime { get; set; }
        public List<SalesItem> SalesItem;
        public float Total => SalesItem.Sum(r => r.TotalPrice);
        [Browsable(false)]public bool FlatDiscount { get; set; }
        [Browsable(false)]public float DiscountValue { get; set; }

        [BsonIgnore]
        public float Discount => FlatDiscount ? DiscountValue : Total * DiscountValue / 100;

        [BsonIgnore]public float DiscountedTotal => Total - Discount;
        public float Vat => DiscountedTotal * 0.15f;
        public float GrandTotal => DiscountedTotal + Vat;
        public float Cash { get; set; }
        public float Change => Cash - GrandTotal;
        public bool Paid { get; set; }

        public Bill() { }//for Serializer

        public Bill(DateTime dateTime)
        {
            DateTime=dateTime;
            SalesItem=new List<SalesItem>();
            SalesItem.Add(new SalesItem(new Product() { Name = "Dummy" }));//BUG WORKAROUND

        }





    }
}
