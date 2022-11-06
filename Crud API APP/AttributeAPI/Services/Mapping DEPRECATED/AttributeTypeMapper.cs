// using System.Linq;
// using API.Entities;
// using API.Models;
// using API.Services.Repositories;
//
// namespace API.Services.Mapping
// {
//     public class AttributeTypeMapper : IMapper<AttributeTypeModel>
//     {
//         public AttributeTypeMapper(IRepository<AttributeTypeEntity> repository)
//         {
//             _repository = repository;
//         }
//
//         private IRepository<AttributeTypeEntity> _repository;
//
//         public BaseEntity ToEntity(BaseModel model)
//         {
//             var castedModel = (AttributeTypeModel)model;
//             
//             AttributeTypeEntity entity =
//                 _repository.GetAll().First(type => type.AttributeType == castedModel.AttributeType);
//
//             return entity;
//         }
//
//         public BaseModel ToModel(BaseEntity entity)
//         {
//             var castedEntity = (AttributeTypeEntity)entity;
//             AttributeTypeModel model = new AttributeTypeModel()
//             {
//                 AttributeType = castedEntity.AttributeType
//             };
//
//             return model;
//         }
//     }
// }