using Application.Feature.HeroFeatures.Heros.Models;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Enums;
using MediatR;

namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByHeroType;

public class GetListByHeroTypeQueryRequest : IRequest<GetListResponse<HeroListModel>>//, ICachableRequest//, ISecuredRequest
{
    public HeroType HeroType { get; set; }
    public PageRequest PageRequest { get; set; }
    //public string CacheKey => $"GetListByHeroTypeQueryRequest ({HeroType},{PageRequest.Page},{PageRequest.PageSize})";

    //public string? CacheGroupKey => "GetHeros";

    //public bool BypassCache { get; }

    //public TimeSpan? SlidingExpiration { get; }

    //public string[] Roles => new[] { Admin, HeroGet };

}
