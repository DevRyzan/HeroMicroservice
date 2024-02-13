
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Remove;

public class RemoveHeroCommandRequest : IRequest<RemoveHeroCommandResponse>
{
    public Guid Id { get; set; }
}
