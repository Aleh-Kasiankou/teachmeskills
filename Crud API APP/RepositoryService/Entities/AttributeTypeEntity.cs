using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Models;

namespace RepositoryService.Entities
{
    public class AttributeTypeEntity : BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string AttributeType { get; set; }
    }
}