using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;
using Domain.Entities.Heros;


namespace Application.Service.Repositories;

public interface IHeroAndSkinRepository : IReadRepository<HeroAndSkin, Guid>, IWriteRepository<HeroAndSkin, Guid>
{
}
