using Application.Feature.HeroFeatures.Skin.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.Skin.Commands.Create;
using Application.Feature.HeroFeatures.Skin.Commands.Delete;
using Application.Feature.HeroFeatures.Skin.Commands.Remove;
using Application.Feature.HeroFeatures.Skin.Commands.Update;
using Application.Feature.HeroFeatures.Skin.Dtos;
using Application.Feature.HeroFeatures.Skin.Queries.GetById;
using Application.Feature.HeroFeatures.Skin.Queries.GetListByActive;
using Application.Feature.HeroFeatures.Skin.Queries.GetListByInActive;
using AutoMapper;

namespace Application.Feature.HeroFeatures.Skin.Profiles;

//public class MappingProfiles : Profile
//{
//    public MappingProfiles()
//    {
//        CreateMap<Domain.Entities.Heros.Skin, ChangeStatusSkinCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.Skin, CreatedSkinDto>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.Skin, CreateSkinCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.Skin, DeleteSkinCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.Skin, RemoveSkinCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.Skin, UpdateSkinCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.Skin, GetByIdSkinQueryResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.Skin, GetListByActiveSkinQueryResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.Skin, GetListByInActiveSkinQueryResponse>().ReverseMap();
//    }
//}
