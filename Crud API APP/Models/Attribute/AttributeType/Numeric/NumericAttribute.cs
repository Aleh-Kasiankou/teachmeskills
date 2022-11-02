using System;

namespace Models.Attribute.AttributeType.Numeric
{
    public sealed class NumericAttribute : AttributeBase
    {
        public NumericAttribute(string name, string label, Guid guid) : base(name, guid)
        {
            Label = label;
        }
        
        public double DefaultValue { get; private set; }
        public string Label { get; set; }
    }
}