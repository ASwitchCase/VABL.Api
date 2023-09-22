using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using VABL.Api.Settings;
using VABL.Api.Models;
using MongoDB.Bson;

namespace VABL.Api.Repositories
{
    public class LockerRepository : ILockerRepository
    {
        private const string DATABASE_NAME = "VABLDB";
        private const string COLLECTION_NAME = "LOCKERLIST";
        private readonly IMongoCollection<LockerList> collection;
        private readonly FilterDefinitionBuilder<LockerList> filterBuilder = Builders<LockerList>.Filter;
        public LockerRepository(MongoDbSettings settings){
            MongoClient mongoClient = new MongoClient(settings.GetConnectionString());
            IMongoDatabase db = mongoClient.GetDatabase(DATABASE_NAME);
            collection = db.GetCollection<LockerList>(COLLECTION_NAME);
        }
        public async Task<LockerList> AddAsync(LockerList newList)
        {
            await collection.InsertOneAsync(newList);
            return await Task.FromResult(newList);
        }

        public async Task DeleteAsync(string id)
        {
            var filter = filterBuilder.Eq(l => l.id,id);
            await collection.DeleteOneAsync(filter);
        }

        public async Task<LockerList> GetAsync(string id)
        {
            var filter = filterBuilder.Eq(l => l.id,id);
            return await collection.Find(filter).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<LockerList>> GetAllAsync()
        {
            return await collection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<LockerList> UpdateAsync(string id, LockerList newList)
        {
            var filter = filterBuilder.Eq(l => l.id,id);
            await collection.ReplaceOneAsync(filter, newList);
            
            return await Task.FromResult(newList);
        }
    }
}