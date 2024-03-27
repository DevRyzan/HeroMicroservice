using Application.Feature.HeroFeatures.HeroStory.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.HeroStory.Commands.Create;
using Application.Feature.HeroFeatures.HeroStory.Commands.Delete;
using Application.Feature.HeroFeatures.HeroStory.Commands.Remove;
using Application.Feature.HeroFeatures.HeroStory.Commands.UndoDelete;
using Application.Feature.HeroFeatures.HeroStory.Commands.Update;
using Application.Feature.HeroFeatures.HeroStory.Dtos;
using Application.Feature.HeroFeatures.HeroStory.Queries.GetById;
using Application.Feature.HeroFeatures.HeroStory.Queries.GetListByActive;
using Application.Feature.HeroFeatures.HeroStory.Queries.GetListByInActive;
using AutoMapper;

namespace Application.Feature.HeroFeatures.HeroStory.Profiles;

//public class MappingProfiles : Profile
//{
//    public MappingProfiles()
//    {
//        CreateMap<Domain.Entities.Heros.HeroStory, ChangeStatusHeroStoryCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.HeroStory, CreateHeroStoryDto>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.HeroStory, CreateHeroStoryCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.HeroStory, DeleteHeroStoryCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.HeroStory, UpdateHeroStoryCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.HeroStory, UndoDeleteHeroStoryCommandResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.HeroStory, RemoveHeroStoryCommandResponse>().ReverseMap();

//        CreateMap<Domain.Entities.Heros.HeroStory, GetByIdHeroStoryQueryResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.HeroStory, GetListByActiveHeroStoryQueryResponse>().ReverseMap();
//        CreateMap<Domain.Entities.Heros.HeroStory, GetListByInActiveHeroStoryQueryResponse>().ReverseMap();
//    }
//}
