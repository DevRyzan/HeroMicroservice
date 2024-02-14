using Application.Feature.HeroFeatures.Skin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.ChangeStatus;

public class ChangeStatusSkinCommandRequest : IRequest<ChangeStatusSkinCommandResponse>
{
    public ChangedStatusSkinDto ChangedStatusSkinDto { get; set; }
}
