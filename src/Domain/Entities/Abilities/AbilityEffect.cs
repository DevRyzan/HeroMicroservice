

namespace Domain.Entities.Abilities;

public class AbilityEffect
{
    public string Name { get; set; }
    public double? Value { get; set; }
    public int? Base { get; set; }
    public int? Duration { get; set; }
    public string? Type { get; set; }
    public List<int>? Upgrades { get; set; }
    public int? Stun { get; set; }
}