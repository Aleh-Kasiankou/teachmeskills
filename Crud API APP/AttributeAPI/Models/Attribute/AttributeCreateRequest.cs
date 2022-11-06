using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using API.Entities;
using API.Models.PossibleValues;

namespace API.Models.Attribute
{
    public class AttributeCreateRequest : BaseModel
    {
        [Required]
        public string Name { get;  set; }
        [Required]
        public AttributeType AttributeType { get; set; }

        public string DefaultLiteralValue { get; set; } = null;
        public string MeasurementUnit { get; set; } = null;
        public IList<PossibleValueCreateRequest> PossibleValues { get; set; } = new List<PossibleValueCreateRequest>();
    }
}