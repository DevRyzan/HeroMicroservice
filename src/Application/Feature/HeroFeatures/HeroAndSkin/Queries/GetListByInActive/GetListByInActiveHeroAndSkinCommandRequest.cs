using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByInActive;

public class GetListByInActiveHeroAndSkinCommandRequest : IRequest<List<GetListByInActiveHeroAndSkinCommandResponse>>
{
    public PageRequest PageRequest { get; set; }
}
