

namespace Application.Feature.HeroFeatures.HeroStats.Commands.Remove;

public class RemoveHeroStatCommandResponse
{
    public Guid Id { get; set; }
    public bool Status { get; set; }
    public bool IsDeleted { get; set; }
}
