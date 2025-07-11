using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.DTOs.UserDTOs
{
    public class ResultUserDto
    {
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string UserId { get; set; }

		public string Name { get; set; }
		public string Email { get; set; }
	}
}
