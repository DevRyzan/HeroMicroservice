using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Queries.GetListByActive;

public class GetListByActiveBardAndHeroQueryRequest : IRequest<List<GetListByActiveBardAndHeroQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
