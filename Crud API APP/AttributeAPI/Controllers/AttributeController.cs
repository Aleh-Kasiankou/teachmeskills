using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Models.Attribute;
using API.Services.Repositories;
using API.Services.Validation;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("attribute")]
    public class AttributeController : ControllerBase
    {
        private readonly IRepository<AttributeEntity> _repository;

        public AttributeController(IRepository<AttributeEntity> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<AttributeEntity> GetAttributes()
        {
            IEnumerable<AttributeEntity> attributesList = _repository.GetAll();
            return attributesList;
        }

        [HttpGet("{id:int}")]
        public IActionResult GetAttribute([FromRoute] int id)
        {
            try
            {
                AttributeEntity entity = _repository.GetById(id);
                return Ok(entity);
            }
            catch (InvalidOperationException)
            {
                return BadRequest($"There is no attribute with id {id}");
            }
            
        }

        [HttpPost]
        public async Task<IActionResult> CreateAttribute([FromBody] AttributeCreateRequest model)
        {
            try
            {
                int id = await _repository.Create(model);

                return Ok($"The id of the created attribute is {id}");
            }

            catch (ValidationError e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> EditAttribute([FromRoute] int id, [FromBody] AttributeUpdateRequest model)
        {
            try
            {
                await _repository.UpdateById(id, model);

                return Ok($"The attribute has been successfully updated!");
            }
            catch (ValidationError e)
            {
                return BadRequest(e.Message);
            }
            catch (InvalidOperationException)
            {
                return BadRequest($"There is no attribute with id {id}");
            }
        }


        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteAttribute([FromRoute] int id)
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