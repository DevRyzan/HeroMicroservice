namespace Application.Feature.HeroFeatures.HeroAndSkin.Commands.UndoDelete;

public class UndoDeleteHeroAndSkinCommandResponse
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
