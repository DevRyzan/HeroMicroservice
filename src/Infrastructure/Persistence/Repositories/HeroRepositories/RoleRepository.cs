using Application.Service.Repositories;
using Core.Persistence.Repositories;
using Core.Persistence.Repositories.Settings;
using Domain.Entities.Heros;
using Microsoft.Extensions.Options;


namespace Persistence.Repositories.HeroRepositories;

public class RoleRepository : MongoDbRepositoryBase<Role, string>, IRoleRepository
{
    public RoleRepository(IOptions<MongoDbSettings> options) : base(options)
    {
    }
}
