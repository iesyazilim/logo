using System;
using System.Collections.Generic;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class VrntException : ILogo
    {
        public virtual string CharCode { get; set; }
        public virtual List<ValRefNode> ValRefsList { get; set; }
    }
}
