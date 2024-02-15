using Application.Feature.HeroFeatures.HeroStats.Dtos;
using MediatR;


namespace Application.Feature.HeroFeatures.HeroStats.Commands.ChangeStatus;

public class ChangeStatusHeroStatCommandRequest : IRequest<ChangeStatusHeroStatCommandResponse>
{
    public ChangeStatusHeroStatDto ChangeStatusHeroStatDto { get; set; }
}