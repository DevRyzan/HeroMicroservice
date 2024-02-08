using Core.Persistence.Repositories;

namespace Domain.Entities.Heros;

public class HeroStat : Entity<Guid>
{
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

    public Guid HeroId { get; set; }
    public Hero Hero { get; set; }

    public HeroStat()
    {

    }
    //public HeroStat()
    //{
    //    Endurance = Convert.ToDouble(string.Empty);
    //    EnduranceGrowthRate = Convert.ToDouble(string.Empty);
    //    Mind = Convert.ToDouble(string.Empty);
    //    MindGrowthRate = Convert.ToDouble(string.Empty);
    //    Vigour = Convert.ToDouble(string.Empty);
    //    VigourGrowthRate = Convert.ToDouble(string.Empty);
    //    PhysicalDamage = Convert.ToDouble(string.Empty);
    //    MagicalDamage = Convert.ToDouble(string.Empty);
    //    AttackSpeed = Convert.ToDouble(string.Empty);
    //    CastSpeed = Convert.ToDouble(string.Empty);
    //    CriticalChance = Convert.ToDouble(string.Empty);
    //    CriticalDamage = Convert.ToDouble(string.Empty);
    //    Health = Convert.ToDouble(string.Empty);
    //    HealthRegen = Convert.ToDouble(string.Empty);
    //    Mana = Convert.ToDouble(string.Empty);
    //    ManaRegen = Convert.ToDouble(string.Empty);
    //    PhysicalArmor = Convert.ToDouble(string.Empty);
    //    MagicArmor = Convert.ToDouble(string.Empty);
    //    LifeSteal = Convert.ToDouble(string.Empty);
    //    MoveSpeed = Convert.ToDouble(string.Empty);
    //}

    public HeroStat(double endurance, double enduranceGrowthRate, double mind, double mindGrowthRate, double vigour, double vigourGrowthRate, double physicalDamage, double magicalDamage, double attackSpeed, double castSpeed, double criticalChance, double criticalDamage, double health, double healthRegen, double mana, double manaRegen, double physicalArmor, double magicArmor, double lifeSteal, double moveSpeed, Guid heroId)
    {
        Endurance = endurance;
        EnduranceGrowthRate = enduranceGrowthRate;
        Mind = mind;
        MindGrowthRate = mindGrowthRate;
        Vigour = vigour;
        VigourGrowthRate = vigourGrowthRate;
        PhysicalDamage = physicalDamage;
        MagicalDamage = magicalDamage;
        AttackSpeed = attackSpeed;
        CastSpeed = castSpeed;
        CriticalChance = criticalChance;
        CriticalDamage = criticalDamage;
        Health = health;
        HealthRegen = healthRegen;
        Mana = mana;
        ManaRegen = manaRegen;
        PhysicalArmor = physicalArmor;
        MagicArmor = magicArmor;
        LifeSteal = lifeSteal;
        MoveSpeed = moveSpeed;
        HeroId = heroId;
    }

    public HeroStat(Guid id, double endurance, double enduranceGrowthRate, double mind, double mindGrowthRate, double vigour, double vigourGrowthRate, double physicalDamage, double magicalDamage, double attackSpeed, double castSpeed, double criticalChance, double criticalDamage, double health, double healthRegen, double mana, double manaRegen, double physicalArmor, double magicArmor, double lifeSteal, double moveSpeed, Guid heroId) : base(id)
    {
        Id = id;
        Endurance = endurance;
        EnduranceGrowthRate = enduranceGrowthRate;
        Mind = mind;
        MindGrowthRate = mindGrowthRate;
        Vigour = vigour;
        VigourGrowthRate = vigourGrowthRate;
        PhysicalDamage = physicalDamage;
        MagicalDamage = magicalDamage;
        AttackSpeed = attackSpeed;
        CastSpeed = castSpeed;
        CriticalChance = criticalChance;
        CriticalDamage = criticalDamage;
        Health = health;
        HealthRegen = healthRegen;
        Mana = mana;
        ManaRegen = manaRegen;
        PhysicalArmor = physicalArmor;
        MagicArmor = magicArmor;
        LifeSteal = lifeSteal;
        MoveSpeed = moveSpeed;
        HeroId = heroId;
    }
}

