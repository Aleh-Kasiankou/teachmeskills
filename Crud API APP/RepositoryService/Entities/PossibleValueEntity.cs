using System.ComponentModel.DataAnnotations;

namespace RepositoryService.Entities
{
    public class PossibleValueEntity : BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public string Guid { get; set; }
        public string Value { get; set; }
        public bool IsDefault { get; set; }
    }
}