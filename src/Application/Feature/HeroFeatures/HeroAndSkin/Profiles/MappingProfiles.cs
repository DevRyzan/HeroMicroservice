using Application.Feature.HeroFeatures.HeroAndSkin.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Create;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Delete;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Remove;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.UndoDelete;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Update;
using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetById;
using Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByActive;
using Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByInActive;
using AutoMapper;

namespace Application.Feature.HeroFeatures.HeroAndSkin.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Domain.Entities.Heros.HeroAndSkin, ChangeStatusHeroAndSkinCommandResponse>().ReverseMap();

        CreateMap<Domain.Entities.Heros.HeroAndSkin, CreateStatusHeroAndSkinDto>().ReverseMap();
        CreateMap<Domain.Entities.Heros.HeroAndSkin, CreateHeroAndSkinCommandResponse>().ReverseMap();

        CreateMap<Domain.Entities.Heros.HeroAndSkin, DeleteHeroAndSkinCommandResponse>().ReverseMap();
        CreateMap<Domain.Entities.Heros.HeroAndSkin, RemoveHeroAndSkinCommandResponse>().ReverseMap();
        CreateMap<Domain.Entities.Heros.HeroAndSkin, UndoDeleteHeroAndSkinCommandResponse>().ReverseMap();
        CreateMap<Domain.Entities.Heros.HeroAndSkin, UpdateHeroAndSkinCommandResponse>().ReverseMap();

        CreateMap<Domain.Entities.Heros.HeroAndSkin, GetByIdHeroAndSkinCommandResponse>().ReverseMap();
        CreateMap<Domain.Entities.Heros.HeroAndSkin, GetListByActiveHeroAndSkinCommandResponse>().ReverseMap();
        CreateMap<Domain.Entities.Heros.HeroAndSkin, GetListByInActiveHeroAndSkinCommandResponse>().ReverseMap();
    }
}
