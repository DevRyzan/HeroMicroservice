using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Update;

public class UpdateHeroAndSkinCommandHandler : IRequestHandler<UpdateHeroAndSkinCommandRequest, UpdateHeroAndSkinCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IHeroAndSkinService _heroAndSkinService;
    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

    public UpdateHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
    {
        _mapper = mapper;
        _heroAndSkinService = heroAndSkinService;
        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
    }

    public async Task<UpdateHeroAndSkinCommandResponse> Handle(UpdateHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
    {
        await _heroAndSkinBusinessRules.IdShouldBeExist(Id: request.UpdateHeroAndSkinDto.Id);

        await _heroAndSkinBusinessRules.HeroShouldBeExist(heroId: request.UpdateHeroAndSkinDto.HeroId);
        await _heroAndSkinBusinessRules.SkinShouldBeExist(skinId: request.UpdateHeroAndSkinDto.SkinId);

        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinService.GetById(id: request.UpdateHeroAndSkinDto.Id);

        heroAndSkin.HeroId = request.UpdateHeroAndSkinDto.HeroId;
        heroAndSkin.SkinId = request.UpdateHeroAndSkinDto.SkinId;

        heroAndSkin.UpdatedDate = DateTime.Now;

        await _heroAndSkinService.Update(heroAndSkin);

        UpdateHeroAndSkinCommandResponse mappedResponse = _mapper.Map<UpdateHeroAndSkinCommandResponse>(heroAndSkin);

        return mappedResponse;
    }
}
