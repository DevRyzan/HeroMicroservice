using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.ChangeStatus;

//public class ChangeStatusHeroCommandHandler : IRequestHandler<ChangeStatusHeroCommandRequest, ChangeStatusHeroCommandResponse>
//{
//    private readonly IHeroService _heroService;
//    private readonly IMapper _mapper;
//    private readonly HeroBusinessRules _heroBusinessRules;

//    public ChangeStatusHeroCommandHandler(IHeroService heroService, IMapper mapper, HeroBusinessRules heroBusinessRules)
//    {
//        _heroService = heroService;
//        _mapper = mapper;
//        _heroBusinessRules = heroBusinessRules;
//    }

//    public async Task<ChangeStatusHeroCommandResponse> Handle(ChangeStatusHeroCommandRequest request, CancellationToken cancellationToken)
//    {
//        // Ensure that the provided Id exists by checking against the HeroBusinessRules.
//        await _heroBusinessRules.HeroIdShouldBeExist(request.ChangeStatusHeroDto.Id);

//        // Retrieve the Hero entity by its Id.
//        Hero hero = await _heroService.GetById(request.ChangeStatusHeroDto.Id);

//        // Toggle the 'Status' property of the Hero entity (true to false, and vice versa).
//        hero.Status = hero.Status == true ? false : true;

//        // Update the 'UpdatedDate' property of the Hero entity to the current UTC time.
//        hero.UpdatedDate = DateTime.UtcNow;

//        // Update the Hero entity in the database.
//        Hero inProgressHero = await _heroService.Update(hero);

//        // Map the updated Hero entity to a response object.
//        ChangeStatusHeroCommandResponse updatedHeroDto = _mapper.Map<ChangeStatusHeroCommandResponse>(inProgressHero);

//        // Return the response object with the updated data.
//        return updatedHeroDto;


//    }
//}