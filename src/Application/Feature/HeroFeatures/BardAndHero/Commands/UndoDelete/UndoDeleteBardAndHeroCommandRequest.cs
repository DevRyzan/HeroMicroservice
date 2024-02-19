using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.UndoDelete;

public class UndoDeleteBardAndHeroCommandRequest : IRequest<UndoDeleteBardAndHeroCommandResponse>
{
    public UndoDeleteBardAndHeroDto UndoDeleteBardAndHeroDto { get; set; }
}
