using Application.Feature.HeroFeatures.Skin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Update;

public class UpdateSkinCommandRequest : IRequest<UpdateSkinCommandResponse>
{
    public UpdateSkinDto UpdateSkinDto { get; set; }
}
