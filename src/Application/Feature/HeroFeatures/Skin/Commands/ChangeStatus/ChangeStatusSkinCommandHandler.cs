using Application.Feature.HeroFeatures.Skin.Rules;
using Application.Service.HeroServices.SkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.ChangeStatus;

//public class ChangeStatusSkinCommandHandler : IRequestHandler<ChangeStatusSkinCommandRequest, ChangeStatusSkinCommandResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly SkinBusinessRules _skinBusinessRules;
//    private readonly ISkinService _skinService;

//    public ChangeStatusSkinCommandHandler(IMapper mapper, SkinBusinessRules skinBusinessRules, ISkinService skinService)
//    {
//        _mapper = mapper;
//        _skinBusinessRules = skinBusinessRules;
//        _skinService = skinService;
//    }

//    public async Task<ChangeStatusSkinCommandResponse> Handle(ChangeStatusSkinCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _skinBusinessRules.IdShouldBeExist(Id: request.ChangedStatusSkinDto.Id);

//        Domain.Entities.Heros.Skin? skin = await _skinService.GetById(id: request.ChangedStatusSkinDto.Id);

//        skin.Status = skin.Status == true ? false : true;
//        skin.UpdatedDate = DateTime.Now;

//        await _skinService.Update(skin);

//        ChangeStatusSkinCommandResponse mappedResponse = _mapper.Map<ChangeStatusSkinCommandResponse>(skin);
//        return mappedResponse;

//    }
//}
