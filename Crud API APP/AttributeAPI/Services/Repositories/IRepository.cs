using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Models;

namespace API.Services.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        List<T> GetAll();
        T GetById(Guid id);
        Task<Guid> Create(BaseModel model);
        Task UpdateById(Guid id, BaseModel model);
        Task RemoveById(Guid id);

    }
}