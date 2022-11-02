using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Options;
using RepositoryService.Entities;

namespace RepositoryService.Repositories
{
    
    public class AttributeRepository : IRepository<AttributeEntity>
    {
        public AttributeRepository(IOptions<ConnectionStrings> credentials)
        {
            Db = new DataBase(credentials);
        }

        private DataBase Db { get; }

        public List<AttributeEntity> GetAll()
        {
            var attributeEntityList = Db.AttributeList.ToList();

            return attributeEntityList;
        }

        public AttributeEntity GetById(int id)
        {
            var attributeEntity = Db.AttributeList.First(attr => attr.Id == id);
            return attributeEntity;
        }

        public void Create(AttributeEntity attributeEntity)
        {
            Db.AttributeList.Add(attributeEntity);
            Db.SaveChanges();
        }

        public void UpdateById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(int id)
        {
            var entityToRemove = Db.AttributeList.First(attr => attr.Id == id);
            Db.AttributeList.Remove(entityToRemove);
            Db.SaveChanges();
        }
    }
}