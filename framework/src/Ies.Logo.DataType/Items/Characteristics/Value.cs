using System;
using Ies.Logo.DataType.Infrastructure;

namespace Ies.Logo.DataType.Items
{
    [Serializable]
    public class Value : ILogo
    {
        public virtual string Vcode { get; set; }
        public virtual string Vname { get; set; }
    }
}
