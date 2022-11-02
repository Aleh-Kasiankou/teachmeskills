using System.Collections.Generic;
using API.Helpers.Mapping;
using API.Helpers.Validation;
using Microsoft.AspNetCore.Mvc;
using Models;
using RepositoryService;
using RepositoryService.Entities;
using RepositoryService.Repositories;


namespace API.Controllers
{
    [ApiController]
    [Route("attribute")]
    public class AttributeController : ControllerBase
    {
        public AttributeController(IRepository<AttributeEntity> repository, IValidator<AttributeModel> validator, IMapper<AttributeModel> mapper)
        {
            _repository = repository;
            _validator = validator;
            _mapper = mapper;
        }

        private readonly IRepository<AttributeEntity> _repository;
        private readonly IValidator<AttributeModel> _validator;
        private readonly IMapper<AttributeModel> _mapper;

        [HttpGet("get")]
        public List<AttributeEntity> GetAttributes()
        {
            List<AttributeEntity> attributesList = _repository.GetAll();
            return attributesList;
        }
        
        [HttpGet("get/{id}")]
        public AttributeModel GetAttribute([FromRoute]int id)
        {
            AttributeEntity entity = _repository.GetById(id);
            AttributeModel model = _mapper.ToModel(entity) as AttributeModel;
            return model;
        }

        [HttpPost("add")]
        public IActionResult CreateAttribute([FromBody] AttributeModel model)
        {
            (bool IsValid, string FormattedExceptionList) validationResult = _validator.Validate(model);

            if (validationResult.IsValid)
            {
                // TODO check if entity successfully created
                AttributeEntity entity = _mapper.ToEntity(model) as AttributeEntity;
                _repository.Create(entity);
                return Ok();
            }
            else
            {
                return BadRequest(validationResult.FormattedExceptionList);
            }
        }
        


        [HttpDelete("delete/{id}")]
        public void DeleteAttribute([FromRoute]int id)
        {
            _repository.RemoveById(id);
        }
    }
}