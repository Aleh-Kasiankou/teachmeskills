using System.Collections.Generic;
using System.Linq;
using Models;
using RepositoryService.Entities;
using RepositoryService.Repositories;

namespace API.Helpers.Mapping
{
    public class AttributeMapper : IMapper<AttributeModel>
    {
        public AttributeMapper(IMapper<AttributeTypeModel> typeMapper, IMapper<PossibleValueModel> optionMapper, IRepository<PossibleValueEntity> repository)
        {
            _typeMapper = typeMapper;
            _optionMapper = optionMapper;
            _repository = repository;
        }

        private IMapper<AttributeTypeModel> _typeMapper;
        private IMapper<PossibleValueModel> _optionMapper;
        private IRepository<PossibleValueEntity> _repository;

        public BaseEntity ToEntity(BaseModel model)
        {
            AttributeModel castedModel = (AttributeModel)model;

            var possibleValueEntities =
                CreateOptionsAndReturn(castedModel);
            
            var attributeEntity = new AttributeEntity()
            
            
            {
                Name = castedModel.Name,
                AttributeType = (AttributeTypeEntity)_typeMapper.ToEntity(castedModel.AttributeType),
                DefaultLiteralValue = castedModel.DefaultLiteralValue,
                MeasurementUnit = castedModel.MeasurementUnit,
                PossibleValues = possibleValueEntities
            };

            return attributeEntity;
        }

        public BaseModel ToModel(BaseEntity entity)
        {
            AttributeEntity castedEntity = (AttributeEntity)entity;
            var possibleValueModels =
                castedEntity.PossibleValues.Select(value => (PossibleValueModel)_optionMapper.ToModel(value)).ToList();

            var attributeModel = new AttributeModel()
            {
                Name = castedEntity.Name,
                AttributeType = (AttributeTypeModel)_typeMapper.ToModel(castedEntity.AttributeType),
                DefaultLiteralValue = castedEntity.DefaultLiteralValue,
                MeasurementUnit = castedEntity.MeasurementUnit,
                PossibleValues = possibleValueModels
            };

            return attributeModel;
        }

        private List<PossibleValueEntity> CreateOptionsAndReturn(AttributeModel model)
        {
            var guidList = new List<string>();
            
            var possibleValueEntities =
                model.PossibleValues.Select(value => (PossibleValueEntity)_optionMapper.ToEntity(value)).ToList();
            
            foreach (var option in possibleValueEntities)
            {
                guidList.Add(option.Guid);
                _repository.Create(option);
            }

            var returnList = new List<PossibleValueEntity>();
            foreach (var guid in guidList)
            {
                returnList.Add(_repository.GetAll().First(value => value.Guid == guid));
            }
            
            return possibleValueEntities;
        }
    }
}