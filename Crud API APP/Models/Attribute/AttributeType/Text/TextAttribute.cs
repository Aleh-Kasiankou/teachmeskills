using System;

namespace Models.Attribute.AttributeType.Text
{
    public class TextAttribute : AttributeBase
    {
        public TextAttribute(string name, Guid guid) : base(name, guid)
        {
            
        }
        public string DefaultValue { get; set; } = "";

    }
}