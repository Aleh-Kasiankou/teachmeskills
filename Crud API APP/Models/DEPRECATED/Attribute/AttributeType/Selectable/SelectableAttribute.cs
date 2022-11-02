using System.Collections.Generic;
using Newtonsoft.Json;

namespace Models.DEPRECATED.Attribute.AttributeType.Selectable
{
    public abstract class SelectableAttribute : AttributeBase, ISelectableAttribute
    {
        public SelectableAttribute(string name, string possibleValues) : base(name)
        {
            UpdatePossibleValues(possibleValues);
        }

        public SelectableAttribute(string name, List<SelectableOption> possibleValues) : base(name)
        {
            PossibleValues = possibleValues;
        }

        public List<SelectableOption> PossibleValues { get; protected set; }

        public void UpdatePossibleValues(string selectableOptions)
        {
            List<SelectableOption> possibleValues =
                JsonConvert.DeserializeObject<List<SelectableOption>>(selectableOptions);
            PossibleValues = possibleValues;
        }

        public abstract string GetDefaultValueJson();

        public string GetPossibleOptionsJson()
        {
            string possibleOptionsJson = JsonConvert.SerializeObject(PossibleValues);
            return possibleOptionsJson;
        }
    }
}