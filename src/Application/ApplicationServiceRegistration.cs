﻿using Application.Service.HeroServices.HeroAndSkinService;
using Application.Service.HeroServices.HeroDetailService;
using Application.Service.HeroServices.HeroService;
using Application.Service.HeroServices.HeroStatService;
using Application.Service.HeroServices.SkinService;
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


        services.AddScoped<ISkinService, SkinManager>();
        services.AddScoped<IHeroAndSkinService, HeroAndSkinManager>();
        services.AddScoped<IHeroDetailService, HeroDetailManager>();
        services.AddScoped<IHeroService, HeroManager>();
        services.AddScoped<IHeroStatService, HeroStatManager>();

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
