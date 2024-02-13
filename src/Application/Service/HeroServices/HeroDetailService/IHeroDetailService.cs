using Domain.Entities.Heros;

namespace Application.Service.HeroServices.HeroDetailService;

public interface IHeroDetailService
{
    Task<HeroDetail> Create(HeroDetail entity);
    Task<HeroDetail> Remove(HeroDetail entity);
    Task<HeroDetail> Delete(HeroDetail entity);
    Task<HeroDetail> Update(HeroDetail entity);

    Task<HeroDetail> GetHeroDetailByHeroId(Guid heroId);
    Task<HeroDetail> GetHeroDetailByHeroDetailIdAndHeroId(Guid heroDetailId, Guid heroId);
    Task<HeroDetail> GetById(Guid id);

}