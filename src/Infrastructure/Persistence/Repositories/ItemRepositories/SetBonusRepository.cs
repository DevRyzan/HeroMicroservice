using Application.Service.Repositories;
using Core.Persistence.Repositories;
using Core.Persistence.Repositories.Settings;
using Domain.Entities.Items;
using Microsoft.Extensions.Options;


namespace Persistence.Repositories.ItemRepositories;

public class SetBonusRepository : MongoDbRepositoryBase<SetBonus, string>, ISetBonusRepository
{
    public SetBonusRepository(IOptions<MongoDbSettings> options) : base(options)
    {
    }
}
