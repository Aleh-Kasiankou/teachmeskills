using System.Collections.Generic;
using System.Linq;
using API.Entities;
using API.Helpers;
using API.Models;
using API.Models.Attribute;
using API.Services.Validation;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.Services.Repositories
{
    public class AttributeRepository : IRepository<AttributeEntity>
    {
        public AttributeRepository(IOptions<ConnectionStrings> credentials, IValidator<AttributeEntity> validator,
            IMapper mapper)
        {
            _validator = validator;
            _mapper = mapper;
            Db = new DataBase(credentials);
        }

        private DataBase Db { get; }
        private readonly IValidator<AttributeEntity> _validator;
        private readonly IMapper _mapper;

        public List<AttributeEntity> GetAll()
        {
            var attributeEntityList = Db.Attribute.Include(a => a.PossibleValues).ToList();

            return attributeEntityList;
        }

        public AttributeEntity GetById(int id)
        {
            var attributeEntity = Db.Attribute.Include(a => a.PossibleValues).First(attr => attr.Id == id);
            return attributeEntity;
        }

        public int Create(BaseModel model)
        {
            var createRequestModel = (AttributeCreateRequest)model;
            AttributeEntity attributeEntity = _mapper.Map<AttributeEntity>(createRequestModel);
            _validator.Validate(attributeEntity);


            Db.Attribute.Add(attributeEntity);
            Db.SaveChanges();
            return attributeEntity.Id;
        }

        public void UpdateById(int id, BaseModel model)
        {
            var updateRequestModel = (AttributeUpdateRequest)model;
            AttributeEntity attributeEntity = GetById(id);

            _mapper.Map(updateRequestModel, attributeEntity);
            _validator.Validate(attributeEntity);

            Db.Update(attributeEntity);
            Db.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var entityToRemove = GetById(id);
            Db.Attribute.Remove(entityToRemove);
            Db.SaveChanges();
        }
    }
}