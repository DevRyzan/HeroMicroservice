using Application.Feature.HeroFeatures.HeroAndSkin.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Create;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Delete;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Remove;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.UndoDelete;
using Application.Feature.HeroFeatures.HeroAndSkin.Commands.Update;
using Application.Feature.HeroFeatures.HeroAndSkin.Dtos;
using Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetById;
using Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByActive;
using Application.Feature.HeroFeatures.HeroAndSkin.Queries.GetListByInActive;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Heros;

[Route("api/[controller]")]
[ApiController]
public class HeroAndSkinsController : BaseController
{
    [HttpPatch("ChangeStatus")]
    public async Task<IActionResult> ChangeStatus([FromBody] ChangeStatusHeroAndSkinDto  changeStatusHeroAndSkinDto)
    {
        ChangeStatusHeroAndSkinCommandRequest request = new()
        {
             ChangeStatusHeroAndSkinDto = changeStatusHeroAndSkinDto
        };
        ChangeStatusHeroAndSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateStatusHeroAndSkinDto  createStatusHeroAndSkinDto)
    {
        CreateHeroAndSkinCommandRequest request = new()
        {
              CreateStatusHeroAndSkinDto = createStatusHeroAndSkinDto
        };
        CreateHeroAndSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPatch("Delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteStatusHeroAndSkinDto  deleteStatusHeroAndSkinDto)
    {
        DeleteHeroAndSkinCommandRequest request = new()
        {
             DeleteStatusHeroAndSkinDto = deleteStatusHeroAndSkinDto
        };
        DeleteHeroAndSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPatch("UndoDelete")]
    public async Task<IActionResult> UndoDelete([FromBody] UndoDeleteHeroAndSkinDto  undoDeleteHeroAndSkinDto)
    {
        UndoDeleteHeroAndSkinCommandRequest request = new()
        {
             UndoDeleteHeroAndSkinDto = undoDeleteHeroAndSkinDto
        };
        UndoDeleteHeroAndSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpDelete("Remove")]
    public async Task<IActionResult> Remove([FromBody] RemoveHeroAndSkinDto  removeHeroAndSkinDto)
    {
        RemoveHeroAndSkinCommandRequest request = new()
        {
             RemoveHeroAndSkinDto = removeHeroAndSkinDto
        };
        RemoveHeroAndSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateHeroAndSkinDto  updateHeroAndSkinDto)
    {
        UpdateHeroAndSkinCommandRequest request = new()
        {
             UpdateHeroAndSkinDto = updateHeroAndSkinDto
        };
        UpdateHeroAndSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById([FromQuery] GetByIdHeroAndSkin  getByIdHeroAndSkin)
    {
        GetByIdHeroAndSkinCommandRequest request = new()
        {
             GetByIdHeroAndSkin = getByIdHeroAndSkin
        };
        GetByIdHeroAndSkinCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetByActiveList")]
    public async Task<IActionResult> GetByActiveList([FromQuery] PageRequest pageRequest)
    {
        GetListByActiveHeroAndSkinCommandRequest request = new()
        {
            PageRequest = pageRequest
        };
        List<GetListByActiveHeroAndSkinCommandResponse> result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetByInActiveList")]
    public async Task<IActionResult> GetByInActiveList([FromQuery] PageRequest pageRequest)
    {
        GetListByInActiveHeroAndSkinCommandRequest request = new()
        {
            PageRequest = pageRequest
        };
        List<GetListByInActiveHeroAndSkinCommandResponse> result = await Mediator.Send(request);
        return Ok(result);
    }
}
