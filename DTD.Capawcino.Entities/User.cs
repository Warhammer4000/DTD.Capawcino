using MongoDB.Bson.Serialization.Attributes;

namespace DTD.Capawcino.Entities
{
    public class User
    {
        [BsonId]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Password { get; set; }

    }
}