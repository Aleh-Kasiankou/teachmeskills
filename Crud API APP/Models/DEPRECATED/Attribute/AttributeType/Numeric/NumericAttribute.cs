namespace Models.DEPRECATED.Attribute.AttributeType.Numeric
{
    public sealed class NumericAttribute : AttributeBase
    {
        public NumericAttribute(string name, string label) : base(name)
        {
            Label = label;
        }
        
        public double DefaultValue { get; private set; }
        public string Label { get; set; }
    }
}