using Application.Feature.HeroFeatures.HeroStory.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Queries.GetById;

public class GetByIdHeroStoryQueryRequest : IRequest<GetByIdHeroStoryQueryResponse>
{
    public GetByIdHeroStoryDto GetByIdHeroStoryDto { get; set; }
}
