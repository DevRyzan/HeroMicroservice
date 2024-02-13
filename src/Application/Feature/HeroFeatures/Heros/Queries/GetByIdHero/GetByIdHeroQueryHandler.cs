using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetByIdHero;

public class GetByIdHeroQueryHandler : IRequestHandler<GetByIdHeroQueryRequest, GetByIdHeroQueryResponse>
{
    private readonly IHeroService _heroService;
    private readonly IHeroDetailService _heroDetailService;
    private readonly IMapper _mapper;
    private readonly HeroBusinessRules _heroBusinessRules;

    public GetByIdHeroQueryHandler(IHeroService heroService, IHeroDetailService heroDetailService, IMapper mapper, HeroBusinessRules heroBusinessRules)
    {
        _heroService = heroService;
        _heroDetailService = heroDetailService;
        _mapper = mapper;
        _heroBusinessRules = heroBusinessRules;
    }

    public async Task<GetByIdHeroQueryResponse> Handle(GetByIdHeroQueryRequest request, CancellationToken cancellationToken)
    {
        // Get the Hero object by its ID
        Hero? hero = await _heroService.GetById(request.Id);

        // Check if the Hero exists
        await _heroBusinessRules.HeroShouldBeExist(hero);

        // Get the HeroDetail associated with the Hero
        HeroDetail heroDetail = await _heroDetailService.GetHeroDetailByHeroId(hero.Id);

        // Check if the HeroDetail exists
        await _heroBusinessRules.HeroDetailShouldBeExist(heroDetail);

        // Map the Hero and HeroDetail properties to a response DTO
        GetByIdHeroQueryResponse response = _mapper.Map<GetByIdHeroQueryResponse>(hero);
        response.Description = heroDetail.Description;
        response.Title = heroDetail.Title;
        response.Story = heroDetail.Story;
        response.IconUrl = heroDetail.IconUrl;
        response.GamPrice = heroDetail.GamPrice;
        response.CreditPrice = heroDetail.CreditPrice;

        // Return the response DTO with Hero and HeroDetail information
        return response;


    }
}