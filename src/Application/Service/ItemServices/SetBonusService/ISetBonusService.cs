

using Domain.Entities.Items;

namespace Application.Service.ItemServices.SetBonusService;

public interface ISetBonusService
{
    Task<SetBonus> Create(SetBonus setBonus);
    Task<SetBonus> Update(SetBonus setBonus);
    Task<SetBonus> Delete(SetBonus setBonus);
    Task<SetBonus> Remove(SetBonus setBonus);
    Task<SetBonus> GetById(Guid id);
    Task<List<SetBonus>> GetActiveList(int index = 0, int size = 10);
    Task<List<SetBonus>> GetInActiveList(int index = 0, int size = 10);
}
