using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class ValRefNode : ILogo
    {
        public virtual string ValCode { get; set; }
    }
}
