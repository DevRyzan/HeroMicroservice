
using Domain.Entities.Abilities;

namespace Domain.Entities.Items;

public class Item
{
    public string Description { get; set; }
    public Dictionary<string, AbilityEffect> Effects { get; set; }
    public string EffectUnit { get; set; }
    public int? Cost { get; set; }
    public int? Resell { get; set; }
    public string Rarity { get; set; }
    public string IconUrl { get; set; }
    public bool IsTriggered { get; set; }
    public bool Stackable { get; set; }
    public int MaxStackSize { get; set; }
}