using Core.Persistence.Repositories;

namespace Domain.Entities.Heros;

public class HeroAndSkin : Entity<Guid>
{
    public Guid HeroId { get; set; }
    public Guid SkinId { get; set; }

    public Hero Hero { get; set; }
    public Skin Skin { get; set; }

    public HeroAndSkin()
    {

    }
    //public HeroAndSkin()
    //{
    //    HeroId = Convert.ToInt32(string.Empty);
    //    SkinId = Convert.ToInt32(string.Empty);
    //}

    public HeroAndSkin(Guid heroId, Guid skinId)
    {
        HeroId = heroId;
        SkinId = skinId;
    }

    public HeroAndSkin(Guid id, Guid heroId, Guid skinId) : base(id)
    {
        Id = id;
        HeroId = heroId;
        SkinId = skinId;
    }
}
