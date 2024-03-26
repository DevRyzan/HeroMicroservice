using Core.Persistence.Repositories;

namespace Domain.Entities.Abilities;

public class Ability : Entity<string>
{
    public string AbilityType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Effect> Effect { get; set; }
    public string EffectUnit { get; set; }
    public string IconUrl { get; set; }
    public string VideoUrl { get; set; }
    public string TacticalUse { get; set; }
    public bool IsTriggered { get; set; }
    public bool IsBlockable { get; set; }
    public bool IsCondition { get; set; }
    public int SlotNumber { get; set; }
    public string Target { get; set; }
    public List<int> Cooldown { get; set; }
    public object Cost { get; set; }
    public bool? IsBlockeble { get; set; }
}