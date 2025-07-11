using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.DTOs.CategoryDTOs
{
    public class GetCategoryDto
    {
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		public string CategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
