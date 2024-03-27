using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;
using Domain.Entities.Abilities;

namespace Application.Service.Repositories;

public interface IAbilityRepository : IReadRepository<Ability, string>, IWriteRepository<Ability, string>
{
}
