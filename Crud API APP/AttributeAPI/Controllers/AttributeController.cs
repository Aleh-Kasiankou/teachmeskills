using System.Collections.Generic;
using API.Entities;
using API.Models;
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
        public AttributeController(IRepository<AttributeEntity> repository)
        {
            _repository = repository;
        }

        private readonly IRepository<AttributeEntity> _repository;

        [HttpGet]
        public IEnumerable<AttributeEntity> GetAttributes()
        {
            IEnumerable<AttributeEntity> attributesList = _repository.GetAll();
            return attributesList;
        }

        [HttpGet("{id:int}")]
        public AttributeEntity GetAttribute([FromRoute] int id)
        {
            AttributeEntity entity = _repository.GetById(id);
            return entity;
        }

        [HttpPost]
        public IActionResult CreateAttribute([FromBody] AttributeCreateRequest model)
        {
            try
            {
                var id = _repository.Create(model);

                return Ok($"The id of the created attribute is {id}");
            }

            catch (ValidationError e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult EditAttribute([FromRoute] int id, [FromBody] AttributeUpdateRequest model)
        {
            try
            {
                _repository.UpdateById(id, model);

                return Ok($"The attribute has been successfully updated!");
            }
            catch (ValidationError e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpDelete("{id:int}")]
        public void DeleteAttribute([FromRoute] int id)
        {
            _repository.RemoveById(id);
        }
    }
}