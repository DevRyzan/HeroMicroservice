using Core.Application.Requests;

namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class GetListByIdHeroDto<TId>
{
    public TId Id { get; set; }
    public PageRequest PageRequest { get; set; }

}