using Application.Feature.HeroFeatures.HeroStory.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Update;

public class UpdateHeroStoryCommandRequest : IRequest<UpdateHeroStoryCommandResponse>
{
    public UpdateHeroStoryDto UpdateHeroStoryDto { get; set; }
}
