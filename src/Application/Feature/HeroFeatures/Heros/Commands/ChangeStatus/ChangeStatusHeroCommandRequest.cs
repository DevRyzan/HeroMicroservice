using Application.Feature.HeroFeatures.Heros.Dtos;
using Core.Application.Transaction;
using MediatR;


namespace Application.Feature.HeroFeatures.Heros.Commands.ChangeStatus;

public class ChangeStatusHeroCommandRequest : IRequest<ChangeStatusHeroCommandResponse>
{
    public ChangeStatusHeroDto ChangeStatusHeroDto { get; set; }
}
