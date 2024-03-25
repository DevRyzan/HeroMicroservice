

namespace Domain.Entities.Heros;

public class Stat
{
    public int Vigour { get; set; }
    public double VigourGrowthRate { get; set; }
    public int Endurance { get; set; }
    public double EnduranceGrowthRate { get; set; }
    public int Mind { get; set; }
    public double MindGrowthRate { get; set; }
    public double AttackTime { get; set; }
    public double CriticalChance { get; set; }
    public int HealthPoint { get; set; }
    public double HealthRegeneration { get; set; }
    public int ManaPoint { get; set; }
    public double ManaRegeneration { get; set; }
    public int MoveSpeed { get; set; }
}