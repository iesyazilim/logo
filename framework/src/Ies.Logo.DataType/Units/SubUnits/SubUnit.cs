using Ies.Logo.DataType.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ies.Logo.DataType.Units.SubUnits
{
    [Serializable]
    public class SubUnit : ILogo, IDataReference
    {
        public virtual string Code { get; set; }
        public virtual string Name { get; set; }
        public virtual Nullable<short> UnitOrder { get; set; }
        public virtual Nullable<short> MainUnit { get; set; }
        public virtual Nullable<decimal> ConvFact1 { get; set; }
        public virtual Nullable<decimal> ConvFact2 { get; set; }
        public virtual Nullable<short> Divisible { get; set; }
        public virtual string GlobalCode { get; set; }
        public virtual Nullable<int> DataReference { get; set; }
        public virtual Nullable<int> InternalReference { get; set; }
    }
}
