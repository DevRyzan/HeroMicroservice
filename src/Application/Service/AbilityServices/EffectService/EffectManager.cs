using Application.Service.Repositories;
using Domain.Entities.Abilities;


namespace Application.Service.AbilityServices.EffectService;

public class EffectManager : IEffectService
{
    private readonly IEffectRepository _effectRepository;

    public EffectManager(IEffectRepository effectRepository)
    {
        _effectRepository = effectRepository;
    }

    public async Task<Effect> Create(Effect effect)
    {
        return await _effectRepository.AddAsync(effect);
    }

    public async Task<Effect> Delete(Effect effect)
    {
        return await _effectRepository.UpdateAsync(effect.Id, effect);
    }
    public async Task<Effect> Remove(Effect effect)
    {
        return await _effectRepository.DeleteAsync(effect);
    }
    public async Task<Effect> Update(Effect effect)
    {
        return await _effectRepository.UpdateAsync(effect.Id, effect);
    }
    public async Task<Effect> GetById(Guid id)
    {
        return await _effectRepository.GetAsync(x => x.Id.Equals(id));
    }
    public async Task<List<Effect>> GetActiveList(int index = 0, int size = 10)
    {
        return await _effectRepository.GetList(x => x.Status.Equals(true), index: index, size: size);
    }
    public async Task<List<Effect>> GetInActiveList(int index = 0, int size = 10)
    {
        return await _effectRepository.GetList(x => x.Status.Equals(false), index: index, size: size);
    }
}
