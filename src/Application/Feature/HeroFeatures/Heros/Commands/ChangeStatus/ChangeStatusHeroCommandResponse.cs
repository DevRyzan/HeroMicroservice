

namespace Application.Feature.HeroFeatures.Heros.Commands.ChangeStatus;

public class ChangeStatusHeroCommandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
    public DateTime UpdatedDate { get; set; }
}
