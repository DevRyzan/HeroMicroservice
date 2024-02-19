using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Update;

public class UpdateHeroAndSkinCommandRequest : IRequest<UpdateHeroAndSkinCommandResponse>
{
    public UpdateHeroAndSkinDto UpdateHeroAndSkinDto { get; set; }
}
