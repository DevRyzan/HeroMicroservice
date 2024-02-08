using Core.Persistence.Repositories;

namespace Domain.Entities.Heros;

public class HeroDetail : Entity<Guid>
{
    public Guid HeroId { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string Story { get; set; }
    public string IconUrl { get; set; }
    public double GamPrice { get; set; }
    public double CreditPrice { get; set; }
    public DateTime PurchasedDate { get; set; }
    public DateTime ReturnedDate { get; set; }

    public Hero Hero { get; set; }
    public HeroDetail()
    {

    }
    //public HeroDetail()
    //{
    //    HeroId = Convert.ToInt32(string.Empty);
    //    Description = string.Empty;
    //    Title = string.Empty;
    //    Story = string.Empty;
    //    IconUrl = string.Empty;
    //    GamPrice = Convert.ToDouble(string.Empty);
    //    CreditPrice = Convert.ToDouble(string.Empty);
    //}

    public HeroDetail(string description, string title, string story, double gamPrice, double creditPrice, DateTime purchasedDate, DateTime returnedDate, Guid heroId)
    {
        Description = description;
        Title = title;
        Story = story;
        GamPrice = gamPrice;
        CreditPrice = creditPrice;
        PurchasedDate = purchasedDate;
        ReturnedDate = returnedDate;
        HeroId = heroId;
    }
    public HeroDetail(Guid id, string description, string title, string story, double gamPrice, double creditPrice, DateTime purchasedDate, DateTime returnedDate, Guid heroId) : base(id)
    {
        Id = id;
        Description = description;
        Title = title;
        Story = story;
        GamPrice = gamPrice;
        CreditPrice = creditPrice;
        PurchasedDate = purchasedDate;
        ReturnedDate = returnedDate;
        HeroId = heroId;
    }
}
