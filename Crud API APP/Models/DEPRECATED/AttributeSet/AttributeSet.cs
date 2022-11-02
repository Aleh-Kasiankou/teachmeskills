using System.Collections.Generic;
using Models.DEPRECATED.Attribute;

namespace Models.DEPRECATED.AttributeSet
{
    public class AttributeSet
    {
        public int Id { get; set; }
        public string Guid { get; set; }
        public string Name { get; set; }
        public AttributeGroup AttributeSetGroup { get; set; }
        public List<AttributeBase> Attributes { get; set; }
    }
}