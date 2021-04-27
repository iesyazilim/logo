using System;
using Logo.DataType.Infrastructure;

namespace Logo.DataType.Items
{
    [Serializable]
    public class Value : ILogo
    {
        public virtual string Vcode { get; set; }
        public virtual string Vname { get; set; }
    }
}
