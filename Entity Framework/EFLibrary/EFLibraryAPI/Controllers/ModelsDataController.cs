using Microsoft.AspNetCore.Mvc;

namespace EFLibraryAPI.Controllers
{
    [ApiController]
    [Route("models")]
    public class ModelsDataController: ControllerBase
    {
        [HttpPost("generate")]
        public IActionResult GenerateData()
        {
            return Ok();
        }
    }
}