using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetListAll;

public class GetListHeroStatQuery : IRequestHandler<GetListHeroStatQueryRequest, List<GetListHeroStatQueryResponse>>
{
    private readonly IHeroStatService _heroStatService;
    private readonly HeroStatBusinessRules _heroStatBusinessRules;
    private readonly IMapper _mapper;

    public GetListHeroStatQuery(IHeroStatService heroStatService, HeroStatBusinessRules heroStatBusinessRules, IMapper mapper)
    {
        _heroStatService = heroStatService;
        _heroStatBusinessRules = heroStatBusinessRules;
        _mapper = mapper;
    }

    public async Task<List<GetListHeroStatQueryResponse>> Handle(GetListHeroStatQueryRequest request, CancellationToken cancellationToken)
    {
        // Comment: Ensure that a list of HeroStats is being requested
        await _heroStatBusinessRules.HeroStatListShouldBeListedWhenSelected(request.PageRequest.Page, request.PageRequest.PageSize);

        // Get a paginated list of HeroStats
        List<HeroStat> heroStatList = await _heroStatService.GetList(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        // Map the list of HeroStats to a response DTO
        List<GetListHeroStatQueryResponse> mappedHeroStatListModel = _mapper.Map<List<GetListHeroStatQueryResponse>>(heroStatList);

        // Return the mapped HeroStatListModel
        return mappedHeroStatListModel;
    }
}
