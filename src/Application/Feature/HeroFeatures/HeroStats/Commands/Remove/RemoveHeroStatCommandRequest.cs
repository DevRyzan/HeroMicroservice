using Application.Feature.HeroFeatures.HeroStats.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStats.Commands.Remove;

public class RemoveHeroStatCommandRequest : IRequest<RemoveHeroStatCommandResponse>
{
    public RemoveHeroStatDto RemoveHeroStatDto { get; set; }
}
