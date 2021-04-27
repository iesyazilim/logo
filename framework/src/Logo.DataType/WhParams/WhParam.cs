using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.WhParams
{
    [Serializable]
    public class WhParam : IWhParam
    {
        public virtual Nullable<int> WhNumber { get; set; }
    }
}
