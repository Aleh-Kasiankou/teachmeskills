using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace API.Entities
{
    public class PossibleValue : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string Value { get; set; }
        public bool IsDefault { get; set; }

        [ForeignKey("Attribute")]
        [JsonIgnore]
        public Guid AttributeId { get; set; }
        [JsonIgnore]
        public Attribute Attribute { get; set; }
    }
}