using Application.Feature.HeroFeatures.Skin.Rules;
using Application.Service.HeroServices.SkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Remove;

//public class RemoveSkinCommandHandler : IRequestHandler<RemoveSkinCommandRequest, RemoveSkinCommandResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly SkinBusinessRules _skinBusinessRules;
//    private readonly ISkinService _skinService;

//    public RemoveSkinCommandHandler(IMapper mapper, SkinBusinessRules skinBusinessRules, ISkinService skinService)
//    {
//        _mapper = mapper;
//        _skinBusinessRules = skinBusinessRules;
//        _skinService = skinService;
//    }

//    public async Task<RemoveSkinCommandResponse> Handle(RemoveSkinCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _skinBusinessRules.IdShouldBeExist(Id: request.RemoveSkinDto.Id);
//        await _skinBusinessRules.RemoveCondition(Id: request.RemoveSkinDto.Id);

//        Domain.Entities.Heros.Skin? skin = await _skinService.GetById(id: request.RemoveSkinDto.Id);

//        await _skinService.Remove(skin);

//        RemoveSkinCommandResponse mappedResponse = _mapper.Map<RemoveSkinCommandResponse>(skin);

//        return mappedResponse;
//    }
//}
