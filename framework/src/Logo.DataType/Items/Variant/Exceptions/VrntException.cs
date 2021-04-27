using System;
using System.Collections.Generic;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class VrntException : ILogo
    {
        public virtual string CharCode { get; set; }
        public virtual List<ValRefNode> ValRefsList { get; set; }
    }
}
