using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.WhParams
{
    [Serializable]
    public class WhParam : IWhParam
    {
        public virtual Nullable<int> WhNumber { get; set; }
    }
}
