using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using Core.Application.Generator;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Create;

public class CreateHeroAndSkinCommandHandler : IRequestHandler<CreateHeroAndSkinCommandRequest, CreateHeroAndSkinCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IHeroAndSkinService _heroAndSkinService;
    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

    public CreateHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
    {
        _mapper = mapper;
        _heroAndSkinService = heroAndSkinService;
        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
    }

    public async Task<CreateHeroAndSkinCommandResponse> Handle(CreateHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
    {
        await _heroAndSkinBusinessRules.HeroShouldBeExist(heroId: request.CreateStatusHeroAndSkinDto.HeroId);
        await _heroAndSkinBusinessRules.SkinShouldBeExist(skinId: request.CreateStatusHeroAndSkinDto.SkinId);

        RandomCodeGenerator codeGenerator = new RandomCodeGenerator();

        Domain.Entities.Heros.HeroAndSkin heroAndSkin = _mapper.Map<Domain.Entities.Heros.HeroAndSkin>(request.CreateStatusHeroAndSkinDto);

        heroAndSkin.IsDeleted = false;
        heroAndSkin.Status = true;
        heroAndSkin.CreatedDate = DateTime.Now;
        heroAndSkin.Code = codeGenerator.GenerateUniqueCode();

        await _heroAndSkinService.Create(heroAndSkin);

        CreateHeroAndSkinCommandResponse mappedResponse = _mapper.Map<CreateHeroAndSkinCommandResponse>(heroAndSkin);

        return mappedResponse;
    }
}
