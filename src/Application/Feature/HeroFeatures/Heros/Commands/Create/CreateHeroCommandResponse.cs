using Domain.Entities.Abilities;
using Domain.Entities.Heros;
using Domain.Entities.Items;

namespace Application.Feature.HeroFeatures.Heros.Commands.Create;
public class CreateHeroCommandResponse
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Role> Role { get; set; }
    public int HealthPoint { get; set; }
    public double HealthRegeneration { get; set; }
    public int ManaPoint { get; set; }
    public double ManaRegeneration { get; set; }
    public int MoveSpeed { get; set; }
    public double AttackTime { get; set; }
    public double CriticalChance { get; set; }
    public double CriticalDamageMod { get; set; }
    public double EvadeChance { get; set; }
    public List<Ability> Ability { get; set; }
    public List<ItemSet> ItemSet { get; set; }
}
