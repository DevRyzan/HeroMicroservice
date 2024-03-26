using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;
using Domain.Entities.Items;

namespace Application.Service.Repositories;

public interface ISetBonusRepository : IReadRepository<SetBonus, string>, IWriteRepository<SetBonus, string>
{
}
