using Application.Feature.HeroFeatures.BardAndHero.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.BardAndHero.Commands.Create;
using Application.Feature.HeroFeatures.BardAndHero.Commands.Delete;
using Application.Feature.HeroFeatures.BardAndHero.Commands.Remove;
using Application.Feature.HeroFeatures.BardAndHero.Commands.UndoDelete;
using Application.Feature.HeroFeatures.BardAndHero.Commands.Update;
using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using Application.Feature.HeroFeatures.BardAndHero.Queries.GetById;
using Application.Feature.HeroFeatures.BardAndHero.Queries.GetListByActive;
using Application.Feature.HeroFeatures.BardAndHero.Queries.GetListByInActive;
using AutoMapper;

namespace Application.Feature.HeroFeatures.BardAndHero.Profiles;

//public class MappingProfiles : Profile
//{
//    public MappingProfiles()
//    {
//        CreateMap<Domain.Entities.Heros.BardAndHero, ChangeStatusBardAndHeroCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.BardAndHero, CreateBardAndHeroDto>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.BardAndHero, CreateBardAndHeroCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.BardAndHero, DeleteBardAndHeroCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.BardAndHero, RemoveBardAndHeroCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.BardAndHero, UndoDeleteBardAndHeroCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.BardAndHero, UpdateBardAndHeroCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.BardAndHero, GetByIdBardAndHeroQueryResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.BardAndHero, GetListByActiveBardAndHeroQueryResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.BardAndHero, GetListByInActiveBardAndHeroQueryResponse>().ReverseMap();
//    }
//}
