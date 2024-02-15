using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Queries.GetListByActive;

public class GetListByActiveHeroStoryQueryRequest : IRequest<List<GetListByActiveHeroStoryQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
