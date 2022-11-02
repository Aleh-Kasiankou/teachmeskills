using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Attribute.AttributeType.Selectable
{
    public class SingleSelectAttribute : SelectableAttribute
    {
        public SingleSelectAttribute(string name, string possibleValues, Guid guid) : base(name, possibleValues, guid)
        {
        }
        
        public SingleSelectAttribute(string name, List<SelectableOption> possibleValues, Guid guid) : base(name, possibleValues, guid)
        {
        }

        public SelectableOption DefaultValue { get; } = SelectableOption.Empty;
        
        public override string GetDefaultValueJson()
        {
            var jsonDefaultValue = JsonConvert.SerializeObject(DefaultValue);
            return jsonDefaultValue;
        }
    }
}