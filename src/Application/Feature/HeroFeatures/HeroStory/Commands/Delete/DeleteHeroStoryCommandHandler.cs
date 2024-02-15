using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Delete;

public class DeleteHeroStoryCommandHandler : IRequestHandler<DeleteHeroStoryCommandRequest, DeleteHeroStoryCommandResponse>
{

    private readonly IHeroStoryService _heroStoryService;
    private readonly IMapper _mapper;
    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

    public DeleteHeroStoryCommandHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
    {
        _heroStoryService = heroStoryService;
        _mapper = mapper;
        _heroStoryBusinessRules = heroStoryBusinessRules;
    }

    public async Task<DeleteHeroStoryCommandResponse> Handle(DeleteHeroStoryCommandRequest request, CancellationToken cancellationToken)
    {

        await _heroStoryBusinessRules.IdShouldBeExist(Id: request.DeleteHeroStoryDto.Id);

        Domain.Entities.Heros.HeroStory heroStory = await _heroStoryService.GetById(id: request.DeleteHeroStoryDto.Id);

        heroStory.Status = false;
        heroStory.IsDeleted = true;
        heroStory.DeletedDate = DateTime.Now;

        await _heroStoryService.Delete(heroStory: heroStory);

        DeleteHeroStoryCommandResponse mappedResponse = _mapper.Map<DeleteHeroStoryCommandResponse>(heroStory);

        return mappedResponse;
    }
}
