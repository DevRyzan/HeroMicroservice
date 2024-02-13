using FluentValidation;


namespace Application.Feature.HeroFeatures.Heros.Commands.Create;


public class CreateHeroCommandValidator : AbstractValidator<CreateHeroCommandRequest>
{

    public CreateHeroCommandValidator()
    {
        RuleFor(c => c.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.Region).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.Status).NotEmpty();
        RuleFor(c => c.Description).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.Title).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.Story).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.GamPrice).NotEmpty().GreaterThan(0);
        RuleFor(c => c.CreditPrice).NotEmpty().GreaterThan(0);
    }

}
