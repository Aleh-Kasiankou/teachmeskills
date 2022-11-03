namespace Models
{
    public class PossibleValueModel : BaseModel
    {
        private int _attributeId;
        public string Value { get; set; }
        public bool IsDefault { get; set; }

        public void SetAttributeId(int attributeId)
        {
            _attributeId = attributeId;
        }
        
        public int GetAttributeId()
        {
            return _attributeId;
        }
    }
}