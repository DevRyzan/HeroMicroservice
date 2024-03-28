using Application.Feature.HeroFeatures.Heros.Dtos;
using Application.Feature.HeroFeatures.Heros.Rules;
using Application.Service.AbilityServices.AbilityService;
using Application.Service.AbilityServices.EffectService;
using Application.Service.HeroServices.HeroService;
using Application.Service.HeroServices.RoleService;
using Application.Service.ItemServices.ItemSetService;
using Application.Service.ItemServices.SetBonusService;
using Application.Service.ItemServices.UniqueItemService;
using AutoMapper;
using Core.Application.Generator;
using Domain.Entities.Abilities;
using Domain.Entities.Heros;
using Domain.Entities.Items;
using MediatR;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Bson;
using System.Data;


namespace Application.Feature.HeroFeatures.Heros.Commands.Create;

public class CreateHeroCommandHandler : IRequestHandler<CreateHeroCommandRequest, CreateHeroCommandResponse>
{
    private readonly IHeroService _heroService;
    private readonly IRoleService _roleService;
    private readonly IAbilityService _abilityService;
    private readonly IEffectService _effectService;
    private readonly IItemSetService _itemSetService;
    private readonly ISetBonusService _setBonusService;
    private readonly IUniqueItemService _uniqueItemService;
    private readonly HeroBusinessRules _heroBusinessRule;
    private readonly IMapper _mapper;

    public CreateHeroCommandHandler(IHeroService heroService, IRoleService roleService, IAbilityService abilityService, IEffectService effectService, IItemSetService itemSetService, ISetBonusService setBonusService, IUniqueItemService uniqueItemService, HeroBusinessRules heroBusinessRule, IMapper mapper)
    {
        _heroService = heroService;
        _roleService = roleService;
        _abilityService = abilityService;
        _effectService = effectService;
        _itemSetService = itemSetService;
        _setBonusService = setBonusService;
        _uniqueItemService = uniqueItemService;
        _heroBusinessRule = heroBusinessRule;
        _mapper = mapper;
    }

    public async Task<CreateHeroCommandResponse> Handle(CreateHeroCommandRequest request, CancellationToken cancellationToken)
    {
        RandomCodeGenerator code1 = new RandomCodeGenerator();

        await _heroBusinessRule.HeroNameShouldNotBeExist(request.CreatedHeroDto.Name);

        var abilityList = new List<Ability>();
        foreach (var abilityDto in request.CreatedHeroDto.Abilities)
        {
            var effectIds = new List<Effect>();
            foreach (var createEffectDto in abilityDto.Effects)
            {
                var createdEffect = new Effect
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = createEffectDto.Name,
                    Value = createEffectDto.Value,
                    Damage = createEffectDto.Damage,
                    DamageUpgrade = createEffectDto.DamageUpgrade.ToList(),
                    Duration = createEffectDto.Duration,
                    DurationUpgrade = createEffectDto.DurationUpgrade.ToList(),
                    Type = createEffectDto.Type,
                    Upgrade = createEffectDto.Upgrade.ToList()
                };
                var effectId = await _effectService.Create(createdEffect);
                effectIds.Add(effectId);
            }

            var createdAbility = new Ability
            {
                Id = ObjectId.GenerateNewId().ToString(),
                AbilityType = abilityDto.AbilityType,
                Name = abilityDto.Name,
                Description = abilityDto.Description,
                Effects = effectIds,
                EffectUnit = abilityDto.EffectUnit,
                IconUrl = abilityDto.IconUrl,
                VideoUrl = abilityDto.VideoUrl,
                TacticalUse = abilityDto.TacticalUse,
                IsTriggered = abilityDto.IsTriggered,
                IsBlockable = abilityDto.IsBlockable,
                IsCondition = abilityDto.IsCondition,
                SlotNumber = abilityDto.SlotNumber,
                Target = abilityDto.Target,
                Cooldown = abilityDto.Cooldown.ToList(),
                Cost = abilityDto.Cost,
            };

            var abilityId = await _abilityService.Create(createdAbility);
            abilityList.Add(abilityId);
        }

        var itemSetList = new List<ItemSet>();
        foreach (var itemSetDto in request.CreatedHeroDto.ItemSets)
        {
            var effectIds = new List<Effect>();
            foreach (var createEffectDto in itemSetDto.UniqueItems.First().Effects)
            {
                var createdEffect = new Effect
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = createEffectDto.Name,
                    Value = createEffectDto.Value,
                    Damage = createEffectDto.Damage,
                    DamageUpgrade = createEffectDto.DamageUpgrade.ToList(),
                    Duration = createEffectDto.Duration,
                    DurationUpgrade = createEffectDto.DurationUpgrade.ToList(),
                    Type = createEffectDto.Type,
                    Upgrade = createEffectDto.Upgrade.ToList()
                };
                var effectId = await _effectService.Create(createdEffect);
                effectIds.Add(effectId);
            }

