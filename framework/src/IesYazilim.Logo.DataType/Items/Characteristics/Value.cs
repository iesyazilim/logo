using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.Items
{
    [Serializable]
    public class Value : ILogo
    {
        public virtual string Vcode { get; set; }
        public virtual string Vname { get; set; }
    }
}
