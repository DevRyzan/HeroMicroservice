using Application.Feature.HeroFeatures.Heros.Models;
using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByHeroType;

public class GetListByHeroTypeQueryHandler : IRequestHandler<GetListByHeroTypeQueryRequest, GetListResponse<HeroListModel>>
{
    private readonly IHeroService _heroService;
    private readonly IHeroDetailService _heroDetailService;
    private readonly HeroBusinessRules _heroBusinessRules;
    private readonly IMapper _mapper;

    public GetListByHeroTypeQueryHandler(IHeroService heroService, IHeroDetailService heroDetailService, HeroBusinessRules heroBusinessRules, IMapper mapper)
    {
        _heroService = heroService;
        _heroDetailService = heroDetailService;
        _heroBusinessRules = heroBusinessRules;
        _mapper = mapper;
    }

    public async Task<GetListResponse<HeroListModel>> Handle(GetListByHeroTypeQueryRequest request, CancellationToken cancellationToken)
    {
        // Comment: Ensure that a list of Heroes is being requested
        await _heroBusinessRules.HerosShouldBeListedWhenSelected(request.PageRequest.Page, request.PageRequest.PageSize);

        // Comment: Check if the requested HeroType exists
        await _heroBusinessRules.HeroShouldBeExistsWhenSlecetedHeroType(request.HeroType);

        // Get a paginated list of Heroes filtered by their HeroType and status
        List<Hero> heroList = await _heroService.GetListByHeroTypeAndStatusTrue(request.HeroType, request.PageRequest.Page, request.PageRequest.PageSize);

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