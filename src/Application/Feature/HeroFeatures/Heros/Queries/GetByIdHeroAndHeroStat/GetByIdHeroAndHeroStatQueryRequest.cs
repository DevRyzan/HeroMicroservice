
using Application.Feature.HeroFeatures.Heros.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.Heros.Queries.GetByIdHeroAndHeroStat;

public class GetByIdHeroAndHeroStatQueryRequest : IRequest<GetByIdHeroAndHeroStatQueryResponse>//, ICachableRequest//, ISecuredRequest
{
    public GetByIdDto GetByIdDto { get; set; }

    //public string CacheKey => $"GetByIdHeroAndHeroStatQueryRequest ({Id})";

    //public string? CacheGroupKey => "GetHeros";

    //public bool BypassCache { get; }

    //public TimeSpan? SlidingExpiration { get; }

    //public string[] Roles => new[] { Admin, HeroGet };


}
