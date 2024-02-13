using Domain.Enums;
using FluentValidation;


namespace Application.Feature.HeroFeatures.Heros.Commands.Update;

public class UpdateHeroCommandValidator : AbstractValidator<UpdatedHeroCommandRequest>
{
    public UpdateHeroCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.Region).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.Description).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.Title).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.Story).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.GamPrice).NotEmpty().GreaterThan(0);
        RuleFor(c => c.CreditPrice).NotEmpty().GreaterThan(0);
        RuleFor(c => c.DifficultLevel).Must(BeAValidDifficultLevelValue);
        RuleFor(c => c.HeroType).Must(BeAValidHeroTypeValue);

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