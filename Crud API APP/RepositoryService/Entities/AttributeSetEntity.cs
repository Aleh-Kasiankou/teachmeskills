using System.Collections.Generic;

namespace RepositoryService.Entities
{
    public class AttributeSetEntity : BaseEntity
    {
        public int Id { get; set; }
        public IList<AttributeEntity> Attributes { get; set; }
    }
}