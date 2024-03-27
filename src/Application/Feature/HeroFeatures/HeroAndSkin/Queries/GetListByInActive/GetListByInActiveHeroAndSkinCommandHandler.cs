using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByInActive;

//public class GetListByInActiveHeroAndSkinCommandHandler : IRequestHandler<GetListByInActiveHeroAndSkinCommandRequest, List<GetListByInActiveHeroAndSkinCommandResponse>>
//{
//    private readonly IMapper _mapper;
//    private readonly IHeroAndSkinService _heroAndSkinService;
//    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

//    public GetListByInActiveHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
//    {
//        _mapper = mapper;
//        _heroAndSkinService = heroAndSkinService;
//        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
//    }

//    public async Task<List<GetListByInActiveHeroAndSkinCommandResponse>> Handle(GetListByInActiveHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _heroAndSkinBusinessRules.PageRequestShouldBeValid(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

//        List<Domain.Entities.Heros.HeroAndSkin> heroAndSkins = await _heroAndSkinService.GetInActiveList(index: request.PageRequest.Page, size: request.PageRequest.PageSize);


//        List<GetListByInActiveHeroAndSkinCommandResponse> mappedResponse = _mapper.Map<List<GetListByInActiveHeroAndSkinCommandResponse>>(heroAndSkins);

//        return mappedResponse;
//    }
//}
