using Application.Service.AbilityServices.AbilityService;
using Application.Service.AbilityServices.EffectService;
using Application.Service.HeroServices.BardAndHeroService;
using Application.Service.HeroServices.HeroAndSkinService;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using Application.Service.HeroServices.HeroStatService;
using Application.Service.HeroServices.HeroStoryService;
using Application.Service.HeroServices.RoleService;
using Application.Service.HeroServices.SkinService;
using Application.Service.ItemServices.ItemSetService;
using Application.Service.ItemServices.SetBonusService;
using Application.Service.ItemServices.UniqueItemService;
using Core.Application;
using Core.Application.Caching;
using Core.Application.Generator;
using Core.Application.Logging;
using Core.Application.Pipelines.Authorization;
using Core.Application.Pipelines.Validation;
using Core.Application.Transaction;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            configuration.AddOpenBehavior(typeof(AuthorizationBehavior<,>));
            configuration.AddOpenBehavior(typeof(CachingBehavior<,>));
            configuration.AddOpenBehavior(typeof(CacheRemovingBehavior<,>));
            configuration.AddOpenBehavior(typeof(LoggingBehavior<,>));
            configuration.AddOpenBehavior(typeof(RequestValidationBehavior<,>));
            configuration.AddOpenBehavior(typeof(TransactionScopeBehavior<,>));
            //configuration.RegisterServicesFromAssemblyContaining<>();
        });

        //services.AddMemoryCache();

        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));

        //services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());


        services.AddSingleton<IRandomCodeGenerator, RandomCodeGenerator>();


        services.AddScoped<IAbilityService, AbilityManager>();
        services.AddScoped<IEffectService, EffectManager>();
        services.AddScoped<IHeroService, HeroManager>();
        services.AddScoped<IRoleService, RoleManager>();
        services.AddScoped<IItemSetService, ItemSetManager>();
        services.AddScoped<ISetBonusService, SetBonusManager>();
        services.AddScoped<IUniqueItemService, UniqueItemManager>();


        return services;
    }
    public static IServiceCollection AddSubClassesOfType(this IServiceCollection services, Assembly assembly, Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (var item in types)
        {
            if (addWithLifeCycle == null)
            {
                services.AddScoped(item);
            }
            else
            {
                addWithLifeCycle(services, type);
            }
        }
        return services;
    }
}
