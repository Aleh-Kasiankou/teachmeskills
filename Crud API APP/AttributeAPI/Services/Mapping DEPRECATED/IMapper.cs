using API.Entities;
using API.Models;

namespace API.Services.Mapping_DEPRECATED
{
    public interface IMapper<T> where T: BaseModel  
    {
        public BaseEntity ToEntity(BaseModel model);
        public BaseModel ToModel(BaseEntity entity);
    }
}