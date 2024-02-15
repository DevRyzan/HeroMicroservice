using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Update;

public class UpdateHeroStatCommandHandler : IRequestHandler<UpdateHeroStatCommandRequest, UpdateHeroStatCommandResponse>
{
    private readonly IHeroStatService _heroStatService;
    private readonly HeroStatBusinessRules _businessRules;
    private readonly IMapper _mapper;

    public UpdateHeroStatCommandHandler(IHeroStatService heroStatService, HeroStatBusinessRules businessRules, IMapper mapper)
    {
        _heroStatService = heroStatService;
        _businessRules = businessRules;
        _mapper = mapper;
    }

    public async Task<UpdateHeroStatCommandResponse> Handle(UpdateHeroStatCommandRequest request, CancellationToken cancellationToken)
    {
        //HeroStat? heroStat = await _heroStatService.GetByHeroId(request.HeroId);

        // Comment: Ensure that the requested HeroStat ID is greater than zero
        await _businessRules.HeroStatIdGreaterThanZero(request.UpdateHeroStatDto.Id);

        // Comment: Check if the requested Hero ID exists
        await _businessRules.HeroShouldBeExist(request.UpdateHeroStatDto.HeroId);

        // Get the existing HeroStat object by its ID
        HeroStat heroStat = await _heroStatService.GetById(request.UpdateHeroStatDto.Id);

        // Map the properties from the request to a new HeroStat object
        HeroStat mappedHeroStat = _mapper.Map<HeroStat>(request);

        // Copy some properties from the existing HeroStat to the mapped HeroStat
        mappedHeroStat.Code = heroStat.Code;
        mappedHeroStat.UpdatedDate = DateTime.Now;
        mappedHeroStat.DeletedDate = DateTime.Now;

        // Update the HeroStat with the modified properties
        HeroStat updatedHeroStat = await _heroStatService.Update(mappedHeroStat);

        // Map the updated HeroStat to a response DTO
        UpdateHeroStatCommandResponse updatedHeroStatDto = _mapper.Map<UpdateHeroStatCommandResponse>(updatedHeroStat);

        // Return the response DTO for the updated HeroStat
        return updatedHeroStatDto;
    }
}
