

using Domain.Entities.Abilities;

namespace Application.Service.AbilityServices.EffectService;

public interface IEffectService
{
    Task<Effect> Create(Effect effect);
    Task<Effect> Update(Effect effect);
    Task<Effect> Delete(Effect effect);
    Task<Effect> Remove(Effect effect);
    Task<Effect> GetById(Guid id);
    Task<List<Effect>> GetActiveList(int index = 0, int size = 10);
    Task<List<Effect>> GetInActiveList(int index = 0, int size = 10);
}
