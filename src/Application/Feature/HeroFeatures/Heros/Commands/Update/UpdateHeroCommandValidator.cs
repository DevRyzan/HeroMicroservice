using Domain.Enums;
using FluentValidation;


namespace Application.Feature.HeroFeatures.Heros.Commands.Update;

public class UpdateHeroCommandValidator : AbstractValidator<UpdatedHeroCommandRequest>
{
    public UpdateHeroCommandValidator()
    {
        RuleFor(c => c.UpdateHeroDto.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.UpdateHeroDto.Region).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.UpdateHeroDto.Status).NotEmpty();
        RuleFor(c => c.UpdateHeroDto.Description).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.UpdateHeroDto.Title).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.UpdateHeroDto.Story).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.UpdateHeroDto.GamPrice).NotEmpty().GreaterThan(0);
        RuleFor(c => c.UpdateHeroDto.CreditPrice).NotEmpty().GreaterThan(0);
        RuleFor(c => c.UpdateHeroDto.DifficultLevel).Must(BeAValidDifficultLevelValue);
        RuleFor(c => c.UpdateHeroDto.HeroType).Must(BeAValidHeroTypeValue);

    }
    private bool BeAValidDifficultLevelValue(DifficultLevel difficultLevel)
    {
        return Enum.IsDefined(typeof(DifficultLevel), difficultLevel);
    }
    private bool BeAValidHeroTypeValue(HeroType heroType)
    {
        return Enum.IsDefined(typeof(HeroType), heroType);
    }
}