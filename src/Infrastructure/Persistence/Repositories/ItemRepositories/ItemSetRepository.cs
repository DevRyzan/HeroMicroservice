using Application.Service.Repositories;
using Core.Persistence.Repositories;
using Core.Persistence.Repositories.Settings;
using Domain.Entities.Items;
using Microsoft.Extensions.Options;


namespace Persistence.Repositories.ItemRepositories;

public class ItemSetRepository : MongoDbRepositoryBase<ItemSet, string>, IItemSetRepository
{
    public ItemSetRepository(IOptions<MongoDbSettings> options) : base(options)
    {
    }
}
