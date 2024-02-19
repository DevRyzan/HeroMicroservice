using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Remove;

public class RemoveBardAndHeroCommandRequest : IRequest<RemoveBardAndHeroCommandResponse>
{
    public RemoveBardAndHeroDto RemoveBardAndHeroDto { get; set; }
}
