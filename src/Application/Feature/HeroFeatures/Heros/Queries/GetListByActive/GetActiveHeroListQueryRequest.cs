using Application.Feature.HeroFeatures.Heros.Models;
using Core.Application.Requests;
using Core.Persistence.Paging;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByActive;

public class GetActiveHeroListQueryRequest : IRequest<GetListResponse<HeroListModel>>//, ICachableRequest//, ISecuredRequest 
{
    public PageRequest PageRequest { get; set; }
    //public string CacheKey => $"GetActiveHeroListQueryRequest ({PageRequest.Page},{PageRequest.PageSize})";

    //public string? CacheGroupKey => "GetHeros";

    //public bool BypassCache { get; }

    //public TimeSpan? SlidingExpiration { get; }

    //public string[] Roles => new[] { Admin, HeroGet };

}
