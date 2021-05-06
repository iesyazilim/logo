using System;
using System.Collections.Generic;
using IesYazilim.Logo.DataType.Infrastructure;

namespace IesYazilim.Logo.DataType.Items
{
    [Serializable]
    public class VrntException : ILogo
    {
        public virtual string CharCode { get; set; }
        public virtual List<ValRefNode> ValRefsList { get; set; }
    }
}
