using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Create;

public class CreateHeroAndSkinCommandRequest : IRequest<CreateHeroAndSkinCommandResponse>
{
    public CreateStatusHeroAndSkinDto CreateStatusHeroAndSkinDto { get; set; }
}
