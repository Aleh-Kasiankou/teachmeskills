using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryService.Entities
{
    public class PossibleValueEntity : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AttributeEntity")]
        public int AttributeEntityId { get; set; }
        public AttributeEntity AttributeEntity { get; set; }
        public string Guid { get; set; }
        public string Value { get; set; }
        public bool IsDefault { get; set; }
    }
}