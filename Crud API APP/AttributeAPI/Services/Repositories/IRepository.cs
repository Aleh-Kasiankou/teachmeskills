using System.Collections.Generic;
using API.Entities;
using API.Models;

namespace API.Services.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        int Create(BaseModel model);
        void UpdateById(int id, BaseModel model);
        void RemoveById(int id);

    }
}