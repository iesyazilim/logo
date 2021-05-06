using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.Items
{
    [Serializable]
    public class Class : ILogo
    {
        public virtual Nullable<int> DomType { get; set; }
        public virtual string ClassCode { get; set; }
    }
}
