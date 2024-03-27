using Core.Persistence.Repositories;
using Domain.Entities.Abilities;

namespace Domain.Entities.Items;

public class SetBonus : Entity<string>
{
    public string Type { get; set; }
    public string Description { get; set; }
    public List<Effect> Effect { get; set; }
    public string EffectUnit { get; set; }
    public bool? IsAbilityActive { get; set; }
}