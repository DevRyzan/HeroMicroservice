using Application.Service.Repositories;
using Domain.Entities.Heros;


namespace Application.Service.HeroServices.HeroStatService;

//public class HeroStatManager : IHeroStatService
//{
//    private readonly IHeroStatRepository _heroStatRepository;

//    public HeroStatManager(IHeroStatRepository heroStatRepository)
//    {
//        _heroStatRepository = heroStatRepository;
//    }

//    public async Task<HeroStat?> Create(HeroStat heroStat)
//    {
//        return await _heroStatRepository.AddAsync(heroStat);
//    }

//    public async Task<HeroStat?> Delete(HeroStat heroStat)
//    {
//        return await _heroStatRepository.UpdateAsync(heroStat.Id, heroStat);
//    }
//    public async Task<HeroStat?> Remove(HeroStat heroStat)
//    {
//        return await _heroStatRepository.DeleteAsync(heroStat);
//    }

//    public async Task<HeroStat> Update(HeroStat heroStat)
//    {
//        return await _heroStatRepository.UpdateAsync(heroStat.Id, heroStat);
//    }
//    public async Task<List<HeroStat>> GetListByActive(int index = 0, int size = 10)
//    {
//        return await _heroStatRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
//    }
//    public async Task<List<HeroStat>> GetListByInActive(int index = 0, int size = 10)
//    {
//        return await _heroStatRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
//    }

//    public async Task<HeroStat?> GetByHeroId(Guid? heroId)
//    {
//        return await _heroStatRepository.GetAsync(x => x.HeroId.Equals(heroId));
//    }

//    public async Task<HeroStat?> GetByHeroIdStatusTrue(Guid? heroId)
//    {
//        return await _heroStatRepository.GetAsync(x => x.HeroId.Equals(heroId) && x.Status.Equals(true));
//    }

//    public async Task<HeroStat?> GetById(Guid? id)
//    {
//        return await _heroStatRepository.GetAsync(x => x.Id.Equals(id));
//    }

//    public async Task<HeroStat?> GetByIdStatusTrue(Guid? id)
//    {
//        return await _heroStatRepository.GetAsync(x => x.Id.Equals(id) && x.Status.Equals(true));
//    }

//    public async Task<HeroStat?> GetHeroStatByHeroStatIdAndHeroId(Guid? heroStatId, Guid? heroId)
//    {
//        return await _heroStatRepository.GetAsync(a => a.Id.Equals(heroStatId) && a.HeroId.Equals(heroId));
//    }

//    public async Task<HeroStat?> GetHeroStatByHeroStatIdAndHeroIdStatusTrue(Guid? heroStatId, Guid? heroId)
//    {
//        return await _heroStatRepository.GetAsync(a => a.Id.Equals(heroStatId) && a.HeroId.Equals(heroId) && a.Status.Equals(true));
//    }

//    public async Task<List<HeroStat>> GetList(int index = 0, int size = 10)
//    {
//        return await _heroStatRepository.GetList(index: index, size: size);
//    }

//}
