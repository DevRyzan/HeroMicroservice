using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.UndoDelete;

//public class UndoDeleteBardAndHeroCommandHandler : IRequestHandler<UndoDeleteBardAndHeroCommandRequest, UndoDeleteBardAndHeroCommandResponse>
//{
//    private readonly IBardAndHeroService _bardAndHeroService;
//    private readonly IMapper _mapper;
//    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

//    public UndoDeleteBardAndHeroCommandHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
//    {
//        _bardAndHeroService = bardAndHeroService;
//        _mapper = mapper;
//        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
//    }

//    public async Task<UndoDeleteBardAndHeroCommandResponse> Handle(UndoDeleteBardAndHeroCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _bardAndHeroBusinessRules.IdShouldBeExist(Id: request.UndoDeleteBardAndHeroDto.Id);

//        Domain.Entities.Heros.BardAndHero bardAndHero = await _bardAndHeroService.GetById(id: request.UndoDeleteBardAndHeroDto.Id);

//        bardAndHero.IsDeleted = false;
//        bardAndHero.UpdatedDate = DateTime.UtcNow;

//        await _bardAndHeroService.Update(bardAndHero);

//        UndoDeleteBardAndHeroCommandResponse mappedResponse = _mapper.Map<UndoDeleteBardAndHeroCommandResponse>(bardAndHero);

//        return mappedResponse;
//    }
//}
