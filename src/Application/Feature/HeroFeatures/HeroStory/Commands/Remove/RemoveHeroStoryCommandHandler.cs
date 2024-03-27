using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Remove;

//public class RemoveHeroStoryCommandHandler : IRequestHandler<RemoveHeroStoryCommandRequest, RemoveHeroStoryCommandResponse>
//{
//    private readonly IHeroStoryService _heroStoryService;
//    private readonly IMapper _mapper;
//    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

//    public RemoveHeroStoryCommandHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
//    {
//        _heroStoryService = heroStoryService;
//        _mapper = mapper;
//        _heroStoryBusinessRules = heroStoryBusinessRules;
//    }

//    public async Task<RemoveHeroStoryCommandResponse> Handle(RemoveHeroStoryCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _heroStoryBusinessRules.IdShouldBeExist(Id: request.RemoveHeroStoryDto.Id);
//        await _heroStoryBusinessRules.RemoveCondition(Id: request.RemoveHeroStoryDto.Id);

//        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryService.GetById(id: request.RemoveHeroStoryDto.Id);

//        await _heroStoryService.Remove(heroStory);

//        RemoveHeroStoryCommandResponse mappedResponse = _mapper.Map<RemoveHeroStoryCommandResponse>(heroStory);
        
//        return mappedResponse;

//    }
//}
