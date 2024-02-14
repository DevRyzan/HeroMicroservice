using Application.Feature.HeroFeatures.Heros.Dtos;
using Core.Application.Transaction;
using MediatR;

namespace Application.Feature.HeroFeatures.Heros.Commands.Delete;

public class DeleteHeroCommandRequest : IRequest<DeleteHeroCommandResponse>
{
    public DeleteHeroDto DeletedHeroDto{ get; set; }
}
