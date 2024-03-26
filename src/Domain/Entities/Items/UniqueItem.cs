using Core.Persistence.Repositories;
using Domain.Entities.Abilities;

namespace Domain.Entities.Items;

public class UniqueItem : Entity<string>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Effect> Effects { get; set; }
}