            var uniqueItemIds = new List<UniqueItem>();
            foreach (var createUniqueItemDto in itemSetDto.UniqueItems)
            {
                var createdUniqueItem = new UniqueItem
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = createUniqueItemDto.Name,
                    Description = createUniqueItemDto.Description,
                    Effects = createUniqueItemDto.Effects.Select(createEffectDto => new Effect
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        Name = createEffectDto.Name,
                        Value = createEffectDto.Value,
                        Damage = createEffectDto.Damage,
                        DamageUpgrade = createEffectDto.DamageUpgrade.ToList(),
                        Duration = createEffectDto.Duration,
                        DurationUpgrade = createEffectDto.DurationUpgrade.ToList(),
                        Type = createEffectDto.Type,
                        Upgrade = createEffectDto.Upgrade.ToList(),
                    }).ToList(),
                };
                var effect = await _effectService.Create(createdUniqueItem.Effects.First());
                var uniqueItemId = await _uniqueItemService.Create(createdUniqueItem);
                uniqueItemIds.Add(uniqueItemId);
            }

            var createdItemSet = new ItemSet
            {
                Id = ObjectId.GenerateNewId().ToString(),
                SetType = itemSetDto.SetType,
                Name = itemSetDto.Name,
                Description = itemSetDto.Description,
                Icon = itemSetDto.Icon,
                Rarity = itemSetDto.Rarity,
                Cost = itemSetDto.Cost,
                Resell = itemSetDto.Resell,
                UniqueItems = itemSetDto.UniqueItems.Select(createUniqueItemDto => new UniqueItem
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Name = createUniqueItemDto.Name,
                    Description = createUniqueItemDto.Description,
                    Effects = createUniqueItemDto.Effects.Select(createEffectDto => new Effect
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        Name = createEffectDto.Name,
                        Value = createEffectDto.Value,
                        Damage = createEffectDto.Damage,
                        DamageUpgrade = createEffectDto.DamageUpgrade.ToList(),
                        Duration = createEffectDto.Duration,
                        DurationUpgrade = createEffectDto.DurationUpgrade.ToList(),
                        Type = createEffectDto.Type,
                        Upgrade = createEffectDto.Upgrade.ToList(),
                    }).ToList(),
                }).ToList(),
                SetBonuses = itemSetDto.SetBonuses.Select(createSetBonusDto => new SetBonus
                {
                    Id = ObjectId.GenerateNewId().ToString(),
                    Type = createSetBonusDto.Type,
                    Description = createSetBonusDto.Description,
                    Effects = createSetBonusDto.Effects.Select(createEffectDto => new Effect
                    {
                        Id = ObjectId.GenerateNewId().ToString(),
                        Name = createEffectDto.Name,
                        Value = createEffectDto.Value,
                        Damage = createEffectDto.Damage,
                        DamageUpgrade = createEffectDto.DamageUpgrade.ToList(),
                        Duration = createEffectDto.Duration,
                        DurationUpgrade = createEffectDto.DurationUpgrade.ToList(),
                        Type = createEffectDto.Type,
                        Upgrade = createEffectDto.Upgrade.ToList(),
                    }).ToList(),
                    EffectUnit = createSetBonusDto.EffectUnit,
                    IsAbilityActive = createSetBonusDto.IsAbilityActive
                }).ToList()
            };

            var itemSetId = await _itemSetService.Create(createdItemSet);
            itemSetList.Add(itemSetId);
        }

        var hero = new Hero
        {
            Name = request.CreatedHeroDto.Name,
            Title = request.CreatedHeroDto.Title,
            Description = request.CreatedHeroDto.Description,
            HealthPoint = request.CreatedHeroDto.HealthPoint,
            HealthRegeneration = request.CreatedHeroDto.HealthRegeneration,
            ManaPoint = request.CreatedHeroDto.ManaPoint,
            ManaRegeneration = request.CreatedHeroDto.ManaRegeneration,
            MoveSpeed = request.CreatedHeroDto.MoveSpeed,
            AttackTime = request.CreatedHeroDto.AttackTime,
            CriticalChance = request.CreatedHeroDto.CriticalChance,
            CriticalDamageMod = request.CreatedHeroDto.CriticalDamageMod,
            EvadeChance = request.CreatedHeroDto.EvadeChance,
            Roles = request.CreatedHeroDto.Roles?.Select(role => new Role
            {
                Name = role.Name,
                Description = role.Description,
                IconUrl = role.IconUrl
            }).ToList(),
            Abilities = abilityList,
            ItemSets = itemSetList,
            
            CreatedDate = DateTime.UtcNow,
            Id = ObjectId.GenerateNewId().ToString(),
            Code = code1.GenerateUniqueCode(),
            Status = true,
            IsDeleted = false
        };

        foreach (var role in hero.Roles)
        {
            var createdRoleId = await _roleService.Create(new Role
            {
                Id = ObjectId.GenerateNewId().ToString(),
                Name = role.Name,
                Description = role.Description,
                IconUrl = role.IconUrl
            });
        }
        await _heroService.Create(hero);

        CreateHeroCommandResponse createdHeroDto = _mapper.Map<CreateHeroCommandResponse>(hero);
        return createdHeroDto;

    }
}