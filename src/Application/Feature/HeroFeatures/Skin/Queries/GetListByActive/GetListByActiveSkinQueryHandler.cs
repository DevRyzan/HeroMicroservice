using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetListByActive;

public class GetListByActiveSkinQueryHandler : IRequestHandler<GetListByActiveSkinQueryRequest, List<GetListByActiveSkinQueryResponse>>
{
    public Task<List<GetListByActiveSkinQueryResponse>> Handle(GetListByActiveSkinQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
