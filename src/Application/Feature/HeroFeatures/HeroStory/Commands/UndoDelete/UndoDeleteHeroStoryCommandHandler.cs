using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.UndoDelete;

public class UndoDeleteHeroStoryCommandHandler : IRequestHandler<UndoDeleteHeroStoryCommandRequest, UndoDeleteHeroStoryCommandResponse>
{
    private readonly IHeroStoryService _heroStoryService;
    private readonly IMapper _mapper;
    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

    public UndoDeleteHeroStoryCommandHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
    {
        _heroStoryService = heroStoryService;
        _mapper = mapper;
        _heroStoryBusinessRules = heroStoryBusinessRules;
    }

    public async Task<UndoDeleteHeroStoryCommandResponse> Handle(UndoDeleteHeroStoryCommandRequest request, CancellationToken cancellationToken)
    {
        await _heroStoryBusinessRules.IdShouldBeExist(Id: request.UndoHeroStoryDto.Id);

        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryService.GetById(id: request.UndoHeroStoryDto.Id);

        heroStory.IsDeleted = false;
        heroStory.UpdatedDate = DateTime.Now;

        await _heroStoryService.Update(heroStory);

        UndoDeleteHeroStoryCommandResponse mappedResponse = _mapper.Map<UndoDeleteHeroStoryCommandResponse>(heroStory);

        return mappedResponse;
    }
}
