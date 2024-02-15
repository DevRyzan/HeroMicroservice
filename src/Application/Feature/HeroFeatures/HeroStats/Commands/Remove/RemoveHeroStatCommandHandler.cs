using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Remove;

public class RemoveHeroStatCommandHandler : IRequestHandler<RemoveHeroStatCommandRequest, RemoveHeroStatCommandResponse>
{
    private readonly IHeroStatService _heroStatService;
    private readonly IMapper _mapper;
    private readonly HeroStatBusinessRules _heroStatBusinessRules;

    public RemoveHeroStatCommandHandler(IHeroStatService heroStatService, HeroStatBusinessRules heroStatBusinessRules, IMapper mapper)
    {
        _heroStatService = heroStatService;
        _heroStatBusinessRules = heroStatBusinessRules;
        _mapper = mapper;
    }

    public async Task<RemoveHeroStatCommandResponse> Handle(RemoveHeroStatCommandRequest request, CancellationToken cancellationToken)
    {
        // Comment: Ensure that the requested HeroStat ID is greater than zero
        await _heroStatBusinessRules.HeroStatIdGreaterThanZero(request.RemoveHeroStatDto.Id);

        // Get the HeroStat object by its ID
        HeroStat heroStat = await _heroStatService.GetById(request.RemoveHeroStatDto.Id);

        // Initiate a task to remove the HeroStat
        await _heroStatService.Remove(heroStat);

        // Create an IsRemovedDto to indicate whether the removal was successful
        RemoveHeroStatCommandResponse deletedHeroStatDto = _mapper.Map<RemoveHeroStatCommandResponse>(heroStat);

        // Return the IsRemovedDto to indicate the removal status
        return deletedHeroStatDto;
    }
}