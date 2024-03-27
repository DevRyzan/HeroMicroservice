
using Domain.Entities.Heros;


namespace Application.Service.HeroServices.RoleService;

public interface IRoleService
{
    Task<Role> Create(Role role);
    Task<Role> Update(Role role);
    Task<Role> Delete(Role role);
    Task<Role> Remove(Role role);
    Task<Role> GetById(Guid id);
    Task<List<Role>> GetActiveList(int index = 0, int size = 10);
    Task<List<Role>> GetInActiveList(int index = 0, int size = 10);
}
