using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Models.Attribute;
using Models.Attribute.AttributeType.Numeric;
using Models.Attribute.AttributeType.Price;
using Models.Attribute.AttributeType.Selectable;
using Models.Attribute.AttributeType.Text;
using Models.Attribute.AttributeType.YesNo;
using RepositoryService;
using RepositoryService.Entities;


namespace API.Controllers
{
    [ApiController]
    [Route("attribute")]
    public class AttributeController : ControllerBase
    {
        public AttributeController(IRepository<AttributeEntity> repository)
        {
            Repository = repository;
        }

        private IRepository<AttributeEntity> Repository { get; set; }

        [HttpGet("get")]
        public List<AttributeEntity> GetAttributes()
        {
            List<AttributeEntity> attributesList = Repository.GetAll();
            return attributesList;
        }
        
        [HttpGet("get/{id}")]
        public AttributeEntity GetAttribute([FromRoute]int id)
        {
            AttributeEntity attr = Repository.GetById(id);
            return attr;
        }

        [HttpPost("add/numeric")]
        public void AddNumericAttribute([FromQuery]string name, [FromBody] string label)
        {
            AttributeBase attribute = new NumericAttribute(name, label);
            Repository.Create(attribute);
        }

        [HttpPost("add/price")]
        public void AddPriceAttribute([FromQuery] string name)
        {
            var attribute = new PriceAttribute(name);
            Repository.Create(attribute);
        }

        [HttpPost("add/single_select")]
        public void AddSingleSelectAttribute([FromQuery] string name, [FromBody] List<SelectableOption> possibleValues)
        {
            var attribute = new SingleSelectAttribute(name, possibleValues);
            Repository.Create(attribute);
        }

        [HttpPost("add/multiple_select")]
        public void AddMultiSelectAttribute([FromQuery] string name,[FromBody] List<SelectableOption> possibleValues)
        {
            var attribute = new MultipleSelectAttribute(name, possibleValues);
            Repository.Create(attribute);
        }

        [HttpPost("add/text")]
        public void AddTextAttribute([FromQuery] string name)
        {
            var attribute = new TextAttribute(name);
            Repository.Create(attribute);
        }

        [HttpPost("add/yes_no")]
        public void AddYesNoAttribute([FromQuery] string name)
        {
            var attribute = new YesNoAttribute(name);
            Repository.Create(attribute);
        }


        [HttpDelete("delete/{id}")]
        public void DeleteAttribute([FromRoute]int id)
        {
            Repository.RemoveById(id);
        }
    }
}