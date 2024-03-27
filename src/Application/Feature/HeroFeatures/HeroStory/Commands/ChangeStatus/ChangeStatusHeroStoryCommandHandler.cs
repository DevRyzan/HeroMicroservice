using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.ChangeStatus;

//public class ChangeStatusHeroStoryCommandHandler : IRequestHandler<ChangeStatusHeroStoryCommandRequest, ChangeStatusHeroStoryCommandResponse>
//{
//    private readonly IHeroStoryService _heroStoryService;
//    private readonly IMapper _mapper;
//    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

//    public ChangeStatusHeroStoryCommandHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
//    {
//        _heroStoryService = heroStoryService;
//        _mapper = mapper;
//        _heroStoryBusinessRules = heroStoryBusinessRules;
//    }

//    public async Task<ChangeStatusHeroStoryCommandResponse> Handle(ChangeStatusHeroStoryCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _heroStoryBusinessRules.IdShouldBeExist(Id: request.ChangeStatusHeroStoryDto.Id);

//        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryService.GetById(id: request.ChangeStatusHeroStoryDto.Id);

//        heroStory.Status = heroStory.Status == true ? false : true;
//        heroStory.UpdatedDate = DateTime.Now;

//        await _heroStoryService.Update(heroStory);

//        ChangeStatusHeroStoryCommandResponse mappedResponse = _mapper.Map<ChangeStatusHeroStoryCommandResponse>(heroStory);

//        return mappedResponse;
//    }
//}
