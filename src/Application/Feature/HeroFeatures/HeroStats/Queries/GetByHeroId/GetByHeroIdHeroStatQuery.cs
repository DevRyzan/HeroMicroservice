using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStats.Queries.GetByHeroId;

//public class GetByHeroIdHeroStatQuery : IRequestHandler<GetByHeroIdHeroStatQueryRequest, GetByHeroIdHeroStatQueryResponse>
//{
//    private readonly IHeroStatService _heroStatService;
//    private readonly HeroStatBusinessRules _businessRules;

//    private readonly IMapper _mapper;

//    public GetByHeroIdHeroStatQuery(IHeroStatService heroStatService, HeroStatBusinessRules businessRules, IMapper mapper)
//    {
//        _heroStatService = heroStatService;
//        _businessRules = businessRules;
//        _mapper = mapper;
//    }

//    public async Task<GetByHeroIdHeroStatQueryResponse> Handle(GetByHeroIdHeroStatQueryRequest request, CancellationToken cancellationToken)
//    {
//        // Comment: Attempt to retrieve a HeroStat by the provided Hero ID
//        HeroStat? heroStat = await _heroStatService.GetByHeroId(request.GetByHeroIdDto.HeroId);

//        // Comment: Ensure that the retrieved HeroStat exists
//        await _businessRules.HeroStatShouldBeExist(heroStat);

//        // Comment: Check if the requested Hero ID exists
//        await _businessRules.HeroShouldBeExist(request.GetByHeroIdDto.HeroId);

//        // Map the HeroStat object to a response DTO
//        GetByHeroIdHeroStatQueryResponse heroStatDto = _mapper.Map<GetByHeroIdHeroStatQueryResponse>(heroStat);

//        // Return the mapped HeroStatDto
//        return heroStatDto;
//    }
//}
