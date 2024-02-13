using Application.Feature.HeroFeatures.Heros.Models;
using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByDifficultLevel;

public class GetActiveListByDifficultLevelQueryHandler : IRequestHandler<GetListByDifficultLevelQueryRequest, GetListResponse<HeroListModel>>
{
    private readonly IHeroService _heroService;
    private readonly IHeroDetailService _heroDetailService;
    private readonly HeroBusinessRules _heroBusinessRules;
    private readonly IMapper _mapper;

    public GetActiveListByDifficultLevelQueryHandler(IHeroService heroService, IHeroDetailService heroDetailService, HeroBusinessRules heroBusinessRules, IMapper mapper)
    {
        _heroService = heroService;
        _heroDetailService = heroDetailService;
        _heroBusinessRules = heroBusinessRules;
        _mapper = mapper;
    }

    public async Task<GetListResponse<HeroListModel>> Handle(GetListByDifficultLevelQueryRequest request, CancellationToken cancellationToken)
    {
        // Comment: Ensure that a list of Heroes is being requested
        await _heroBusinessRules.HerosShouldBeListedWhenSelected(request.PageRequest.Page, request.PageRequest.PageSize);

        // Get a paginated list of Heroes filtered by their difficulty level
        List<Hero> heroList = await _heroService.GetListByDifficultLevel(request.DifficultLevel, request.PageRequest.Page, request.PageRequest.PageSize);

        // Map the filtered Hero list to a response DTO
        GetListResponse<HeroListModel> mappedHeroListModel = _mapper.Map<GetListResponse<HeroListModel>>(heroList);

        // Iterate through the mapped Hero list and enrich each item with additional information
        foreach (var item in mappedHeroListModel.Items)
        {
            Guid id = item.Id;

            // Retrieve detailed information about the Hero and HeroDetail
            var hero = await _heroService.GetById(id);
            var heroDetail = await _heroDetailService.GetHeroDetailByHeroId(id);

            // Update the HeroListModel item with HeroDetail information
            item.Description = heroDetail.Description;
            item.Title = heroDetail.Title;
            item.Story = heroDetail.Story;
            item.IconUrl = heroDetail.IconUrl;
            item.GamPrice = heroDetail.GamPrice;
            item.CreditPrice = heroDetail.CreditPrice;
        }

        // Return the mapped and enriched HeroListModel
        return mappedHeroListModel;

    }
}