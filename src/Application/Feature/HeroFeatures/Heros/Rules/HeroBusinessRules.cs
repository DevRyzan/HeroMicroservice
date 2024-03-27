using Application.Feature.HeroFeatures.Heros.Constants;
using Application.Service.Repositories;
using Core.Application;
using Core.CrossCuttingConcerns.Exceptions;
using Domain.Entities.Heros;
using Domain.Enums;


namespace Application.Feature.HeroFeatures.Heros.Rules;

public class HeroBusinessRules : BaseBusinessRules
{
    private readonly IHeroRepository _heroRepository;

    public HeroBusinessRules(IHeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }

    //public async Task AbilityShouldBeExist(Guid abiltiyId)
    //{
    //    Domain.Entities.Abilities.Ability ability = await _abilityRepository.GetAsync(x => x.Id.Equals(abiltiyId));
    //    if (ability == null) throw new BusinessException(HeroMessages.AbilityShouldBeExist);
    //}

    public virtual Task HeroShouldBeExist(Hero? hero)
    {
        if (hero == null) throw new BusinessException(HeroMessages.HeroDoesNotExist);
        return Task.CompletedTask;
    }
    //public virtual Task HeroDetailShouldBeExist(HeroDetail? heroDetail)
    //{
    //    if (heroDetail == null) throw new BusinessException(HeroMessages.HeroDetailDoesNotExist);
    //    return Task.CompletedTask;
    //}
    //public virtual Task HeroStatShouldBeExist(HeroStat? heroStat)
    //{
    //    if (heroStat == null) throw new BusinessException(HeroMessages.HeroStatDoesNotExist);
    //    return Task.CompletedTask;
    //}
    //public virtual async Task HeroShouldBeExistsWhenSlecetedHeroType(HeroType heroType)
    //{
    //    Hero? hero = await _heroRepository.GetAsync(a => a.HeroType == heroType);
    //    if (hero == null) throw new BusinessException(HeroMessages.HeroDoesNotExist);
    //}
    public virtual async Task HeroShouldBeExistsWhenSelectedStatus(bool status)
    {
        Hero? hero = await _heroRepository.GetAsync(a => a.Status == status);
        if (hero == null) throw new BusinessException(HeroMessages.HeroDoesNotExist);
    }
    public virtual async Task HeroNameShouldNotBeExist(string name)
    {
        Hero? hero = await _heroRepository.GetAsync(a => a.Name == name);
        if (hero != null) throw new BusinessException(HeroMessages.HeroNameAlreadyExists);
    }
    public virtual async Task HeroNameShouldNotBeExistWithId(string name, string id)
    {
        Hero? hero = await _heroRepository.GetAsync(a => a.Name == name && a.Id != id);
        if (hero != null) throw new BusinessException(HeroMessages.HeroNameAlreadyExists);
    }
    public virtual async Task HeroIdShouldBeExist(string? id)
    {
        Hero? hero = await _heroRepository.GetAsync(a => a.Id == id);
        if (hero == null) throw new BusinessException(HeroMessages.HeroDoesNotExist);
    }
    public virtual async Task HeroTypeShouldBeExists(HeroType heroType)
    {
        var type = new HeroType();
        if (!heroType.Equals(type)) throw new BusinessException(HeroMessages.HeroTypeDontExists);

    }
    public virtual async Task HerosShouldBeListedWhenSelected(int page, int pageSize)
    {
        if (page < 0 || pageSize < 0)
            throw new BusinessException(HeroMessages.PageRequestDontSuccess);
    }


}
