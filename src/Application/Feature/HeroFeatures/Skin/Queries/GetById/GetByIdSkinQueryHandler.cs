using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetById;

public class GetByIdSkinCommandHandler : IRequestHandler<GetByIdSkinQueryRequest, GetByIdSkinQueryResponse>
{
    public Task<GetByIdSkinQueryResponse> Handle(GetByIdSkinQueryRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
