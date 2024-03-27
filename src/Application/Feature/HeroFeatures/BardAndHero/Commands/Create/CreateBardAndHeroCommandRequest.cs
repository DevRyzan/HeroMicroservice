using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Create;

public class CreateBardAndHeroCommandRequest : IRequest<CreateBardAndHeroCommandResponse>
{
    public CreateBardAndHeroDto CreateBardAndHeroDto { get; set; }
}
