using Application.Feature.HeroFeatures.HeroStory.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.ChangeStatus;

public class ChangeStatusHeroStoryCommandRequest : IRequest<ChangeStatusHeroStoryCommandResponse>
{
    public ChangeStatusHeroStoryDto ChangeStatusHeroStoryDto { get; set; }
}
