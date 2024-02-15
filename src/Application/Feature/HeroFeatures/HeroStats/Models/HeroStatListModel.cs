using Application.Feature.HeroFeatures.HeroStats.Dtos;
using Core.Persistence.Paging;


namespace Application.Feature.HeroFeatures.HeroStats.Models;


public class HeroStatListModel : BasePageableModel
{
    public IList<HeroStatListDto> Items { get; set; }
}

