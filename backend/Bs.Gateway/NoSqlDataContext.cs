using Bs.Gateway.Entities;
using MongoDB.Driver;

namespace Bs.Gateway
{
    internal class NoSqlDataContext
    {
        private readonly MongoClient mongoClient;
        private readonly IMongoDatabase database;

        public IMongoCollection<UserEntity> Users {get;set;}

        public NoSqlDataContext(MongoClientSettings mongoClientSettings)
        {
            this.mongoClient = new MongoClient(mongoClientSettings);
            this.database = mongoClient.GetDatabase("BooksStore");

            this.Users = database.GetCollection<UserEntity>("Users");
        }
    }
}