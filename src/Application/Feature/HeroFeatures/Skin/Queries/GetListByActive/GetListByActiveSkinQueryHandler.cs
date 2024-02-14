using Application.Service.HeroServices.SkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetListByActive;

public class GetListByActiveSkinQueryHandler : IRequestHandler<GetListByActiveSkinQueryRequest, List<GetListByActiveSkinQueryResponse>>
{
    private readonly IMapper _mapper;
    private readonly ISkinService _skinService;

    public GetListByActiveSkinQueryHandler(IMapper mapper, ISkinService skinService)
    {
        _mapper = mapper;
        _skinService = skinService;
    }

    public async Task<List<GetListByActiveSkinQueryResponse>> Handle(GetListByActiveSkinQueryRequest request, CancellationToken cancellationToken)
    {
        List<Domain.Entities.Heros.Skin> skins = await _skinService.GetListByActive(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<GetListByActiveSkinQueryResponse> mappedResponse = _mapper.Map<List<GetListByActiveSkinQueryResponse>>(skins);
        return mappedResponse;

    }
}
