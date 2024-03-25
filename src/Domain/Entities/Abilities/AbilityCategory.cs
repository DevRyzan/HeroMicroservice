

namespace Domain.Entities.Abilities;

public class AbilityCategory
{
    public Dictionary<string, Ability> Passive { get; set; }
    public Dictionary<string, Ability> BaseAttackAbility { get; set; }
    public Dictionary<string, Ability> ActiveAbilities { get; set; }
    public Dictionary<string, Ability> UltimateAbility { get; set; }
}