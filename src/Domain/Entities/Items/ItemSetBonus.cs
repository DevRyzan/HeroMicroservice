

namespace Domain.Entities.Items;

public class ItemSetBonus
{
    public string Description { get; set; }
    public Dictionary<string, int?> Effects { get; set; }
    public string EffectUnit { get; set; }
    public bool IsAbilityActive { get; set; }
}
