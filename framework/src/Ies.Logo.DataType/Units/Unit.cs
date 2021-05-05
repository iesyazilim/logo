using System;

namespace Ies.Logo.DataType.Units
{
    [Serializable]
    public class Unit : IUnit
    {
        public virtual string UnitCode { get; set; }
    }
}
