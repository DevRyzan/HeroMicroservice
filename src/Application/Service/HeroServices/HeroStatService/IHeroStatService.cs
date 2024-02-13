using Domain.Entities.Heros;


namespace Application.Service.HeroServices.HeroStatService;

public interface IHeroStatService
{
    Task<HeroStat?> Create(HeroStat heroStat);
    Task<HeroStat?> Remove(HeroStat heroStat);
    Task<HeroStat?> Delete(HeroStat heroStat);
    Task<HeroStat> Update(HeroStat heroStat);
    Task<HeroStat?> GetById(Guid? id);
    Task<HeroStat?> GetByHeroId(Guid? heroId);
    Task<HeroStat?> GetHeroStatByHeroStatIdAndHeroId(Guid? heroStatId, Guid? heroId);
    Task<List<HeroStat>> GetList(int index = 0, int size = 10);
    Task<List<HeroStat>> GetListByActive(int index = 0, int size = 10);
    Task<List<HeroStat>> GetListByInActive(int index = 0, int size = 10);


    #region STATUS TRUE
    Task<HeroStat?> GetByIdStatusTrue(Guid? id);
    Task<HeroStat?> GetByHeroIdStatusTrue(Guid? heroId);
    Task<HeroStat?> GetHeroStatByHeroStatIdAndHeroIdStatusTrue(Guid? heroStatId, Guid? heroId);

    #endregion

}
