using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization.IdGenerators;

namespace DTD.Capawcino.Entities
{
    [BsonIgnoreExtraElements]
    public class ProductType
    {

        [BsonId(IdGenerator = typeof(GuidGenerator))] [Browsable(false)] public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }


        public override string ToString()
        {
            return Name;
        }
    }
}
