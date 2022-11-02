using Models;
using RepositoryService.Entities;

namespace API.Helpers.Mapping
{
    public interface IMapper<T> where T: BaseModel  
    {
        public BaseEntity ToEntity(BaseModel model);
        public BaseModel ToModel(BaseEntity entity);
    }
}