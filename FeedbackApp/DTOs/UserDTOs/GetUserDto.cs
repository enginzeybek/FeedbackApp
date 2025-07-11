using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.DTOs.UserDTOs
{
    public class GetUserDto
    {
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string UserId { get; set; }

		public string Name { get; set; }
		public string Email { get; set; }
	}
}
