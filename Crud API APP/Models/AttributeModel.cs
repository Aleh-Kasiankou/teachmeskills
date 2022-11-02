﻿using System;
using System.Collections.Generic;

namespace Models
{
    public class AttributeModel : BaseModel
    {
        public string Name { get;  set; }
        public AttributeTypeModel AttributeType { get; set; }
        public string DefaultLiteralValue { get; set; } = null;
        public string MeasurementUnit { get; set; } = null;
        public IList<PossibleValueModel> PossibleValues { get; set; } = null;
    }
}