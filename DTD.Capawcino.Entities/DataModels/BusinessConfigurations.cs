using System;
using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace DTD.Capawcino.Entities
{
    public class BusinessConfigurations
    {
        [Browsable(false)] [BsonId(IdGenerator = typeof(GuidGenerator))] public Guid Id { get; set; }
        public float VatAmount;

    }
}
