using Application.Feature.HeroFeatures.BardAndHero.Constants;
using Application.Service.Repositories;
using Core.Application;
using Core.CrossCuttingConcerns.Exceptions;

namespace Application.Feature.HeroFeatures.BardAndHero.Rules;

//public class BardAndHeroBusinessRules : BaseBusinessRules
//{
//    private readonly IBardAndHeroRepository _bardAndHeroRepository;
//    private readonly IHeroRepository _heroRepository;

//    public BardAndHeroBusinessRules(IBardAndHeroRepository bardAndHeroRepository, IHeroRepository heroRepository)
//    {
//        _bardAndHeroRepository = bardAndHeroRepository;
//        _heroRepository = heroRepository;
//    }


//    public async Task IdShouldBeExist(Guid Id)
//    {
//        Domain.Entities.Heros.BardAndHero heroAndSkin = await _bardAndHeroRepository.GetAsync(x => x.Id.Equals(Id));
//        if (heroAndSkin == null) throw new BusinessException(BardAndHeroMessages.IdShouldBeExist);
//    }

//    public async Task HeroIdShouldBeExist(Guid heroId)
//    {
//        Domain.Entities.Heros.Hero hero = await _heroRepository.GetAsync(x => x.Id.Equals(heroId));
//        if (hero == null) throw new BusinessException(BardAndHeroMessages.HeroIdShouldBeExist);
//    }
//    public async Task RemoveCondition(Guid Id)
//    {
//        Domain.Entities.Heros.BardAndHero bardAndHero = await _bardAndHeroRepository.GetAsync(x => x.Id.Equals(Id));
//        if (bardAndHero.IsDeleted == false) throw new BusinessException(BardAndHeroMessages.RemoveCondition);
//        if (bardAndHero.Status == true) throw new BusinessException(BardAndHeroMessages.RemoveCondition);
//    }
//    public async Task PageRequestShouldBeValid(int index, int size)
//    {
//        if (index < 0 || size <= 0) throw new BusinessException(BardAndHeroMessages.PageRequestShouldBeValid);
//    }
//}
