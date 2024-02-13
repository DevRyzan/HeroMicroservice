using Domain.Entities.Heros;
using Domain.Enums;


namespace Application.Service.HeroServices.HeroService;

public interface IHeroService
{
    Task<Hero> Create(Hero hero);
    Task<Hero> Update(Hero hero);
    Task<Hero> Delete(Hero hero);
    Task<Hero> Remove(Hero hero);
    Task<Hero> GetById(Guid id);

    Task<Hero> GetByIdAndStatus(Guid id, bool status);
    Task<Hero> GetByHeroType(HeroType heroType);
    Task<List<Hero>> GetListByStatus(bool status, int index = 0, int size = 10);
    Task<List<Hero>> GetActiveList(int index = 0, int size = 10);
    Task<List<Hero>> GetInActiveList(int index = 0, int size = 10);
    Task<List<Hero>> GetList(int index = 0, int size = 10);
    Task<List<Hero>> GetListByAbilityId(Guid abilityId, int index = 0, int size = 10);
    Task<List<Hero>> GetListByHeroTypeAndStatusTrue(HeroType heroType, int index = 0, int size = 10);
    Task<List<Hero>> GetListByDifficultLevel(DifficultLevel difficultLevel, int index = 0, int size = 10);



    #region STATUS TRUE
    Task<Hero> GetByIdStatusTrue(Guid id);
    Task<Hero> GetByHeroTypeStatusTrue(HeroType heroType);
    Task<List<Hero>> GetListStatusTrue(int index = 0, int size = 10);
    Task<List<Hero>> GetByDifficultLevelStatusTrue(DifficultLevel difficultLevel, int index = 0, int size = 10);

    #endregion

}