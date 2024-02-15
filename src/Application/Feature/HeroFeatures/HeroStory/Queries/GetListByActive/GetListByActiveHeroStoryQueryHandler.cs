using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Queries.GetListByActive;

public class GetListByActiveHeroStoryQueryHandler : IRequestHandler<GetListByActiveHeroStoryQueryRequest, List<GetListByActiveHeroStoryQueryResponse>>
{
    private readonly IHeroStoryService _heroStoryService;
    private readonly IMapper _mapper;
    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

    public GetListByActiveHeroStoryQueryHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
    {
        _heroStoryService = heroStoryService;
        _mapper = mapper;
        _heroStoryBusinessRules = heroStoryBusinessRules;
    }

    public async Task<List<GetListByActiveHeroStoryQueryResponse>> Handle(GetListByActiveHeroStoryQueryRequest request, CancellationToken cancellationToken)
    {
        await _heroStoryBusinessRules.PageRequestShouldBeValid(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<Domain.Entities.Heros.HeroStory> heroStories = await _heroStoryService.GetListByActive(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<GetListByActiveHeroStoryQueryResponse> mappedResponse = _mapper.Map<List<GetListByActiveHeroStoryQueryResponse>>(heroStories);

        return mappedResponse;

    }
}
