using Application.Feature.HeroFeatures.HeroStats.Dtos;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.Create;

public class CreateHeroStatCommandRequest : IRequest<CreateHeroStatCommandResponse>
{
    public CreateHeroStatDto CreateHeroStatDto { get; set; }
}
