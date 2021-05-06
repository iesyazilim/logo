using System;

namespace IesYazilim.Logo.DataType.Units
{
    [Serializable]
    public class Unit : IUnit
    {
        public virtual string UnitCode { get; set; }
    }
}
