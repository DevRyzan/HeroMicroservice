using Application.Feature.HeroFeatures.Skin.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.Skin.Commands.Create;
using Application.Feature.HeroFeatures.Skin.Commands.Delete;
using Application.Feature.HeroFeatures.Skin.Commands.Remove;
using Application.Feature.HeroFeatures.Skin.Commands.Update;
using Application.Feature.HeroFeatures.Skin.Dtos;
using Application.Feature.HeroFeatures.Skin.Queries.GetById;
using Application.Feature.HeroFeatures.Skin.Queries.GetListByActive;
using Application.Feature.HeroFeatures.Skin.Queries.GetListByInActive;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Heros;

[Route("api/[controller]")]
[ApiController]
public class SkinController : BaseController
{
    [HttpPatch("ChangeStatus")]
    public async Task<IActionResult> ChangeStatus([FromBody] ChangedStatusSkinDto changedStatusSkinDto)
    {
        ChangeStatusSkinCommandRequest request = new()
        {
            ChangedStatusSkinDto = changedStatusSkinDto
        };
        ChangeStatusSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreatedSkinDto createdSkinDto)
    {
        CreateSkinCommandRequest request = new()
        {
            CreatedSkinDto = createdSkinDto
        };
        CreateSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPatch("Delete")]
    public async Task<IActionResult> Delete([FromBody] DeletedSkinDto deletedSkinDto)
    {
        DeleteSkinCommandRequest request = new()
        {
            DeletedSkinDto = deletedSkinDto
        };
        DeleteSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpDelete("Remove")]
    public async Task<IActionResult> Remove([FromBody] RemoveSkinDto removeSkinDto)
    {
        RemoveSkinCommandRequest request = new()
        {
            RemoveSkinDto = removeSkinDto
        };
        RemoveSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateSkinDto updateSkinDto)
    {
        UpdateSkinCommandRequest request = new()
        {
            UpdateSkinDto = updateSkinDto
        };
        UpdateSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery] GetByIdSkinDto getByIdSkinDto)
    {
        GetByIdSkinQueryRequest request = new()
        {
            GetByIdSkinDto = getByIdSkinDto
        };
        GetByIdSkinQueryResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetByActiveList")]
    public async Task<IActionResult> GetByActiveList([FromQuery] PageRequest pageRequest)
    {
        GetListByActiveSkinQueryRequest request = new()
        {
            PageRequest = pageRequest
        };
        List<GetListByActiveSkinQueryResponse> result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetByInActiveList")]
    public async Task<IActionResult> GetByInActiveList([FromQuery] PageRequest pageRequest)
    {
        GetListByInActiveSkinQueryRequest request = new()
        {
            PageRequest = pageRequest
        };
        List<GetListByInActiveSkinQueryResponse> result = await Mediator.Send(request);
        return Ok(result);
    }
}
