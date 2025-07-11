using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.DTOs.FeedbackDTOs
{
    public class ResultFeedbackDto
    {
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string FeedbackId { get; set; }

		public string UserId { get; set; }
		public string CategoryId { get; set; }
		public string Message { get; set; }
		public DateTime SubmittedAt { get; set; }
	}
}
