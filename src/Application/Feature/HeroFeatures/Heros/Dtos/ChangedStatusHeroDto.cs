

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class ChangedStatusHeroDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool Status { get; set; }
    public DateTime UpdatedDate { get; set; }

    public ChangedStatusHeroDto()
    {
    }

    public ChangedStatusHeroDto(Guid ıd, string name, bool status, DateTime updatedDate)
    {
        Id = ıd;
        Name = name;
        Status = status;
        UpdatedDate = updatedDate;
    }

}