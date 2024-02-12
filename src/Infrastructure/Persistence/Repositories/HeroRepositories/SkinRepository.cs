using Application.Service.Repositories;
using Core.Persistence.Repositories.Settings;
using Core.Persistence.Repositories;
using Domain.Entities.Heros;
using Microsoft.Extensions.Options;

namespace Persistence.Repositories.HeroRepositories;

public class SkinRepository : MongoDbRepositoryBase<Skin, Guid>, ISkinRepository
{
    public SkinRepository(IOptions<MongoDbSettings> options) : base(options)
    {

    }
}
