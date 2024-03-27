 using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.ChangeStatus;

public class ChangeStatusBardAndHeroCommandHandler : IRequestHandler<ChangeStatusBardAndHeroCommandRequest, ChangeStatusBardAndHeroCommandResponse>
{
    private readonly IBardAndHeroService _bardAndHeroService;
    private readonly IMapper _mapper;
    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

    public ChangeStatusBardAndHeroCommandHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
    {
        _bardAndHeroService = bardAndHeroService;
        _mapper = mapper;
        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
    }

    public async Task<ChangeStatusBardAndHeroCommandResponse> Handle(ChangeStatusBardAndHeroCommandRequest request, CancellationToken cancellationToken)
    {

        await _bardAndHeroBusinessRules.IdShouldBeExist(Id: request.ChangeStatusBardAndHeroDto.Id);

        Domain.Entities.Heros.BardAndHero bardAndHero = await _bardAndHeroService.GetById(id: request.ChangeStatusBardAndHeroDto.Id);

        bardAndHero.Status = bardAndHero.Status == true ? false : true;
        bardAndHero.UpdatedDate = DateTime.Now;

        await _bardAndHeroService.Update(bardAndHero);

        ChangeStatusBardAndHeroCommandResponse mappedResponse = _mapper.Map<ChangeStatusBardAndHeroCommandResponse>(bardAndHero);

        return mappedResponse;

    }
}
