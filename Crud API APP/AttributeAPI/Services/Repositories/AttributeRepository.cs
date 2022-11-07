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
        private readonly DataBase _db;
        private readonly IValidator<AttributeEntity> _validator;
        private readonly IMapper _mapper;

        public AttributeRepository(IOptions<ConnectionStrings> credentials, IValidator<AttributeEntity> validator,
            IMapper mapper)
        {
            _validator = validator;
            _mapper = mapper;
            _db = new DataBase(credentials);
        }


        public List<AttributeEntity> GetAll()
        {
            var attributeEntityList = _db.Attribute.Include(a => a.PossibleValues).ToList();

            return attributeEntityList;
        }

        public AttributeEntity GetById(int id)
        {
            var attributeEntity = _db.Attribute.Include(a => a.PossibleValues).First(attr => attr.Id == id);
            return attributeEntity;
        }

        public int Create(BaseModel model)
        {
            var createRequestModel = (AttributeCreateRequest)model;
            AttributeEntity attributeEntity = _mapper.Map<AttributeEntity>(createRequestModel);
            _validator.Validate(attributeEntity);


            _db.Attribute.Add(attributeEntity);
            _db.SaveChanges();
            return attributeEntity.Id;
        }

        public void UpdateById(int id, BaseModel model)
        {
            var updateRequestModel = (AttributeUpdateRequest)model;
            AttributeEntity attributeEntity = GetById(id);

            _mapper.Map(updateRequestModel, attributeEntity);
            _validator.Validate(attributeEntity);

            _db.Update(attributeEntity);
            _db.SaveChanges();
        }

        public void RemoveById(int id)
        {
            var entityToRemove = GetById(id);
            _db.Attribute.Remove(entityToRemove);
            _db.SaveChanges();
        }
    }
}