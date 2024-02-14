using Application.Feature.HeroFeatures.Skin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetById;

public class GetByIdSkinQueryRequest : IRequest<GetByIdSkinQueryResponse>
{
    public GetByIdSkinDto GetByIdSkinDto { get; set; }
}
