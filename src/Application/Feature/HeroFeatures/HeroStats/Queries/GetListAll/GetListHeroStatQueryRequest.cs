using Application.Feature.HeroFeatures.HeroStats.Dtos;
using Core.Application.Requests;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetListAll;

public class GetListHeroStatQueryRequest : IRequest<List<GetListHeroStatQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
