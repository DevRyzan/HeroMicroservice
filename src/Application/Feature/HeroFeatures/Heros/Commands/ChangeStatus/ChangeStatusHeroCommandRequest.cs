using Core.Application.Transaction;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.ChangeStatus;

public class ChangeStatusHeroCommandRequest : IRequest<ChangeStatusHeroCommandResponse>
{
    public Guid Id { get; set; }
}
