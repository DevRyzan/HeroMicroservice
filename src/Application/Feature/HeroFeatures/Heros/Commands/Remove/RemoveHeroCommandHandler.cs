using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Remove;

//public class RemoveHeroCommandHandler : IRequestHandler<RemoveHeroCommandRequest, RemoveHeroCommandResponse>
//{
//    private readonly IHeroService _heroService;
//    private readonly IHeroStatService _heroStatservice;
//    private readonly IHeroDetailService _heroDetailService;
//    private readonly IMapper _mapper;
//    private readonly HeroBusinessRules _heroBusinessRules;

//    public RemoveHeroCommandHandler(IHeroService heroService, IHeroStatService heroStatservice, IHeroDetailService heroDetailService, IMapper mapper, HeroBusinessRules heroBusinessRules)
//    {
//        _heroService = heroService;
//        _heroStatservice = heroStatservice;
//        _heroDetailService = heroDetailService;
//        _mapper = mapper;
//        _heroBusinessRules = heroBusinessRules;
//    }

//    public async Task<RemoveHeroCommandResponse> Handle(RemoveHeroCommandRequest request, CancellationToken cancellationToken)
//    {
//        // Check if the Hero ID exists
//        await _heroBusinessRules.HeroIdShouldBeExist(request.RemoveHeroDto.Id);

//        // Get the Hero object by its ID
//        Hero hero = await _heroService.GetById(request.RemoveHeroDto.Id);
//        // Map the properties from the request to the Hero object
//        Hero mappedHero = _mapper.Map<Hero>(request);

//        // Get the HeroDetail associated with the mapped Hero
//        HeroDetail heroDetail = await _heroDetailService.GetHeroDetailByHeroId(mappedHero.Id);
//        // Check if the HeroDetail exists
//        await _heroBusinessRules.HeroDetailShouldBeExist(heroDetail);


//        //Tüm Ekleme Silme Update İşlemlerinde eğer çoklu bir işlem mevcutsa bunları sadece şartlar sağlandığı vakit yapılması gerekmekte yoksa birbirlerinden bağımsız CRUD işlemleri gerçekleşir...........


//        // Get the HeroStat associated with the mapped Hero
//        HeroStat heroStat = await _heroStatservice.GetByHeroId(mappedHero.Id);
//        // Check if the HeroStat exists
//        await _heroBusinessRules.HeroStatShouldBeExist(heroStat);

//        // Remove the Hero, HeroDetail, and HeroStat
//        await _heroService.Remove(hero);
//        await _heroDetailService.Remove(heroDetail);
//        await _heroStatservice.Remove(heroStat);

//        // Map the removed Hero to a response DTO and set additional properties
//        RemoveHeroCommandResponse removedHeroDto = _mapper.Map<RemoveHeroCommandResponse>(mappedHero);
//        removedHeroDto.Name = hero.Name;
//        removedHeroDto.Description = heroDetail.Description;
//        removedHeroDto.Title = heroDetail.Title;
//        removedHeroDto.HeroDetailId = heroDetail.Id;
//        removedHeroDto.HeroStatId = heroStat.Id;

//        // Return the response DTO for the removed Hero
//        return removedHeroDto;

//    }
//}
