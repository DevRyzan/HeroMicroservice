using Application.Service.Repositories;
using Domain.Entities.Heros;
using Domain.Enums;


namespace Application.Service.HeroServices.HeroService;

public class HeroManager : IHeroService
{
    private readonly IHeroRepository _heroRepository;

    public HeroManager(IHeroRepository heroRepository)
    {
        _heroRepository = heroRepository;
    }
    public async Task<Hero> Create(Hero hero)
    {
        return await _heroRepository.AddAsync(hero);
    }

    public async Task<Hero> Delete(Hero hero)
    {
        return await _heroRepository.UpdateAsync(hero.Id, hero);
    }

    public async Task<Hero> Remove(Hero hero)
    {
        return await _heroRepository.DeleteAsync(hero);
    }

    public async Task<Hero> Update(Hero hero)
    {
        return await _heroRepository.UpdateAsync(hero.Id, hero);
    }

    //public async Task<List<Hero>> GetListByDifficultLevel(DifficultLevel difficultLevel, int index = 0, int size = 10)
    //{
    //    return await _heroRepository.GetList(x => x.DifficultLevel.Equals(difficultLevel), index: index, size: size);
    //}

    //public async Task<List<Hero>> GetByDifficultLevelStatusTrue(DifficultLevel difficultLevel, int index = 0, int size = 10)
    //{
    //    return await _heroRepository.GetList(x => x.DifficultLevel.Equals(difficultLevel) && x.Status.Equals(true), index: index, size: size);
    //}

    //public async Task<Hero> GetByHeroType(HeroType heroType)
    //{
    //    return await _heroRepository.GetAsync(x => x.HeroType.Equals(heroType));
    //}

    //public async Task<Hero> GetByHeroTypeStatusTrue(HeroType heroType)
    //{
    //    return await _heroRepository.GetAsync(x => x.HeroType.Equals(heroType) && x.Status.Equals(true));
    //}

    public async Task<Hero> GetById(Guid id)
    {
        return await _heroRepository.GetAsync(x => x.Id.Equals(id));
    }

    public async Task<Hero> GetByIdAndStatus(Guid id, bool status)
    {
        return await _heroRepository.GetAsync(x => x.Id.Equals(id) && x.Status.Equals(status));
    }

    public async Task<Hero> GetByIdStatusTrue(Guid id)
    {
        return await _heroRepository.GetAsync(x => x.Id.Equals(id) && x.Status.Equals(true));
    }
    public async Task<List<Hero>> GetActiveList(int index = 0, int size = 10)
    {
        return await _heroRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }
    public async Task<List<Hero>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _heroRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }

    public async Task<List<Hero>> GetList(int index = 0, int size = 10)
    {
        return await _heroRepository.GetList(index: index, size: size);
    }

    public async Task<List<Hero>> GetListByAbilityId(Guid abilityId, int index = 0, int size = 10)
    {
        //return await _heroRepository.GetList(x => x.Abilities.Any(t => t.Id.Equals(abilityId)), index: index, size: size);
        throw new NotImplementedException();
    }

    //public async Task<List<Hero>> GetListByHeroTypeAndStatusTrue(HeroType heroType, int index = 0, int size = 10)
    //{
    //    return await _heroRepository.GetList(x => x.HeroType.Equals(heroType) && x.Status.Equals(true), index: index, size: size);
    //}

    public async Task<List<Hero>> GetListByStatus(bool status, int index = 0, int size = 10)
    {
        return await _heroRepository.GetList(x => x.Status.Equals(status), index: index, size: size);
    }

    public async Task<List<Hero>> GetListStatusTrue(int index = 0, int size = 10)
    {
        return await _heroRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }
}
