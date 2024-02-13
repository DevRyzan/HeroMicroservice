using Core.Application.Transaction;
using MediatR;

namespace Application.Feature.HeroFeatures.Heros.Commands.Delete;

public class DeleteHeroCommandRequest : IRequest<DeleteHeroCommandResponse>
{
    public Guid Id { get; set; }
}
