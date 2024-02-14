namespace Application.Feature.HeroFeatures.Skin.Queries.GetListByActive;

public class GetListByActiveSkinQueryResponse
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int Price { get; set; }
    public bool Status { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public DateTime PurchasedDate { get; set; }
    public DateTime ReturnedDate { get; set; }
}
