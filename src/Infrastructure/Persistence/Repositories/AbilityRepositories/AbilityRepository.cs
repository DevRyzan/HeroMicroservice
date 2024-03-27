﻿using Application.Service.Repositories;
using Core.Persistence.Repositories;
using Core.Persistence.Repositories.Settings;
using Domain.Entities.Abilities;
using Microsoft.Extensions.Options;


namespace Persistence.Repositories.AbilityRepositories;

public class AbilityRepository : MongoDbRepositoryBase<Ability, string>, IAbilityRepository
{
    public AbilityRepository(IOptions<MongoDbSettings> options) : base(options)
    {
    }
}
