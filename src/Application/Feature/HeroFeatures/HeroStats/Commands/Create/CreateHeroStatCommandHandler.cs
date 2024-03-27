using Application.Feature.HeroFeatures.HeroStats.Rules;
using Application.Service.HeroServices.HeroStatService;
using AutoMapper;
using Core.Application.Generator;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Create;

//public class CreateHeroStatCommandHandler : IRequestHandler<CreateHeroStatCommandRequest, CreateHeroStatCommandResponse>
//{
//    private readonly IHeroStatService _heroStatService;
//    private readonly IMapper _mapper;
//    private readonly HeroStatBusinessRules _heroStatBusinessRules;

//    public CreateHeroStatCommandHandler(IHeroStatService heroStatService, IMapper mapper, HeroStatBusinessRules heroStatBusinessRules)
//    {
//        _heroStatService = heroStatService;
//        _mapper = mapper;
//        _heroStatBusinessRules = heroStatBusinessRules;
//    }

//    public async Task<CreateHeroStatCommandResponse> Handle(CreateHeroStatCommandRequest request, CancellationToken cancellationToken)
//    {
//        RandomCodeGenerator code = new RandomCodeGenerator();
//        // Comment: Ensure that the Hero doesn't already have a HeroStat
//        await _heroStatBusinessRules.HeroShouldNotHaveHeroStat(request.CreateHeroStatDto.HeroId);

//        // Comment: Check if the requested Hero ID exists
//        await _heroStatBusinessRules.HeroShouldBeExist(request.CreateHeroStatDto.HeroId);

//        // Map the properties from the request to a new HeroStat object
//        HeroStat mappedHeroStat = _mapper.Map<HeroStat>(request);

//        // Comment: Check that the HeroStat with the same properties doesn't already exist
//        await _heroStatBusinessRules.HeroStatShouldBeNotExists(mappedHeroStat);

//        // Generate a unique code for the HeroStat
//        mappedHeroStat.Code = code.GenerateUniqueCode();

//        // Set additional properties for the newly created HeroStat
//        mappedHeroStat.IsDeleted = false;
//        mappedHeroStat.Status = true;
//        mappedHeroStat.CreatedDate = DateTime.Now;

//        // Create the HeroStat with the provided properties
//        HeroStat createdHeroStat = await _heroStatService.Create(mappedHeroStat);

//        // Map the created HeroStat to a response DTO
//        CreateHeroStatCommandResponse createdHeroStatDto = _mapper.Map<CreateHeroStatCommandResponse>(createdHeroStat);

//        // Set the 'CreatedDate' property in the response DTO to the current UTC time
//        createdHeroStatDto.CreatedDate = mappedHeroStat.CreatedDate;

//        // Return the response DTO for the newly created HeroStat
//        return createdHeroStatDto;
//    }
//}
