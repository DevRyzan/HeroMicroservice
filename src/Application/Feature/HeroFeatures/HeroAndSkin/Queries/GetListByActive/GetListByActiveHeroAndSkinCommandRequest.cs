using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByActive;

public class GetListByActiveHeroAndSkinCommandRequest : IRequest<List<GetListByActiveHeroAndSkinCommandResponse>>
{
    public PageRequest PageRequest { get; set; }
}
