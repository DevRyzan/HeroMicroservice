using Domain.Enums;

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class HeroListDto
{
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
    public int HeroDetailId { get; set; }

    public HeroListDto()
    {
    }

    public HeroListDto(string name, string region, DifficultLevel difficultLevel, bool status, HeroType heroType, int heroDetailId)
    {
        Name = name;
        Region = region;
        DifficultLevel = difficultLevel;
        Status = status;
        HeroType = heroType;
        HeroDetailId = heroDetailId;
    }

}