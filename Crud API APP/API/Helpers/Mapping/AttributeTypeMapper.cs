using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Models;
using RepositoryService.Entities;
using RepositoryService.Repositories;

namespace API.Helpers.Mapping
{
    public class AttributeTypeMapper : IMapper<AttributeTypeModel>
    {
        public AttributeTypeMapper(IRepository<AttributeTypeEntity> repository)
        {
            _repository = repository;
        }

        private IRepository<AttributeTypeEntity> _repository;

        public BaseEntity ToEntity(BaseModel model)
        {
            var castedModel = (AttributeTypeModel)model;
            
            AttributeTypeEntity entity =
                _repository.GetAll().First(type => type.AttributeType == castedModel.AttributeType);

            return entity;
        }

        public BaseModel ToModel(BaseEntity entity)
        {
            var castedEntity = (AttributeTypeEntity)entity;
            AttributeTypeModel model = new AttributeTypeModel()
            {
                AttributeType = castedEntity.AttributeType
            };

            return model;
        }
    }
}