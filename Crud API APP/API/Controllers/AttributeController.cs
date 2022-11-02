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
        public AttributeController(IRepository<AttributeEntity, AttributeBase> repository)
        {
            Repository = repository;
        }

        private IRepository<AttributeEntity, AttributeBase> Repository { get; set; }

        [HttpGet("get")]
        public List<AttributeBase> GetAttributes()
        {
            List<AttributeBase> attributesList = Repository.GetAll();
            return attributesList;
        }
        
        [HttpGet("get/{id}")]
        public AttributeBase GetAttribute([FromRoute]string id)
        {
            AttributeBase attr = Repository.GetById(id);
            return attr;
        }

        [HttpPost("add/numeric")]
        public void AddNumericAttribute([FromQuery]string name, [FromBody] string label)
        {
            AttributeBase attribute = new NumericAttribute(name, label, Guid.NewGuid());
            Repository.Create(attribute);
        }

        [HttpPost("add/price")]
        public void AddPriceAttribute([FromQuery] string name)
        {
            var attribute = new PriceAttribute(name, Guid.NewGuid());
            Repository.Create(attribute);
        }

        [HttpPost("add/single_select")]
        public void AddSingleSelectAttribute([FromQuery] string name, [FromBody] List<SelectableOption> possibleValues)
        {
            var attribute = new SingleSelectAttribute(name, possibleValues, Guid.NewGuid());
            Repository.Create(attribute);
        }

        [HttpPost("add/multiple_select")]
        public void AddMultiSelectAttribute([FromQuery] string name,[FromBody] List<SelectableOption> possibleValues)
        {
            var attribute = new MultipleSelectAttribute(name, possibleValues, Guid.NewGuid());
            Repository.Create(attribute);
        }

        [HttpPost("add/text")]
        public void AddTextAttribute([FromQuery] string name)
        {
            var attribute = new TextAttribute(name, Guid.NewGuid());
            Repository.Create(attribute);
        }

        [HttpPost("add/yes_no")]
        public void AddYesNoAttribute([FromQuery] string name)
        {
            var attribute = new YesNoAttribute(name, Guid.NewGuid());
            Repository.Create(attribute);
        }


        [HttpDelete("delete/{id}")]
        public void DeleteAttribute([FromRoute]string id)
        {
            Repository.RemoveById(id);
        }
    }
}