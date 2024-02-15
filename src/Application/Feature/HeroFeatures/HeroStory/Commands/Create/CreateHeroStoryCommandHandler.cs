using Application.Feature.HeroFeatures.HeroStory.Rules;
using Application.Service.HeroServices.HeroStoryService;
using AutoMapper;
using Core.Application.Generator;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStory.Commands.Create;

public class CreateHeroStoryCommandHandler : IRequestHandler<CreateHeroStoryCommandRequest, CreateHeroStoryCommandResponse>
{
    private readonly IHeroStoryService _heroStoryService;
    private readonly IMapper _mapper;
    private readonly HeroStoryBusinessRules _heroStoryBusinessRules;

    public CreateHeroStoryCommandHandler(IHeroStoryService heroStoryService, IMapper mapper, HeroStoryBusinessRules heroStoryBusinessRules)
    {
        _heroStoryService = heroStoryService;
        _mapper = mapper;
        _heroStoryBusinessRules = heroStoryBusinessRules;
    }

    public async Task<CreateHeroStoryCommandResponse> Handle(CreateHeroStoryCommandRequest request, CancellationToken cancellationToken)
    {

        await _heroStoryBusinessRules.CreateHeroIdCondition(heroId: request.CreateHeroStoryDto.HeroId);

        RandomCodeGenerator codeGenerator = new RandomCodeGenerator();
        Domain.Entities.Heros.HeroStory heroStory = _mapper.Map<Domain.Entities.Heros.HeroStory>(request.CreateHeroStoryDto);

        heroStory.Status = true;
        heroStory.IsDeleted = false;
        heroStory.Code = codeGenerator.GenerateUniqueCode();
        heroStory.CreatedDate = DateTime.Now;

        await _heroStoryService.Create(heroStory);

        CreateHeroStoryCommandResponse mappedResponse = _mapper.Map<CreateHeroStoryCommandResponse>(heroStory);

        return mappedResponse;

    }
}
