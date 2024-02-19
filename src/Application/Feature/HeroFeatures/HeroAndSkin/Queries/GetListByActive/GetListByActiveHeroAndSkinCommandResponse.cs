namespace Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByActive;

public class GetListByActiveHeroAndSkinCommandResponse
{
    public Guid Id { get; set; }
    public Guid HeroId { get; set; }
    public Guid SkinId { get; set; }
    public bool Status { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
}
