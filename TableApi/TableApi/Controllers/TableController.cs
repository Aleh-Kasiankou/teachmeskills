using System.Collections.Generic;
using Io;
using Logger;
using Microsoft.AspNetCore.Mvc;

namespace TableApi.Controllers
{
    [ApiController]
    [Route("table")]
    public class TableController : ControllerBase
    {
        public ImportManager<Person> ImportManager { get; set; } = new ImportManager<Person>(new FileLogger());
        
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            var data = ImportManager.ImportTable();

            return data;
        }
        
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var data = ImportManager.ImportTable();
            if (data.Count < id + 1)
            {
                return BadRequest();
            }

            return data[id];
        }
    }
}