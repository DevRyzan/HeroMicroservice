using Application.Feature.HeroFeatures.Heros.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.Heros.Commands.Create;
using Application.Feature.HeroFeatures.Heros.Commands.Delete;
using Application.Feature.HeroFeatures.Heros.Commands.Remove;
using Application.Feature.HeroFeatures.Heros.Commands.Update;
using Application.Feature.HeroFeatures.Heros.Dtos;
using Application.Feature.HeroFeatures.Heros.Models;
using Application.Feature.HeroFeatures.Heros.Queries.GetByIdHero;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities.Heros;


namespace Application.Feature.HeroFeatures.Heros.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Hero, CreateHeroDto>().ReverseMap();
        CreateMap<Hero, CreateHeroCommandResponse>().ReverseMap();

        CreateMap<Hero, ChangeStatusHeroCommandResponse>().ReverseMap();

        CreateMap<Hero, DeleteHeroCommandResponse>().ReverseMap();

        CreateMap<Hero, RemoveHeroCommandResponse>().ReverseMap();

        CreateMap<Hero, UpdatedHeroCommandResponse>().ReverseMap();

        CreateMap<Hero, GetByIdHeroQueryResponse>().ReverseMap();

        CreateMap<IList<Hero>, GetListResponse<HeroListModel>>().ReverseMap();

    }
}
