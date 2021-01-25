using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WindowsFormsApp1
{
    class DALayer
    {
        public MongoClient client = new MongoClient("mongodb://localhost:27017");

        public IMongoDatabase GetDataBase()
        {
            IMongoDatabase database = client.GetDatabase("gameshow");
            return database;
        }

        public IMongoCollection<BsonDocument> Get_BSON_collection(String tblName) {
            IMongoDatabase database = GetDataBase();
            IMongoCollection<BsonDocument> collection = database.GetCollection<BsonDocument>(tblName);
            return collection;
        }
        
        public List<BsonDocument> Query_SELECT_O_FROM_TABLE(String tblName)
        {
            IMongoCollection<BsonDocument> collection = Get_BSON_collection(tblName);
            List<BsonDocument> documents = collection.Find(new BsonDocument()).Limit(15).ToList();
            return documents;
        }
    }
}
