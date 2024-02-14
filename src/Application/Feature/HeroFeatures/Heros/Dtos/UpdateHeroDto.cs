using Domain.Enums;

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class UpdateHeroDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public bool Status { get; set; }
    public DifficultLevel DifficultLevel { get; set; }
    public HeroType HeroType { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string Story { get; set; }
    public string IconUrl { get; set; }
    public double GamPrice { get; set; }
    public double CreditPrice { get; set; }


}
