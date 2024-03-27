using Domain.Entities.Items;


namespace Application.Service.ItemServices.ItemSetService;

public interface IItemSetService
{
    Task<ItemSet> Create(ItemSet itemSet);
    Task<ItemSet> Update(ItemSet itemSet);
    Task<ItemSet> Delete(ItemSet itemSet);
    Task<ItemSet> Remove(ItemSet itemSet);
    Task<ItemSet> GetById(Guid id);
    Task<List<ItemSet>> GetActiveList(int index = 0, int size = 10);
    Task<List<ItemSet>> GetInActiveList(int index = 0, int size = 10);
}
