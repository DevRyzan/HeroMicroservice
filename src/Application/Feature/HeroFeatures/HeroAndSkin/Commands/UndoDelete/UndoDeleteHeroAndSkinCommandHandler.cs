using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.UndoDelete;

public class UndoDeleteHeroAndSkinCommandHandler : IRequestHandler<UndoDeleteHeroAndSkinCommandRequest, UndoDeleteHeroAndSkinCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IHeroAndSkinService _heroAndSkinService;
    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

    public UndoDeleteHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
    {
        _mapper = mapper;
        _heroAndSkinService = heroAndSkinService;
        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
    }

    public async Task<UndoDeleteHeroAndSkinCommandResponse> Handle(UndoDeleteHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
    {
        await _heroAndSkinBusinessRules.IdShouldBeExist(Id: request.UndoDeleteHeroAndSkinDto.Id);

        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinService.GetById(id: request.UndoDeleteHeroAndSkinDto.Id);

        heroAndSkin.IsDeleted = false;
        heroAndSkin.UpdatedDate = DateTime.Now;

        await _heroAndSkinService.Update(heroAndSkin);

        UndoDeleteHeroAndSkinCommandResponse mappedResponse = _mapper.Map<UndoDeleteHeroAndSkinCommandResponse>(heroAndSkin);

        return mappedResponse;
    }
}
