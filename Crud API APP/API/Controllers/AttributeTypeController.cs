using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RepositoryService;
using RepositoryService.Entities;
using RepositoryService.Repositories;

namespace API.Controllers
{
    [ApiController]
    [Route("attribute_type")]
    public class AttributeTypeController
    {
        public AttributeTypeController(IRepository<AttributeTypeEntity> repository)
        {
            _repository = repository;
        }

        private IRepository<AttributeTypeEntity> _repository;
        
        [HttpGet("get")]
        public List<AttributeTypeEntity> GetAttributeTypes()
        {
            List<AttributeTypeEntity> attributeTypesList = _repository.GetAll();
            return attributeTypesList;
        }
        
        [HttpGet("get/{id}")]
        public AttributeTypeEntity GetAttributeById([FromRoute] int id)
        {
            AttributeTypeEntity attributeTypeEntity = _repository.GetById(id);
            return attributeTypeEntity;
        }
    }
}