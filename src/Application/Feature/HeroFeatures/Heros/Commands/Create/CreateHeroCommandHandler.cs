using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using AutoMapper;
using Core.Application.Generator;
using Domain.Entities.Heros;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Create;

//public class CreateHeroCommandHandler : IRequestHandler<CreateHeroCommandRequest, CreateHeroCommandResponse>
//{
//    private readonly IHeroService _heroService;
//    private readonly HeroBusinessRules _heroBusinessRule;
//    private readonly IMapper _mapper;
//    private readonly IHeroDetailService _heroDetailService;

//    public CreateHeroCommandHandler(IHeroService heroService, HeroBusinessRules heroBusinessRule, IMapper mapper, IHeroDetailService heroDetailService)
//    {
//        _heroService = heroService;
//        _heroBusinessRule = heroBusinessRule;
//        _mapper = mapper;
//        _heroDetailService = heroDetailService;
//    }

//    public async Task<CreateHeroCommandResponse> Handle(CreateHeroCommandRequest request, CancellationToken cancellationToken)
//    {
//        RandomCodeGenerator code1 = new RandomCodeGenerator();
//        RandomCodeGenerator code2 = new RandomCodeGenerator();
//        // Check if the hero name already exists
//        await _heroBusinessRule.HeroNameShouldNotBeExist(request.CreatedHeroDto.Name);

//        // Create a Hero object and map properties from the request
//        Hero mappedHero = _mapper.Map<Hero>(request.CreatedHeroDto);
//        mappedHero.Code = code1.GenerateUniqueCode();
//        mappedHero.CreatedDate = DateTime.Now;

//        // Create a HeroDetail object and populate its properties from the request
//        HeroDetail createdHeroDetail = new HeroDetail()
//        {
//            Description = request.CreatedHeroDto.Description,
//            Title = request.CreatedHeroDto.Title,
//            Story = request.CreatedHeroDto.Story,
//            IconUrl = request.CreatedHeroDto.IconUrl,
//            GamPrice = request.CreatedHeroDto.GamPrice,
//            CreditPrice = request.CreatedHeroDto.CreditPrice,
//            Status = request.CreatedHeroDto.Status,
//            IsDeleted = false,
//            Code = code2.GenerateUniqueCode()
//        };

//        // Create a new Hero in the system
//        Hero createdHero = await _heroService.Create(mappedHero);

//        // Set HeroDetail properties, associate it with the created Hero, and record creation date
//        createdHeroDetail.HeroId = createdHero.Id;
//        createdHeroDetail.CreatedDate = DateTime.Now;

//        // Create a HeroDetail in the system
//        await _heroDetailService.Create(createdHeroDetail);

//        // Map the created Hero to a response DTO and set additional properties
//        CreateHeroCommandResponse createdHeroDto = _mapper.Map<CreateHeroCommandResponse>(createdHero);
//        //createdHeroDto.CreatedDate = mappedHero.CreatedDate;
//        createdHeroDto.Description = createdHeroDetail.Description;
//        createdHeroDto.Title = createdHeroDetail.Title;
//        createdHeroDto.Story = createdHeroDetail.Story;
//        createdHeroDto.GamPrice = createdHeroDetail.GamPrice;
//        createdHeroDto.CreditPrice = createdHeroDetail.CreditPrice;
//        //createdHeroDto.HeroDetailId = createdHeroDetail.Id;
//        createdHeroDto.IconUrl = createdHeroDetail.IconUrl;

//        // Return the response DTO for the created Hero
//        return createdHeroDto;

//    }
//}