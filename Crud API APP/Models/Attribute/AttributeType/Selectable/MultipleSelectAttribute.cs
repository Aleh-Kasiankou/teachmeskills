using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Attribute.AttributeType.Selectable
{
    public class MultipleSelectAttribute : SelectableAttribute
    {
        public MultipleSelectAttribute(string name, string possibleValues, Guid guid) : base(name, possibleValues, guid)
        {
        }
        
        public MultipleSelectAttribute(string name, List<SelectableOption> possibleValues, Guid guid) : base(name, possibleValues, guid)
        {
        }

        public List<SelectableOption> DefaultValue { get; } = new List<SelectableOption>();


        public override string GetDefaultValueJson()
        {
            var jsonDefaultValue = JsonConvert.SerializeObject(DefaultValue);
            return jsonDefaultValue;
        }
    }
}