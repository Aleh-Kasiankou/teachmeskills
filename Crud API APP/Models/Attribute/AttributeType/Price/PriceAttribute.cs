using System;

namespace Models.Attribute.AttributeType.Price
{
    public class PriceAttribute : AttributeBase
    {
        public PriceAttribute(string name, Guid guid) : base(name, guid)
        {
        }
        
        public decimal DefaultValue { get; private set; }
    }
}