using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Models.Attribute;
using API.Services.Repositories;
using API.Services.Validation;
using Microsoft.AspNetCore.Mvc;
using Attribute = API.Entities.Attribute;


namespace API.Controllers
{
    [ApiController]
    [Route("attribute")]
    public class AttributeController : ControllerBase
    {
        private readonly IRepository<Attribute> _repository;

        public AttributeController(IRepository<Attribute> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Attribute> GetAttributes()
        {
            return _repository.GetAll();;
        }

        [HttpGet("{id:Guid}")]
        public IActionResult GetAttribute([FromRoute] Guid id)
        {
            try
            {
                return Ok(_repository.GetById(id));
            }
            catch (InvalidOperationException)
            {
                return NotFound($"There is no attribute with id {id}");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttribute([FromBody] AttributeCreateRequest model)
        {
            try
            {
                Guid id = await _repository.Create(model);

                return Ok($"The id of the created attribute is {id}");
            }

            catch (ValidationErrorException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:Guid}")]
        public async Task<IActionResult> EditAttribute([FromRoute] Guid id, [FromBody] AttributeUpdateRequest model)
        {
            try
            {
                await _repository.UpdateById(id, model);

                return Ok($"The attribute has been successfully updated!");
            }
            catch (ValidationErrorException e)
            {
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException)
            {
                return BadRequest($"There is no attribute with id {id}");
            }
        }


        [HttpDelete("{id:Guid}")]
        public async Task<IActionResult> DeleteAttribute([FromRoute] Guid id)
        {
            try
            {
                await _repository.RemoveById(id);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return BadRequest($"There is no attribute with id {id}");
            }
            catch (AggregateException e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}