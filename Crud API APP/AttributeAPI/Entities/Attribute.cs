using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API.Entities
{
    public class Attribute : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public AttributeType AttributeType { get; set; }
        public string Name { get;  set; }
        public string DefaultLiteralValue { get; set; }
        public string MeasurementUnit { get; set; }
        public IList<PossibleValue> PossibleValues { get; set; } = new List<PossibleValue>();
    }
}