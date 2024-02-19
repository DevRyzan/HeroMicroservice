using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByActive;

public class GetListByActiveHeroAndSkinCommandHandler : IRequestHandler<GetListByActiveHeroAndSkinCommandRequest, List<GetListByActiveHeroAndSkinCommandResponse>>
{
    private readonly IMapper _mapper;
    private readonly IHeroAndSkinService _heroAndSkinService;
    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

    public GetListByActiveHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
    {
        _mapper = mapper;
        _heroAndSkinService = heroAndSkinService;
        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
    }

    public async Task<List<GetListByActiveHeroAndSkinCommandResponse>> Handle(GetListByActiveHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
    {

        await _heroAndSkinBusinessRules.PageRequestShouldBeValid(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<Domain.Entities.Heros.HeroAndSkin> heroAndSkins = await _heroAndSkinService.GetActiveList(index: request.PageRequest.Page, size: request.PageRequest.PageSize);


        List<GetListByActiveHeroAndSkinCommandResponse> mappedResponse = _mapper.Map<List<GetListByActiveHeroAndSkinCommandResponse>>(heroAndSkins);

        return mappedResponse;

    }
}
