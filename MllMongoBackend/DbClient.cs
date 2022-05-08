using MongoDB.Driver;

namespace MllMongoBackend;

public class DbClient : IDbContext
{
    private readonly MongoClient _client;

    public DbClient(string connectionString, string dbName)
    {
        _client = new MongoClient(connectionString);
        Database = _client.GetDatabase(dbName);
    }
    
    public IMongoDatabase Database { get; }
}

public interface IDbContext
{
    IMongoDatabase Database { get; }
}
