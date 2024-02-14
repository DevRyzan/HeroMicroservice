using Application.Feature.HeroFeatures.Heros.Dtos;
using Domain.Enums;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Update;

public class UpdatedHeroCommandRequest : IRequest<UpdatedHeroCommandResponse>
{
    public UpdateHeroDto UpdateHeroDto { get; set; }
}
