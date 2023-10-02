using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using VABL.Api.Models;
using VABL.Api.Settings;

namespace VABL.Api.Repositories
{
    public class UserRepository : IUserRepository
    {
        private const string DATABASE_NAME = "VABLDB";
        private const string COLLECTION_NAME = "USERS";
        private readonly IMongoCollection<User> collection;
        private readonly FilterDefinitionBuilder<User> filterBuilder = Builders<User>.Filter;
        public UserRepository(MongoDbSettings settings){
            MongoClient mongoClient = new MongoClient(settings.GetConnectionString());
            IMongoDatabase db = mongoClient.GetDatabase(DATABASE_NAME);
            collection = db.GetCollection<User>(COLLECTION_NAME);
        }
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await collection.Find(new BsonDocument()).ToListAsync();
        }
    }
}