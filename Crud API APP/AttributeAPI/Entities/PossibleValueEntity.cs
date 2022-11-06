using System;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace API.Entities
{
    public class PossibleValueEntity : BaseEntity
    {
        public string Value { get; set; }
        public bool IsDefault { get; set; }

        [ForeignKey("Attribute")]
        [JsonIgnore]
        public int AttributeId { get; set; }
        [JsonIgnore]
        public AttributeEntity Attribute { get; set; }
    }
}