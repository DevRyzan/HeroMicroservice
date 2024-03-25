using Domain.Entities.Abilities;

namespace Domain.Entities.Items;

public class SetBonus
{
    public string Description { get; set; }
    public Dictionary<string, AbilityEffect> Effects { get; set; }
    public string EffectUnit { get; set; }
    public bool IsAbilityActive { get; set; }
}