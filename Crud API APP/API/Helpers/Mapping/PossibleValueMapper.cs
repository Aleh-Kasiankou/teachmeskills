using System;
using Models;
using RepositoryService.Entities;

namespace API.Helpers.Mapping
{
    public class PossibleValueMapper : IMapper<PossibleValueModel>
    {
        public BaseEntity ToEntity(BaseModel model)
        {
            var castedModel = (PossibleValueModel) model;
            var entity = new PossibleValueEntity()
            {
                Value = castedModel.Value,
                IsDefault = castedModel.IsDefault,
                Guid = Guid.NewGuid().ToString()
            };

            return entity;
        }

        public BaseModel ToModel(BaseEntity entity)
        {
            var castedEntity = (PossibleValueEntity) entity;
            var model = new PossibleValueModel()
            {
                Value = castedEntity.Value,
                IsDefault = castedEntity.IsDefault
            };

            return model;
        }
    }
}