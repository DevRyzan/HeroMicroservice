using FluentValidation;


namespace Application.Feature.HeroFeatures.Heros.Commands.Create;


public class CreateHeroCommandValidator : AbstractValidator<CreateHeroCommandRequest>
{

    public CreateHeroCommandValidator()
    {
        RuleFor(c => c.CreatedHeroDto.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.CreatedHeroDto.Region).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.CreatedHeroDto.Status).NotEmpty();
        RuleFor(c => c.CreatedHeroDto.Description).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.CreatedHeroDto.Title).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(c => c.CreatedHeroDto.Story).NotEmpty().MinimumLength(2).MaximumLength(250);
        RuleFor(c => c.CreatedHeroDto.GamPrice).NotEmpty().GreaterThan(0);
        RuleFor(c => c.CreatedHeroDto.CreditPrice).NotEmpty().GreaterThan(0);
    }

}
