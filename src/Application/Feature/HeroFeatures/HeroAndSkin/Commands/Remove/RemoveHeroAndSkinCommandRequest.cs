using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Remove;

public class RemoveHeroAndSkinCommandRequest : IRequest<RemoveHeroAndSkinCommandResponse>
{
    public RemoveHeroAndSkinDto RemoveHeroAndSkinDto { get; set; }
}
