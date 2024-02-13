
using Domain.Enums;

namespace Application.Feature.HeroFeatures.Heros.Queries.GetByIdHeroAndHeroStat;

public class GetByIdHeroAndHeroStatQueryResponse 
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public DifficultLevel DifficultLevel { get; set; }
    public bool Status { get; set; }
    public HeroType HeroType { get; set; }


    public string Description { get; set; }
    public string Title { get; set; }
    public string Story { get; set; }
    public string IconUrl { get; set; }
    public double GamPrice { get; set; }
    public double CreditPrice { get; set; }

    public double Endurance { get; set; }
    public double EnduranceGrowthRate { get; set; }
    public double Mind { get; set; }
    public double MindGrowthRate { get; set; }
    public double Vigour { get; set; }
    public double VigourGrowthRate { get; set; }
    public double PhysicalDamage { get; set; }
    public double MagicalDamage { get; set; }
    public double AttackSpeed { get; set; }
    public double CastSpeed { get; set; }
    public double CriticalChance { get; set; }
    public double CriticalDamage { get; set; }
    public double Health { get; set; }
    public double HealthRegen { get; set; }
    public double Mana { get; set; }
    public double ManaRegen { get; set; }
    public double PhysicalArmor { get; set; }
    public double MagicArmor { get; set; }
    public double LifeSteal { get; set; }
    public double MoveSpeed { get; set; }
}
