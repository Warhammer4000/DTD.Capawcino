using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTD.Capawcino.Entities;
using MongoDB.Bson;

namespace DTD.Capawcino.DatabaseManager
{
    public class CRUDManager
    {

        private IMongoDatabase DatabseInterface;

        public CRUDManager()
        {
            var client= new MongoClient();
            DatabseInterface = client.GetDatabase(DatabaseStrings.DatabseName);
        }


        //Insert One
        public void InsertRecord<T>(string table,T record)
        {
            var collection = DatabseInterface.GetCollection<T>(table);
            collection.InsertOne(record);
        }


        //Select All
        public List<T> LoadRecords<T>(string table)
        {
            var collection = DatabseInterface.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }


        //Select By ID
        public T LoadRecordById<T>(string table,Guid id)
        {
            var collection = DatabseInterface.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            return collection.Find(filter).First(); 
        }


        public T LoadRecordByFilter<T>(string table, FilterDefinition<T> filter)
        {
            var collection = DatabseInterface.GetCollection<T>(table);
            return collection.Find(filter).FirstOrDefault();
        }


        //Update or Insert
        public void UpsertRecord<T>(string table,Guid id,T record)
        {
            var collection = DatabseInterface.GetCollection<T>(table);
            var result = collection.ReplaceOne(new BsonDocument("_id", id), record,
                new UpdateOptions {IsUpsert = true});
        }



        //Delete using ID
        public void DeleteRecord<T>(string table,Guid id)
        {
            var collection = DatabseInterface.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("Id", id);
            collection.DeleteOne(filter);
        }
    }
}
