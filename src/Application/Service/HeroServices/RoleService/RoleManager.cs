using Application.Service.Repositories;
using Domain.Entities.Heros;


namespace Application.Service.HeroServices.RoleService;

public class RoleManager : IRoleService
{
    private readonly IRoleRepository _roleRepository;

    public RoleManager(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<Role> Create(Role role)
    {
        return await _roleRepository.AddAsync(role);
    }
    public async Task<Role> Delete(Role role)
    {
        return await _roleRepository.UpdateAsync(role.Id, role);
    }
    public async Task<Role> Remove(Role role)
    {
        return await _roleRepository.DeleteAsync(role);
    }
    public async Task<Role> Update(Role role)
    {
        return await _roleRepository.UpdateAsync(role.Id, role);
    }
    public async Task<Role> GetById(Guid id)
    {
        return await _roleRepository.GetAsync(x => x.Id.Equals(id));
    }
    public async Task<List<Role>> GetActiveList(int index = 0, int size = 10)
    {
        return await _roleRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }
    public async Task<List<Role>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _roleRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }
}