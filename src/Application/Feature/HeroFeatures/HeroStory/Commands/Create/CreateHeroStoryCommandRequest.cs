using Application.Feature.HeroFeatures.HeroStory.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Create;

public class CreateHeroStoryCommandRequest : IRequest<CreateHeroStoryCommandResponse>
{
    public CreateHeroStoryDto CreateHeroStoryDto { get; set; }
}
