using Application.Feature.HeroFeatures.Heros.Models;
using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetListHero;

public class GetListHeroQueryHandler : IRequestHandler<GetListHeroQueryRequest, GetListResponse<HeroListModel>>
{
    private readonly IHeroService _heroService;
    private readonly IHeroDetailService _heroDetailService;
    private readonly IMapper _mapper;
    private readonly HeroBusinessRules _heroBusinessRules;

    public GetListHeroQueryHandler(IHeroService heroService, IHeroDetailService heroDetailService, IMapper mapper, HeroBusinessRules heroBusinessRules)
    {
        _heroService = heroService;
        _heroDetailService = heroDetailService;
        _mapper = mapper;
        _heroBusinessRules = heroBusinessRules;
    }

    public async Task<GetListResponse<HeroListModel>> Handle(GetListHeroQueryRequest request, CancellationToken cancellationToken)
    {

        // Comment: Ensure that a list of Heroes is being requested
        await _heroBusinessRules.HerosShouldBeListedWhenSelected(request.PageRequest.Page, request.PageRequest.PageSize);

        // Get a paginated list of Heroes
        List<Hero> heroList = await _heroService.GetList(request.PageRequest.Page, request.PageRequest.PageSize);

        // Map the list of Heroes to a response DTO
        GetListResponse<HeroListModel> mappedHeroListModel = _mapper.Map<GetListResponse<HeroListModel>>(heroList);

        // Iterate through the mapped Hero list and enrich each item with additional information
        foreach (var item in mappedHeroListModel.Items)
        {
            // Get the Hero and HeroDetail associated with each item
            var hero = await _heroService.GetById(item.Id);
            var heroDetail = await _heroDetailService.GetHeroDetailByHeroId(item.Id);

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