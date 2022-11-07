using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Models;

namespace API.Services.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        Task<int> Create(BaseModel model);
        Task UpdateById(int id, BaseModel model);
        Task RemoveById(int id);

    }
}