using Application.Service.Repositories;
using Domain.Entities.Items;


namespace Application.Service.ItemServices.SetBonusService;

public class SetBonusManager : ISetBonusService
{
    private readonly ISetBonusRepository _setBonusRepository;

    public SetBonusManager(ISetBonusRepository setBonusRepository)
    {
        _setBonusRepository = setBonusRepository;
    }

    public async Task<SetBonus> Create(SetBonus setBonus)
    {
        return await _setBonusRepository.AddAsync(setBonus);
    }
    public async Task<SetBonus> Delete(SetBonus setBonus)
    {
        return await _setBonusRepository.UpdateAsync(setBonus.Id, setBonus);
    }
    public async Task<SetBonus> Remove(SetBonus setBonus)
    {
        return await _setBonusRepository.DeleteAsync(setBonus);
    }
    public async Task<SetBonus> Update(SetBonus setBonus)
    {
        return await _setBonusRepository.UpdateAsync(setBonus.Id, setBonus);
    }
    public async Task<SetBonus> GetById(Guid id)
    {
        return await _setBonusRepository.GetAsync(x => x.Id.Equals(id));
    }
    public async Task<List<SetBonus>> GetActiveList(int index = 0, int size = 10)
    {
        return await _setBonusRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }
    public async Task<List<SetBonus>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _setBonusRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }
}
