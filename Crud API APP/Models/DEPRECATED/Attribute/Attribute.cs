namespace Models.DEPRECATED.Attribute
{
    public class AttributeBase
    {
        public AttributeBase()
        {
        }

        public AttributeBase(string name)
        {
            Name = name;
            AttributeType = GetType().Name;
        }
        
        public string AttributeType { get; }
        public string Name { get; protected set; }
    }
}