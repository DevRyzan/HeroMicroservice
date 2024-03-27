using Application.Feature.HeroFeatures.HeroAndSkin.Rules;
using Application.Service.HeroServices.HeroAndSkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.Delete;

//public class DeleteHeroAndSkinCommandHandler : IRequestHandler<DeleteHeroAndSkinCommandRequest, DeleteHeroAndSkinCommandResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly IHeroAndSkinService _heroAndSkinService;
//    private readonly HeroAndSkinBusinessRules _heroAndSkinBusinessRules;

//    public DeleteHeroAndSkinCommandHandler(IMapper mapper, IHeroAndSkinService heroAndSkinService, HeroAndSkinBusinessRules heroAndSkinBusinessRules)
//    {
//        _mapper = mapper;
//        _heroAndSkinService = heroAndSkinService;
//        _heroAndSkinBusinessRules = heroAndSkinBusinessRules;
//    }

//    public async Task<DeleteHeroAndSkinCommandResponse> Handle(DeleteHeroAndSkinCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _heroAndSkinBusinessRules.IdShouldBeExist(Id: request.DeleteStatusHeroAndSkinDto.Id);

//        Domain.Entities.Heros.HeroAndSkin heroAndSkin = await _heroAndSkinService.GetById(id: request.DeleteStatusHeroAndSkinDto.Id);

//        heroAndSkin.Status = false;
//        heroAndSkin.IsDeleted = true;
//        heroAndSkin.DeletedDate = DateTime.Now;

//        await _heroAndSkinService.Delete(heroAndSkin: heroAndSkin);

//        DeleteHeroAndSkinCommandResponse mappedResponse = _mapper.Map<DeleteHeroAndSkinCommandResponse>(heroAndSkin);

//        return mappedResponse;
//    }
//}
