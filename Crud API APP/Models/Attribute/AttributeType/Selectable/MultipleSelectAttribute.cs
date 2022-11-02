using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.Attribute.AttributeType.Selectable
{
    public class MultipleSelectAttribute : SelectableAttribute
    {
        public MultipleSelectAttribute(string name, string possibleValues) : base(name, possibleValues)
        {
        }
        
        public MultipleSelectAttribute(string name, List<SelectableOption> possibleValues) : base(name, possibleValues)
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