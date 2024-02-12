using Core.Persistence.Repositories.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace Persistence.Context;

public class BaseDbContext
{
    public IMongoDatabase Database { get; }

    public BaseDbContext(IOptions<MongoDbSettings> options)
    {
        var client = new MongoClient(options.Value.ConnectionString);
        Database = client.GetDatabase(options.Value.Database);
    }
}
