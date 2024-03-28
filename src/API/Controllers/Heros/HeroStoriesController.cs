using Application.Feature.HeroFeatures.HeroStory.Commands.ChangeStatus;
using Application.Feature.HeroFeatures.HeroStory.Commands.Create;
using Application.Feature.HeroFeatures.HeroStory.Commands.Delete;
using Application.Feature.HeroFeatures.HeroStory.Commands.Remove;
using Application.Feature.HeroFeatures.HeroStory.Commands.UndoDelete;
using Application.Feature.HeroFeatures.HeroStory.Commands.Update;
using Application.Feature.HeroFeatures.HeroStory.Dtos;
using Application.Feature.HeroFeatures.HeroStory.Queries.GetById;
using Application.Feature.HeroFeatures.HeroStory.Queries.GetListByActive;
using Application.Feature.HeroFeatures.HeroStory.Queries.GetListByInActive;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.Heros;

//[Route("api/[controller]")]
//[ApiController]
//public class HeroStoriesController : BaseController
//{
//    [HttpPatch("ChangeStatus")]
//    public async Task<IActionResult> ChangeStatus([FromBody] ChangeStatusHeroStoryDto changeStatusHeroStoryDto)
//    {
//        ChangeStatusHeroStoryCommandRequest request = new()
//        {
//            ChangeStatusHeroStoryDto = changeStatusHeroStoryDto
//        };
//        ChangeStatusHeroStoryCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPost("Create")]
//    public async Task<IActionResult> Create([FromBody] CreateHeroStoryDto createHeroStoryDto)
//    {
//        CreateHeroStoryCommandRequest request = new()
//        {
//            CreateHeroStoryDto = createHeroStoryDto
//        };
//        CreateHeroStoryCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPatch("Delete")]
//    public async Task<IActionResult> Delete([FromBody] DeleteHeroStoryDto deleteHeroStoryDto)
//    {
//        DeleteHeroStoryCommandRequest request = new()
//        {
//            DeleteHeroStoryDto = deleteHeroStoryDto
//        };
//        DeleteHeroStoryCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPatch("UndoDelete")]
//    public async Task<IActionResult> UndoDelete([FromBody] UndoHeroStoryDto undoHeroStoryDto)
//    {
//        UndoDeleteHeroStoryCommandRequest request = new()
//        {
//            UndoHeroStoryDto = undoHeroStoryDto
//        };
//        UndoDeleteHeroStoryCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpDelete("Remove")]
//    public async Task<IActionResult> Remove([FromBody] RemoveHeroStoryDto removeHeroStoryDto)
//    {
//        RemoveHeroStoryCommandRequest request = new()
//        {
//            RemoveHeroStoryDto = removeHeroStoryDto
//        };
//        RemoveHeroStoryCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPut("Update")]
//    public async Task<IActionResult> Update([FromBody] UpdateHeroStoryDto updateHeroStoryDto)
//    {
//        UpdateHeroStoryCommandRequest request = new()
//        {
//            UpdateHeroStoryDto = updateHeroStoryDto
//        };
//        UpdateHeroStoryCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpGet("GetById")]
//    public async Task<IActionResult> GetById([FromQuery] GetByIdHeroStoryDto getByIdHeroStoryDto)
//    {
//        GetByIdHeroStoryQueryRequest request = new()
//        {
//            GetByIdHeroStoryDto = getByIdHeroStoryDto
//        };
//        GetByIdHeroStoryQueryResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpGet("GetByActiveList")]
//    public async Task<IActionResult> GetByActiveList([FromQuery] PageRequest pageRequest)
//    {
//        GetListByActiveHeroStoryQueryRequest request = new()
//        {
//            PageRequest = pageRequest
//        };
//        List<GetListByActiveHeroStoryQueryResponse> result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpGet("GetByInActiveList")]
//    public async Task<IActionResult> GetByInActiveList([FromQuery] PageRequest pageRequest)
//    {
//        GetListByInActiveHeroStoryQueryRequest request = new()
//        {
//            PageRequest = pageRequest
//        };
//        List<GetListByInActiveHeroStoryQueryResponse> result = await Mediator.Send(request);
//        return Ok(result);
//    }

//}
