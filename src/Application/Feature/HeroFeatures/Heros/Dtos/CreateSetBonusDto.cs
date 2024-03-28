

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class CreateSetBonusDto
{
    public string Type { get; set; }
    public string Description { get; set; }
    public List<CreateEffectDto> Effects { get; set; }
    public string EffectUnit { get; set; }
    public bool? IsAbilityActive { get; set; }
}
