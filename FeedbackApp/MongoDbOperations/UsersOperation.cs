using FeedbackApp.DTOs.CategoryDTOs;
using FeedbackApp.DTOs.UserDTOs;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedbackApp.MongoDbOperations
{
    public class UsersOperation
    {
        public List<ResultUserDto> UserList()
        {
            var connection = new MongoDbConnection();
            var userCollection = connection.GetUsersCollection();

            List<ResultUserDto> userList = new List<ResultUserDto>();

            var user = userCollection.Find(new BsonDocument()).ToList();

			foreach (var item in user)
			{
                userList.Add(new ResultUserDto
                {
                    UserId = item["_id"].ToString(),
                    Email = item["Email"].ToString(),
                    Name = item["Name"].ToString()
                });
			}

            return userList;

		}

        public void CreateUser(CreateUserDto createUserDto)
        {
            var connection = new MongoDbConnection();
            var userCollection = connection.GetUsersCollection();

            var user = new BsonDocument
            {
                {"Name",createUserDto.Name },
                {"Email",createUserDto.Email }
            };

            userCollection.InsertOne(user);
        }

        public void UpdateUser(UpdateUserDto updateUserDto)
        {
            var connection = new MongoDbConnection();
            var userCollection = connection.GetUsersCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(updateUserDto.UserId));
            var updatedUser = Builders<BsonDocument>.Update.
                Set("Name", updateUserDto.Name).
                Set("Email", updateUserDto.Email);

            userCollection.UpdateOne(filter, updatedUser);
                
        }

        public void DeleteUser(string id)
        {
            var connection = new MongoDbConnection();
            var userCollection = connection.GetUsersCollection();

            var user = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            userCollection.DeleteOne(user);
        }

        public GetUserDto GetUser(string id)
        {
            var connection = new MongoDbConnection();
            var userCollection = connection.GetUsersCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var user = userCollection.Find(filter).FirstOrDefault();

            var value = new GetUserDto
            {
                Email = user["Email"].ToString(),
                Name = user["Name"].ToString(),
                UserId = user["_id"].ToString()
            };

            return value;
        }
    }
}
