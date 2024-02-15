using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Queries.GetById;

public class GetByIdHeroStoryQueryHandler : IRequestHandler<GetByIdHeroStoryQueryRequest, GetByIdHeroStoryQueryResponse>
{
    private readonly IHeroStoryService _heroStoryService;
    private readonly IMapper _mapper;
    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

    public GetByIdHeroStoryQueryHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
    {
        _heroStoryService = heroStoryService;
        _mapper = mapper;
        _heroStoryBusinessRules = heroStoryBusinessRules;
    }

    public async Task<GetByIdHeroStoryQueryResponse> Handle(GetByIdHeroStoryQueryRequest request, CancellationToken cancellationToken)
    {

        await _heroStoryBusinessRules.IdShouldBeExist(Id: request.GetByIdHeroStoryDto.Id);

        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryService.GetById(id: request.GetByIdHeroStoryDto.Id);

        GetByIdHeroStoryQueryResponse mappedResponse = _mapper.Map<GetByIdHeroStoryQueryResponse>(heroStory);

        return mappedResponse;
    }
}
