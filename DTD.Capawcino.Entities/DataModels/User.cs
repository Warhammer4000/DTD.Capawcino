using System;
using System.ComponentModel;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace DTD.Capawcino.Entities
{
    [BsonIgnoreExtraElements]
    public class User
    {
     
        [BsonId(IdGenerator = typeof(GuidGenerator))] [Browsable(false)] public Guid Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }

    }
}