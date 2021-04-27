using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class QProd : ILogo, ISourceIndex
    {
        public virtual Nullable<decimal> Amnt { get; set; }
        public virtual Nullable<decimal> Price { get; set; }
        public virtual Nullable<decimal> Perc { get; set; }
        public virtual Nullable<int> LineNo { get; set; }
        public virtual Nullable<decimal> LostFactor { get; set; }
        public virtual ItemCardType CardType { get; set; }
        public virtual string Scode { get; set; }
        public virtual string Sdef { get; set; }
        public virtual string Uedit { get; set; }
        public virtual string Uunit { get; set; }

        #region Implementation
        public virtual Nullable<short> SourceIndex { get; set; }
        #endregion
    }
}
