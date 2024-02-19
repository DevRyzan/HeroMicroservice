namespace Application.Feature.HeroFeatures.BardAndHero.Commands.Update;

public class UpdateBardAndHeroCommandResponse
{
    public Guid Id { get; set; }
    public Guid HeroId { get; set; }
    public Guid BardId { get; set; }
    public bool Status { get; set; }
    public bool IsDeleted { get; set; }
    public string Code { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
}
