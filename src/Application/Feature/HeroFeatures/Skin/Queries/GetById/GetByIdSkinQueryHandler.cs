using Application.Feature.HeroFeatures.Skin.Rules;
using Application.Service.HeroServices.SkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetById;

//public class GetByIdSkinCommandHandler : IRequestHandler<GetByIdSkinQueryRequest, GetByIdSkinQueryResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly ISkinService _skinService;
//    private readonly SkinBusinessRules _skinBusinessRules;

//    public GetByIdSkinCommandHandler(IMapper mapper, ISkinService skinService, SkinBusinessRules skinBusinessRules)
//    {
//        _mapper = mapper;
//        _skinService = skinService;
//        _skinBusinessRules = skinBusinessRules;
//    }

//    public async Task<GetByIdSkinQueryResponse> Handle(GetByIdSkinQueryRequest request, CancellationToken cancellationToken)
//    {
//        await _skinBusinessRules.IdShouldBeExist(Id: request.GetByIdSkinDto.Id);

//        Domain.Entities.Heros.Skin? skin = await _skinService.GetById(id: request.GetByIdSkinDto.Id);

//        GetByIdSkinQueryResponse mappedResponse = _mapper.Map<GetByIdSkinQueryResponse>(skin);

//        return mappedResponse;
//    }
//}
