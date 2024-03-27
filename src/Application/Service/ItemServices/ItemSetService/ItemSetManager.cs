using Application.Service.Repositories;
using Domain.Entities.Items;


namespace Application.Service.ItemServices.ItemSetService;

public class ItemSetManager : IItemSetService
{
    private readonly IItemSetRepository _itemSetRepository;

    public ItemSetManager(IItemSetRepository itemSetRepository)
    {
        _itemSetRepository = itemSetRepository;
    }

    public async Task<ItemSet> Create(ItemSet itemSet)
    {
        return await _itemSetRepository.AddAsync(itemSet);
    }
    public async Task<ItemSet> Delete(ItemSet itemSet)
    {
        return await _itemSetRepository.UpdateAsync(itemSet.Id, itemSet);
    }
    public async Task<ItemSet> Remove(ItemSet itemSet)
    {
        return await _itemSetRepository.DeleteAsync(itemSet);
    }
    public async Task<ItemSet> Update(ItemSet itemSet)
    {
        return await _itemSetRepository.UpdateAsync(itemSet.Id, itemSet);
    }
    public async Task<ItemSet> GetById(Guid id)
    {
        return await _itemSetRepository.GetAsync(x => x.Id.Equals(id));
    }
    public async Task<List<ItemSet>> GetActiveList(int index = 0, int size = 10)
    {
        return await _itemSetRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }
    public async Task<List<ItemSet>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _itemSetRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }
}
