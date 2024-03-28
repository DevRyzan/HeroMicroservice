using Application.Feature.HeroFeatures.BardAndHero.Rules;
using Application.Service.HeroServices.BardAndHeroService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Queries.GetById;

//public class GetByIdBardAndHeroQueryHandler : IRequestHandler<GetByIdBardAndHeroQueryRequest, GetByIdBardAndHeroQueryResponse>
//{
//    private readonly IBardAndHeroService _bardAndHeroService;
//    private readonly IMapper _mapper;
//    private readonly BardAndHeroBusinessRules _bardAndHeroBusinessRules;

//    public GetByIdBardAndHeroQueryHandler(IBardAndHeroService bardAndHeroService, IMapper mapper, BardAndHeroBusinessRules bardAndHeroBusinessRules)
//    {
//        _bardAndHeroService = bardAndHeroService;
//        _mapper = mapper;
//        _bardAndHeroBusinessRules = bardAndHeroBusinessRules;
//    }

//    public async Task<GetByIdBardAndHeroQueryResponse> Handle(GetByIdBardAndHeroQueryRequest request, CancellationToken cancellationToken)
//    {
//        await _bardAndHeroBusinessRules.IdShouldBeExist(Id: request.GetByIdBardAndHeroDto.Id);

//        Domain.Entities.Heros.BardAndHero bardAndHero = await _bardAndHeroService.GetById(id: request.GetByIdBardAndHeroDto.Id);

//        GetByIdBardAndHeroQueryResponse mappedResponse = _mapper.Map<GetByIdBardAndHeroQueryResponse>(bardAndHero);

//        return mappedResponse;
//    }
//}
