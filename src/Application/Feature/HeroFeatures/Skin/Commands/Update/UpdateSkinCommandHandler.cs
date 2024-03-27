using Application.Feature.HeroFeatures.Skin.Rules;
using Application.Service.HeroServices.SkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Update;

//public class UpdateSkinCommandHandler : IRequestHandler<UpdateSkinCommandRequest, UpdateSkinCommandResponse>
//{
//    private readonly IMapper _mapper;
//    private readonly ISkinService _skinService;
//    private readonly SkinBusinessRules _skinBusinessRules;

//    public UpdateSkinCommandHandler(IMapper mapper, ISkinService skinService, SkinBusinessRules skinBusinessRules)
//    {
//        _mapper = mapper;
//        _skinService = skinService;
//        _skinBusinessRules = skinBusinessRules;
//    }

//    public async Task<UpdateSkinCommandResponse> Handle(UpdateSkinCommandRequest request, CancellationToken cancellationToken)
//    {
//        await _skinBusinessRules.IdShouldBeExist(Id: request.UpdateSkinDto.Id);

//        Domain.Entities.Heros.Skin? skin = await _skinService.GetById(id: request.UpdateSkinDto.Id);
//        skin.Title = request.UpdateSkinDto.Title;
//        skin.Description = request.UpdateSkinDto.Description;
//        skin.ImageUrl = request.UpdateSkinDto.ImageUrl;
//        skin.Price = request.UpdateSkinDto.Price;

//        await _skinService.Update(skin);


//        UpdateSkinCommandResponse mappedResponse = _mapper.Map<UpdateSkinCommandResponse>(skin);

//        return mappedResponse;

//    }
//}
