namespace API.Models.PossibleValues
{
    public class PossibleValueCreateRequest : BaseModel
    {
        public string Value { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}