using DTD.Capawcino.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DTD.Capawcino.DatabaseManager
{
    public class DatabaseQueries
    {
        private IMongoDatabase database;

        public DatabaseQueries()
        {
            var client = new MongoClient();
            database = client.GetDatabase(DatabaseStrings.DatabseName);
     
        }

        public bool CollectionExists(string collectionName)
        {
            var filter = new BsonDocument("name", collectionName);
            var options = new ListCollectionNamesOptions { Filter = filter };

            return database.ListCollectionNames(options).Any();
        }
    }
}