namespace Application.Feature.HeroFeatures.Skin.Dtos;

public class UpdateSkinDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int Price { get; set; }
    public bool Status { get; set; }
}
