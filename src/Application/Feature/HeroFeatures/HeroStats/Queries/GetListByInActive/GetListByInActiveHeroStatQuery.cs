using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetListByInActive;

public class GetListByInActiveHeroStatQuery : IRequestHandler<GetListByInActiveHeroStatQueryRequest, List<GetListByInActiveHeroStatQueryResponse>>
{
    private readonly IHeroStatService _heroStatService;
    private readonly IMapper _mapper;
    private readonly HeroStatBusinessRules _heroStatBusinessRules;

    public GetListByInActiveHeroStatQuery(IHeroStatService heroStatService, IMapper mapper, HeroStatBusinessRules heroStatBusinessRules)
    {
        _heroStatService = heroStatService;
        _mapper = mapper;
        _heroStatBusinessRules = heroStatBusinessRules;
    }

    public async Task<List<GetListByInActiveHeroStatQueryResponse>> Handle(GetListByInActiveHeroStatQueryRequest request, CancellationToken cancellationToken)
    {
        // Comment: Ensure that a list of active HeroStats is being requested
        await _heroStatBusinessRules.HeroStatListShouldBeListedWhenSelected(request.PageRequest.Page, request.PageRequest.PageSize);

        // Get a paginated list of active HeroStats
        List<HeroStat> heroStatList = await _heroStatService.GetListByInActive(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        // Map the list of active HeroStats to a response DTO
        List<GetListByInActiveHeroStatQueryResponse> mappedHeroStatListModel = _mapper.Map<List<GetListByInActiveHeroStatQueryResponse>>(heroStatList);

        // Return the mapped HeroStatListModel
        return mappedHeroStatListModel;
    }
}
