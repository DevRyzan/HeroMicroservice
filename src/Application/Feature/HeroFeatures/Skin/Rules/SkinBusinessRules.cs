using Application.Feature.HeroFeatures.Skin.Constants;
using Application.Service.Repositories;
using Core.Application;
using Core.CrossCuttingConcerns.Exceptions;

namespace Application.Feature.HeroFeatures.Skin.Rules;

public class SkinBusinessRules : BaseBusinessRules
{
    private readonly ISkinRepository _skinRepository;

    public SkinBusinessRules(ISkinRepository skinRepository)
    {
        _skinRepository = skinRepository;
    }

    public async Task IdShouldBeExist(Guid Id)
    {
        Domain.Entities.Heros.Skin skin = await _skinRepository.GetAsync(x => x.Id.Equals(Id));
        if (skin == null) throw new BusinessException(SkinMessages.IdShouldBeExist);
    }
    public async Task RemoveCondition(Guid Id)
    {
        Domain.Entities.Heros.Skin skin = await _skinRepository.GetAsync(x => x.Id.Equals(Id));
        if (skin.IsDeleted != true && skin.Status != false) throw new BusinessException(SkinMessages.RemoveCondition);
    }
}
