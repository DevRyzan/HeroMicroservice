
using FluentValidation;


namespace Application.Feature.HeroFeatures.Heros.Commands.ChangeStatus;

public class ChangeStatusHeroCommandValidator : AbstractValidator<ChangeStatusHeroCommandRequest>
{
    public ChangeStatusHeroCommandValidator()
    {
        //RuleFor(c => c.Id).GreaterThan(0);

    }
}