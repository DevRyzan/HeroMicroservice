

using System.Text.Json.Serialization;

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class CreateAbilityDto
{
    public string AbilityType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<CreateEffectDto>? Effects { get; set; }
    public string EffectUnit { get; set; }
    public string IconUrl { get; set; }
    public string VideoUrl { get; set; }
    public string TacticalUse { get; set; }
    public bool IsTriggered { get; set; }
    public bool IsBlockable { get; set; }
    public bool IsCondition { get; set; }
    public int SlotNumber { get; set; }
    public string Target { get; set; }
    public List<int>? Cooldown { get; set; }

    public List<int>? Cost { get; set; }
}
