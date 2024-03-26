using Application.Service.Repositories;
using Core.Persistence.Repositories;
using Core.Persistence.Repositories.Settings;
using Domain.Entities.Items;
using Microsoft.Extensions.Options;

namespace Persistence.Repositories.ItemRepositories;

public class UniqueItemRepository : MongoDbRepositoryBase<UniqueItem, string>, IUniqueItemRepository
{
    public UniqueItemRepository(IOptions<MongoDbSettings> options) : base(options)
    {
    }
}
