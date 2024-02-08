using Core.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Heros;


public class Skin : Entity<Guid>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int Price { get; set; }
    public DateTime PurchasedDate { get; set; }
    public DateTime ReturnedDate { get; set; }
    [NotMapped]
    public IFormFileCollection Files { get; set; }
    public byte[] Bytes { get; set; }
    public string FileExtension { get; set; }


    public ICollection<HeroAndSkin> HeroAndSkins { get; set; }

    public Skin()
    {

    }
    //public Skin()
    //{
    //    Title = string.Empty;
    //    Description = string.Empty;
    //    ImageUrl = string.Empty;
    //    Price = Convert.ToInt32(string.Empty);
    //    FileExtension = string.Empty;
    //}
    public Skin(string title, string description, string ımageUrl, int price, DateTime purchasedDate, DateTime returnedDate, IFormFileCollection files, byte[] bytes, string fileExtension)
    {
        Title = title;
        Description = description;
        ImageUrl = ımageUrl;
        Price = price;
        PurchasedDate = purchasedDate;
        ReturnedDate = returnedDate;
        Files = files;
        Bytes = bytes;
        FileExtension = fileExtension;
    }

    public Skin(Guid id, string title, string description, string ımageUrl, int price, DateTime purchasedDate, DateTime returnedDate, IFormFileCollection files, byte[] bytes, string fileExtension) : base(id)
    {
        Id = id;
        Title = title;
        Description = description;
        ImageUrl = ımageUrl;
        Price = price;
        PurchasedDate = purchasedDate;
        ReturnedDate = returnedDate;
        Files = files;
        Bytes = bytes;
        FileExtension = fileExtension;
    }
}