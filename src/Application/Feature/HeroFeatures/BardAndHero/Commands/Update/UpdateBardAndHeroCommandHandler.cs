using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Update;

public class UpdateBardAndHeroCommandHandler : IRequestHandler<UpdateBardAndHeroCommandRequest, UpdateBardAndHeroCommandResponse>
{
    private readonly IBardAndHeroService _bardAndHeroService;
    private readonly IMapper _mapper;
    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

    public UpdateBardAndHeroCommandHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
    {
        _bardAndHeroService = bardAndHeroService;
        _mapper = mapper;
        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
    }

    public async Task<UpdateBardAndHeroCommandResponse> Handle(UpdateBardAndHeroCommandRequest request, CancellationToken cancellationToken)
    {

        await _bardAndHeroBusinessRules.IdShouldBeExist(Id: request.UpdateBardAndHeroDto.Id);
        await _bardAndHeroBusinessRules.HeroIdShouldBeExist(heroId: request.UpdateBardAndHeroDto.HeroId);

        Domain.Entities.Heros.BardAndHero bardAndHero = await _bardAndHeroService.GetById(id: request.UpdateBardAndHeroDto.Id);

        bardAndHero.HeroId = request.UpdateBardAndHeroDto.HeroId;
        bardAndHero.BardId = request.UpdateBardAndHeroDto.BardId;

        bardAndHero.UpdatedDate = DateTime.Now;

        await _bardAndHeroService.Update(bardAndHero);

        UpdateBardAndHeroCommandResponse mappedResponse = _mapper.Map<UpdateBardAndHeroCommandResponse>(bardAndHero);

        return mappedResponse;
    }
}
