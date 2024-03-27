using Application.Feature.HeroFeatures.Heros.Models;
using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities.Heros;
using MediatR;

namespace Application.Feature.HeroFeatures.Heros.Queries.GetListByInActive;

//public class GetListHeroByInActiveQueryHandler : IRequestHandler<GetListHeroByInActiveQueryRequest, GetListResponse<HeroListModel>>
//{
//    private readonly IHeroService _heroService;
//    private readonly IHeroDetailService _heroDetailService;
//    private readonly IMapper _mapper;
//    private readonly HeroBusinessRules _heroBusinessRules;

//    public GetListHeroByInActiveQueryHandler(IHeroService heroService, IHeroDetailService heroDetailService, IMapper mapper, HeroBusinessRules heroBusinessRules)
//    {
//        _heroService = heroService;
//        _heroDetailService = heroDetailService;
//        _mapper = mapper;
//        _heroBusinessRules = heroBusinessRules;
//    }

//    public async Task<GetListResponse<HeroListModel>> Handle(GetListHeroByInActiveQueryRequest request, CancellationToken cancellationToken)
//    {
//        // Comment: Ensure that a list of inactive Heroes is being requested
//        await _heroBusinessRules.HerosShouldBeListedWhenSelected(request.PageRequest.Page, request.PageRequest.PageSize);

//        // Get a paginated list of inactive Heroes
//        List<Hero> heroList = await _heroService.GetInActiveList(request.PageRequest.Page, request.PageRequest.PageSize);

//        // Map the list of inactive Heroes to a response DTO
//        GetListResponse<HeroListModel> mappedHeroListModel = _mapper.Map<GetListResponse<HeroListModel>>(heroList);

//        // Iterate through the mapped Hero list and enrich each item with additional information
//        foreach (var item in mappedHeroListModel.Items)
//        {
//            Guid id = item.Id;

//            // Retrieve detailed information about the Hero and HeroDetail
//            var hero = await _heroService.GetById(id);
//            var heroDetail = await _heroDetailService.GetHeroDetailByHeroId(id);

//            // Update the HeroListModel item with HeroDetail information
//            item.Description = heroDetail.Description;
//            item.Title = heroDetail.Title;
//            item.Story = heroDetail.Story;
//            item.IconUrl = heroDetail.IconUrl;
//            item.GamPrice = heroDetail.GamPrice;
//            item.CreditPrice = heroDetail.CreditPrice;
//        }

//        // Return the mapped and enriched HeroListModel for inactive Heroes
//        return mappedHeroListModel;


//    }
//}