using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using Core.Application.Generator;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Create;

public class CreateBardAndHeroCommandHandler : IRequestHandler<CreateBardAndHeroCommandRequest, CreateBardAndHeroCommandResponse>
{
    private readonly IBardAndHeroService _bardAndHeroService;
    private readonly IMapper _mapper;
    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

    public CreateBardAndHeroCommandHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
    {
        _bardAndHeroService = bardAndHeroService;
        _mapper = mapper;
        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
    }

    public async Task<CreateBardAndHeroCommandResponse> Handle(CreateBardAndHeroCommandRequest request, CancellationToken cancellationToken)
    {
        await _bardAndHeroBusinessRules.HeroIdShouldBeExist(heroId: request.CreateBardAndHeroDto.HeroId);

        RandomCodeGenerator randomCodeGenerator = new();
        Domain.Entities.Heros.BardAndHero bardAndHero = _mapper.Map<Domain.Entities.Heros.BardAndHero>(request.CreateBardAndHeroDto);

        bardAndHero.Status = true;
        bardAndHero.IsDeleted = false;
        bardAndHero.CreatedDate = DateTime.Now;
        bardAndHero.Code = randomCodeGenerator.GenerateUniqueCode();

        await _bardAndHeroService.Create(bardAndHero);

        CreateBardAndHeroCommandResponse mappedResponse = _mapper.Map<CreateBardAndHeroCommandResponse>(bardAndHero);

        return mappedResponse;
    }
}
