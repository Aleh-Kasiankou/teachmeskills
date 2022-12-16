using EFLibraryPersistence;
using EFLibraryServices.DbSampleDataGenerator;
using Microsoft.AspNetCore.Mvc;

namespace EFLibraryAPI.Controllers
{
    [ApiController]
    [Route("sample_data")]
    public class SampleDataController : ControllerBase
    {
        private readonly DbSampleDataGenerator _dbSampleDataGenerator;

        public SampleDataController(DbSampleDataGenerator dbSampleDataGenerator)
        {
            _dbSampleDataGenerator = dbSampleDataGenerator;
        }

        [HttpPost]
        public IActionResult GenerateData()
        {
            try
            {
                _dbSampleDataGenerator.GenerateData();   
            }
            catch
            {
                return Problem(statusCode:500);
            }

            return Ok();
        }
    }
}