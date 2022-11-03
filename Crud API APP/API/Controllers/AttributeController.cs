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
        public AttributeController(IRepository<AttributeEntity> repository, IValidator<AttributeModel> validator,
            IMapper<PossibleValueModel> valueMapper, IMapper<AttributeModel> attributeMapper, IRepository<PossibleValueEntity> optionRepository)
        {
            _attributeRepository = repository;
            _validator = validator;
            _valueMapper = valueMapper;
            _attributeMapper = attributeMapper;
            _optionRepository = optionRepository;
        }

        private readonly IRepository<AttributeEntity> _attributeRepository;
        private readonly IRepository<PossibleValueEntity> _optionRepository;
        private readonly IValidator<AttributeModel> _validator;
        private readonly IMapper<AttributeModel> _attributeMapper;
        private readonly IMapper<PossibleValueModel> _valueMapper;

        [HttpGet("get")]
        public List<AttributeEntity> GetAttributes()
        {
            List<AttributeEntity> attributesList = _attributeRepository.GetAll();
            return attributesList;
        }

        [HttpGet("get/{id}")]
        public AttributeModel GetAttribute([FromRoute] int id)
        {
            AttributeEntity entity = _attributeRepository.GetById(id);
            AttributeModel model = _attributeMapper.ToModel(entity) as AttributeModel;
            return model;
        }

        [HttpPost("add")]
        public IActionResult CreateAttribute([FromBody] AttributeModel model)
        {
            (bool IsValid, string FormattedExceptionList) validationResult = _validator.Validate(model);

            if (validationResult.IsValid)
            {
                // TODO check if entity successfully created
                AttributeEntity entity = _attributeMapper.ToEntity(model) as AttributeEntity;
                
                var attrId = _attributeRepository.Create(entity);
                 
                var attributeEntity = _attributeRepository.GetById(attrId);

                foreach (var option in model.PossibleValues)
                {
                    option.SetAttributeId(attrId);
                    var optionEntity = _valueMapper.ToEntity(option) as PossibleValueEntity;
                    _optionRepository.Create(optionEntity);
                }

                return Ok();
            }
            else
            {
                return BadRequest(validationResult.FormattedExceptionList);
            }
        }


        [HttpDelete("delete/{id}")]
        public void DeleteAttribute([FromRoute] int id)
        {
            _attributeRepository.RemoveById(id);
        }
    }
}