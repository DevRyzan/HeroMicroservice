
using Domain.Enums;


namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class CreatedHeroDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public DifficultLevel DifficultLevel { get; set; }
    public bool Status { get; set; }
    public HeroType HeroType { get; set; }

    //public int FirstAbilityId { get; set; }
    //public int SecondAbilityId { get; set; }
    //public int ThirdAbilityId { get; set; }
    //public int UltimateAbilityId { get; set; }
    //public int PasifeAbilityId { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string Story { get; set; }
    public double GamPrice { get; set; }
    public double CreditPrice { get; set; }
    public DateTime CreatedDate { get; set; }
    public int HeroDetailId { get; set; }


    public CreatedHeroDto()
    {

    }
    public CreatedHeroDto(Guid id, string name, string region, DifficultLevel difficultLevel, bool status, HeroType heroType, string description, string title, string story, double gamPrice, double creditPrice, DateTime createdDate, int heroDetailId)
    {
        Id = id;
        Name = name;
        Region = region;
        DifficultLevel = difficultLevel;
        Status = status;
        HeroType = heroType;
        Description = description;
        Title = title;
        Story = story;
        GamPrice = gamPrice;
        CreditPrice = creditPrice;
        CreatedDate = createdDate;
        HeroDetailId = heroDetailId;
    }

}