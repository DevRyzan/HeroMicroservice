using Application.Feature.HeroFeatures.Heros.Models;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Enums;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByDifficultLevel;

public class GetListByDifficultLevelQueryRequest : IRequest<GetListResponse<HeroListModel>>//, ICachableRequest//, ISecuredRequest
{
    public DifficultLevel DifficultLevel { get; set; }
    public PageRequest PageRequest { get; set; }

    //public string CacheKey => $"GetListByDifficultLevelQueryRequest ({DifficultLevel},{PageRequest.Page},{PageRequest.PageSize})";

    //public string? CacheGroupKey => "GetHeros";

    //public bool BypassCache { get; }

    //public TimeSpan? SlidingExpiration { get; }

    //public string[] Roles => new[] { Admin, HeroGet };

}
