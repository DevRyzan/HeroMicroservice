using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Update;

public class UpdatedHeroCommandHandler : IRequestHandler<UpdatedHeroCommandRequest, UpdatedHeroCommandResponse>
{
    private readonly IHeroService _heroService;
    private readonly HeroBusinessRules _heroBusinessRule;
    private readonly IMapper _mapper;
    private readonly IHeroDetailService _heroDetailService;

    public UpdatedHeroCommandHandler(IHeroService heroService, HeroBusinessRules heroBusinessRule, IMapper mapper, IHeroDetailService heroDetailService)
    {
        _heroService = heroService;
        _heroBusinessRule = heroBusinessRule;
        _mapper = mapper;
        _heroDetailService = heroDetailService;
    }

    public async Task<UpdatedHeroCommandResponse> Handle(UpdatedHeroCommandRequest request, CancellationToken cancellationToken)
    {
        // Check if the Hero ID exists
        await _heroBusinessRule.HeroIdShouldBeExist(request.Id);

        // Check if the Hero name doesn't exist with the given ID
        await _heroBusinessRule.HeroNameShouldNotBeExistWithId(request.Name, request.Id);

        // Map the properties from the request to a new Hero object
        Hero mappedHero = _mapper.Map<Hero>(request);

        // Get the HeroDetail associated with the mapped Hero
        HeroDetail heroDetail = await _heroDetailService.GetHeroDetailByHeroId(mappedHero.Id);

        // Update HeroDetail properties with values from the request
        heroDetail.Description = request.Description;
        heroDetail.IconUrl = request.IconUrl;
        heroDetail.Title = request.Title;
        heroDetail.Story = request.Story;
        heroDetail.GamPrice = request.GamPrice;
        heroDetail.CreditPrice = request.CreditPrice;
        heroDetail.UpdatedDate = DateTime.UtcNow;

        // Set the CreatedDate of the mapped Hero to match the existing CreatedDate in HeroDetail
        mappedHero.CreatedDate = heroDetail.CreatedDate;
        mappedHero.UpdatedDate = DateTime.UtcNow;

        // Check if the HeroDetail exists
        await _heroBusinessRule.HeroDetailShouldBeExist(heroDetail);

        // Update the Hero with the new values
        Hero updatedHero = await _heroService.Update(mappedHero);

        // Update the HeroDetail
        await _heroDetailService.Update(heroDetail);

        // Map the updated Hero to a response DTO and set additional properties
        UpdatedHeroCommandResponse updatedHeroDto = _mapper.Map<UpdatedHeroCommandResponse>(updatedHero);
        updatedHeroDto.Description = heroDetail.Description;
        updatedHeroDto.Title = heroDetail.Title;
        updatedHeroDto.Story = heroDetail.Story;
        updatedHeroDto.GamPrice = heroDetail.GamPrice;
        updatedHeroDto.CreditPrice = heroDetail.CreditPrice;
        updatedHeroDto.DifficultLevel = request.DifficultLevel;
        updatedHeroDto.IconUrl = request.IconUrl;
        updatedHeroDto.HeroType = request.HeroType;
        updatedHeroDto.HeroDetailId = heroDetail.Id;
        updatedHeroDto.UpdatedDate = DateTime.UtcNow;

        // Return the response DTO for the updated Hero
        return updatedHeroDto;

    }
}