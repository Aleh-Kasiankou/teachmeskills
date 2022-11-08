using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using API.Models;
using API.Models.Attribute;
using API.Services.Validation;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Attribute = API.Entities.Attribute;

namespace API.Services.Repositories
{
    public class AttributeRepository : IRepository<Attribute>
    {
        private readonly AttributeDbContext _db;
        private readonly IValidator<Attribute> _validator;
        private readonly IMapper _mapper;

        public AttributeRepository(IOptions<ConnectionStrings> credentials, IValidator<Attribute> validator,
            IMapper mapper)
        {
            _validator = validator;
            _mapper = mapper;
            _db = new AttributeDbContext(credentials);
        }


        public List<Attribute> GetAll()
        {
            var attributeEntityList = _db.Attribute.Include(a => a.PossibleValues).ToList();

            return attributeEntityList;
        }

        public Attribute GetById(Guid id)
        {
            var attributeEntity = _db.Attribute.Include(a => a.PossibleValues).First(attr => attr.Id == id);
            return attributeEntity;
        }

        public async Task<Guid> Create(BaseModel model)
        {
            var createRequestModel = (AttributeCreateRequest)model;
            Attribute attribute = _mapper.Map<Attribute>(createRequestModel);
            _validator.Validate(attribute);


            _db.Attribute.Add(attribute);
            await _db.SaveChangesAsync();
            return attribute.Id;
        }

        public async Task UpdateById(Guid id, BaseModel model)
        {
            var updateRequestModel = (AttributeUpdateRequest)model;
            Attribute attribute = GetById(id);

            _mapper.Map(updateRequestModel, attribute);
            _validator.Validate(attribute);

            _db.Update(attribute);
            await _db.SaveChangesAsync();
        }

        public async Task RemoveById(Guid id)
        {
            var entityToRemove = GetById(id);
            _db.Attribute.Remove(entityToRemove);
            await _db.SaveChangesAsync();
        }
    }
}