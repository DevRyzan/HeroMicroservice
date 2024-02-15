using FluentValidation;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Update;

public class UpdateHeroStatCommandValidator : AbstractValidator<UpdateHeroStatCommandRequest>
{
    public UpdateHeroStatCommandValidator()
    {
        RuleFor(c => c.UpdateHeroStatDto.Id)
            .NotEmpty();

        RuleFor(c => c.UpdateHeroStatDto.HeroId)
            .NotEmpty();

        RuleFor(c => c.UpdateHeroStatDto.Endurance)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.EnduranceGrowthRate)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.Mind)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.MindGrowthRate)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.Vigour)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.VigourGrowthRate)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.PhysicalDamage)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.MagicalDamage)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.AttackSpeed)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.CastSpeed)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.CriticalChance)
            //.NotNull()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.CriticalDamage)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.Health)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.HealthRegen)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.Mana)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.ManaRegen)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.PhysicalArmor)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.MagicArmor)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.LifeSteal)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.MoveSpeed)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.UpdateHeroStatDto.Status)
            .NotEmpty();



    }
}
