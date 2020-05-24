using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using Sync.WebApi.Entities;

namespace Sync.WebApi.Config
{
    public class SyncApiDbContext
    {

        private readonly IMongoDatabase _database = null;

        public IMongoCollection<ProductEntity> products => _database.GetCollection<ProductEntity>("Product");

        public SyncApiDbContext(ISyncDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            if (client != null)
            {
                _database = client.GetDatabase(settings.DatabaseName);
            }
        }

    }
}