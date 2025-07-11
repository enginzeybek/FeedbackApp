using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.DTOs.FeedbackDTOs
{
    public class GetFeedbackDto
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
