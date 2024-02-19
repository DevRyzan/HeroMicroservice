using Application.Feature.HeroFeatures.HeroAndSkin.Constants;
using Application.Service.Repositories;
using Core.Application;
using Core.CrossCuttingConcerns.Exceptions;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Rules;

public class HeroAndSkinBusinessRules : BaseBusinessRules
{
    private readonly IHeroAndSkinRepository _heroAndSkinRepository;
    private readonly IHeroRepository _heroRepository;
    private readonly ISkinRepository _skinRepository;

    public HeroAndSkinBusinessRules(IHeroAndSkinRepository heroAndSkinRepository, IHeroRepository heroRepository, ISkinRepository skinRepository)
    {
        _heroAndSkinRepository = heroAndSkinRepository;
        _heroRepository = heroRepository;
        _skinRepository = skinRepository;
    }

    public async Task HeroShouldBeExist(Guid heroId) 
    {
        Domain.Entities.Heros.Hero hero = await _heroRepository.GetAsync(x => x.Id.Equals(heroId));
        if (hero == null) throw new BusinessException(HeroAndSkinMessages.HeroShouldBeExist);
    }

    public async Task SkinShouldBeExist(Guid skinId)
    {
        Domain.Entities.Heros.Skin skin = await _skinRepository.GetAsync(x => x.Id.Equals(skinId));
        if (skin == null) throw new BusinessException(HeroAndSkinMessages.SkinShouldBeExist);
    }

    public async Task IdShouldBeExist(Guid Id)
    {
        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinRepository.GetAsync(x => x.Id.Equals(Id));
        if (heroAndSkin == null) throw new BusinessException(HeroAndSkinMessages.IdShouldBeExist);
    }
    public async Task RemoveCondition(Guid Id)
    {
        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinRepository.GetAsync(x => x.Id.Equals(Id));
        if (heroAndSkin.IsDeleted == false) throw new BusinessException(HeroAndSkinMessages.RemoveCondition);
        if (heroAndSkin.Status == true) throw new BusinessException(HeroAndSkinMessages.RemoveCondition);
    }
    public async Task PageRequestShouldBeValid(int index, int size)
    {
        if (index < 0 || size <= 0) throw new BusinessException(HeroAndSkinMessages.PageRequestShouldBeValid);
    }
}
