using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class AttributeEntity : BaseEntity
    {
        public AttributeType AttributeType { get; set; }
        public string Name { get;  set; }
        public string DefaultLiteralValue { get; set; }
        public string MeasurementUnit { get; set; }
        public IList<PossibleValueEntity> PossibleValues { get; set; } = new List<PossibleValueEntity>();
    }
}