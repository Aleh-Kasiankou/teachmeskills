using System.Collections.Generic;
using Models.Attribute;

namespace Models.AttributeSet
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