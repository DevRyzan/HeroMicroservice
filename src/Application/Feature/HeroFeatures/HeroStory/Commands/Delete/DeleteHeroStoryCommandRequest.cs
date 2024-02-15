using Application.Feature.HeroFeatures.HeroStory.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Delete;

public class DeleteHeroStoryCommandRequest : IRequest<DeleteHeroStoryCommandResponse>
{
    public DeleteHeroStoryDto DeleteHeroStoryDto { get; set; }
}
