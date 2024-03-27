

using Domain.Entities.Items;

namespace Application.Service.ItemServices.UniqueItemService;

public interface IUniqueItemService
{
    Task<UniqueItem> Create(UniqueItem uniqueItem);
    Task<UniqueItem> Update(UniqueItem uniqueItem);
    Task<UniqueItem> Delete(UniqueItem uniqueItem);
    Task<UniqueItem> Remove(UniqueItem uniqueItem);
    Task<UniqueItem> GetById(Guid id);
    Task<List<UniqueItem>> GetActiveList(int index = 0, int size = 10);
    Task<List<UniqueItem>> GetInActiveList(int index = 0, int size = 10);
}
