using Core.Persistence.Repositories.Settings;
using Core.Persistence.Repositories;
using Domain.Entities.Heros;
using Application.Service.Repositories;
using Microsoft.Extensions.Options;


namespace Persistence.Repositories.HeroRepositories;

public class HeroRepository : MongoDbRepositoryBase<Hero, Guid>, IHeroRepository
{
    public HeroRepository(IOptions<MongoDbSettings> options) : base(options)
    {

    }
}
