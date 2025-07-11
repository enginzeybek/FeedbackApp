using FeedbackApp.DTOs.CategoryDTOs;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.MongoDbOperations
{
    public class CategoriesOperation
    {
		public List<ResultCategoryDto> CategoryList()
		{
			var connection = new MongoDbConnection();
			var categorycollection = connection.GetCategoriesCollection();

			var category = categorycollection.Find(new BsonDocument()).ToList();
			List<ResultCategoryDto> categoryList = new List<ResultCategoryDto>();

			foreach (var item in category)
			{
				categoryList.Add(new ResultCategoryDto
				{
					CategoryId = item["_id"].ToString(),
					Description = item["Description"].ToString(),
					Name = item["Name"].ToString()
				});
			}

			return categoryList;
		}

		public void AddCategory(CreateCategoryDto createCategoryDto)
		{
			var connection = new MongoDbConnection();
			var categoryCollection = connection.GetCategoriesCollection();

			var category = new BsonDocument
			{
				{"Name",createCategoryDto.Name },
				{"Description",createCategoryDto.Description }
			};

			categoryCollection.InsertOne(category);
		}

		public void UpdateCategory(UpdateCategoryDto updateCategoryDto)
		{
			var connection = new MongoDbConnection();
			var categoryCollection = connection.GetCategoriesCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(updateCategoryDto.CategoryId));
			var updatedCategory = Builders<BsonDocument>.Update.
				Set("Name", updateCategoryDto.Name).
				Set("Description", updateCategoryDto.Description);

			categoryCollection.UpdateOne(filter,updatedCategory);
		}

		public void DeleteCategory(string id)
		{
			var connection = new MongoDbConnection();
			var categoryCollection = connection.GetCategoriesCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

			categoryCollection.DeleteOne(filter);
		}

		public GetCategoryDto GetCategory(string id)
		{
			var connection = new MongoDbConnection();
			var categoryCollection = connection.GetCategoriesCollection();

			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
			var category = categoryCollection.Find(filter).FirstOrDefault();

			return new GetCategoryDto
			{
				CategoryId = category["_id"].ToString(),
				Description = category["Description"].ToString(),
				Name = category["Name"].ToString()
			};
		}

	}
}
