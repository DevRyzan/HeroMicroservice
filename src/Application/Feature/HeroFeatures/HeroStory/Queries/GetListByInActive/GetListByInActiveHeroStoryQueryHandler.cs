using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Queries.GetListByInActive;

public class GetListByInActiveHeroStoryQueryHandler : IRequestHandler<GetListByInActiveHeroStoryQueryRequest, List<GetListByInActiveHeroStoryQueryResponse>>
{
    private readonly IHeroStoryService _heroStoryService;
    private readonly IMapper _mapper;
    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

    public GetListByInActiveHeroStoryQueryHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
    {
        _heroStoryService = heroStoryService;
        _mapper = mapper;
        _heroStoryBusinessRules = heroStoryBusinessRules;
    }

    public async Task<List<GetListByInActiveHeroStoryQueryResponse>> Handle(GetListByInActiveHeroStoryQueryRequest request, CancellationToken cancellationToken)
    {
        await _heroStoryBusinessRules.PageRequestShouldBeValid(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<Domain.Entities.Heros.HeroStory> heroStories = await _heroStoryService.GetListByInActive(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<GetListByInActiveHeroStoryQueryResponse> mappedResponse = _mapper.Map<List<GetListByInActiveHeroStoryQueryResponse>>(heroStories);

        return mappedResponse;
    }
}
