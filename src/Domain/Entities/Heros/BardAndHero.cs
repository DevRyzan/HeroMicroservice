

using Core.Persistence.Repositories;

namespace Domain.Entities.Heros;

public class BardAndHero : Entity<Guid>
{
    public Guid BardId { get; set; }
    public Guid HeroId { get; set; }

    //public Bard Bard { get; set; }
    public Hero Hero { get; set; }

    public BardAndHero()
    {

    }
    //public BardAndHero()
    //{
    //    BardId = Convert.ToInt32(string.Empty);
    //    HeroId = Convert.ToInt32(string.Empty);
    //}

    public BardAndHero(Guid bardId, Guid heroId)
    {
        BardId = bardId;
        HeroId = heroId;
    }

    public BardAndHero(Guid id, Guid bardId, Guid heroId) : base(id)
    {
        Id = id;
        BardId = bardId;
        HeroId = heroId;
    }
}
