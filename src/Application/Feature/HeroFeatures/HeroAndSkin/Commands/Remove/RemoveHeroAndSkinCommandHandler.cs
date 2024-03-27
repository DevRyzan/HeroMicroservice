using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Remove;

//public class RemoveHeroAndSkinCommandHandler : IRequestHandler<RemoveHeroAndSkinCommandRequest, RemoveHeroAndSkinCommandResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly IHeroAndSkinService _heroAndSkinService;
//    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

//    public RemoveHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
//    {
//        _mapper = mapper;
//        _heroAndSkinService = heroAndSkinService;
//        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
//    }

//    public async Task<RemoveHeroAndSkinCommandResponse> Handle(RemoveHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _heroAndSkinBusinessRules.IdShouldBeExist(Id: request.RemoveHeroAndSkinDto.Id);
//        await _heroAndSkinBusinessRules.RemoveCondition(Id: request.RemoveHeroAndSkinDto.Id);

//        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinService.GetById(id: request.RemoveHeroAndSkinDto.Id);

//        await _heroAndSkinService.Remove(heroAndSkin);

//        RemoveHeroAndSkinCommandResponse mappedResponse = _mapper.Map<RemoveHeroAndSkinCommandResponse>(heroAndSkin);

//        return mappedResponse;
//    }
//}
