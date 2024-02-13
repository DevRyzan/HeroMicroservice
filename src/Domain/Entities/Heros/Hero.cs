using Core.Persistence.Repositories;
using Domain.Abilities;
using Domain.Enums;


namespace Domain.Entities.Heros;


public class Hero : Entity<Guid>
{
    public string? Name { get; set; }
    public string? Region { get; set; }
    public DifficultLevel? DifficultLevel { get; set; }
    public HeroType? HeroType { get; set; }


    public HeroStat? HeroStat { get; set; }
    public HeroDetail? HeroDetail { get; set; }

    public ICollection<HeroAndSkin>? HeroAndSkins { get; set; }
    public ICollection<Ability>? Abilities { get; set; }
    public ICollection<BardAndHero>? BardAndHeros { get; set; }
    public ICollection<HeroStory>? HeroStories { get; set; }


    //public int FirstAbilityId { get; set; }
    //public int SecondAbilityId { get; set; }
    //public int ThirdAbilityId { get; set; }
    //public int UltimateAbilityId { get; set; }
    //public int PasifeAbilityId { get; set; } 

    public Hero()
    {

    }
    //public Hero()
    //{
    //    Name = string.Empty;
    //    Region = string.Empty;
    //    HeroAndSkins = new HashSet<HeroAndSkin>();
    //}

    //public Hero(string? name, string? region, DifficultLevel? difficultLevel, HeroType? heroType, HeroStat? heroStat, HeroDetail? heroDetail, ICollection<HeroAndSkin>? heroAndSkins, ICollection<Ability>? abilities, ICollection<BardAndHero>? bardAndHeros, ICollection<HeroStory>? heroStories)
    //{
    //    Name = name;
    //    Region = region;
    //    DifficultLevel = difficultLevel;
    //    HeroType = heroType;
    //    HeroStat = heroStat;
    //    HeroDetail = heroDetail;
    //    HeroAndSkins = heroAndSkins;
    //    Abilities = abilities;
    //    BardAndHeros = bardAndHeros;
    //    HeroStories = heroStories;
    //}

    //public Hero(Guid id, string? name, string? region, DifficultLevel? difficultLevel, HeroType? heroType, HeroStat? heroStat, HeroDetail? heroDetail, ICollection<HeroAndSkin>? heroAndSkins, ICollection<Ability>? abilities, ICollection<BardAndHero>? bardAndHeros, ICollection<HeroStory>? heroStories) : base(id)
    //{
    //    Id = id;
    //    Name = name;
    //    Region = region;
    //    DifficultLevel = difficultLevel;
    //    HeroType = heroType;
    //    HeroStat = heroStat;
    //    HeroDetail = heroDetail;
    //    HeroAndSkins = heroAndSkins;
    //    Abilities = abilities;
    //    BardAndHeros = bardAndHeros;
    //    HeroStories = heroStories;
    //}


}
