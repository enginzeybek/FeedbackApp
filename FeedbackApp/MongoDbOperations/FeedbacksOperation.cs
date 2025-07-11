using FeedbackApp.DTOs.FeedbackDTOs;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.MongoDbOperations
{
    public class FeedbacksOperation
    {
        public List<ResultFeedbackDto> FeedbackList()
        {
            var connection = new MongoDbConnection();
            var feedbackCollection = connection.GetFeedbacksCollection();

            var mongoFeedback = feedbackCollection.Find(new BsonDocument()).ToList();
            List<ResultFeedbackDto> feedbackList = new List<ResultFeedbackDto>();

			foreach (var item in mongoFeedback)
			{
                feedbackList.Add(new ResultFeedbackDto
                {
                    CategoryId = item["categoryId"].ToString(),
                    FeedbackId = item["_id"].ToString(),
                    Message = item["Message"].ToString(),
                    SubmittedAt = Convert.ToDateTime(item["submittedAt"].ToString()),
                    UserId = item["userId"].ToString()
                });
			}

			return feedbackList;
		}

        public void CreateFeedback(CreateFeedbackDto createFeedbackDto)
        {
            var connection = new MongoDbConnection();
            var feedbackCollection = connection.GetFeedbacksCollection();

            var document = new BsonDocument
            {
                { "userId" , createFeedbackDto.UserId },
                {"categoryId",createFeedbackDto.CategoryId },
                {"Message",createFeedbackDto.Message },
                {"submittedAt",createFeedbackDto.SubmittedAt }
            };

            feedbackCollection.InsertOne(document);
        }

        public void UpdateFeedback(UpdateFeedbackDto updateFeedbackDto)
        {
            var connection = new MongoDbConnection();
            var feedbackCollection = connection.GetFeedbacksCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(updateFeedbackDto.FeedbackId));
            var updatedFeedback = Builders<BsonDocument>.Update.
                Set("userId", updateFeedbackDto.UserId).
                Set("categoryId", updateFeedbackDto.CategoryId).
                Set("Message", updateFeedbackDto.Message).
                Set("submittedAt", updateFeedbackDto.SubmittedAt);

            feedbackCollection.UpdateOne(filter, updatedFeedback);
        }

        public void DeleteFeedback(string id)
        {
			var connection = new MongoDbConnection();
			var feedbackCollection = connection.GetFeedbacksCollection();

            var deletedFeedback = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            feedbackCollection.DeleteOne(deletedFeedback);
		}

        public GetFeedbackDto GetFeedback(string id)
        {
			var connection = new MongoDbConnection();
			var feedbackCollection = connection.GetFeedbacksCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var feedback = feedbackCollection.Find(filter).FirstOrDefault();

            return new GetFeedbackDto
            {
                CategoryId = feedback["categoryId"].ToString(),
                FeedbackId = feedback["_id"].ToString(),
                Message = feedback["Message"].ToString(),
                SubmittedAt = Convert.ToDateTime(feedback["submittedAt"].ToString()),
                UserId = feedback["userId"].ToString()
            };
		}
    }
}
