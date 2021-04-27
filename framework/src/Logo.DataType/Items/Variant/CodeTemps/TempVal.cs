using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class TempVal : ILogo
    {
        public virtual string CharValCode { get; set; }
        public virtual string CharAbbrev { get; set; }
        public virtual Nullable<int> ValChecked { get; set; }
    }
}
