﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace DTD.Capawcino.Entities
{
    [BsonIgnoreExtraElements]
    public class Product
    {
        [BsonId(IdGenerator = typeof(GuidGenerator))] [Browsable(false)] public Guid Id { get; set; }


        public string Name { get; set; }
        public ProductType ProductType { get; set; }
        public List<Tag> TagsList { get; set; }

        [Browsable(false)] public string ImagePath { get; set; }


        public float Cost { get; set; }

        [Browsable(false)]
        public bool FlatProfit { get; set; }
        [Browsable(false)]
        public float ProfitValue { get; set; }

        [BsonIgnore]
        public float Profit => FlatProfit ? ProfitValue : Cost * ProfitValue / 100;

        public float Royality { get; set; }

        [BsonIgnore]  public float Total => Cost + Profit + Royality;


        [Browsable(false)]
        public bool FlatDiscount { get; set; }
        [Browsable(false)]
        public float DiscountValue { get; set; }

        [BsonIgnore] [DisplayName("Discount")] public float DiscountAmount => FlatDiscount ? DiscountValue : Total * DiscountValue / 100;

        [BsonIgnore]  public float GrandTotal => Total - DiscountAmount;

        
    }
}
