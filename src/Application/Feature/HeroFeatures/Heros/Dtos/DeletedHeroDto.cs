

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class DeletedHeroDto
{
    public Guid Id { get; set; }
    public bool Status { get; set; }
    public bool HeroStatStatus { get; set; }
    public bool HeroDetailStatus { get; set; }
    public DateTime DeletedDate { get; set; }


}
