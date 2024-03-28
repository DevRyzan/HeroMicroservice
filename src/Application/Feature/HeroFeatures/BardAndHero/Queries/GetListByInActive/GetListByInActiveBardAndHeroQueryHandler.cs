 using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Queries.GetListByInActive;

//public class GetListByInActiveBardAndHeroQueryHandler : IRequestHandler<GetListByInActiveBardAndHeroQueryRequest, List<GetListByInActiveBardAndHeroQueryResponse>>
//{
//    private readonly IBardAndHeroService _bardAndHeroService;
//    private readonly IMapper _mapper;
//    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

//    public GetListByInActiveBardAndHeroQueryHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
//    {
//        _bardAndHeroService = bardAndHeroService;
//        _mapper = mapper;
//        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
//    }

//    public async Task<List<GetListByInActiveBardAndHeroQueryResponse>> Handle(GetListByInActiveBardAndHeroQueryRequest request, CancellationToken cancellationToken)
//    {
//        await _bardAndHeroBusinessRules.PageRequestShouldBeValid(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

//        List<Domain.Entities.Heros.BardAndHero> bardAndHeroes = await _bardAndHeroService.GetInActiveList(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

//        List<GetListByInActiveBardAndHeroQueryResponse> mappedResponse = _mapper.Map<List<GetListByInActiveBardAndHeroQueryResponse>>(bardAndHeroes);

//        return mappedResponse;

//    }
//}
