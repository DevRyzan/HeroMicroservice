namespace Application.Feature.HeroFeatures.HeroAndSkin.Dtos;

public class UpdateHeroAndSkinDto
{
    public Guid Id { get; set; }
    public Guid HeroId { get; set; }
    public Guid SkinId { get; set; }
}
