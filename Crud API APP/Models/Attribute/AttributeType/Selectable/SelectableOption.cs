using System;

namespace Models.Attribute.AttributeType.Selectable
{
    public class SelectableOption
    {
        public SelectableOption(string value)
        {
            Value = value;
        }
        //todo IDs should be automatically generated on creation, not inserted??
        public int Id { get; set; }
        public string Value { get; protected set; }
        
        public static SelectableOption Empty { get; } = new SelectableOption("");
    }
}