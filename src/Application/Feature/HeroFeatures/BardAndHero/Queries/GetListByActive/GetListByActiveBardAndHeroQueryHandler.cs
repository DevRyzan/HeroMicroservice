using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Queries.GetListByActive;

public class GetListByActiveBardAndHeroQueryHandler : IRequestHandler<GetListByActiveBardAndHeroQueryRequest, List<GetListByActiveBardAndHeroQueryResponse>>
{
    private readonly IBardAndHeroService _bardAndHeroService;
    private readonly IMapper _mapper;
    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

    public GetListByActiveBardAndHeroQueryHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
    {
        _bardAndHeroService = bardAndHeroService;
        _mapper = mapper;
        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
    }

    public async Task<List<GetListByActiveBardAndHeroQueryResponse>> Handle(GetListByActiveBardAndHeroQueryRequest request, CancellationToken cancellationToken)
    {

        await _bardAndHeroBusinessRules.PageRequestShouldBeValid(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<Domain.Entities.Heros.BardAndHero> bardAndHeroes = await _bardAndHeroService.GetActiveList(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<GetListByActiveBardAndHeroQueryResponse> mappedResponse = _mapper.Map<List<GetListByActiveBardAndHeroQueryResponse>>(bardAndHeroes);

        return mappedResponse;
    }
}
