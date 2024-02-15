using Application.Feature.HeroFeatures.HeroStory.Constants;
using Application.Service.HeroServices.HeroService;
using Application.Service.Repositories;
using Core.Application;
using Core.CrossCuttingConcerns.Exceptions;

namespace Application.Feature.HeroFeatures.HeroStory.Rules;

public class HeroStoryBusinessRules : BaseBusinessRules
{
    private readonly IHeroStoryRepository _heroStoryRepository;
    private readonly IHeroRepository  _heroRepository;

    public HeroStoryBusinessRules(IHeroStoryRepository heroStoryRepository, IHeroRepository heroRepository)
    {
        _heroStoryRepository = heroStoryRepository;
        _heroRepository = heroRepository;
    }

    public async Task IdShouldBeExist(Guid Id)
    {
        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryRepository.GetAsync(x => x.Id.Equals(Id));
        if (heroStory == null) throw new BusinessException(HeroStoryMessages.IdShouldBeExist);
    }
    public async Task RemoveCondition(Guid Id)
    {
        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryRepository.GetAsync(x => x.Id.Equals(Id));
        if (heroStory.IsDeleted == false) throw new BusinessException(HeroStoryMessages.RemoveCondition);
        if (heroStory.Status == true) throw new BusinessException(HeroStoryMessages.RemoveCondition);
    }

    public async Task UpdateHeroIdCondition(Guid Id,Guid heroId)
    {
        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryRepository.GetAsync(x => !x.Id.Equals(Id) && x.HeroId.Equals(heroId));
        if (heroStory != null) throw new BusinessException(HeroStoryMessages.UpdateHeroIdCondition);
    }

    public async Task CreateHeroIdCondition(Guid heroId)
    {
        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryRepository.GetAsync(x => x.HeroId.Equals(heroId));
        Domain.Entities.Heros.Hero hero = await _heroRepository.GetAsync(x => x.Id.Equals(heroId));
        if (hero == null) throw new BusinessException(HeroStoryMessages.CreateHeroIdCondition);
        if (heroStory != null) throw new BusinessException(HeroStoryMessages.CreateHeroIdCondition);
    }

    public async Task PageRequestShouldBeValid(int index, int size)
    {
        if (index < 0 || size <= 0) throw new BusinessException(HeroStoryMessages.PageRequestShouldBeValid);
    }
}
