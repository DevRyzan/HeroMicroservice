using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Delete;

public class DeleteBardAndHeroCommandRequest : IRequest<DeleteBardAndHeroCommandResponse>
{
    public DeleteBardAndHeroDto DeleteBardAndHeroDto { get; set; }
}
