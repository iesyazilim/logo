using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class ValRefNode : ILogo
    {
        public virtual string ValCode { get; set; }
    }
}
