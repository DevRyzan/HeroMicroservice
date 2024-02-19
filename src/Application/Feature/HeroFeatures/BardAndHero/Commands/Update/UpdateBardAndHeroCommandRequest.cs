using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Update;

public class UpdateBardAndHeroCommandRequest : IRequest<UpdateBardAndHeroCommandResponse>
{
    public UpdateBardAndHeroDto UpdateBardAndHeroDto { get; set; }
}
