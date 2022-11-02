namespace RepositoryService.Entities
{
    public class AttributeEntity
    {
        public AttributeEntity()
        {
            
        }
        public AttributeEntity(string name, string attributeType)
        {
            Name = name;
            AttributeType = attributeType;
        }

        public int Id { get; set; }
        public string AttributeType { get; set; }
        public string Name { get;  set; }
        public string DefaultValue { get; set; }
        public string Label { get; set; } = null;
        public string PossibleValues { get; set; } = null; //json
    }
}