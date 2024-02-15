using Domain.Entities.Heros;

namespace Application.Service.HeroServices.HeroStoryService;

public interface IHeroStoryService
{
    Task<HeroStory> Create(HeroStory heroStory);
    Task<HeroStory> Update(HeroStory heroStory);
    Task<HeroStory> Delete(HeroStory heroStory);
    Task<HeroStory> Remove(HeroStory heroStory);

    Task<HeroStory> GetById(Guid id);
    Task<List<HeroStory>> GetListByActive(int index = 0, int size = 10);
    Task<List<HeroStory>> GetListByInActive(int index = 0, int size = 10);
}
