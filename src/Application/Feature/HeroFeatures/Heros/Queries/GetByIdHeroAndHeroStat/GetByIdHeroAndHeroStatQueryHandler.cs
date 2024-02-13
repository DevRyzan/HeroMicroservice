using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Queries.GetByIdHeroAndHeroStat;

public class GetByIdHeroAndHeroStatQueryHandler : IRequestHandler<GetByIdHeroAndHeroStatQueryRequest, GetByIdHeroAndHeroStatQueryResponse>
{
    private readonly IHeroService _heroService;
    private readonly IHeroDetailService _heroDetailService;
    private readonly IHeroStatService _heroStatService;
    private readonly IMapper _mapper;
    private readonly HeroBusinessRules _heroBusinessRules;

    public GetByIdHeroAndHeroStatQueryHandler(IHeroService heroService, IHeroDetailService heroDetailService, IHeroStatService heroStatService, IMapper mapper, HeroBusinessRules heroBusinessRules)
    {
        _heroService = heroService;
        _heroDetailService = heroDetailService;
        _heroStatService = heroStatService;
        _mapper = mapper;
        _heroBusinessRules = heroBusinessRules;
    }

    public async Task<GetByIdHeroAndHeroStatQueryResponse> Handle(GetByIdHeroAndHeroStatQueryRequest request, CancellationToken cancellationToken)
    {
        // Get the Hero object by its ID
        Hero hero = await _heroService.GetById(request.Id);

        // Check if the Hero exists
        await _heroBusinessRules.HeroShouldBeExist(hero);

        // Get the HeroDetail associated with the Hero
        HeroDetail heroDetail = await _heroDetailService.GetHeroDetailByHeroId(hero.Id);

        // Check if the HeroDetail exists
        await _heroBusinessRules.HeroDetailShouldBeExist(heroDetail);

        // Get the HeroStat associated with the Hero
        HeroStat heroStat = await _heroStatService.GetByHeroId(hero.Id);

        // Check if the HeroStat exists
        await _heroBusinessRules.HeroStatShouldBeExist(heroStat);

        // Map the Hero and HeroDetail properties to a response DTO
        GetByIdHeroAndHeroStatQueryResponse heroAndHeroStatDto = _mapper.Map<GetByIdHeroAndHeroStatQueryResponse>(hero);
        heroAndHeroStatDto.Description = heroDetail.Description;
        heroAndHeroStatDto.Title = heroDetail.Title;
        heroAndHeroStatDto.Story = heroDetail.Story;
        heroAndHeroStatDto.GamPrice = heroDetail.GamPrice;
        heroAndHeroStatDto.CreditPrice = heroDetail.CreditPrice;
        heroAndHeroStatDto.IconUrl = heroDetail.IconUrl;

        // Map the HeroStat properties to the response DTO
        heroAndHeroStatDto.Vigour = heroStat.Vigour;
        heroAndHeroStatDto.VigourGrowthRate = heroStat.VigourGrowthRate;
        heroAndHeroStatDto.Endurance = heroStat.Endurance;
        heroAndHeroStatDto.MindGrowthRate = heroStat.MindGrowthRate;
        heroAndHeroStatDto.EnduranceGrowthRate = heroStat.EnduranceGrowthRate;
        heroAndHeroStatDto.Mind = heroStat.Mind;
        heroAndHeroStatDto.PhysicalDamage = heroStat.PhysicalDamage;
        heroAndHeroStatDto.MagicalDamage = heroStat.MagicalDamage;
        heroAndHeroStatDto.AttackSpeed = heroStat.AttackSpeed;
        heroAndHeroStatDto.CastSpeed = heroStat.CastSpeed;
        heroAndHeroStatDto.CriticalDamage = heroStat.CriticalDamage;
        heroAndHeroStatDto.CriticalChance = heroStat.CriticalChance;
        heroAndHeroStatDto.Health = heroStat.Health;
        heroAndHeroStatDto.HealthRegen = heroStat.HealthRegen;
        heroAndHeroStatDto.PhysicalArmor = heroStat.PhysicalArmor;
        heroAndHeroStatDto.MagicArmor = heroStat.MagicArmor;
        heroAndHeroStatDto.LifeSteal = heroStat.LifeSteal;
        heroAndHeroStatDto.Mana = heroStat.Mana;
        heroAndHeroStatDto.ManaRegen = heroStat.ManaRegen;
        heroAndHeroStatDto.MoveSpeed = heroStat.MoveSpeed;

        // Return the response DTO containing Hero and HeroStat information
        return heroAndHeroStatDto;

    }
}