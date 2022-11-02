using System;

namespace Models.Attribute.AttributeType.Price
{
    public class PriceAttribute : AttributeBase
    {
        public PriceAttribute(string name) : base(name)
        {
        }
        
        public decimal DefaultValue { get; private set; }
    }
}