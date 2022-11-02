using System;
using System.Collections.Generic;
using Models.Attribute.AttributeType.Selectable;
using Newtonsoft.Json;

namespace Models.Attribute.AttributeType.YesNo
{
    public sealed class YesNoAttribute : AttributeBase
    {
        public YesNoAttribute(string name) : base(name)
        {
        }

        public List<SelectableOption> PossibleValues { get; set; } =
            new List<SelectableOption>(){new SelectableOption(true.ToString()), new SelectableOption(false.ToString())};

        public bool DefaultValue { get; set; } = false;

        public string GetPossibleOptionsJson()
        {
            string jsonPossibleValues = JsonConvert.SerializeObject(PossibleValues);
            return jsonPossibleValues;
        }
        
        public string GetDefaultValueJson()
        {
            var jsonDefaultValue = JsonConvert.SerializeObject(DefaultValue);
            return jsonDefaultValue;
        }
    }
}