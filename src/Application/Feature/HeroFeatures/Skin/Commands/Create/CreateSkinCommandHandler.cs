using Application.Feature.HeroFeatures.Skin.Rules;
using Application.Service.HeroServices.SkinService;
using AutoMapper;
using Core.Application.Generator;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Create;

public class CreateSkinCommandHandler : IRequestHandler<CreateSkinCommandRequest, CreateSkinCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly ISkinService _skinService;

    public CreateSkinCommandHandler(IMapper mapper, ISkinService skinService)
    {
        _mapper = mapper;
        _skinService = skinService;
    }

    public async Task<CreateSkinCommandResponse> Handle(CreateSkinCommandRequest request, CancellationToken cancellationToken)
    {
        RandomCodeGenerator codeGenerator = new RandomCodeGenerator();

        Domain.Entities.Heros.Skin skin = _mapper.Map<Domain.Entities.Heros.Skin>(request.CreatedSkinDto);

        skin.CreatedDate = DateTime.Now;
        skin.PurchasedDate = DateTime.Now;
        skin.Status = true;
        skin.IsDeleted = false;
        skin.Code = codeGenerator.GenerateUniqueCode();

        await _skinService.Create(skin);

        CreateSkinCommandResponse mappedResponse = _mapper.Map<CreateSkinCommandResponse>(skin);

        return mappedResponse;
    }
}
