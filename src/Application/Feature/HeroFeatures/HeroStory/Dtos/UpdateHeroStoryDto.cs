namespace Application.Feature.HeroFeatures.HeroStory.Dtos;

public class UpdateHeroStoryDto
{
    public Guid Id { get; set; }
    public Guid HeroId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Story { get; set; }
}
