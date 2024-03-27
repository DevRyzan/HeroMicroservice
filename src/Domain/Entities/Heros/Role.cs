

using Core.Persistence.Repositories;

namespace Domain.Entities.Heros;

public class Role : Entity<string>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string IconUrl { get; set; }
}