using Ies.Logo.Core;
using Ies.Logo.DataType.AggregateRoot;
using Ies.Logo.DataType.Units.SubUnits;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.Units
{
    [Serializable]
    public class UnitSet : AuditedAggregateRoot
    {
        public static LogoObjectType XmlRoot => LogoObjectType.UNIT_SETS;

        public virtual string Code { get; set; }
        public virtual string Description { get; set; }
        public virtual int Type { get; set; }
        #region SubClasses
        public virtual List<SubUnit> Units { get; set; }
        #endregion
    }
}
