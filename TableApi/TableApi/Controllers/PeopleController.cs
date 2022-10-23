using System.Collections.Generic;
using Io;
using Logger;
using Microsoft.AspNetCore.Mvc;

namespace TableApi.Controllers
{
    [ApiController]
    [Route("people/get")]
    public class PeopleController : ControllerBase
    {
        public ILogger Logger { get; set; }
        
        public PeopleController(ILogger logger)
        {
            Logger = logger;
        }

        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var importManager = new ImportManager<Person>(Logger);
            var data = importManager.ImportTable();

            return data;
        }
        
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var importManager = new ImportManager<Person>(Logger);
            var data = importManager.ImportTable();
            if (data.Count < id + 1)
            {
                return BadRequest();
            }

            return data[id];
        }
    }
}