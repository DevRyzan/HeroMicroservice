using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Queries.GetById;

public class GetByIdBardAndHeroQueryRequest : IRequest<GetByIdBardAndHeroQueryResponse>
{
    public GetByIdBardAndHeroDto GetByIdBardAndHeroDto { get; set; }
}
