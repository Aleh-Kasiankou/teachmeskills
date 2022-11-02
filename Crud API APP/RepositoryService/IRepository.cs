using System.Collections.Generic;
using Models.Attribute;

namespace RepositoryService
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Create(AttributeBase attribute);
        void UpdateById(int id);
        void RemoveById(int id);

    }
}