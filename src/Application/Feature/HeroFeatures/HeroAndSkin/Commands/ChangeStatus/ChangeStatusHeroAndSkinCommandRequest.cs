using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.ChangeStatus;

public class ChangeStatusHeroAndSkinCommandRequest : IRequest<ChangeStatusHeroAndSkinCommandResponse>
{
    public ChangeStatusHeroAndSkinDto ChangeStatusHeroAndSkinDto { get; set; }
}

