using Application.Feature.HeroFeatures.HeroStory.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Remove;

public class RemoveHeroStoryCommandRequest : IRequest<RemoveHeroStoryCommandResponse>
{
    public RemoveHeroStoryDto RemoveHeroStoryDto { get; set; }
}
