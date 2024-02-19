using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetListByActive;

public class GetListByActiveHeroStatQuery : IRequestHandler<GetListByActiveHeroStatQueryRequest, List<GetListByActiveHeroStatQueryResponse>>
{
    private readonly IHeroStatService _heroStatService;
    private readonly IMapper _mapper;
    private readonly HeroStatBusinessRules _heroStatBusinessRules;

    public GetListByActiveHeroStatQuery(IHeroStatService heroStatService, IMapper mapper, HeroStatBusinessRules heroStatBusinessRules)
    {
        _heroStatService = heroStatService;
        _mapper = mapper;
        _heroStatBusinessRules = heroStatBusinessRules;
    }

    public async Task<List<GetListByActiveHeroStatQueryResponse>> Handle(GetListByActiveHeroStatQueryRequest request, CancellationToken cancellationToken)
    {
        // Comment: Ensure that a list of active HeroStats is being requested
        await _heroStatBusinessRules.HeroStatListShouldBeListedWhenSelected(request.PageRequest.Page, request.PageRequest.PageSize);

        // Get a paginated list of active HeroStats
        List<HeroStat> heroStatList = await _heroStatService.GetListByActive(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        // Map the list of active HeroStats to a response DTO
        List<GetListByActiveHeroStatQueryResponse> mappedHeroStatListModel = _mapper.Map<List<GetListByActiveHeroStatQueryResponse>>(heroStatList);

        // Return the mapped HeroStatListModel
        return mappedHeroStatListModel;
    }
}
