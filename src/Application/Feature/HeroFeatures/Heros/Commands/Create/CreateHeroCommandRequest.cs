using Application.Feature.HeroFeatures.Heros.Dtos;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.Create;

public class CreateHeroCommandRequest : IRequest<CreateHeroCommandResponse>
{
    public CreateHeroDto CreatedHeroDto { get; set; }

    //public string[] Roles => new[] { Admin, HeroAdd };
}
