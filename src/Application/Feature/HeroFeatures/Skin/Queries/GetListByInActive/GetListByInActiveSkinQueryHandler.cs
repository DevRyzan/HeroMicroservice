using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetListByInActive;

public class GetListByInActiveSkinQueryHandler : IRequestHandler<GetListByInActiveSkinQueryRequest, List<GetListByInActiveSkinQueryResponse>>
{
    public Task<List<GetListByInActiveSkinQueryResponse>> Handle(GetListByInActiveSkinQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
