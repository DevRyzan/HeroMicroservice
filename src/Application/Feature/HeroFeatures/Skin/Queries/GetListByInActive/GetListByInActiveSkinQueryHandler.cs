using Application.Service.HeroServices.SkinService;
using AutoMapper;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetListByInActive;

public class GetListByInActiveSkinQueryHandler : IRequestHandler<GetListByInActiveSkinQueryRequest, List<GetListByInActiveSkinQueryResponse>>
{
    private readonly IMapper _mapper;
    private readonly ISkinService _skinService;

    public GetListByInActiveSkinQueryHandler(IMapper mapper, ISkinService skinService)
    {
        _mapper = mapper;
        _skinService = skinService;
    }

    public async Task<List<GetListByInActiveSkinQueryResponse>> Handle(GetListByInActiveSkinQueryRequest request, CancellationToken cancellationToken)
    {
        List<Domain.Entities.Heros.Skin> skins = await _skinService.GetListByInActive(index: request.PageRequest.Page, size: request.PageRequest.PageSize);

        List<GetListByInActiveSkinQueryResponse> mappedResponse = _mapper.Map<List<GetListByInActiveSkinQueryResponse>>(skins);

        return mappedResponse;
    }
}
