
namespace API.Controllers.Heros;

//[Route("api/[controller]")]
//[ApiController]
//public class BardAndHeroController : BaseController
//{
//    [HttpPatch("ChangeStatus")]
//    public async Task<IActionResult> ChangeStatus([FromBody] ChangeStatusBardAndHeroDto changeStatusBardAndHeroDto)
//    {
//        ChangeStatusBardAndHeroCommandRequest request = new()
//        {
//            ChangeStatusBardAndHeroDto = changeStatusBardAndHeroDto
//        };
//        ChangeStatusBardAndHeroCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPost("Create")]
//    public async Task<IActionResult> Create([FromBody] CreateBardAndHeroDto createBardAndHeroDto)
//    {
//        CreateBardAndHeroCommandRequest request = new()
//        {
//            CreateBardAndHeroDto = createBardAndHeroDto
//        };
//        CreateBardAndHeroCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPatch("Delete")]
//    public async Task<IActionResult> Delete([FromBody] DeleteBardAndHeroDto deleteBardAndHeroDto)
//    {
//        DeleteBardAndHeroCommandRequest request = new()
//        {
//            DeleteBardAndHeroDto = deleteBardAndHeroDto
//        };
//        DeleteBardAndHeroCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPatch("UndoDelete")]
//    public async Task<IActionResult> UndoDelete([FromBody] UndoDeleteBardAndHeroDto undoDeleteBardAndHeroDto)
//    {
//        UndoDeleteBardAndHeroCommandRequest request = new()
//        {
//            UndoDeleteBardAndHeroDto = undoDeleteBardAndHeroDto
//        };
//        UndoDeleteBardAndHeroCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpDelete("Remove")]
//    public async Task<IActionResult> Remove([FromBody] RemoveBardAndHeroDto removeBardAndHeroDto)
//    {
//        RemoveBardAndHeroCommandRequest request = new()
//        {
//            RemoveBardAndHeroDto = removeBardAndHeroDto
//        };
//        RemoveBardAndHeroCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpPut("Update")]
//    public async Task<IActionResult> Update([FromBody] UpdateBardAndHeroDto  updateBardAndHeroDto)
//    {
//        UpdateBardAndHeroCommandRequest request = new()
//        {
//             UpdateBardAndHeroDto = updateBardAndHeroDto
//        };
//        UpdateBardAndHeroCommandResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpGet("GetById")]
//    public async Task<IActionResult> GetById([FromQuery] GetByIdBardAndHeroDto  getByIdBardAndHeroDto)
//    {
//        GetByIdBardAndHeroQueryRequest request = new()
//        {
//             GetByIdBardAndHeroDto = getByIdBardAndHeroDto
//        };
//        GetByIdBardAndHeroQueryResponse result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpGet("GetByActiveList")]
//    public async Task<IActionResult> GetByActiveList([FromQuery] PageRequest pageRequest)
//    {
//        GetListByActiveBardAndHeroQueryRequest request = new()
//        {
//            PageRequest = pageRequest
//        };
//        List<GetListByActiveBardAndHeroQueryResponse> result = await Mediator.Send(request);
//        return Ok(result);
//    }

//    [HttpGet("GetByInActiveList")]
//    public async Task<IActionResult> GetByInActiveList([FromQuery] PageRequest pageRequest)
//    {
//        GetListByInActiveBardAndHeroQueryRequest request = new()
//        {
//            PageRequest = pageRequest
//        };
//        List<GetListByInActiveBardAndHeroQueryResponse> result = await Mediator.Send(request);
//        return Ok(result);
//    }
//}
