using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Update;

public class UpdateSkinCommandHandler : IRequestHandler<UpdateSkinCommandRequest, UpdateSkinCommandResponse>
{
    public Task<UpdateSkinCommandResponse> Handle(UpdateSkinCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
