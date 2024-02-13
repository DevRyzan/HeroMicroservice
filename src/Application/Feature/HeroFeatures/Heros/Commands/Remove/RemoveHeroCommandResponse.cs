

namespace Application.Feature.HeroFeatures.Heros.Commands.Remove;

public class RemoveHeroCommandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public Guid HeroDetailId { get; set; }
    public Guid HeroStatId { get; set; }
}
