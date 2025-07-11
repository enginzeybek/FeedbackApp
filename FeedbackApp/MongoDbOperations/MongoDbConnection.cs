using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.MongoDbOperations
{
    public class MongoDbConnection
    {
        private IMongoDatabase _mongoDatabase;

		public MongoDbConnection()
		{
			var client = new MongoClient("mongodb://localhost:27017");

			_mongoDatabase = client.GetDatabase("FeedbackApp");
		}

		public IMongoCollection<BsonDocument> GetCategoriesCollection()
		{
			return _mongoDatabase.GetCollection<BsonDocument>("Categories");
		}

		public IMongoCollection<BsonDocument> GetFeedbacksCollection()
		{
			return _mongoDatabase.GetCollection<BsonDocument>("Feedbacks");
		}

		public IMongoCollection<BsonDocument> GetUsersCollection()
		{
			return _mongoDatabase.GetCollection<BsonDocument>("Users");
		}


	}
}
