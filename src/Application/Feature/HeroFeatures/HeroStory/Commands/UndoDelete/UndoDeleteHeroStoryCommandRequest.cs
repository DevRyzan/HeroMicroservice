using Application.Feature.HeroFeatures.HeroStory.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.UndoDelete;

public class UndoDeleteHeroStoryCommandRequest : IRequest<UndoDeleteHeroStoryCommandResponse>
{
    public UndoHeroStoryDto UndoHeroStoryDto { get; set; }
}
