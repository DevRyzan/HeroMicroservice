using Application.Feature.HeroFeatures.HeroStats.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.HeroStats.Commands.Create;
using Application.Feature.HeroFeatures.HeroStats.Commands.Delete;
using Application.Feature.HeroFeatures.HeroStats.Commands.Remove;
using Application.Feature.HeroFeatures.HeroStats.Commands.Update;
using Application.Feature.HeroFeatures.HeroStats.Dtos;
using Application.Feature.HeroFeatures.HeroStats.Models;
using AutoMapper;
using Domain.Entities.Heros;



namespace Application.Feature.HeroFeatures.HeroStats.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<HeroStat, CreateHeroStatDto>().ReverseMap();
        CreateMap<HeroStat, CreateHeroStatCommandResponse>().ReverseMap();

        CreateMap<HeroStat, DeleteHeroStatDto>().ReverseMap();
        CreateMap<HeroStat, DeleteHeroStatCommandResponse>().ReverseMap();

        CreateMap<HeroStat, UpdateHeroStatDto>().ReverseMap();
        CreateMap<HeroStat, UpdateHeroStatCommandResponse>().ReverseMap();

        CreateMap<HeroStat, RemoveHeroStatDto>().ReverseMap();
        CreateMap<HeroStat, RemoveHeroStatCommandResponse>().ReverseMap();

        CreateMap<HeroStat, ChangeStatusHeroStatDto>().ReverseMap();
        CreateMap<HeroStat, ChangeStatusHeroStatCommandResponse>().ReverseMap();

        CreateMap<HeroStat, HeroStatListDto>().ReverseMap();
        CreateMap<IList<HeroStat>, HeroStatListModel>().ReverseMap();
    }
}
