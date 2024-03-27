using Application.Feature.HeroFeatures.HeroStats.Constants;
using Application.Service.Repositories;
using Core.Application;
using Core.CrossCuttingConcerns.Exceptions;
using Domain.Entities.Heros;

namespace Application.Feature.HeroFeatures.HeroStats.Rules;

//public class HeroStatBusinessRules : BaseBusinessRules
//{
//    private readonly IHeroStatRepository _heroStatRepository;
//    private readonly IHeroRepository _heroRepository;

//    public HeroStatBusinessRules(IHeroStatRepository heroStatRepository, IHeroRepository heroRepository)
//    {
//        _heroStatRepository = heroStatRepository;
//        _heroRepository = heroRepository;
//    }
//    public virtual async Task HeroShouldBeExist(Guid id)
//    {
//        Hero hero = await _heroRepository.GetAsync(a => a.Id.Equals(id));
//        if (hero == null) throw new BusinessException(HeroStatMessages.HeroDoesNotExist);
//    }
//    public virtual async Task HeroShouldNotHaveHeroStat(Guid heroId)
//    {
//        HeroStat heroStat = await _heroStatRepository.GetAsync(a => a.HeroId.Equals(heroId));
//        if (heroStat != null) throw new BusinessException(HeroStatMessages.HeroShouldNotHaveHeroStat);
//    }
//    public virtual Task HeroStatShouldBeExist(HeroStat? heroStat)
//    {
//        if (heroStat == null) throw new BusinessException(HeroStatMessages.HeroStatDoesNotExist);
//        return Task.CompletedTask;
//    }
//    public virtual async Task HeroStatShouldBeNotExists(HeroStat? heroStat)
//    {
//        HeroStat getHeroStat = await _heroStatRepository.GetAsync(a => a.Id == heroStat.Id);
//        if (getHeroStat != null) throw new BusinessException(HeroStatMessages.HeroStatShouldBeNotExists);
//    }
//    public async virtual Task HeroStatIdGreaterThanZero(Guid id)
//    {
//        HeroStat getHeroStat = await _heroStatRepository.GetAsync(a => a.Id == id);
//        if (getHeroStat == null) throw new BusinessException(HeroStatMessages.HeroStatDoesNotExist);
//    }

//    public virtual async Task HeroStatListShouldBeListedWhenSelected(int page, int pageSize)
//    {
//        if (page < 0 || pageSize < 0)
//            throw new BusinessException(HeroStatMessages.PageRequestDontSuccess);
//    }
//}
