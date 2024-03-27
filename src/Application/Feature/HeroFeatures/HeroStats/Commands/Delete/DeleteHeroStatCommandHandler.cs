using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Delete;

//public class DeleteHeroStatCommandHandler : IRequestHandler<DeleteHeroStatCommandRequest, DeleteHeroStatCommandResponse>
//{
//    private readonly IHeroStatService _heroStatService;
//    private readonly IMapper _mapper;
//    private readonly HeroStatBusinessRules _heroStatBusinessRules;

//    public DeleteHeroStatCommandHandler(IHeroStatService heroStatService, IMapper mapper, HeroStatBusinessRules heroStatBusinessRules)
//    {
//        _heroStatService = heroStatService;
//        _mapper = mapper;
//        _heroStatBusinessRules = heroStatBusinessRules;
//    }

//    public async Task<DeleteHeroStatCommandResponse> Handle(DeleteHeroStatCommandRequest request, CancellationToken cancellationToken)
//    {
//        // Comment: Ensure that the requested HeroStat ID is greater than zero
//        await _heroStatBusinessRules.HeroStatIdGreaterThanZero(request.DeleteHeroStatDto.Id);

//        // Map the properties from the request to a new HeroStat object
//        HeroStat mappedHeroStat = _mapper.Map<HeroStat>(request);

//        // Set the 'Status' property of the HeroStat to false
//        mappedHeroStat.Status = false;
//        mappedHeroStat.IsDeleted = true;

//        // Set the 'DeletedDate' property to the current UTC time
//        mappedHeroStat.DeletedDate = DateTime.Now;

//        // Update the HeroStat with the modified properties
//        HeroStat deletedHeroStat = await _heroStatService.Update(mappedHeroStat);

//        // Map the updated HeroStat to a response DTO
//        DeleteHeroStatCommandResponse deletedHeroStatDto = _mapper.Map<DeleteHeroStatCommandResponse>(deletedHeroStat);

//        // Return the response DTO for the deleted HeroStat
//        return deletedHeroStatDto;
//    }
//}
