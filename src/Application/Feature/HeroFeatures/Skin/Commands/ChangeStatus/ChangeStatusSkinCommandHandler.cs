using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.ChangeStatus;

public class ChangeStatusSkinCommandHandler : IRequestHandler<ChangeStatusSkinCommandRequest, ChangeStatusSkinCommandResponse>
{
    public Task<ChangeStatusSkinCommandResponse> Handle(ChangeStatusSkinCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
