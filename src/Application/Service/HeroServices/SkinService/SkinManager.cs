using Application.Service.Repositories;
using Domain.Entities.Heros;

namespace Application.Service.HeroServices.SkinService;

//public class SkinManager : ISkinService
//{
//    private readonly ISkinRepository _skinRepository;

//    public SkinManager(ISkinRepository skinRepository)
//    {
//        _skinRepository = skinRepository;
//    }

//    public async Task<Skin?> Create(Skin skin)
//    {
//        return await _skinRepository.AddAsync(skin);
//    }

//    public async Task<Skin?> Delete(Skin skin)
//    {
//        return await _skinRepository.UpdateAsync(skin.Id,skin);
//    }

//    public async Task<Skin?> GetById(Guid? id)
//    {
//        return await _skinRepository.GetAsync(x => x.Id.Equals(id));
//    }

//    public async Task<List<Skin>> GetListByActive(int index = 0, int size = 10)
//    {
//        return await _skinRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
//    }

//    public async Task<List<Skin>> GetListByInActive(int index = 0, int size = 10)
//    {
//        return await _skinRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
//    }

//    public async Task<Skin?> Remove(Skin skin)
//    {
//        return await _skinRepository.DeleteAsync(skin.Id);
//    }

//    public async Task<Skin> Update(Skin skin)
//    {
//        return await _skinRepository.UpdateAsync(skin.Id,skin);
//    }
//}
