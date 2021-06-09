using System;

namespace Ies.Logo.DataType.WhParams
{
    [Serializable]
    public class ServiceWhParam : WhParam
    {
        public virtual Nullable<int> LeadTime { get; set; }
    }
}
