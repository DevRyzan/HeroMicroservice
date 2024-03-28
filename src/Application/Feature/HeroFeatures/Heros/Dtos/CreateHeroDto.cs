using Domain.Entities.Items;


namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class CreateHeroDto
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<CreateRoleDto>? Roles { get; set; }
    public int HealthPoint { get; set; }
    public double HealthRegeneration { get; set; }
    public int ManaPoint { get; set; }
    public double ManaRegeneration { get; set; }
    public int MoveSpeed { get; set; }
    public double AttackTime { get; set; }
    public double? CriticalChance { get; set; }
    public double? CriticalDamageMod { get; set; }
    public double? EvadeChance { get; set; }
    public List<CreateAbilityDto> Abilities { get; set; }
    public List<CreateItemSetDto>? ItemSets { get; set; }
}