using Application.Service.Repositories;
using Domain.Entities.Heros;


namespace Application.Service.HeroServices.HeroAndSkinService;

public class HeroAndSkinManager : IHeroAndSkinService
{

    private readonly IHeroAndSkinRepository _heroAndSkinRepository;

    public HeroAndSkinManager(IHeroAndSkinRepository heroAndSkinRepository)
    {
        _heroAndSkinRepository = heroAndSkinRepository;
    }

    public async Task<HeroAndSkin> Create(HeroAndSkin heroAndSkin)
    {
        return await _heroAndSkinRepository.AddAsync(heroAndSkin);
    }

    public async Task<HeroAndSkin> Delete(HeroAndSkin heroAndSkin)
    {
        return await _heroAndSkinRepository.UpdateAsync(heroAndSkin.Id, heroAndSkin);
    }

    public async Task<HeroAndSkin> Remove(HeroAndSkin heroAndSkin)
    {
        return await _heroAndSkinRepository.DeleteAsync(heroAndSkin);
    }

    public async Task<HeroAndSkin> Update(HeroAndSkin heroAndSkin)
    {
        return await _heroAndSkinRepository.UpdateAsync(heroAndSkin.Id, heroAndSkin);
    }

    public async Task<List<HeroAndSkin>> GetActiveList(int index = 0, int size = 10)
    {
        return await _heroAndSkinRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }

    public async Task<HeroAndSkin> GetById(Guid id)
    {
        return await _heroAndSkinRepository.GetAsync(x => x.Id.Equals(id));
    }

    public async Task<HeroAndSkin> GetByIdByStatusTrue(Guid id)
    {
        return await _heroAndSkinRepository.GetAsync(x => x.Id.Equals(id) && x.Status == true);
    }

    public async Task<List<HeroAndSkin>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _heroAndSkinRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }

    public async Task<List<HeroAndSkin>> GetList(int index = 0, int size = 10)
    {
        return await _heroAndSkinRepository.GetList(index: index, size: size);
    }

    public async Task<List<HeroAndSkin>> GetListByHeroId(Guid heroId, int index = 0, int size = 10)
    {
        return await _heroAndSkinRepository.GetList(x => x.HeroId.Equals(heroId), index: index, size: size);
    }

    public async Task<List<HeroAndSkin>> GetListByHeroIdByStatusTrue(Guid heroId, int index = 0, int size = 10)
    {
        return await _heroAndSkinRepository.GetList(x => x.HeroId.Equals(heroId) && x.Status.Equals(true), index: index, size: size);
    }

    public async Task<List<HeroAndSkin>> GetListBySkinId(Guid skinId, int index = 0, int size = 10)
    {
        return await _heroAndSkinRepository.GetList(x => x.SkinId.Equals(skinId), index: index, size: size);
    }

    public async Task<List<HeroAndSkin>> GetListBySkinIdByStatusTrue(Guid skinId, int index = 0, int size = 10)
    {
        return await _heroAndSkinRepository.GetList(x => x.SkinId.Equals(skinId) && x.Status.Equals(true), index: index, size: size);
    }


}