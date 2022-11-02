using System;

namespace Models.Attribute.AttributeType.Text
{
    public class TextAttribute : AttributeBase
    {
        public TextAttribute(string name) : base(name)
        {
            
        }
        public string DefaultValue { get; set; } = "";

    }
}