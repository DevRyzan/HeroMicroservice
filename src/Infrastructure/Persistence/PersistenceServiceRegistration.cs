using Application.Service.Repositories;
using Core.Persistence.Repositories.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories.AbilityRepositories;
using Persistence.Repositories.HeroRepositories;
using Persistence.Repositories.ItemRepositories;


namespace Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services
            .Configure<MongoDbSettings>(options =>
            {
                options.ConnectionString = configuration.GetSection(nameof(MongoDbSettings) + ":" + MongoDbSettings.ConnectionStringValue).Value;
                options.Database = configuration.GetSection(nameof(MongoDbSettings) + ":" + MongoDbSettings.DatabaseValue).Value;
            })
            .AddTransient<BaseDbContext>()
            .AddScoped<IHeroRepository, HeroRepository>()
            .AddScoped<IAbilityRepository, AbilityRepository>()
            .AddScoped<IEffectRepository, EffectRepository>()
            .AddScoped<IItemSetRepository, ItemSetRepository>()
            .AddScoped<IRoleRepository, RoleRepository>()
            .AddScoped<ISetBonusRepository, SetBonusRepository>()
            .AddScoped<IUniqueItemRepository, UniqueItemRepository>();
    }
}