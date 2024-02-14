using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetListByActive;

public class GetListByActiveSkinQueryRequest : IRequest<List<GetListByActiveSkinQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
