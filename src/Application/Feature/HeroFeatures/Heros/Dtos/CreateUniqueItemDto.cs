

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class CreateUniqueItemDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<CreateEffectDto> Effects { get; set; }
}
