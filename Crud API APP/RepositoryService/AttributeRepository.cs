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
    //todo Try to somehow remove generics from IRepository
    //todo store in json, deserialize upon instance creation
    //todo delegate conversion to separate method or class
    //todo need return List of AttributeBase objects (or casted?)
    public class AttributeRepository : IRepository<AttributeEntity, AttributeBase>
    {
        public AttributeRepository(IOptions<ConnectionStrings> credentials)
        {
            Db = new DataBase(credentials);
        }

        private DataBase Db { get; }

        public List<AttributeBase> GetAll()
        {
            var attributeList = new List<AttributeBase>();
            var attributeDataList = Db.AttributeList.ToList();
            foreach (var attributeData in attributeDataList)
            {
                attributeList.Add(CastToDotNetObj(attributeData));
            }

            return attributeList;
        }

        public AttributeBase GetById(string guid)
        {
                var attributeData = Db.AttributeList.First(attr => attr.Guid == guid);
                AttributeBase attribute = CastToDotNetObj(attributeData);
                return attribute;

        }

        public void Create(AttributeBase attributeData)
        {
            AttributeEntity attribute = new AttributeEntity(attributeData.Name, attributeData.AttributeType, attributeData.Id.ToString());
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

        public void UpdateById(string guid)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(string guid)
        {
            var entityToRemove = Db.AttributeList.First(attr => attr.Guid == guid);
            Db.AttributeList.Remove(entityToRemove);
            Db.SaveChanges();
        }

        public AttributeBase CastToDotNetObj(AttributeEntity attributeEntity)
        {
            AttributeBase attribute;
            switch (attributeEntity.AttributeType)
            {
                case "NumericAttribute":
                    attribute = new NumericAttribute(attributeEntity.Name, attributeEntity.Label,
                        Guid.Parse(attributeEntity.Guid));
                    break;
                case "PriceAttribute":
                    attribute = new PriceAttribute(attributeEntity.Name, Guid.Parse(attributeEntity.Guid));
                    break;
                case "SingleSelectAttribute":
                    attribute = new SingleSelectAttribute(attributeEntity.Name, attributeEntity.PossibleValues,
                        Guid.Parse(attributeEntity.Guid));
                    break;
                case "MultipleSelectAttribute":
                    attribute = new MultipleSelectAttribute(attributeEntity.Name, attributeEntity.PossibleValues,
                        Guid.Parse(attributeEntity.Guid));
                    break;
                case "TextAttribute":
                    attribute = new TextAttribute(attributeEntity.Name, Guid.Parse(attributeEntity.Guid));
                    break;
                case "YesNoAttribute":
                    attribute = new YesNoAttribute(attributeEntity.Name, Guid.Parse(attributeEntity.Guid));
                    break;
                default:
                    attribute = null;
                    break;
            }

            return attribute;
        }
    }
}