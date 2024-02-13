using Application.Feature.HeroFeatures.Heros.Models;
using Core.Application.Requests;
using Core.Persistence.Paging;
using MediatR;

namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByInActive;

public class GetListHeroByInActiveQueryRequest : IRequest<GetListResponse<HeroListModel>>//, ICachableRequest//, ISecuredRequest
{
    public PageRequest PageRequest { get; set; }
    //public string CacheKey => $"GetListHeroByInActiveQueryRequest ({PageRequest.Page},{PageRequest.PageSize})";

    //public string? CacheGroupKey => "GetHeros";

    //public bool BypassCache { get; }

    //public TimeSpan? SlidingExpiration { get; }

    //public string[] Roles => new[] { Admin, HeroGet };

}
