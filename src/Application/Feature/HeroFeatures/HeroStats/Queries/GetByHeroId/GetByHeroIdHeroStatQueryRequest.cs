using Application.Feature.HeroFeatures.HeroStats.Dtos;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetByHeroId;

public class GetByHeroIdHeroStatQueryRequest : IRequest<GetByHeroIdHeroStatQueryResponse>
{
    public GetByHeroIdDto GetByHeroIdDto { get; set; }
}
