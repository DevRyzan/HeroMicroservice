using Application.Service.Repositories;
using Domain.Entities.Heros;

namespace Application.Service.HeroServices.BardAndHeroService;

public class BardAndHeroManager : IBardAndHeroService
{
    private readonly IBardAndHeroRepository _bardAndHeroRepository;

    public BardAndHeroManager(IBardAndHeroRepository bardAndHeroRepository)
    {
        _bardAndHeroRepository = bardAndHeroRepository;
    }

    public async Task<BardAndHero> Create(BardAndHero bardAndHero)
    {
        return await _bardAndHeroRepository.AddAsync(bardAndHero);
    }

    public async Task<BardAndHero> Delete(BardAndHero bardAndHero)
    {
        return await _bardAndHeroRepository.UpdateAsync(bardAndHero.Id,bardAndHero);
    }

    public async Task<List<BardAndHero>> GetActiveList(int index = 0, int size = 10)
    {
        return await _bardAndHeroRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }

    public async Task<BardAndHero> GetById(Guid id)
    {
        return await _bardAndHeroRepository.GetAsync(x => x.Id.Equals(id));
    }

    public async Task<List<BardAndHero>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _bardAndHeroRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }

    public async Task<BardAndHero> Remove(BardAndHero bardAndHero)
    {
        return await _bardAndHeroRepository.DeleteAsync(bardAndHero);
    }
    public async Task<BardAndHero> Update(BardAndHero bardAndHero)
    {
        return await _bardAndHeroRepository.UpdateAsync(bardAndHero.Id, bardAndHero);
    }
}
