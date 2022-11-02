using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RepositoryService.Entities
{
    public class AttributeEntity : BaseEntity
    {
        public AttributeEntity()
        {
            
        }
        // public AttributeEntity(string name, AttributeTypeEntity attributeType)
        // {
        //     Name = name;
        //     AttributeType = attributeType;
        // }

        [Key]
        public int Id { get; set; }
        public AttributeTypeEntity AttributeType { get; set; }
        public string Name { get;  set; }
        public string DefaultLiteralValue { get; set; }
        public string MeasurementUnit { get; set; } = null;
        public IList<PossibleValueEntity> PossibleValues { get; set; } = null;
    }
}