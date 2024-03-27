using Application.Service.Repositories;
using Domain.Entities.Items;


namespace Application.Service.ItemServices.UniqueItemService;

public class UniqueItemManager : IUniqueItemService
{
    private readonly IUniqueItemRepository _uniqueItemRepository;

    public UniqueItemManager(IUniqueItemRepository uniqueItemRepository)
    {
        _uniqueItemRepository = uniqueItemRepository;
    }
    
    public async Task<UniqueItem> Create(UniqueItem uniqueItem)
    {
        return await _uniqueItemRepository.AddAsync(uniqueItem);
    }
    public async Task<UniqueItem> Delete(UniqueItem uniqueItem)
    {
        return await _uniqueItemRepository.UpdateAsync(uniqueItem.Id, uniqueItem);
    }
    public async Task<UniqueItem> Remove(UniqueItem uniqueItem)
    {
        return await _uniqueItemRepository.DeleteAsync(uniqueItem);
    }
    public async Task<UniqueItem> Update(UniqueItem uniqueItem)
    {
        return await _uniqueItemRepository.UpdateAsync(uniqueItem.Id, uniqueItem);
    }
    public async Task<UniqueItem> GetById(Guid id)
    {
        return await _uniqueItemRepository.GetAsync(x => x.Id.Equals(id));
    }
    public async Task<List<UniqueItem>> GetActiveList(int index = 0, int size = 10)
    {
        return await _uniqueItemRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }
    public async Task<List<UniqueItem>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _uniqueItemRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }
}
