using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetById;

public class GetByIdHeroAndSkinCommandHandler : IRequestHandler<GetByIdHeroAndSkinCommandRequest, GetByIdHeroAndSkinCommandResponse>
{
    private readonly IMapper _mapper;
    private readonly IHeroAndSkinService _heroAndSkinService;
    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

    public GetByIdHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
    {
        _mapper = mapper;
        _heroAndSkinService = heroAndSkinService;
        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
    }

    public async Task<GetByIdHeroAndSkinCommandResponse> Handle(GetByIdHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
    {
        await _heroAndSkinBusinessRules.IdShouldBeExist(Id: request.GetByIdHeroAndSkin.Id);

        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinService.GetById(id: request.GetByIdHeroAndSkin.Id);

        GetByIdHeroAndSkinCommandResponse mappedResponse = _mapper.Map<GetByIdHeroAndSkinCommandResponse>(heroAndSkin);

        return mappedResponse;

    }
}
