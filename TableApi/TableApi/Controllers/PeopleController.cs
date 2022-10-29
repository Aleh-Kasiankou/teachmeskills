using System.Collections.Generic;
using Io;
using Logger;
using Microsoft.AspNetCore.Mvc;

namespace TableApi.Controllers
{
    [ApiController]
    [Route("people")]
    public class PeopleController : ControllerBase
    {
        private IImportHandler<Person> ImportHandler { get; }

        public PeopleController(IImportHandler<Person> importHandler)
        {
            ImportHandler = importHandler;
        }

        [HttpGet("get")]
        public IEnumerable<Person> Get()
        {
            var data = ImportHandler.ImportTable();

            return data;
        }

        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            var data = ImportHandler.ImportTable();
            if (data.Count < id + 1)
            {
                return BadRequest();
            }

            return data[id];
        }

        [HttpPost("post")]
        public IActionResult AddNewPerson([FromBody] Person person)
        {
            var data = ImportHandler.ImportTable();
            data.Add(person);
            ImportHandler.ExportData(data);

            return Ok();
        }

        [HttpPut("put/{id}")]
        public IActionResult EditPerson([FromRoute] int id, [FromBody] Person person)
        {
            var isSavedPerson = (Get(id).Result);
            if (isSavedPerson is BadRequestResult)
            {
                return BadRequest();
            }

            var data = ImportHandler.ImportTable();
            data[id] = person;
            ImportHandler.ExportData(data);
            
            return Ok();
        }
        
        [HttpDelete("delete/{id}")]
        public IActionResult DeletePerson([FromRoute] int id)
        {
            var isSavedPerson = (Get(id).Result);
            if (isSavedPerson is BadRequestResult)
            {
                return BadRequest();
            }

            var data = ImportHandler.ImportTable();
            data.RemoveAt(id);
            ImportHandler.ExportData(data);
            
            return Ok();
        }
    }
}