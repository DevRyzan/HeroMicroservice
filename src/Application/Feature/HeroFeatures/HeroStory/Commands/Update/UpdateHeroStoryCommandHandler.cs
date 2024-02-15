using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Update;

public class UpdateHeroStoryCommandHandler : IRequestHandler<UpdateHeroStoryCommandRequest, UpdateHeroStoryCommandResponse>
{
    private readonly IHeroStoryService _heroStoryService;
    private readonly IMapper _mapper;
    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

    public UpdateHeroStoryCommandHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
    {
        _heroStoryService = heroStoryService;
        _mapper = mapper;
        _heroStoryBusinessRules = heroStoryBusinessRules;
    }

    public async Task<UpdateHeroStoryCommandResponse> Handle(UpdateHeroStoryCommandRequest request, CancellationToken cancellationToken)
    {
        await _heroStoryBusinessRules.IdShouldBeExist(Id: request.UpdateHeroStoryDto.Id);
        await _heroStoryBusinessRules.UpdateHeroIdCondition(Id: request.UpdateHeroStoryDto.Id, heroId: request.UpdateHeroStoryDto.HeroId);

        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryService.GetById(id: request.UpdateHeroStoryDto.Id);

        heroStory.Description = request.UpdateHeroStoryDto.Description;
        heroStory.Story = request.UpdateHeroStoryDto.Story;
        heroStory.Name = request.UpdateHeroStoryDto.Name;
        heroStory.HeroId = request.UpdateHeroStoryDto.HeroId;

        await _heroStoryService.Update(heroStory);

        UpdateHeroStoryCommandResponse mappedResponse = _mapper.Map<UpdateHeroStoryCommandResponse>(heroStory);

        return mappedResponse;
    }
}
