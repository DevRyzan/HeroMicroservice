using Application.Service.Repositories;
using Core.Persistence.Repositories.Settings;
using Core.Persistence.Repositories;
using Domain.Entities.Heros;
using Microsoft.Extensions.Options;

namespace Persistence.Repositories.HeroRepositories;

public class HeroAndSkinRepository : MongoDbRepositoryBase<HeroAndSkin, Guid>, IHeroAndSkinRepository
{
    public HeroAndSkinRepository(IOptions<MongoDbSettings> options) : base(options)
    {

    }
}