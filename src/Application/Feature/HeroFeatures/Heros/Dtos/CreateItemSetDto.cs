using Domain.Entities.Items;

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class CreateItemSetDto
{
    public string SetType { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Icon { get; set; }
    public string Rarity { get; set; }
    public int Cost { get; set; }
    public int Resell { get; set; }
    public List<CreateUniqueItemDto> UniqueItems { get; set; }
    public List<CreateSetBonusDto> SetBonuses { get; set; }
}