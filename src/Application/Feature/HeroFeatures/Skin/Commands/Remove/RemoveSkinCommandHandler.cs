using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Commands.Remove;

public class RemoveSkinCommandHandler : IRequestHandler<RemoveSkinCommandRequest, RemoveSkinCommandResponse>
{
    public Task<RemoveSkinCommandResponse> Handle(RemoveSkinCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
