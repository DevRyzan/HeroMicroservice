using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.ChangeStatus;

public class ChangeStatusHeroStatCommandHandler : IRequestHandler<ChangeStatusHeroStatCommandRequest, ChangeStatusHeroStatCommandResponse>
{
    private readonly IHeroStatService _heroStatService;
    private readonly HeroStatBusinessRules _heroStatBusinessRules;

    public ChangeStatusHeroStatCommandHandler(IHeroStatService heroStatService, HeroStatBusinessRules heroStatBusinessRules)
    {
        _heroStatService = heroStatService;
        _heroStatBusinessRules = heroStatBusinessRules;
    }

    public async Task<ChangeStatusHeroStatCommandResponse> Handle(ChangeStatusHeroStatCommandRequest request, CancellationToken cancellationToken)
    {

        // Comment: Ensure that the requested HeroStat ID is greater than zero
        await _heroStatBusinessRules.HeroStatIdGreaterThanZero(request.ChangeStatusHeroStatDto.Id);

        // Get the HeroStat object by its ID
        HeroStat heroStat = await _heroStatService.GetById(request.ChangeStatusHeroStatDto.Id);

        // Toggle the 'Status' property of the HeroStat (if true, set to false, and vice versa)
        heroStat.Status = heroStat.Status == true ? false : true;

        // Update the 'UpdatedDate' property to the current UTC time
        heroStat.UpdatedDate = DateTime.Now;

        // Update the HeroStat with the modified values
        await _heroStatService.Update(heroStat);

        // Create and return a response object with the updated HeroStat's ID and Status
        return new()
        {
            Id = request.ChangeStatusHeroStatDto.Id,
            Status = heroStat.Status,
        };

    }
}