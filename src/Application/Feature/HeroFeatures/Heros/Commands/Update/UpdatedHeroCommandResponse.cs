﻿
using Domain.Enums;


namespace Application.Feature.HeroFeatures.Heros.Commands.Update;

public class UpdatedHeroCommandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Region { get; set; }
    public bool Status { get; set; }

    //public int FirstAbilityId { get; set; }
    //public int SecondAbilityId { get; set; }
    //public int ThirdAbilityId { get; set; }
    //public int UltimateAbilityId { get; set; }
    //public int PasifeAbilityId { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public string IconUrl { get; set; }
    public string Story { get; set; }
    public double GamPrice { get; set; }
    public double CreditPrice { get; set; }
    public Guid HeroDetailId { get; set; }
    public HeroType HeroType { get; set; }
    public DifficultLevel DifficultLevel { get; set; }
    public DateTime UpdatedDate { get; set; }
}