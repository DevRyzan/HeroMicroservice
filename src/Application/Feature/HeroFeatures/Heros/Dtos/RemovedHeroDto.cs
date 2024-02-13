
namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class RemovedHeroDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public int HeroDetailId { get; set; }
    public int HeroStatId { get; set; }

}
