using System.Collections.Generic;
using API.Entities;
using API.Models.PossibleValues;

namespace API.Models.Attribute
{
    public class AttributeUpdateRequest : BaseModel
    {
        
        public string Name { get;  set; }
        public AttributeType AttributeType { get; set; }
        public string DefaultLiteralValue { get; set; } = null;
        public string MeasurementUnit { get; set; } = null;
        public IList<PossibleValueCreateRequest> PossibleValues { get; set; } = new List<PossibleValueCreateRequest>();
    }
}