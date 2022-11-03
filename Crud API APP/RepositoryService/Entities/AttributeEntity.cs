using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryService.Entities
{
    public class AttributeEntity : BaseEntity
    {
        public AttributeEntity()
        {
            
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey("AttributeType")]
        public int AttributeTypeId { get; set; }
        public AttributeTypeEntity AttributeType { get; set; }
        public string Name { get;  set; }
        public string DefaultLiteralValue { get; set; }
        public string MeasurementUnit { get; set; } = null;
        public IList<PossibleValueEntity> PossibleValues { get; set; } = new List<PossibleValueEntity>();
    }
}