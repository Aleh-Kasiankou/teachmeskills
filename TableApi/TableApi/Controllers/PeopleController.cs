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
        private IImportHandler<Person> ImportHandler { get;}

        public PeopleController(IImportHandler<Person> importHandler)
        {
            ImportHandler = importHandler;
        }

        [HttpGet]
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
    }
}