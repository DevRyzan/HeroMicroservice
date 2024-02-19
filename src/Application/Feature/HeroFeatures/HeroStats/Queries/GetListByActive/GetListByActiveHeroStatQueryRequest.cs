using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetListByActive;

public class GetListByActiveHeroStatQueryRequest : IRequest<List<GetListByActiveHeroStatQueryResponse>>
{
    public PageRequest PageRequest { get; set; }

}
