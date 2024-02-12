using Core.Persistence.Repositories.ReadRepositories;
using Core.Persistence.Repositories.WriteRepositories;
using Domain.Entities.Heros;


namespace Application.Service.Repositories;

public interface ISkinRepository : IReadRepository<Skin, Guid>, IWriteRepository<Skin, Guid>
{
}
