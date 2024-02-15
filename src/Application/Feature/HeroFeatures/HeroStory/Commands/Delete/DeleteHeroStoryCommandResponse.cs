namespace Application.Feature.HeroFeatures.HeroStory.Commands.Delete;

public class DeleteHeroStoryCommandResponse
{
    public Guid Id { get; set; }
    public Guid HeroId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Story { get; set; }
    public string Code { get; set; }
    public bool Status { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
}
