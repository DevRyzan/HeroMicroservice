

namespace Domain.Entities.Abilities;

public class Ability
{
    public string Description { get; set; }
    public string Targeting { get; set; }
    public Dictionary<string, AbilityEffect> Effects { get; set; }
    public string EffectUnit { get; set; }
    public List<int>? Cooldown { get; set; }
    public List<int>? Cost { get; set; }
    public string IconUrl { get; set; }
    public string VideoUrl { get; set; }
    public string TacticalUse { get; set; }
    public bool IsTriggered { get; set; }
    public bool IsBlockeble { get; set; }
    public bool IsCondition { get; set; }
    public int SlotNumber { get; set; }
}