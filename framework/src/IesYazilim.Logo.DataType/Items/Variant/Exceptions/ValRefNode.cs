using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.Items
{
    [Serializable]
    public class ValRefNode : ILogo
    {
        public virtual string ValCode { get; set; }
    }
}
