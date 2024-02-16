using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.UndoDelete;

public class UndoDeleteHeroAndSkinCommandRequest : IRequest<UndoDeleteHeroAndSkinCommandResponse>
{
    public UndoDeleteHeroAndSkinDto UndoDeleteHeroAndSkinDto { get; set; }
}
