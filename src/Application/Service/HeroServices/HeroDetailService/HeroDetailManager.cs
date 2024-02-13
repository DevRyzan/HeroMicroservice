

using Application.Service.Repositories;
using Domain.Entities.Heros;

namespace Application.Service.HeroServices.HeroDetailService;

public class HeroDetailManager : IHeroDetailService
{
    private readonly IHeroDetailRepository _heroDetailRepository;

    public HeroDetailManager(IHeroDetailRepository heroDetailRepository)
    {
        _heroDetailRepository = heroDetailRepository;
    }

    public async Task<HeroDetail> Create(HeroDetail entity)
    {
        return await _heroDetailRepository.AddAsync(entity);
    }

    public async Task<HeroDetail> Delete(HeroDetail entity)
    {
        return await _heroDetailRepository.UpdateAsync(entity.Id, entity);
    }
    public async Task<HeroDetail> Remove(HeroDetail entity)
    {
        return await _heroDetailRepository.DeleteAsync(entity);
    }

    public async Task<HeroDetail> Update(HeroDetail entity)
    {
        return await _heroDetailRepository.UpdateAsync(entity.Id, entity);
    }

    public async Task<HeroDetail> GetById(Guid id)
    {
        return await _heroDetailRepository.GetAsync(x => x.Id.Equals(id));
    }

    public async Task<HeroDetail> GetHeroDetailByHeroDetailIdAndHeroId(Guid heroDetailId, Guid heroId)
    {
        return await _heroDetailRepository.GetAsync(a => a.Id == heroDetailId && a.HeroId.Equals(heroId));
    }

    public async Task<HeroDetail> GetHeroDetailByHeroId(Guid heroId)
    {
        return await _heroDetailRepository.GetAsync(x => x.HeroId.Equals(heroId));
    }

    
}
