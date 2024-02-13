using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Create;

public class CreateSkinCommandHandler : IRequestHandler<CreateSkinCommandRequest, CreateSkinCommandResponse>
{
    public Task<CreateSkinCommandResponse> Handle(CreateSkinCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
