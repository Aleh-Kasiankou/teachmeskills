using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using RepositoryService.Entities;

namespace RepositoryService.Repositories
{
    public class AttributeTypeRepository : IRepository<AttributeTypeEntity>
    {
        public AttributeTypeRepository(IOptions<ConnectionStrings> credentials)
        {
            Db = new DataBase(credentials);
        }

        private DataBase Db { get; }

        public List<AttributeTypeEntity> GetAll()
        {
            var attributeTypeEntities = Db.AttributeType.ToList();
            return attributeTypeEntities;
        }

        public AttributeTypeEntity GetById(int id)
        {
            var attributeTypeEntity = Db.AttributeType.First(attr => attr.Id == id);
            return attributeTypeEntity;
        }

        public void Create(AttributeTypeEntity attribute)
        {
            throw new NotSupportedException();
        }

        public void UpdateById(int id)
        {
            throw new NotSupportedException();
        }

        public void RemoveById(int id)
        {
            throw new NotSupportedException();
        }
    }
}