using System.Collections.Generic;
using Models.Attribute;

namespace RepositoryService
{
    public interface IRepository<T, U>
    {
        List<U> GetAll();
        U GetById(string guid);
        void Create(AttributeBase attribute);
        void UpdateById(string guid);
        void RemoveById(string guid);

    }
}