using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Queries.GetListByInActive;

public class GetListByInActiveHeroStoryQueryRequest : IRequest<List<GetListByInActiveHeroStoryQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
