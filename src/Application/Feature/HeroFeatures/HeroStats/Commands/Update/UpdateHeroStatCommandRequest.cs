using Application.Feature.HeroFeatures.HeroStats.Dtos;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Update;

public class UpdateHeroStatCommandRequest : IRequest<UpdateHeroStatCommandResponse>
{
    public UpdateHeroStatDto UpdateHeroStatDto { get; set; }
}
