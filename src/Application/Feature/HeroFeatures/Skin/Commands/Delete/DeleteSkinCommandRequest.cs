using Application.Feature.HeroFeatures.Skin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Delete;

public class DeleteSkinCommandRequest : IRequest<DeleteSkinCommandResponse>
{
    public DeletedSkinDto DeletedSkinDto { get; set; }
}
