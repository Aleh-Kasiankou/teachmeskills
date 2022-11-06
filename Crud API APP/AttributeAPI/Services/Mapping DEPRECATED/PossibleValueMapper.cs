// using System;
// using API.Entities;
// using API.Models;
//
// namespace API.Services.Mapping
// {
//     public class PossibleValueMapper : IMapper<PossibleValueModel>
//     {
//         public BaseEntity ToEntity(BaseModel model)
//         {
//             var castedModel = (PossibleValueModel) model;
//             var entity = new PossibleValueEntity()
//             {
//                 AttributeEntityId = castedModel.GetAttributeId(),
//                 Value = castedModel.Value,
//                 IsDefault = castedModel.IsDefault,
//                 Guid = Guid.NewGuid().ToString()
//             };
//
//             return entity;
//         }
//
//         public BaseModel ToModel(BaseEntity entity)
//         {
//             var castedEntity = (PossibleValueEntity) entity;
//             var model = new PossibleValueModel()
//             {
//                 Value = castedEntity.Value,
//                 IsDefault = castedEntity.IsDefault
//             };
//
//             return model;
//         }
//     }
// }