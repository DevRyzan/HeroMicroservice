

namespace Application.Feature.HeroFeatures.HeroStats.Commands.Delete;

public class DeleteHeroStatCommandResponse
{

    public Guid Id { get; set; }
    public bool Status { get; set; }
    public bool IsDeleted { get; set; }
}
