using EFLibraryPersistence;
using EFLibraryServices.DbDataGenerator;
using Microsoft.AspNetCore.Mvc;

namespace EFLibraryAPI.Controllers
{
    [ApiController]
    [Route("models")]
    public class ModelsDataController : ControllerBase
    {
        private readonly DbDataGenerator _dbDataGenerator;

        public ModelsDataController(DbDataGenerator dbDataGenerator)
        {
            _dbDataGenerator = dbDataGenerator;
        }

        [HttpPost("generate")]
        public IActionResult GenerateData()
        {
            try
            {
                _dbDataGenerator.GenerateData();   
            }
            catch
            {
                return Problem(statusCode:500);
            }

            return Ok();
        }
    }
}