using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Qproductions
{
    [Serializable]
    public class Transaction : ILogo
    {
        public virtual Nullable<decimal> Amnt{ get; set; }
        public virtual Nullable<decimal> Price{ get; set; }
        public virtual Nullable<decimal> Perc{ get; set; }
        public virtual Nullable<int> Lineno{ get; set; }
        public virtual Nullable<decimal> Lostfactor{ get; set; }
        public virtual Nullable<short> Sourceindex{ get; set; }
        public virtual Nullable<int> Uomref{ get; set; }
        public virtual Nullable<short> Cardtype{ get; set; }
        public virtual string Scode{ get; set; }
        public virtual string Sdef{ get; set; }
        public virtual string Uedit{ get; set; }
        public virtual string Uunit{ get; set; }
        public virtual Nullable<short> CompType{ get; set; }
    }
}
