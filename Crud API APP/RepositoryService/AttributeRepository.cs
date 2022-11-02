using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using Models.Attribute;
using Models.Attribute.AttributeType.Numeric;
using Models.Attribute.AttributeType.Price;
using Models.Attribute.AttributeType.Selectable;
using Models.Attribute.AttributeType.Text;
using Models.Attribute.AttributeType.YesNo;
using RepositoryService.Entities;

namespace RepositoryService
{
    //todo Get rid of hardcoded names
    //todo Perhaps inherit YesNo from selectable attribute?
    //todo store in json, deserialize upon instance creation
    //todo delegate conversion to separate method or class
    public class AttributeRepository : IRepository<AttributeEntity>
    {
        public AttributeRepository(IOptions<ConnectionStrings> credentials)
        {
            Db = new DataBase(credentials);
        }

        private DataBase Db { get; }

        public List<AttributeEntity> GetAll()
        {
            var attributeEntityList = Db.AttributeList.ToList();

            return attributeEntityList;
        }

        public AttributeEntity GetById(int id)
        {
                var attributeEntity = Db.AttributeList.First(attr => attr.Id == id);
                return attributeEntity;

        }

        public void Create(AttributeBase attributeData)
        {
            AttributeEntity attribute = new AttributeEntity(attributeData.Name, attributeData.AttributeType);
            switch (attributeData.AttributeType)
            {
                case "NumericAttribute":
                    var castedNumericAttribute = (NumericAttribute)attributeData;
                    attribute.Label = castedNumericAttribute.Label;
                    attribute.DefaultValue = castedNumericAttribute.DefaultValue.ToString();
                    break;
                case "PriceAttribute":
                    var castedPriceAttribute = (PriceAttribute)attributeData;
                    attribute.DefaultValue = castedPriceAttribute.DefaultValue.ToString();
                    break;
                case "SingleSelectAttribute":
                    var castedSingleSelectAttribute = (SingleSelectAttribute)attributeData;
                    attribute.DefaultValue = castedSingleSelectAttribute.GetDefaultValueJson();
                    attribute.PossibleValues = castedSingleSelectAttribute.GetPossibleOptionsJson();
                    break;
                case "MultipleSelectAttribute":
                    var castedMultiSelectAttribute = (MultipleSelectAttribute)attributeData;
                    attribute.DefaultValue = castedMultiSelectAttribute.GetDefaultValueJson();
                    attribute.PossibleValues = castedMultiSelectAttribute.GetPossibleOptionsJson();
                    break;
                case "TextAttribute":
                    var castedTextAttribute = (TextAttribute)attributeData;
                    attribute.DefaultValue = castedTextAttribute.DefaultValue;
                    break;
                case "YesNoAttribute":
                    var castedYesNoAttribute = (YesNoAttribute)attributeData;
                    attribute.DefaultValue = castedYesNoAttribute.GetDefaultValueJson();
                    attribute.PossibleValues = castedYesNoAttribute.GetPossibleOptionsJson();
                    break;
                default:
                    throw new ArgumentException($"{attributeData.AttributeType} Type is not supported!");
            }

            Db.AttributeList.Add(attribute);
            Db.SaveChanges();
        }

        public void UpdateById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            var entityToRemove = Db.AttributeList.First(attr => attr.Id == id);
            Db.AttributeList.Remove(entityToRemove);
            Db.SaveChanges();
        }

        public AttributeBase CastToDotNetObj(AttributeEntity attributeEntity)
        {
            AttributeBase attribute;
            switch (attributeEntity.AttributeType)
            {
                case "NumericAttribute":
                    attribute = new NumericAttribute(attributeEntity.Name, attributeEntity.Label);
                    break;
                case "PriceAttribute":
                    attribute = new PriceAttribute(attributeEntity.Name);
                    break;
                case "SingleSelectAttribute":
                    attribute = new SingleSelectAttribute(attributeEntity.Name, attributeEntity.PossibleValues);
                    break;
                case "MultipleSelectAttribute":
                    attribute = new MultipleSelectAttribute(attributeEntity.Name, attributeEntity.PossibleValues);
                    break;
                case "TextAttribute":
                    attribute = new TextAttribute(attributeEntity.Name);
                    break;
                case "YesNoAttribute":
                    attribute = new YesNoAttribute(attributeEntity.Name);
                    break;
                default:
                    attribute = null;
                    break;
            }

            return attribute;
        }
    }
}