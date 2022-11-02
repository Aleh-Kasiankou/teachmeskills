using System;

namespace Models.Attribute
{
    public class AttributeBase
    {
        public AttributeBase()
        {
        }

        public AttributeBase(string name, Guid id)
        {
            Name = name;
            Id = id;
            AttributeType = GetType().Name;
        }

        public Guid Id { get; }
        public string AttributeType { get; }
        public string Name { get; protected set; }
    }
}