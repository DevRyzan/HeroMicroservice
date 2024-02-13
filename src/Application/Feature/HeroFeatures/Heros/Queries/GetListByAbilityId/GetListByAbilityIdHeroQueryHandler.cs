using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Core.Persistence.Paging;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByAbilityId;

public class GetListByAbilityIdHeroQueryHandler : IRequestHandler<GetListByAbilityIdHeroQueryRequest, GetListResponse<GetListByAbilityIdHeroQueryResponse>>
{
    private readonly IHeroService _heroService;
    private readonly IMapper _mapper;
    private readonly HeroBusinessRules _heroBusinessRules;

    public GetListByAbilityIdHeroQueryHandler(IHeroService heroService, IMapper mapper, HeroBusinessRules heroBusinessRules)
    {
        _heroService = heroService;
        _mapper = mapper;
        _heroBusinessRules = heroBusinessRules;
    }

    public async Task<GetListResponse<GetListByAbilityIdHeroQueryResponse>> Handle(GetListByAbilityIdHeroQueryRequest request, CancellationToken cancellationToken)
    {
        // Check if the requested Ability exists
        //await _heroBusinessRules.AbilityShouldBeExist(request.AbilityId);

        // Get a paginated list of Heroes by their Ability ID
        var paginateAbility = await _heroService.GetListByAbilityId(abilityId: request.AbilityId, index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        // Map the paginated Hero list to a response DTO
        GetListResponse<GetListByAbilityIdHeroQueryResponse> mappedResponse = _mapper.Map<GetListResponse<GetListByAbilityIdHeroQueryResponse>>(paginateAbility);

        // Return the mapped response containing the list of Heroes with the requested Ability
        return mappedResponse;

    }
}