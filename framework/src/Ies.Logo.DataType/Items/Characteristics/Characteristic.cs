using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class Characteristic : ILogo
    {
        public virtual Nullable<int> LineNr { get; set; }
        public virtual Nullable<int> MatrixLoc { get; set; }
        public virtual Nullable<int> Priority { get; set; }
        public virtual string Ccode { get; set; }
        public virtual string Vcode { get; set; }
        public virtual List<Value> Values { get; set; }
    }
}
