using Application.Service.Repositories;
using Core.Persistence.Repositories.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositories.HeroRepositories;


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
            .AddScoped<IBardAndHeroRepository, BardAndHeroRepository>()
            .AddScoped<IHeroAndSkinRepository, HeroAndSkinRepository>()
            .AddScoped<IHeroDetailRepository, HeroDetailRepository>()
            .AddScoped<IHeroRepository, HeroRepository>()
            .AddScoped<IHeroStatRepository, HeroStatRepository>()
            .AddScoped<IHeroStoryRepository, HeroStoryRepository>()
            .AddScoped<ISkinRepository, SkinRepository>();
    }
}