using Core.Application.Requests;
using Core.Persistence.Paging;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByAbilityId;

public class GetListByAbilityIdHeroQueryRequest : IRequest<GetListResponse<GetListByAbilityIdHeroQueryResponse>>//, ICachableRequest//, ISecuredRequest
{
    public Guid AbilityId { get; set; }
    public PageRequest PageRequest { get; set; }
    //public string CacheKey => $"GetListByAbilityIdHeroQueryRequest ({AbilityId},{PageRequest.Page},{PageRequest.PageSize})";

    //public string? CacheGroupKey => "GetHeros";

    //public bool BypassCache { get; }

    //public TimeSpan? SlidingExpiration { get; }

    //public string[] Roles => new[] { Admin, HeroGet };

}