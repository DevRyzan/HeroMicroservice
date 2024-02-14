using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Delete;

public class DeleteHeroCommandHandler : IRequestHandler<DeleteHeroCommandRequest, DeleteHeroCommandResponse>
{
    private readonly IHeroService _heroService;
    private readonly IHeroDetailService _heroDetailService;
    private readonly IHeroStatService _heroStatService;
    private readonly HeroBusinessRules _heroBusinessRules;
    private readonly IMapper _mapper;

    public DeleteHeroCommandHandler(IHeroService heroService, IHeroDetailService heroDetailService, IHeroStatService heroStatService, HeroBusinessRules heroBusinessRules, IMapper mapper)
    {
        _heroService = heroService;
        _heroDetailService = heroDetailService;
        _heroStatService = heroStatService;
        _heroBusinessRules = heroBusinessRules;
        _mapper = mapper;
    }

    public async Task<DeleteHeroCommandResponse> Handle(DeleteHeroCommandRequest request, CancellationToken cancellationToken)
    {
        // Get the Hero object by its ID
        Hero hero = await _heroService.GetById(request.DeletedHeroDto.Id);
        // Check if the Hero exists
        await _heroBusinessRules.HeroShouldBeExist(hero);

        // Set the Hero's status to false and record the deletion date
        hero.Status = false;
        hero.DeletedDate = DateTime.UtcNow;

        // Get the HeroDetail associated with the Hero
        HeroDetail heroDetail = await _heroDetailService.GetHeroDetailByHeroId(hero.Id);
        // Check if the HeroDetail exists
        await _heroBusinessRules.HeroDetailShouldBeExist(heroDetail);

        // Set the HeroDetail's status to false and record the deletion date
        heroDetail.Status = false;
        heroDetail.DeletedDate = DateTime.UtcNow;

        // Get the HeroStat associated with the Hero
        HeroStat heroStat = await _heroStatService.GetByHeroId(hero.Id);
        // Check if the HeroStat exists
        await _heroBusinessRules.HeroStatShouldBeExist(heroStat);

        // Set the HeroStat's status to false and record the deletion date
        heroStat.Status = false;
        heroStat.DeletedDate = DateTime.UtcNow;

        // Delete the Hero and associated records (HeroDetail and HeroStat)
        Hero deletedHero = await _heroService.Delete(hero);
        await _heroDetailService.Delete(heroDetail);
        await _heroStatService.Delete(heroStat);

        // Map the deleted Hero to a response DTO and set additional properties
        DeleteHeroCommandResponse deletedHeroDto = _mapper.Map<DeleteHeroCommandResponse>(deletedHero);
        deletedHeroDto.Status = false;
        deletedHeroDto.HeroStatStatus = false;
        deletedHeroDto.HeroDetailStatus = false;
        deletedHeroDto.DeletedDate = DateTime.UtcNow;

        // Return the response DTO for the deleted Hero
        return deletedHeroDto;

    }
}