using Application.Feature.HeroFeatures.Skin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Remove;

public class RemoveSkinCommandRequest : IRequest<RemoveSkinCommandResponse>
{
    public RemoveSkinDto RemoveSkinDto { get; set; }
}
