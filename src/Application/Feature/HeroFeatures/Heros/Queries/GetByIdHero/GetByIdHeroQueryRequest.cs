

using MediatR;

namespace Application.Feature.HeroFeatures.Heros.Queries.GetByIdHero;

public class GetByIdHeroQueryRequest : IRequest<GetByIdHeroQueryResponse>//, ICachableRequest//, ISecuredRequest
{
    public Guid Id { get; set; }

    //public string CacheKey => $"GetByIdHeroQueryRequest ({Id})";

    //public string? CacheGroupKey => "GetHeros";

    //public bool BypassCache { get; }

    //public TimeSpan? SlidingExpiration { get; }

    //public string[] Roles => new[] { Admin, HeroGet };


}
