using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Delete;

public class DeleteHeroAndSkinCommandRequest : IRequest<DeleteHeroAndSkinCommandResponse>
{
    public DeleteStatusHeroAndSkinDto DeleteStatusHeroAndSkinDto { get; set; }
}
