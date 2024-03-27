using Application.Feature.HeroFeatures.Skin.Rules;
using Application.Service.HeroServices.SkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Delete;

//public class DeleteSkinCommandHandler : IRequestHandler<DeleteSkinCommandRequest, DeleteSkinCommandResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly SkinBusinessRules _skinBusinessRules;
//    private readonly ISkinService _skinService;

//    public DeleteSkinCommandHandler(IMapper mapper, SkinBusinessRules skinBusinessRules, ISkinService skinService)
//    {
//        _mapper = mapper;
//        _skinBusinessRules = skinBusinessRules;
//        _skinService = skinService;
//    }

//    public async Task<DeleteSkinCommandResponse> Handle(DeleteSkinCommandRequest request, CancellationToken cancellationToken)
//    {

//        await _skinBusinessRules.IdShouldBeExist(Id: request.DeletedSkinDto.Id);

//        Domain.Entities.Heros.Skin? skin = await _skinService.GetById(id: request.DeletedSkinDto.Id);

//        skin.IsDeleted = true;
//        skin.Status = false;
//        skin.DeletedDate = DateTime.Now;

//        await _skinService.Update(skin);

//        DeleteSkinCommandResponse mappedResponse = _mapper.Map<DeleteSkinCommandResponse>(skin);

//        return mappedResponse;
//    }
//}
