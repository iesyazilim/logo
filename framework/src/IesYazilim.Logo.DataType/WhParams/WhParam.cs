using System;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.WhParams
{
    [Serializable]
    public class WhParam : IWhParam
    {
        public virtual Nullable<int> WhNumber { get; set; }
    }
}
