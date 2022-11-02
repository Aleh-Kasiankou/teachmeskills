using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Attribute.AttributeType.Selectable
{
    public class SingleSelectAttribute : SelectableAttribute
    {
        public SingleSelectAttribute(string name, string possibleValues) : base(name, possibleValues)
        {
        }
        
        public SingleSelectAttribute(string name, List<SelectableOption> possibleValues) : base(name, possibleValues)
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