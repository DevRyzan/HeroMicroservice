using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Remove;

//public class RemoveBardAndHeroCommandHandler : IRequestHandler<RemoveBardAndHeroCommandRequest, RemoveBardAndHeroCommandResponse>
//{
//    private readonly IBardAndHeroService _bardAndHeroService;
//    private readonly IMapper _mapper;
//    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

//    public RemoveBardAndHeroCommandHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
//    {
//        _bardAndHeroService = bardAndHeroService;
//        _mapper = mapper;
//        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
//    }

//    public async Task<RemoveBardAndHeroCommandResponse> Handle(RemoveBardAndHeroCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _bardAndHeroBusinessRules.IdShouldBeExist(Id: request.RemoveBardAndHeroDto.Id);

//        await _bardAndHeroBusinessRules.RemoveCondition(Id: request.RemoveBardAndHeroDto.Id);

//        Domain.Entities.Heros.BardAndHero bardAndHero = await _bardAndHeroService.GetById(id: request.RemoveBardAndHeroDto.Id);

//        await _bardAndHeroService.Remove(bardAndHero);

//        RemoveBardAndHeroCommandResponse mappedResponse = _mapper.Map<RemoveBardAndHeroCommandResponse>(bardAndHero);

//        return mappedResponse;

//    }
//}
