
namespace Application.Feature.HeroFeatures.HeroStats.Commands.Create;

public class CreateHeroStatCommandResponse
{
    public Guid Id { get; set; }
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
    public bool Status { get; set; }
    public Guid HeroId { get; set; }
    public DateTime CreatedDate { get; set; }
}
