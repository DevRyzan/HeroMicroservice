using Core.Application.Requests;


namespace Application.Feature.HeroFeatures.Heros.Dtos;

public class GetListByEnumTypeHeroDto<TEnum> where TEnum : Enum
{
    public TEnum EnumType { get; set; }
    public PageRequest PageRequest { get; set; }
}