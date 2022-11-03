using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Models;
using RepositoryService.Entities;
using RepositoryService.Repositories;

namespace API.Helpers.Mapping
{
    public class AttributeMapper : IMapper<AttributeModel>
    {
        public AttributeMapper(IMapper<AttributeTypeModel> typeMapper, IMapper<PossibleValueModel> optionMapper,
            IRepository<AttributeTypeEntity> typeRepository, IRepository<PossibleValueEntity> optionRepository)
        {
            _typeMapper = typeMapper;
            _optionMapper = optionMapper;
            _typeRepository = typeRepository;
            _optionRepository = optionRepository;
        }

        private IMapper<AttributeTypeModel> _typeMapper;
        private IMapper<PossibleValueModel> _optionMapper;
        private IRepository<AttributeTypeEntity> _typeRepository;
        private IRepository<PossibleValueEntity> _optionRepository;

        public BaseEntity ToEntity(BaseModel model)
        {
            AttributeModel castedModel = (AttributeModel)model;


            var attributeTypeId = ((AttributeTypeEntity)_typeMapper.ToEntity(castedModel.AttributeType)).Id;

            var attributeEntity = new AttributeEntity()
            {
                Name = castedModel.Name,
                AttributeTypeId = attributeTypeId,
                DefaultLiteralValue = castedModel.DefaultLiteralValue,
                MeasurementUnit = castedModel.MeasurementUnit,
                PossibleValues = new Collection<PossibleValueEntity>()
            };


            return attributeEntity;
        }

        public BaseModel ToModel(BaseEntity entity)
        {
            AttributeEntity castedEntity = (AttributeEntity)entity;

            // var possibleValueModels =
            //     castedEntity.PossibleValues.Select(value => (PossibleValueModel)_optionMapper.ToModel(value)).ToList();

            var attrTypeEntity = _typeRepository.GetById(castedEntity.AttributeTypeId);
            var attrPossibleValueModels =
                _optionRepository.GetAll().Where(option => option.AttributeEntityId == castedEntity.Id)
                    .Select(opt => (PossibleValueModel) _optionMapper.ToModel(opt)).ToList();
            
            var attributeModel = new AttributeModel()
            {
                Name = castedEntity.Name,
                AttributeType = (AttributeTypeModel)(_typeMapper.ToModel(attrTypeEntity)),
                DefaultLiteralValue = castedEntity.DefaultLiteralValue,
                MeasurementUnit = castedEntity.MeasurementUnit,
                PossibleValues = attrPossibleValueModels
            };

            return attributeModel;
        }

        // private List<PossibleValueEntity> CreateOptionsAndReturn(AttributeModel model)
        // {
        //     var guidList = new List<string>();
        //
        //     var possibleValueEntities =
        //         model.PossibleValues.Select(value => (PossibleValueEntity)_optionMapper.ToEntity(value)).ToList();
        //
        //     foreach (var option in possibleValueEntities)
        //     {
        //         guidList.Add(option.Guid);
        //         _repository.Create(option);
        //     }
        //
        //     var returnList = new List<PossibleValueEntity>();
        //     foreach (var guid in guidList)
        //     {
        //         returnList.Add(_repository.GetAll().First(value => value.Guid == guid));
        //     }
        //
        //     return possibleValueEntities;
        // }
    }
}