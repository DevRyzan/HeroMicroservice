using Application.Feature.HeroFeatures.BardAndHero.Dtos;
using MediatR;

namespace Application.Feature.HeroFeatures.BardAndHero.Commands.ChangeStatus;

public class ChangeStatusBardAndHeroCommandRequest : IRequest<ChangeStatusBardAndHeroCommandResponse>
{
    public ChangeStatusBardAndHeroDto ChangeStatusBardAndHeroDto { get; set; }
}
