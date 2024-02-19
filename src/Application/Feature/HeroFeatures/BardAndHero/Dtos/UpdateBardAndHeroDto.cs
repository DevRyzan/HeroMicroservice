namespace Application.Feature.HeroFeatures.BardAndHero.Dtos;

public class UpdateBardAndHeroDto
{
    public Guid Id { get; set; }
    public Guid HeroId { get; set; }
    public Guid BardId { get; set; }
}
