using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Queries.GetListByInActive;

public class GetListByInActiveBardAndHeroQueryRequest : IRequest<List<GetListByInActiveBardAndHeroQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
