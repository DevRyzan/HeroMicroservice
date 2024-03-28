

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class CreateEffectDto
{

    public string Name { get; set; }
    public double Value { get; set; }
    public int? Damage { get; set; }
    public List<int> DamageUpgrade { get; set; }
    public int? Duration { get; set; }
    public List<int> DurationUpgrade { get; set; }
    public string Type { get; set; }
    public List<int> Upgrade { get; set; }
}
