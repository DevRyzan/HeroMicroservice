using Application.Feature.HeroFeatures.Skin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Create;

public class CreateSkinCommandRequest : IRequest<CreateSkinCommandResponse>
{
    public CreatedSkinDto CreatedSkinDto { get; set; }
}
