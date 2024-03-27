using Application.Service.Repositories;
using Domain.Entities.Heros;

namespace Application.Service.HeroServices.HeroStoryService;

//public class HeroStoryManager : IHeroStoryService
//{
//    private readonly IHeroStoryRepository _heroStoryRepository;

//    public HeroStoryManager(IHeroStoryRepository heroStoryRepository)
//    {
//        _heroStoryRepository = heroStoryRepository;
//    }

//    public async Task<HeroStory> Create(HeroStory heroStory)
//    {
//        return await _heroStoryRepository.AddAsync(heroStory);
//    }

//    public async Task<HeroStory> Delete(HeroStory heroStory)
//    {
//        return await _heroStoryRepository.UpdateAsync(heroStory.Id,heroStory);
//    }

//    public async Task<HeroStory> GetById(Guid id)
//    {
//        return await _heroStoryRepository.GetAsync(x => x.Id.Equals(id));
//    }

//    public async Task<List<HeroStory>> GetListByActive(int index = 0, int size = 10)
//    {
//        return await _heroStoryRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
//    }

//    public async Task<List<HeroStory>> GetListByInActive(int index = 0, int size = 10)
//    {
//        return await _heroStoryRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
//    }

//    public async Task<HeroStory> Remove(HeroStory heroStory)
//    {
//        return await _heroStoryRepository.DeleteAsync(heroStory);
//    }

//    public async Task<HeroStory> Update(HeroStory heroStory)
//    {
//        return await _heroStoryRepository.UpdateAsync(heroStory.Id, heroStory);
//    }
//}
