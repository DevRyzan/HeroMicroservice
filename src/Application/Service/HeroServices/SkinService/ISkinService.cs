using Domain.Entities.Heros;

namespace Application.Service.HeroServices.SkinService;

public interface ISkinService
{
    Task<Skin?> Create(Skin skin);
    Task<Skin?> Remove(Skin skin);
    Task<Skin?> Delete(Skin skin);
    Task<Skin> Update(Skin skin);
    Task<Skin?> GetById(Guid? id);

    Task<List<Skin>> GetListByActive(int index = 0, int size = 10);
    Task<List<Skin>> GetListByInActive(int index = 0, int size = 10);
}
