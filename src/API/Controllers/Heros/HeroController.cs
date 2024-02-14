using Application.Feature.HeroFeatures.Heros.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.Heros.Commands.Create;
using Application.Feature.HeroFeatures.Heros.Commands.Delete;
using Application.Feature.HeroFeatures.Heros.Commands.Remove;
using Application.Feature.HeroFeatures.Heros.Commands.Update;
using Application.Feature.HeroFeatures.Heros.Dtos;
using Application.Feature.HeroFeatures.Heros.Models;
using Application.Feature.HeroFeatures.Heros.Queries.GetByIdHero;
using Application.Feature.HeroFeatures.Heros.Queries.GetByIdHeroAndHeroStat;
using Application.Feature.HeroFeatures.Heros.Queries.GetListByAbilityId;
using Application.Feature.HeroFeatures.Heros.Queries.GetListByActive;
using Application.Feature.HeroFeatures.Heros.Queries.GetListByDifficultLevel;
using Application.Feature.HeroFeatures.Heros.Queries.GetListByHeroType;
using Application.Feature.HeroFeatures.Heros.Queries.GetListByInActive;
using Application.Feature.HeroFeatures.Heros.Queries.GetListHero;
using Core.Application.Requests;
using Core.Persistence.Paging;
using Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Heros;


[Route("api/[controller]")]
[ApiController]
public class HeroController : BaseController
{
    [HttpPost("Create")]
    public async Task<IActionResult> Create([FromBody] CreateHeroDto createHeroDto)
    {
        CreateHeroCommandRequest request = new()
        {
            CreatedHeroDto = createHeroDto
        };
        CreateHeroCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }
    [HttpPut("Delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteHeroDto deleteHeroDto)
    {
        DeleteHeroCommandRequest request = new()
        {
            DeletedHeroDto = deleteHeroDto
        };
        DeleteHeroCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPut("Update")]  
    public async Task<IActionResult> Update([FromBody] UpdateHeroDto updateHeroDto)
    {
        UpdatedHeroCommandRequest request = new()
        {
            UpdateHeroDto = updateHeroDto
        };
        UpdatedHeroCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpDelete("Remove")]
    public async Task<IActionResult> DeleteHero([FromQuery] RemoveHeroDto removeHeroDto)
    {
        RemoveHeroCommandRequest request = new()
        {
            RemoveHeroDto = removeHeroDto
        };
        RemoveHeroCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpPut("ChangeStatusHero")]
    public async Task<IActionResult> ChangeStatusHero([FromBody] ChangeStatusHeroDto changeStatusHeroDto)
    {
        ChangeStatusHeroCommandRequest request = new()
        {
            ChangeStatusHeroDto = changeStatusHeroDto
        };
        ChangeStatusHeroCommandResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdHero([FromQuery] GetByIdDto getByIdDto)
    {
        GetByIdHeroQueryRequest request = new()
        {
            GetByIdDto = getByIdDto
        };
        GetByIdHeroQueryResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetByIdHeroAndStat")]
    public async Task<IActionResult> GetByIdHeroAndStat([FromQuery] GetByIdDto getByIdDto)
    {
        GetByIdHeroAndHeroStatQueryRequest request = new()
        {
            GetByIdDto = getByIdDto
        };
        GetByIdHeroAndHeroStatQueryResponse result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetListByHeroType")]
    public async Task<IActionResult> GetListByHeroType([FromQuery] GetListByEnumTypeHeroDto<HeroType> getListByEnumTypeHeroDto)
    {
        GetListByHeroTypeQueryRequest request = new()
        {
            HeroType = getListByEnumTypeHeroDto.EnumType,
            PageRequest = getListByEnumTypeHeroDto.PageRequest
        };

        GetListResponse<HeroListModel> result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetListByDifficultLevel")]
    public async Task<IActionResult> GetListByDifficultLevel([FromQuery] GetListByEnumTypeHeroDto<DifficultLevel> getListByEnumTypeHeroDto)
    {
        GetListByDifficultLevelQueryRequest request = new()
        {
            DifficultLevel = getListByEnumTypeHeroDto.EnumType,
            PageRequest = getListByEnumTypeHeroDto.PageRequest
        };

        GetListResponse<HeroListModel> result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetListByActive")]
    public async Task<IActionResult> GetActiveListHero([FromQuery] PageRequest pageRequest)
    {
        GetActiveHeroListQueryRequest request = new()
        {
            PageRequest = pageRequest
        };
        GetListResponse<HeroListModel> result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetListByInActive")]
    public async Task<IActionResult> GetByStatus([FromQuery] PageRequest pageRequest)
    {
        GetListHeroByInActiveQueryRequest request = new()
        {
            PageRequest = pageRequest
        };
        GetListResponse<HeroListModel> result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetListByAbilityId")]
    public async Task<IActionResult> GetByStatus([FromQuery] GetListByIdHeroDto<Guid> getListByIdHeroDto)
    {
        GetListByAbilityIdHeroQueryRequest request = new()
        {
            AbilityId = getListByIdHeroDto.Id,
            PageRequest = getListByIdHeroDto.PageRequest
        };

        GetListResponse<GetListByAbilityIdHeroQueryResponse> result = await Mediator.Send(request);
        return Ok(result);
    }

    [HttpGet("GetListAllHeros")]
    public async Task<IActionResult> GetListHero([FromQuery] PageRequest pageRequest)
    {
        GetListHeroQueryRequest request = new()
        {
            PageRequest = pageRequest
        };

        GetListResponse<HeroListModel> result = await Mediator.Send(request);
        return Ok(result);
    }
}