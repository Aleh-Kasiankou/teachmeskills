namespace RepositoryService.Entities
{
    public class AttributeEntity
    {
        public AttributeEntity()
        {
            
        }
        public AttributeEntity(string name, string attributeType, string guid)
        {
            Name = name;
            AttributeType = attributeType;
            Guid = guid;
        }

        public int Id { get; set; }
        public string Guid { get; set; }
        public string AttributeType { get; set; }
        public string Name { get;  set; }
        public string DefaultValue { get; set; }
        public string Label { get; set; } = null;
        public string PossibleValues { get; set; } = null; //json
    }
}