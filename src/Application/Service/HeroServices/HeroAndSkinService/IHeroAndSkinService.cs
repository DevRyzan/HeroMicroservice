using Core.Persistence.Paging;
using Domain.Entities.Heros;

namespace Application.Service.HeroServices.HeroAndSkinService;

public interface IHeroAndSkinService
{
    Task<HeroAndSkin> Create(HeroAndSkin heroAndSkin);
    Task<HeroAndSkin> Update(HeroAndSkin heroAndSkin);
    Task<HeroAndSkin> Delete(HeroAndSkin heroAndSkin);
    Task<HeroAndSkin> Remove(HeroAndSkin heroAndSkin);

    Task<HeroAndSkin> GetById(Guid id);
    Task<List<HeroAndSkin>> GetListByHeroId(Guid heroId, int index = 0, int size = 10);
    Task<List<HeroAndSkin>> GetListBySkinId(Guid skinId, int index = 0, int size = 10);
    Task<List<HeroAndSkin>> GetList(int index = 0, int size = 10);
    Task<List<HeroAndSkin>> GetActiveList(int index = 0, int size = 10);
    Task<List<HeroAndSkin>> GetInActiveList(int index = 0, int size = 10);

    Task<HeroAndSkin> GetByIdByStatusTrue(Guid id);
    Task<List<HeroAndSkin>> GetListByHeroIdByStatusTrue(Guid heroId, int index = 0, int size = 10);
    Task<List<HeroAndSkin>> GetListBySkinIdByStatusTrue(Guid skinId, int index = 0, int size = 10);
}