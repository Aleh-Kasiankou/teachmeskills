using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebEF.Models;

namespace WebEF.Controllers
{
    [ApiController]
    [Route("Person")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly TestContext _testContext;

        public PersonController(ILogger<PersonController> logger, TestContext testContext)
        {
            _logger = logger;
            _testContext = testContext;
        }

        [HttpGet("/{id:guid}")]

        public Person Get([FromRoute] Guid id)
        {
            return _testContext.Persons.FirstOrDefault(x => x.Id == id);
        }
        
        [HttpPut("/{id:Guid}")]

        public async Task<Person> Put([FromRoute] Guid id, [FromBody] int age)
        {
            var person = await _testContext.Persons.FirstOrDefaultAsync(x => x.Id == id);
            person.Age = age;
            await _testContext.SaveChangesAsync();

            return person;
        }
        
        [HttpPost]
        public async Task<Person> Post([FromBody] Person person)
        {
            var transaction = await _testContext.Database.BeginTransactionAsync();
            _testContext.Persons.Add(person);
            await _testContext.SaveChangesAsync();
            await _testContext.SaveChangesAsync();
            await _testContext.SaveChangesAsync();

            await transaction.CommitAsync();
            await transaction.RollbackAsync();

            return person;
        }
    }
}