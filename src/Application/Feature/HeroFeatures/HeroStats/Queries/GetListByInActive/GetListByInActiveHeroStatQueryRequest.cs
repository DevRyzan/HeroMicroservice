using Application.Feature.HeroFeatures.HeroStats.Queries.GetListByActive;
using Core.Application.Requests;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetListByInActive;

public class GetListByInActiveHeroStatQueryRequest : IRequest<List<GetListByInActiveHeroStatQueryResponse>>
{
    public PageRequest PageRequest { get; set; }

}
