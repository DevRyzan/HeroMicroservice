using Core.Persistence.Repositories;

namespace Domain.Entities.Heros;

public class HeroStory : Entity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Story { get; set; }

    public Guid HeroId { get; set; }
    public Hero Hero { get; set; }

    public HeroStory()
    {

    }
    //public HeroStory()
    //{
    //    Name = string.Empty;
    //    Description = string.Empty;
    //    Story = string.Empty;
    //    HeroId = Convert.ToInt32(string.Empty);
    //}
    public HeroStory(string name, string description, string story, Guid heroId, Hero hero)
    {
        Name = name;
        Description = description;
        Story = story;
        HeroId = heroId;
        Hero = hero;
    }
    public HeroStory(Guid id, string name, string description, string story, Guid heroId, Hero hero) : base(id)
    {
        Id = id;
        Name = name;
        Description = description;
        Story = story;
        HeroId = heroId;
        Hero = hero;
    }
}

