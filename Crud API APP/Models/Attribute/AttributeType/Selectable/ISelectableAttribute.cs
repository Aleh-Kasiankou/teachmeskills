using System;
using System.Collections.Generic;

namespace Models.Attribute.AttributeType.Selectable
{
    public interface ISelectableAttribute
    {
        public void UpdatePossibleValues(string possibleValues);
    }
}