using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.ChangeStatus;

public class ChangeStatusHeroAndSkinCommandHandler : IRequestHandler<ChangeStatusHeroAndSkinCommandRequest, ChangeStatusHeroAndSkinCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IHeroAndSkinService _heroAndSkinService;
    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

    public ChangeStatusHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
    {
        _mapper = mapper;
        _heroAndSkinService = heroAndSkinService;
        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
    }

    public async Task<ChangeStatusHeroAndSkinCommandResponse> Handle(ChangeStatusHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
    {
        await _heroAndSkinBusinessRules.IdShouldBeExist(Id: request.ChangeStatusHeroAndSkinDto.Id);

        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinService.GetById(id: request.ChangeStatusHeroAndSkinDto.Id);

        heroAndSkin.Status = heroAndSkin.Status == true ? false : true;
        heroAndSkin.UpdatedDate = DateTime.Now;

        await _heroAndSkinService.Update(heroAndSkin);

        ChangeStatusHeroAndSkinCommandResponse mappedResponse = _mapper.Map<ChangeStatusHeroAndSkinCommandResponse>(heroAndSkin);

        return mappedResponse;
    }
}
