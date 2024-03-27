﻿
using Domain.Entities.Abilities;

namespace Application.Service.AbilityServices.AbilityService;

public interface IAbilityService
{
    Task<Ability> Create(Ability ability);
    Task<Ability> Update(Ability ability);
    Task<Ability> Delete(Ability ability);
    Task<Ability> Remove(Ability ability);
    Task<Ability> GetById(Guid id);
    Task<List<Ability>> GetActiveList(int index = 0, int size = 10);
    Task<List<Ability>> GetInActiveList(int index = 0, int size = 10);
}
