using Application.Feature.HeroFeatures.HeroStats.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.HeroStats.Commands.Create;
using Application.Feature.HeroFeatures.HeroStats.Commands.Delete;
using Application.Feature.HeroFeatures.HeroStats.Commands.Remove;
using Application.Feature.HeroFeatures.HeroStats.Commands.Update;
using Application.Feature.HeroFeatures.HeroStats.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Heros;


[Route("api/[controller]")]
[ApiController]
public class HeroStatController : BaseController
{
    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateHeroStatDto createHeroStatDto)
    {
        CreateHeroStatCommandRequest request = new()
        {
            CreateHeroStatDto = createHeroStatDto
        };
        CreateHeroStatCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update([FromBody] UpdateHeroStatDto updateHeroStatDto)
    {
        UpdateHeroStatCommandRequest request = new()
        {
            UpdateHeroStatDto = updateHeroStatDto
        };
        UpdateHeroStatCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPut("Delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteHeroStatDto deleteHeroStatDto)
    {
        DeleteHeroStatCommandRequest request = new()
        {
            DeleteHeroStatDto = deleteHeroStatDto
        };
        DeleteHeroStatCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPut("ChangeStatus")]
    public async Task<IActionResult> ChangeStatus([FromBody] ChangeStatusHeroStatDto changeStatusHeroStatDto)
    {
        ChangeStatusHeroStatCommandRequest request = new()
        {
            ChangeStatusHeroStatDto = changeStatusHeroStatDto
        };
        ChangeStatusHeroStatCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    
    [HttpDelete("Remove")]
    public async Task<IActionResult> Remove([FromQuery] RemoveHeroStatDto removeHeroStatDto)
    {
        RemoveHeroStatCommandRequest request = new()
        {
            RemoveHeroStatDto = removeHeroStatDto
        };
        RemoveHeroStatCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

}