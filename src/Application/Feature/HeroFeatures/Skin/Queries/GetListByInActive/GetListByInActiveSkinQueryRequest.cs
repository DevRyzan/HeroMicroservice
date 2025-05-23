﻿using Core.Application.Requests;
using MediatR;

namespace Application.Feature.HeroFeatures.Skin.Queries.GetListByInActive;

public class GetListByInActiveSkinQueryRequest : IRequest<List<GetListByInActiveSkinQueryResponse>>
{
    public PageRequest PageRequest { get; set; }
}
