using Application.Feature.HeroFeatures.HeroStats.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.HeroStats.Commands.Delete;

public class DeleteHeroStatCommandRequest : IRequest<DeleteHeroStatCommandResponse>
{
    public DeleteHeroStatDto DeleteHeroStatDto { get; set; }
}
