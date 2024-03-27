using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Delete;

public class DeleteBardAndHeroCommandHandler : IRequestHandler<DeleteBardAndHeroCommandRequest, DeleteBardAndHeroCommandResponse>
{
    private readonly IBardAndHeroService _bardAndHeroService;
    private readonly IMapper _mapper;
    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

    public DeleteBardAndHeroCommandHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
    {
        _bardAndHeroService = bardAndHeroService;
        _mapper = mapper;
        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
    }

    public async Task<DeleteBardAndHeroCommandResponse> Handle(DeleteBardAndHeroCommandRequest request, CancellationToken cancellationToken)
    {

        await _bardAndHeroBusinessRules.IdShouldBeExist(Id: request.DeleteBardAndHeroDto.Id);

        Domain.Entities.Heros.BardAndHero hero = await _bardAndHeroService.GetById(id: request.DeleteBardAndHeroDto.Id);

        hero.IsDeleted = true;
        hero.Status = false;
        hero.DeletedDate = DateTime.Now;

        await _bardAndHeroService.Delete(hero);

        DeleteBardAndHeroCommandResponse mappedResponse = _mapper.Map<DeleteBardAndHeroCommandResponse>(hero);

        return mappedResponse;
    }
}
