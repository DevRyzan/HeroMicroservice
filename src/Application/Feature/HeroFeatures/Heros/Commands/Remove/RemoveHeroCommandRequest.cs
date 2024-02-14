
using Application.Feature.HeroFeatures.Heros.Dtos;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Remove;

public class RemoveHeroCommandRequest : IRequest<RemoveHeroCommandResponse>
{
    public RemoveHeroDto RemoveHeroDto { get; set; }
}
