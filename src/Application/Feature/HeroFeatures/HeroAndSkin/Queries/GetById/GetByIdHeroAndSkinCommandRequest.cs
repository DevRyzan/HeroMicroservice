using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetById;

public class GetByIdHeroAndSkinCommandRequest : IRequest<GetByIdHeroAndSkinCommandResponse>
{
    public GetByIdHeroAndSkin GetByIdHeroAndSkin { get; set; }
}
