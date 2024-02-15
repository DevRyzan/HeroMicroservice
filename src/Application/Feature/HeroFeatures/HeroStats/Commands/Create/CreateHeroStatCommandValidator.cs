using FluentValidation;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Create;

public class CreateHeroStatCommandValidator : AbstractValidator<CreateHeroStatCommandRequest>
{
    public CreateHeroStatCommandValidator()
    {
        RuleFor(c => c.CreateHeroStatDto.HeroId);

        RuleFor(c => c.CreateHeroStatDto.Endurance)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.EnduranceGrowthRate)
        //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.Mind)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.MindGrowthRate)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.Vigour)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.VigourGrowthRate)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.PhysicalDamage)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.MagicalDamage)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.AttackSpeed)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.CastSpeed)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.CriticalChance)
            //.NotNull()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.CriticalDamage)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.Health)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.HealthRegen)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.Mana)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.ManaRegen)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.PhysicalArmor)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.MagicArmor)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.LifeSteal)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.MoveSpeed)
            //.NotEmpty()
            .GreaterThanOrEqualTo(0);

        RuleFor(c => c.CreateHeroStatDto.Status)
            .NotEmpty();
    }
}
