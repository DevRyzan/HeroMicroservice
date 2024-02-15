using Application.Feature.HeroFeatures.HeroStats.Commands.Create;
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




}